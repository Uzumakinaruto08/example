namespace StudentInfo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            chckHtml = new CheckBox();
            chckPhython = new CheckBox();
            chckVB = new CheckBox();
            chckJava = new CheckBox();
            chckCpp = new CheckBox();
            chckPHP = new CheckBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            btnsave_Click = new Button();
            btnUpload = new Button();
            PicImage = new PictureBox();
            cboYearLevel = new ComboBox();
            label11 = new Label();
            cbostatus = new ComboBox();
            txtCNum = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtReligion = new TextBox();
            label8 = new Label();
            dtpBday = new DateTimePicker();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtStudentNumber = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            DGVSTUDENTS = new DataGridView();
            pictureBox3 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSTUDENTS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(chckHtml);
            panel2.Controls.Add(chckPhython);
            panel2.Controls.Add(chckVB);
            panel2.Controls.Add(chckJava);
            panel2.Controls.Add(chckCpp);
            panel2.Controls.Add(chckPHP);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(btnsave_Click);
            panel2.Controls.Add(btnUpload);
            panel2.Controls.Add(PicImage);
            panel2.Controls.Add(cboYearLevel);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cbostatus);
            panel2.Controls.Add(txtCNum);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtReligion);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dtpBday);
            panel2.Controls.Add(rbFemale);
            panel2.Controls.Add(rbMale);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(txtStudentNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = SystemColors.Desktop;
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 301);
            panel2.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(623, 262);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(785, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(704, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btn_Update_Click;
            // 
            // chckHtml
            // 
            chckHtml.AutoSize = true;
            chckHtml.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chckHtml.Location = new Point(582, 199);
            chckHtml.Name = "chckHtml";
            chckHtml.Size = new Size(58, 19);
            chckHtml.TabIndex = 33;
            chckHtml.Text = "HTML";
            chckHtml.UseVisualStyleBackColor = true;
            // 
            // chckPhython
            // 
            chckPhython.AutoSize = true;
            chckPhython.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chckPhython.Location = new Point(580, 224);
            chckPhython.Name = "chckPhython";
            chckPhython.Size = new Size(85, 19);
            chckPhython.TabIndex = 32;
            chckPhython.Text = "PHYTHON";
            chckPhython.UseVisualStyleBackColor = true;
            // 
            // chckVB
            // 
            chckVB.AutoSize = true;
            chckVB.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chckVB.Location = new Point(580, 170);
            chckVB.Name = "chckVB";
            chckVB.Size = new Size(68, 19);
            chckVB.TabIndex = 31;
            chckVB.Text = "VB.NET";
            chckVB.UseVisualStyleBackColor = true;
            // 
            // chckJava
            // 
            chckJava.AutoSize = true;
            chckJava.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chckJava.Location = new Point(486, 223);
            chckJava.Name = "chckJava";
            chckJava.Size = new Size(55, 19);
            chckJava.TabIndex = 30;
            chckJava.Text = "JAVA";
            chckJava.UseVisualStyleBackColor = true;
            // 
            // chckCpp
            // 
            chckCpp.AutoSize = true;
            chckCpp.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chckCpp.Location = new Point(486, 198);
            chckCpp.Name = "chckCpp";
            chckCpp.Size = new Size(41, 19);
            chckCpp.TabIndex = 29;
            chckCpp.Text = "C#";
            chckCpp.UseVisualStyleBackColor = true;
            // 
            // chckPHP
            // 
            chckPHP.AutoSize = true;
            chckPHP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chckPHP.Location = new Point(486, 170);
            chckPHP.Name = "chckPHP";
            chckPHP.Size = new Size(51, 19);
            chckPHP.TabIndex = 28;
            chckPHP.Text = "PHP";
            chckPHP.UseVisualStyleBackColor = true;
            chckPHP.CheckedChanged += chckPHP_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(432, 144);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 27;
            label7.Text = "Skills:";
            label7.Click += label13_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.DarkSalmon;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(502, 51);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 25);
            txtEmail.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(436, 53);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 25;
            label12.Text = "Email:";
            // 
            // btnsave_Click
            // 
            btnsave_Click.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave_Click.Location = new Point(896, 262);
            btnsave_Click.Name = "btnsave_Click";
            btnsave_Click.Size = new Size(87, 28);
            btnsave_Click.TabIndex = 24;
            btnsave_Click.Text = "Save";
            btnsave_Click.UseVisualStyleBackColor = true;
            btnsave_Click.Click += btnsave_Click_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(803, 145);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(123, 23);
            btnUpload.TabIndex = 23;
            btnUpload.Text = "Browse Picture";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // PicImage
            // 
            PicImage.Image = (Image)resources.GetObject("PicImage.Image");
            PicImage.Location = new Point(785, 3);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(156, 136);
            PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PicImage.TabIndex = 22;
            PicImage.TabStop = false;
            PicImage.Click += PicImage_Click;
            // 
            // cboYearLevel
            // 
            cboYearLevel.BackColor = Color.DarkSalmon;
            cboYearLevel.FormattingEnabled = true;
            cboYearLevel.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year ", "4th Year", "5th Year" });
            cboYearLevel.Location = new Point(527, 16);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(151, 25);
            cboYearLevel.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(434, 19);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 20;
            label11.Text = "Year&Level:";
            // 
            // cbostatus
            // 
            cbostatus.BackColor = Color.LightSalmon;
            cbostatus.FormattingEnabled = true;
            cbostatus.Items.AddRange(new object[] { "Single", "", "Married", "", "Widowed", "", "Divorced", "", "Separated" });
            cbostatus.Location = new Point(160, 212);
            cbostatus.Name = "cbostatus";
            cbostatus.Size = new Size(151, 25);
            cbostatus.TabIndex = 19;
            // 
            // txtCNum
            // 
            txtCNum.BackColor = Color.DarkSalmon;
            txtCNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCNum.Location = new Point(160, 244);
            txtCNum.Name = "txtCNum";
            txtCNum.Size = new Size(171, 25);
            txtCNum.TabIndex = 18;
            txtCNum.Text = "a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(40, 247);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 17;
            label10.Text = "Contact#:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 215);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 16;
            label9.Text = "Status:";
            // 
            // txtReligion
            // 
            txtReligion.BackColor = Color.DarkSalmon;
            txtReligion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtReligion.Location = new Point(160, 179);
            txtReligion.Name = "txtReligion";
            txtReligion.Size = new Size(171, 25);
            txtReligion.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(40, 182);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 14;
            label8.Text = "Religion:";
            // 
            // dtpBday
            // 
            dtpBday.Format = DateTimePickerFormat.Custom;
            dtpBday.Location = new Point(160, 142);
            dtpBday.MaxDate = new DateTime(2008, 12, 31, 0, 0, 0, 0);
            dtpBday.MinDate = new DateTime(1973, 1, 1, 0, 0, 0, 0);
            dtpBday.Name = "dtpBday";
            dtpBday.Size = new Size(122, 25);
            dtpBday.TabIndex = 13;
            dtpBday.Value = new DateTime(2008, 12, 31, 0, 0, 0, 0);
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(240, 105);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(70, 21);
            rbFemale.TabIndex = 12;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(163, 105);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(56, 21);
            rbMale.TabIndex = 11;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.DarkSalmon;
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(160, 74);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 25);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.DarkSalmon;
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(160, 48);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 25);
            txtFirstName.TabIndex = 8;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.BackColor = Color.LightSalmon;
            txtStudentNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNumber.Location = new Point(160, 19);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(171, 25);
            txtStudentNumber.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 142);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Birthday:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 22);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 5;
            label6.Text = "Student Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 111);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 74);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 2;
            label4.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 48);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Salmon;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(240, 28);
            label1.Name = "label1";
            label1.Size = new Size(535, 40);
            label1.TabIndex = 1;
            label1.Text = "STUDENT INFORMATION SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(DGVSTUDENTS);
            panel1.Location = new Point(0, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 116);
            panel1.TabIndex = 4;
            // 
            // DGVSTUDENTS
            // 
            DGVSTUDENTS.AllowUserToAddRows = false;
            DGVSTUDENTS.AllowUserToDeleteRows = false;
            DGVSTUDENTS.AllowUserToOrderColumns = true;
            DGVSTUDENTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVSTUDENTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSTUDENTS.Location = new Point(3, -7);
            DGVSTUDENTS.Name = "DGVSTUDENTS";
            DGVSTUDENTS.ReadOnly = true;
            DGVSTUDENTS.RowTemplate.Height = 25;
            DGVSTUDENTS.Size = new Size(1004, 123);
            DGVSTUDENTS.TabIndex = 0;
            DGVSTUDENTS.CellContentClick += DGVSTUDENTS_CellContentClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(818, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1049, 561);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVSTUDENTS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtStudentNumber;
        private Label label3;
        private DateTimePicker dtpBday;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private ComboBox cbostatus;
        private TextBox txtCNum;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private TextBox txtReligion;
        private ComboBox cboYearLevel;
        private PictureBox pictureBox1;
        private PictureBox PicImage;
        private Button btnsave_Click;
        private Button btnUpload;
        private TextBox txtEmail;
        private Label label12;
        private CheckBox chckHtml;
        private CheckBox chckPhython;
        private CheckBox chckVB;
        private CheckBox chckJava;
        private CheckBox chckCpp;
        private CheckBox chckPHP;
        private Label label7;
        private Panel panel1;
        private DataGridView DGVSTUDENTS;
        private PictureBox pictureBox3;
        private ComboBox comboBox3;
        private Label label14;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private ContextMenuStrip contextMenuStrip1;
    }
}