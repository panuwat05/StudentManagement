namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbStName = new TextBox();
            tbStId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            btSearch = new Button();
            btTopSt = new Button();
            btAddAdvisor = new Button();
            btAddSt = new Button();
            tbStMajor = new TextBox();
            label11 = new Label();
            tbGrade = new TextBox();
            label10 = new Label();
            label14 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            lbStID = new Label();
            groupBox1 = new GroupBox();
            lbAdvisor = new Label();
            lbGrade = new Label();
            lbStMajor = new Label();
            lbStName = new Label();
            tb_AdvisorName = new TextBox();
            lstStuden = new ListBox();
            CmbAdvisor = new ComboBox();
            tb_AdvisorMajor = new TextBox();
            label15 = new Label();
            dgvStudents = new DataGridView();
            tbSearchStudent = new TextBox();
            label16 = new Label();
            label17 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // tbStName
            // 
            tbStName.Location = new Point(165, 106);
            tbStName.Name = "tbStName";
            tbStName.Size = new Size(100, 23);
            tbStName.TabIndex = 0;
            // 
            // tbStId
            // 
            tbStId.Location = new Point(165, 77);
            tbStId.Name = "tbStId";
            tbStId.Size = new Size(100, 23);
            tbStId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "ใส่ข้อมูลนักศึกษา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 7;
            label2.Text = "อาจารย์ที่ปรึกษา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 77);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 8;
            label3.Text = "รหัสนักศึกษา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 109);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "ชื่อ-นามสกุล ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 140);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 11;
            label6.Text = "สาขาที่เรียน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 77);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 14;
            label8.Text = "ชื่อ ";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(1079, 72);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(74, 35);
            btSearch.TabIndex = 16;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click_1;
            // 
            // btTopSt
            // 
            btTopSt.BackColor = Color.BurlyWood;
            btTopSt.Location = new Point(161, 699);
            btTopSt.Name = "btTopSt";
            btTopSt.Size = new Size(234, 51);
            btTopSt.TabIndex = 17;
            btTopSt.Text = "Show Top Student";
            btTopSt.UseVisualStyleBackColor = false;
            btTopSt.Click += btTopSt_Click;
            // 
            // btAddAdvisor
            // 
            btAddAdvisor.BackColor = Color.BurlyWood;
            btAddAdvisor.Location = new Point(368, 153);
            btAddAdvisor.Name = "btAddAdvisor";
            btAddAdvisor.Size = new Size(151, 78);
            btAddAdvisor.TabIndex = 19;
            btAddAdvisor.Text = "AddAdvisor";
            btAddAdvisor.UseVisualStyleBackColor = false;
            btAddAdvisor.Click += btAddAdvisor_Click;
            // 
            // btAddSt
            // 
            btAddSt.BackColor = Color.BurlyWood;
            btAddSt.ForeColor = SystemColors.ActiveCaptionText;
            btAddSt.Location = new Point(84, 242);
            btAddSt.Name = "btAddSt";
            btAddSt.Size = new Size(152, 78);
            btAddSt.TabIndex = 20;
            btAddSt.Text = "AddStudent";
            btAddSt.UseVisualStyleBackColor = false;
            btAddSt.Click += btAddSt_Click;
            // 
            // tbStMajor
            // 
            tbStMajor.Location = new Point(165, 134);
            tbStMajor.Name = "tbStMajor";
            tbStMajor.Size = new Size(100, 23);
            tbStMajor.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 171);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 24;
            label11.Text = "เกรด";
            // 
            // tbGrade
            // 
            tbGrade.Location = new Point(165, 163);
            tbGrade.Name = "tbGrade";
            tbGrade.Size = new Size(100, 23);
            tbGrade.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 195);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 27;
            label10.Text = "อาจารย์ที่ปรึกษา";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(189, 35);
            label14.Name = "label14";
            label14.Size = new Size(118, 25);
            label14.TabIndex = 35;
            label14.Text = "ข้อมูลนักศึกษา";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 275);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 40;
            label5.Text = "อาจารย์ที่ปรึกษา";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 234);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 39;
            label7.Text = "เกรด";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 187);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 38;
            label9.Text = "สาขาที่เรียน";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(29, 140);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 37;
            label12.Text = "ชื่อ-นามสกุล ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(29, 88);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 36;
            label13.Text = "รหัสนักศึกษา";
            // 
            // lbStID
            // 
            lbStID.AutoSize = true;
            lbStID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStID.Location = new Point(189, 88);
            lbStID.Name = "lbStID";
            lbStID.Size = new Size(213, 20);
            lbStID.TabIndex = 41;
            lbStID.Text = "----------------------------------";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.background2_1200x675;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(lbAdvisor);
            groupBox1.Controls.Add(lbGrade);
            groupBox1.Controls.Add(lbStMajor);
            groupBox1.Controls.Add(lbStName);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lbStID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(37, 346);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 334);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // lbAdvisor
            // 
            lbAdvisor.AutoSize = true;
            lbAdvisor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAdvisor.Location = new Point(189, 275);
            lbAdvisor.Name = "lbAdvisor";
            lbAdvisor.Size = new Size(213, 20);
            lbAdvisor.TabIndex = 45;
            lbAdvisor.Text = "----------------------------------";
            // 
            // lbGrade
            // 
            lbGrade.AutoSize = true;
            lbGrade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGrade.Location = new Point(189, 234);
            lbGrade.Name = "lbGrade";
            lbGrade.Size = new Size(213, 20);
            lbGrade.TabIndex = 44;
            lbGrade.Text = "----------------------------------";
            // 
            // lbStMajor
            // 
            lbStMajor.AutoSize = true;
            lbStMajor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStMajor.Location = new Point(189, 187);
            lbStMajor.Name = "lbStMajor";
            lbStMajor.Size = new Size(213, 20);
            lbStMajor.TabIndex = 43;
            lbStMajor.Text = "----------------------------------";
            // 
            // lbStName
            // 
            lbStName.AutoSize = true;
            lbStName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStName.Location = new Point(189, 140);
            lbStName.Name = "lbStName";
            lbStName.Size = new Size(213, 20);
            lbStName.TabIndex = 42;
            lbStName.Text = "----------------------------------";
            // 
            // tb_AdvisorName
            // 
            tb_AdvisorName.Location = new Point(408, 74);
            tb_AdvisorName.Name = "tb_AdvisorName";
            tb_AdvisorName.Size = new Size(100, 23);
            tb_AdvisorName.TabIndex = 48;
            // 
            // lstStuden
            // 
            lstStuden.BackColor = Color.PeachPuff;
            lstStuden.FormattingEnabled = true;
            lstStuden.ItemHeight = 15;
            lstStuden.Location = new Point(635, 359);
            lstStuden.Name = "lstStuden";
            lstStuden.Size = new Size(539, 349);
            lstStuden.TabIndex = 49;
            lstStuden.SelectedIndexChanged += lstStuden_SelectedIndexChanged;
            // 
            // CmbAdvisor
            // 
            CmbAdvisor.FormattingEnabled = true;
            CmbAdvisor.Location = new Point(164, 198);
            CmbAdvisor.Name = "CmbAdvisor";
            CmbAdvisor.Size = new Size(121, 23);
            CmbAdvisor.TabIndex = 50;
            // 
            // tb_AdvisorMajor
            // 
            tb_AdvisorMajor.Location = new Point(408, 106);
            tb_AdvisorMajor.Name = "tb_AdvisorMajor";
            tb_AdvisorMajor.Size = new Size(100, 23);
            tb_AdvisorMajor.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(372, 109);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 52;
            label15.Text = "สาขา";
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = Color.GhostWhite;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(635, 195);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(539, 140);
            dgvStudents.TabIndex = 53;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // tbSearchStudent
            // 
            tbSearchStudent.Location = new Point(1064, 43);
            tbSearchStudent.Name = "tbSearchStudent";
            tbSearchStudent.Size = new Size(100, 23);
            tbSearchStudent.TabIndex = 54;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1064, 9);
            label16.Name = "label16";
            label16.Size = new Size(99, 15);
            label16.TabIndex = 55;
            label16.Text = "ค้นหาข้อมูลนักศึกษา";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(982, 46);
            label17.Name = "label17";
            label17.Size = new Size(76, 15);
            label17.TabIndex = 56;
            label17.Text = "ใส่รหัสนักศึกษา";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kku02_770x433;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1204, 774);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(tbSearchStudent);
            Controls.Add(dgvStudents);
            Controls.Add(label15);
            Controls.Add(tb_AdvisorMajor);
            Controls.Add(CmbAdvisor);
            Controls.Add(lstStuden);
            Controls.Add(tb_AdvisorName);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(tbGrade);
            Controls.Add(label11);
            Controls.Add(tbStMajor);
            Controls.Add(btAddSt);
            Controls.Add(btAddAdvisor);
            Controls.Add(btTopSt);
            Controls.Add(btSearch);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbStId);
            Controls.Add(tbStName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "KKU";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbStName;
        private TextBox tbStId;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox tbAdvisorName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBox7;
        private Label label8;
        private Button btSearch;
        private Button btTopSt;
        private Button btAddAdvisor;
        private Button btAddSt;
        private TextBox tbStMajor;
        private Label label11;
        private TextBox tbGrade;
        private Label label10;
        private ComboBox cmbAdvisor;
        private Label label14;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label lbStID;
        private GroupBox groupBox1;
        private Label lbAdvisor;
        private Label lbGrade;
        private Label lbStMajor;
        private Label lbStName;
        private TextBox tb_AdvisorName;
        private ListBox lstStuden;
        private ComboBox CmbAdvisor;
        private TextBox tb_AdvisorMajor;
        private Label label15;
        private DataGridView dgvStudents;
        private TextBox tbSearchStudent;
        private Label label16;
        private Label label17;
    }
}
