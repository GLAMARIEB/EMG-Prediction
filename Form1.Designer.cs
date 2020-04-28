namespace EMG_Prediction
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tConnect = new System.Windows.Forms.Button();
            this.tBaudrate = new System.Windows.Forms.ComboBox();
            this.Tcomport = new System.Windows.Forms.ComboBox();
            this.btn_tDisconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PredictionBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aBaudrate = new System.Windows.Forms.ComboBox();
            this.Acomport = new System.Windows.Forms.ComboBox();
            this.btn_aDisconnect = new System.Windows.Forms.Button();
            this.btn_aConnect = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tConnect);
            this.groupBox1.Controls.Add(this.tBaudrate);
            this.groupBox1.Controls.Add(this.Tcomport);
            this.groupBox1.Controls.Add(this.btn_tDisconnect);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(32, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to Tiva";
            // 
            // btn_tConnect
            // 
            this.btn_tConnect.Location = new System.Drawing.Point(262, 21);
            this.btn_tConnect.Name = "btn_tConnect";
            this.btn_tConnect.Size = new System.Drawing.Size(100, 37);
            this.btn_tConnect.TabIndex = 5;
            this.btn_tConnect.Text = "Connect";
            this.btn_tConnect.UseVisualStyleBackColor = true;
            this.btn_tConnect.Click += new System.EventHandler(this.Btn_tConnect_Click);
            // 
            // tBaudrate
            // 
            this.tBaudrate.FormattingEnabled = true;
            this.tBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.tBaudrate.Location = new System.Drawing.Point(18, 84);
            this.tBaudrate.Name = "tBaudrate";
            this.tBaudrate.Size = new System.Drawing.Size(121, 24);
            this.tBaudrate.TabIndex = 4;
            // 
            // Tcomport
            // 
            this.Tcomport.FormattingEnabled = true;
            this.Tcomport.Location = new System.Drawing.Point(18, 34);
            this.Tcomport.Name = "Tcomport";
            this.Tcomport.Size = new System.Drawing.Size(121, 24);
            this.Tcomport.TabIndex = 3;
            // 
            // btn_tDisconnect
            // 
            this.btn_tDisconnect.Location = new System.Drawing.Point(262, 64);
            this.btn_tDisconnect.Name = "btn_tDisconnect";
            this.btn_tDisconnect.Size = new System.Drawing.Size(100, 44);
            this.btn_tDisconnect.TabIndex = 2;
            this.btn_tDisconnect.Text = "Disconnect";
            this.btn_tDisconnect.UseVisualStyleBackColor = true;
            this.btn_tDisconnect.Click += new System.EventHandler(this.Btn_tDisconnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 25);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PredictionBox);
            this.groupBox2.Location = new System.Drawing.Point(32, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prediction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(704, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "5 = WAVE OUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "6 = POINT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "7 = OKAY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "4 = WAVE IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "2 = Rest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "3 = OPEN HAND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "1 = FIST";
            // 
            // PredictionBox
            // 
            this.PredictionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PredictionBox.Location = new System.Drawing.Point(18, 42);
            this.PredictionBox.Multiline = true;
            this.PredictionBox.Name = "PredictionBox";
            this.PredictionBox.Size = new System.Drawing.Size(275, 121);
            this.PredictionBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aBaudrate);
            this.groupBox3.Controls.Add(this.Acomport);
            this.groupBox3.Controls.Add(this.btn_aDisconnect);
            this.groupBox3.Controls.Add(this.btn_aConnect);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(542, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect to Arduino";
            // 
            // aBaudrate
            // 
            this.aBaudrate.FormattingEnabled = true;
            this.aBaudrate.Items.AddRange(new object[] {
            "9600"});
            this.aBaudrate.Location = new System.Drawing.Point(18, 89);
            this.aBaudrate.Name = "aBaudrate";
            this.aBaudrate.Size = new System.Drawing.Size(121, 24);
            this.aBaudrate.TabIndex = 5;
            // 
            // Acomport
            // 
            this.Acomport.FormattingEnabled = true;
            this.Acomport.Location = new System.Drawing.Point(18, 43);
            this.Acomport.Name = "Acomport";
            this.Acomport.Size = new System.Drawing.Size(121, 24);
            this.Acomport.TabIndex = 4;
            // 
            // btn_aDisconnect
            // 
            this.btn_aDisconnect.Location = new System.Drawing.Point(353, 89);
            this.btn_aDisconnect.Name = "btn_aDisconnect";
            this.btn_aDisconnect.Size = new System.Drawing.Size(107, 49);
            this.btn_aDisconnect.TabIndex = 3;
            this.btn_aDisconnect.Text = "Disconnect";
            this.btn_aDisconnect.UseVisualStyleBackColor = true;
            this.btn_aDisconnect.Click += new System.EventHandler(this.Btn_aDisconnect_Click);
            // 
            // btn_aConnect
            // 
            this.btn_aConnect.Location = new System.Drawing.Point(353, 32);
            this.btn_aConnect.Name = "btn_aConnect";
            this.btn_aConnect.Size = new System.Drawing.Size(107, 51);
            this.btn_aConnect.TabIndex = 2;
            this.btn_aConnect.Text = "Connect";
            this.btn_aConnect.UseVisualStyleBackColor = true;
            this.btn_aConnect.Click += new System.EventHandler(this.Btn_aConnect_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 157);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 22);
            this.textBox3.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox5.Image = global::EMG_Prediction.Properties.Resources.waveOut;
            this.pictureBox5.Location = new System.Drawing.Point(709, 236);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 116);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Image = global::EMG_Prediction.Properties.Resources.waveIn;
            this.pictureBox4.Location = new System.Drawing.Point(543, 235);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Image = global::EMG_Prediction.Properties.Resources.open_hand;
            this.pictureBox3.Location = new System.Drawing.Point(361, 226);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Image = global::EMG_Prediction.Properties.Resources.Rest;
            this.pictureBox2.Location = new System.Drawing.Point(190, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::EMG_Prediction.Properties.Resources.fist;
            this.pictureBox1.Location = new System.Drawing.Point(6, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox6.Image = global::EMG_Prediction.Properties.Resources.waveOut;
            this.pictureBox6.Location = new System.Drawing.Point(881, 235);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(141, 116);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox7.Image = global::EMG_Prediction.Properties.Resources.waveOut;
            this.pictureBox7.Location = new System.Drawing.Point(11, 351);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(141, 116);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 745);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tBaudrate;
        private System.Windows.Forms.ComboBox Tcomport;
        private System.Windows.Forms.Button btn_tDisconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PredictionBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox aBaudrate;
        private System.Windows.Forms.ComboBox Acomport;
        private System.Windows.Forms.Button btn_aDisconnect;
        private System.Windows.Forms.Button btn_aConnect;
        private System.Windows.Forms.TextBox textBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btn_tConnect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

