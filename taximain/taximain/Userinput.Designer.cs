namespace taximain
{
    partial class Userinput
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btentertime = new System.Windows.Forms.Button();
            this.cbhr = new System.Windows.Forms.ComboBox();
            this.rbam = new System.Windows.Forms.RadioButton();
            this.rbpm = new System.Windows.Forms.RadioButton();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.tbkilometers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbfareamount = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbpassengername = new System.Windows.Forms.TextBox();
            this.tbpassengerid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(49, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Distance travelled:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(225, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSENGER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(49, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Time :";
            // 
            // btentertime
            // 
            this.btentertime.ForeColor = System.Drawing.Color.DarkBlue;
            this.btentertime.Location = new System.Drawing.Point(287, 208);
            this.btentertime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btentertime.Name = "btentertime";
            this.btentertime.Size = new System.Drawing.Size(91, 19);
            this.btentertime.TabIndex = 7;
            this.btentertime.Text = "Enter Time";
            this.btentertime.UseVisualStyleBackColor = true;
            this.btentertime.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbhr
            // 
            this.cbhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhr.FormattingEnabled = true;
            this.cbhr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbhr.Location = new System.Drawing.Point(160, 209);
            this.cbhr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbhr.Name = "cbhr";
            this.cbhr.Size = new System.Drawing.Size(92, 21);
            this.cbhr.TabIndex = 11;
            // 
            // rbam
            // 
            this.rbam.AutoSize = true;
            this.rbam.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbam.Location = new System.Drawing.Point(138, 230);
            this.rbam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbam.Name = "rbam";
            this.rbam.Size = new System.Drawing.Size(41, 17);
            this.rbam.TabIndex = 12;
            this.rbam.TabStop = true;
            this.rbam.Text = "AM";
            this.rbam.UseVisualStyleBackColor = true;
            // 
            // rbpm
            // 
            this.rbpm.AutoSize = true;
            this.rbpm.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbpm.Location = new System.Drawing.Point(140, 251);
            this.rbpm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbpm.Name = "rbpm";
            this.rbpm.Size = new System.Drawing.Size(41, 17);
            this.rbpm.TabIndex = 13;
            this.rbpm.TabStop = true;
            this.rbpm.Text = "PM";
            this.rbpm.UseVisualStyleBackColor = true;
            this.rbpm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(218, 288);
            this.tbtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbtime.Name = "tbtime";
            this.tbtime.Size = new System.Drawing.Size(92, 20);
            this.tbtime.TabIndex = 14;
            // 
            // tbkilometers
            // 
            this.tbkilometers.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbkilometers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbkilometers.Location = new System.Drawing.Point(287, 168);
            this.tbkilometers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbkilometers.Name = "tbkilometers";
            this.tbkilometers.Size = new System.Drawing.Size(76, 20);
            this.tbkilometers.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(49, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your Entered Time is :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(49, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estimated Fare Amount:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(59, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 19);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate Estimated Fare amount";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbfareamount
            // 
            this.tbfareamount.Location = new System.Drawing.Point(310, 383);
            this.tbfareamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbfareamount.Name = "tbfareamount";
            this.tbfareamount.Size = new System.Drawing.Size(84, 20);
            this.tbfareamount.TabIndex = 19;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(49, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = " Passenger ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(49, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Passenger Name:";
            // 
            // tbpassengername
            // 
            this.tbpassengername.Location = new System.Drawing.Point(218, 124);
            this.tbpassengername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpassengername.Name = "tbpassengername";
            this.tbpassengername.Size = new System.Drawing.Size(76, 20);
            this.tbpassengername.TabIndex = 23;
            // 
            // tbpassengerid
            // 
            this.tbpassengerid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbpassengerid.Location = new System.Drawing.Point(218, 84);
            this.tbpassengerid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpassengerid.Name = "tbpassengerid";
            this.tbpassengerid.Size = new System.Drawing.Size(76, 20);
            this.tbpassengerid.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(435, 364);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 34);
            this.button3.TabIndex = 26;
            this.button3.Text = "Upload ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(590, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Userinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(753, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbpassengerid);
            this.Controls.Add(this.tbpassengername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbfareamount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbkilometers);
            this.Controls.Add(this.tbtime);
            this.Controls.Add(this.rbpm);
            this.Controls.Add(this.rbam);
            this.Controls.Add(this.cbhr);
            this.Controls.Add(this.btentertime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Userinput";
            this.Text = "Userinput";
            this.Load += new System.EventHandler(this.Userinput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btentertime;
        private System.Windows.Forms.ComboBox cbhr;
        private System.Windows.Forms.RadioButton rbam;
        private System.Windows.Forms.RadioButton rbpm;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.TextBox tbkilometers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbfareamount;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbpassengername;
        private System.Windows.Forms.TextBox tbpassengerid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}