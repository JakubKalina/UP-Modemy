namespace Modem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSent = new System.Windows.Forms.TextBox();
            this.textBoxRecieved = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxBits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCommand = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(622, 350);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(143, 55);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odebrane";
            // 
            // textBoxSent
            // 
            this.textBoxSent.Location = new System.Drawing.Point(142, 364);
            this.textBoxSent.Name = "textBoxSent";
            this.textBoxSent.Size = new System.Drawing.Size(443, 26);
            this.textBoxSent.TabIndex = 2;
            // 
            // textBoxRecieved
            // 
            this.textBoxRecieved.Location = new System.Drawing.Point(54, 108);
            this.textBoxRecieved.Multiline = true;
            this.textBoxRecieved.Name = "textBoxRecieved";
            this.textBoxRecieved.Size = new System.Drawing.Size(531, 220);
            this.textBoxRecieved.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wyślij";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(795, 262);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(194, 55);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(853, 212);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(136, 26);
            this.textBoxPort.TabIndex = 6;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(853, 165);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(136, 26);
            this.textBoxSpeed.TabIndex = 7;
            // 
            // textBoxBits
            // 
            this.textBoxBits.Location = new System.Drawing.Point(853, 111);
            this.textBoxBits.Name = "textBoxBits";
            this.textBoxBits.Size = new System.Drawing.Size(136, 26);
            this.textBoxBits.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Szerokość ramki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Szybkość transmisji";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port COM";
            // 
            // checkBoxCommand
            // 
            this.checkBoxCommand.AutoSize = true;
            this.checkBoxCommand.Location = new System.Drawing.Point(824, 363);
            this.checkBoxCommand.Name = "checkBoxCommand";
            this.checkBoxCommand.Size = new System.Drawing.Size(126, 24);
            this.checkBoxCommand.TabIndex = 12;
            this.checkBoxCommand.Text = "Tryb komend";
            this.checkBoxCommand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.checkBoxCommand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBits);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRecieved);
            this.Controls.Add(this.textBoxSent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSent;
        private System.Windows.Forms.TextBox textBoxRecieved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCommand;
    }
}

