using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modem
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Klasa umożliwiająca podłączenie się przez port COM
        /// </summary>
        SerialPort _serialPort;

        /// <summary>
        /// Wątek na którym spradzane jest czy nie ma nowych wiadomości do odczytu
        /// </summary>
        Thread reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Nawiązanie połączenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            bool result = ConnectPort();
            if (result == true)
                MessageBox.Show("Połączono");
            else MessageBox.Show("Nie udało się połączyć");
        }

        /// <summary>
        /// Wysyłanie wiadomości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            Send(textBoxSent.Text);
        }


        /// <summary>
        /// Łączenie z portem COM
        /// </summary>
        /// <returns></returns>
        public bool ConnectPort()
        {
            int bits = Int32.Parse(textBoxBits.Text);
            int speed = Int32.Parse(textBoxSpeed.Text);
            string port = textBoxPort.Text;

            this._serialPort = new SerialPort(port, speed, Parity.None, bits, StopBits.One);

            if (_serialPort != null)
                _serialPort.Open();

            if (_serialPort.IsOpen)
            {
                _serialPort.Handshake = Handshake.RequestToSend;
                _serialPort.DtrEnable = true;


                reader = new Thread(Read);
                reader.Start();
                return true;
            }
            else return false;
        }


        /// <summary>
        /// Odczyt wiadomości
        /// </summary>
        public void Read()
        {
            while (_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadExisting();
                    if (message.Length > 0)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                       {
                           textBoxRecieved.AppendText(message + Environment.NewLine);
                       });
                    }
                }
                catch (TimeoutException) { }
            }
        }

        /// <summary>
        /// Wysłanie wiadomości
        /// </summary>
        /// <param name="text"></param>
        public void Send(string text)
        {
            if (_serialPort != null)
            {
                if (text == "+++")
                {
                    _serialPort.Write("+");
                    Thread.Sleep(1000);
                    _serialPort.Write("+");
                    Thread.Sleep(1000);
                    _serialPort.Write("+");
                    Thread.Sleep(1000);

                }
                else _serialPort.Write(text + Environment.NewLine);
            
            }

        }
    }
}
