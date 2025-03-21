namespace Congratulation
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
            checkDb = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            conn = new TextBox();
            label1 = new Label();
            SQLServer = new RadioButton();
            Oracle = new RadioButton();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtFolderPath = new TextBox();
            txtOutputPath = new TextBox();
            button2 = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            lblProgress = new Label();
            formate = new ComboBox();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox6 = new GroupBox();
            formate2 = new ComboBox();
            groupBox5 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            chkListFontStyle = new ComboBox();
            button4 = new Button();
            numericFontSize = new NumericUpDown();
            cmbFonts = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkDb
            // 
            checkDb.Location = new Point(1031, 130);
            checkDb.Name = "checkDb";
            checkDb.Size = new Size(192, 34);
            checkDb.TabIndex = 0;
            checkDb.Text = "Check Connect DB";
            checkDb.UseVisualStyleBackColor = true;
            checkDb.Click += checkDb_Click;
            // 
            // conn
            // 
            conn.Location = new Point(183, 132);
            conn.Name = "conn";
            conn.Size = new Size(842, 31);
            conn.TabIndex = 1;
            conn.Text = "Server=localhost;Database=Makkah;User ID=sa;Password=root;TrustServerCertificate=True;";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 135);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 2;
            label1.Text = "Connection String";
            // 
            // SQLServer
            // 
            SQLServer.AutoSize = true;
            SQLServer.Checked = true;
            SQLServer.Location = new Point(186, 100);
            SQLServer.Name = "SQLServer";
            SQLServer.Size = new Size(118, 29);
            SQLServer.TabIndex = 3;
            SQLServer.TabStop = true;
            SQLServer.Text = "SQLServer";
            SQLServer.UseVisualStyleBackColor = true;
            // 
            // Oracle
            // 
            Oracle.AutoSize = true;
            Oracle.Location = new Point(333, 100);
            Oracle.Name = "Oracle";
            Oracle.Size = new Size(87, 29);
            Oracle.TabIndex = 4;
            Oracle.TabStop = true;
            Oracle.Text = "Oracle";
            Oracle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 5;
            label2.Text = "Example Sql Server";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 63);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 7;
            label5.Text = "Example Oracle ";
            // 
            // button1
            // 
            button1.Location = new Point(254, 26);
            button1.Name = "button1";
            button1.Size = new Size(205, 34);
            button1.TabIndex = 9;
            button1.Text = "Templates Folder ...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1031, 167);
            button5.Name = "button5";
            button5.Size = new Size(191, 34);
            button5.TabIndex = 17;
            button5.Text = "Load Employees";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(842, 31);
            textBox2.TabIndex = 16;
            textBox2.Text = "Provider=OraOLEDB.Oracle;Data Source=Makkah;User ID=your_user;Password=your_password;";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(842, 31);
            textBox1.TabIndex = 15;
            textBox1.Text = "Server=localhost;Database=Makkah;User ID=sa;Password=root;TrustServerCertificate=True;";
            // 
            // txtFolderPath
            // 
            txtFolderPath.BackColor = SystemColors.InactiveCaption;
            txtFolderPath.Enabled = false;
            txtFolderPath.Location = new Point(6, 29);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(242, 31);
            txtFolderPath.TabIndex = 11;
            // 
            // txtOutputPath
            // 
            txtOutputPath.BackColor = SystemColors.InactiveCaption;
            txtOutputPath.Enabled = false;
            txtOutputPath.Location = new Point(6, 32);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(256, 31);
            txtOutputPath.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(277, 31);
            button2.Name = "button2";
            button2.Size = new Size(205, 34);
            button2.TabIndex = 12;
            button2.Text = "Output Folder ...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1017, 72);
            button3.Name = "button3";
            button3.Size = new Size(205, 34);
            button3.TabIndex = 14;
            button3.Text = "Start Process";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 543);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1261, 34);
            progressBar1.TabIndex = 15;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(623, 596);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(22, 25);
            lblProgress.TabIndex = 16;
            lblProgress.Text = "0";
            // 
            // formate
            // 
            formate.FormattingEnabled = true;
            formate.Items.AddRange(new object[] { "jpg", "png" });
            formate.Location = new Point(465, 27);
            formate.Name = "formate";
            formate.Size = new Size(59, 33);
            formate.TabIndex = 18;
            formate.Text = "jpg";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(713, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 33);
            comboBox1.TabIndex = 20;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(880, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 29);
            radioButton2.TabIndex = 22;
            radioButton2.Text = "All Employee";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(713, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 29);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Current Emp.";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(checkDb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(conn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Oracle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SQLServer);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ImeMode = ImeMode.Katakana;
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1261, 209);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "DataBase setting";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(12, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1261, 105);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(formate2);
            groupBox6.Controls.Add(txtOutputPath);
            groupBox6.Controls.Add(button2);
            groupBox6.Location = new Point(624, 19);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(631, 80);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Output Setting";
            // 
            // formate2
            // 
            formate2.FormattingEnabled = true;
            formate2.Items.AddRange(new object[] { "jpg", "png" });
            formate2.Location = new Point(488, 33);
            formate2.Name = "formate2";
            formate2.Size = new Size(59, 33);
            formate2.TabIndex = 19;
            formate2.Text = "jpg";
            formate2.SelectedIndexChanged += formate2_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtFolderPath);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(formate);
            groupBox5.Location = new Point(15, 19);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(547, 80);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            groupBox5.Text = "Input Setting";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLightLight;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(12, 398);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1261, 133);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chkListFontStyle);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(numericFontSize);
            groupBox4.Controls.Add(cmbFonts);
            groupBox4.Location = new Point(10, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(663, 89);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Font and Color";
            // 
            // chkListFontStyle
            // 
            chkListFontStyle.FormattingEnabled = true;
            chkListFontStyle.Location = new Point(499, 42);
            chkListFontStyle.Name = "chkListFontStyle";
            chkListFontStyle.Size = new Size(142, 33);
            chkListFontStyle.TabIndex = 27;
            chkListFontStyle.Text = "Regular";
            chkListFontStyle.SelectedIndexChanged += chkListFontStyle_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(218, 39);
            button4.Name = "button4";
            button4.Size = new Size(170, 34);
            button4.TabIndex = 23;
            button4.Text = "Select Color";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericFontSize
            // 
            numericFontSize.Location = new Point(409, 42);
            numericFontSize.Name = "numericFontSize";
            numericFontSize.Size = new Size(74, 31);
            numericFontSize.TabIndex = 26;
            numericFontSize.ValueChanged += numericFontSize_ValueChanged;
            // 
            // cmbFonts
            // 
            cmbFonts.FormattingEnabled = true;
            cmbFonts.Location = new Point(25, 39);
            cmbFonts.Name = "cmbFonts";
            cmbFonts.Size = new Size(182, 33);
            cmbFonts.TabIndex = 24;
            cmbFonts.SelectedIndexChanged += cmbFonts_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 48);
            panel1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(484, 10);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 0;
            label3.Text = "Generate Congratulation Card";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1285, 649);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblProgress);
            Controls.Add(progressBar1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "بطائق تهنئة";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericFontSize).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkDb;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox conn;
        private Label label1;
        private RadioButton SQLServer;
        private RadioButton Oracle;
        private Label label2;
        private Label label5;
        private Button button1;
        private TextBox txtFolderPath;
        private TextBox txtOutputPath;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Label lblProgress;
        private ComboBox formate;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button4;
        private ComboBox cmbFonts;
        private NumericUpDown numericFontSize;
        private GroupBox groupBox4;
        private ComboBox chkListFontStyle;
        private Panel panel1;
        private Label label3;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private ComboBox formate2;
    }
}