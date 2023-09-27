using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace StudentInfo
{
    public partial class Form1 : Form

    {
        int index;
        string gender = "", skills = "";
        byte[] img;

        public Form1()
        {
            InitializeComponent();
            //* Student Information System *//

            DGVSTUDENTS.ColumnCount = 11;
            DGVSTUDENTS.Columns[0].Name = "StudentID";
            DGVSTUDENTS.Columns[1].Name = "Firstname";
            DGVSTUDENTS.Columns[2].Name = "Lastname";
            DGVSTUDENTS.Columns[3].Name = "Gender";
            DGVSTUDENTS.Columns[4].Name = "Birthday";
            DGVSTUDENTS.Columns[5].Name = "Religion";
            DGVSTUDENTS.Columns[6].Name = "Status";
            DGVSTUDENTS.Columns[7].Name = "Contact#";
            DGVSTUDENTS.Columns[8].Name = "Year Level";
            DGVSTUDENTS.Columns[9].Name = "Email";
            DGVSTUDENTS.Columns[10].Name = "Skills";


        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvimage =
            new DataGridViewImageColumn();
            dgvimage.HeaderText = "image";
            dgvimage.ImageLayout =
            DataGridViewImageCellLayout.Stretch;
            DGVSTUDENTS.Columns.Add(dgvimage);
        }

        public void RadioButtons()
        {
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender += "Female";

            if (chckCpp.Checked)
                skills += "C#";
            if (chckHtml.Checked)
                skills += "Html";
            if (chckJava.Checked)
                skills += "JAVA";
            if (chckPHP.Checked)
                skills += "PHP";
            if (chckPhython.Checked)
                skills += "Phython";
            if (chckVB.Checked)
                skills += "VP.NET";
        }

        public void Checkbox()
        {
            if (chckCpp.Checked)
                skills += "C#";
            if (chckHtml.Checked)
                skills += "HTML";
            if (chckJava.Checked)
                skills += "JAVA";
            if (chckPHP.Checked)
                skills += "PHP";
            if (chckPhython.Checked)
                skills += "Phython";
            if (chckVB.Checked)
                skills += "VP.NET";
        }

        public void PicBox()
        {
            MemoryStream ms = new MemoryStream();
            PicImage.Image.Save(ms, PicImage.Image.RawFormat);
            img = ms.ToArray();
        }
        private void DGVSTUDENTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = DGVSTUDENTS.Rows[index];
            txtStudentNumber.Text = row.Cells[0].Value.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_Click(object sender, EventArgs e)
        {
            string gender = "", skills = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            if (chckCpp.Checked)
            {
                skills += "C++";
            }
            if (chckHtml.Checked)
            {
                skills += "HTML";
            }
            if (chckJava.Checked)
            {
                skills += "JAVA";
            }
            if (chckPHP.Checked)
            {
                skills += "PHP";
            }
            if (chckPhython.Checked)
            {
                skills += "PHYTHON";
            }
            if (chckVB.Checked)
            {
                skills += "VB.NET";
            }

            MemoryStream memoryStream = new
            MemoryStream();
            PicImage.Image.Save(memoryStream,
            PicImage.Image.RawFormat);
            byte[] img = memoryStream.ToArray();
            DGVSTUDENTS.Rows.Add(
            txtStudentNumber.Text,
            txtFirstName.Text,
            txtLastName.Text,
            gender,
            dtpBday.Value,
            txtReligion.Text,
            cbostatus.SelectedItem,
            txtCNum.Text,
            cboYearLevel.SelectedItem,
            txtEmail.Text,
            skills,
            img);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new
            OpenFileDialog();
            dlg.Filter = "Choose image(*.jpg; *.png; *.gif; | *.jpg; *.pgn; *.gif;";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image =
                Image.FromFile(dlg.FileName);
            }
        }

        private void PicImage_Click(object sender, EventArgs e)
        {

        }

        private void Value(object sender, KeyPressEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void ClearText()
        {
            txtStudentNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpBday.ResetText();
            txtReligion.Clear();
            cbostatus.SelectedIndex = 0;
            txtCNum.Clear();
            cboYearLevel.SelectedIndex = 0;
            txtEmail.Clear();
            chckCpp.Checked = false;
            chckHtml.Checked = false;
            chckJava.Checked = false;
            chckPHP.Checked = false;
            chckPhython.Checked = false;
            chckVB.Checked = false;
            PicImage.Image = null;

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }



        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Update Your Record?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RadioButtons();
                Checkbox();
                PicBox();
                DataGridViewRow row2 = DGVSTUDENTS.Rows[index];
                row2.Cells[0].Value = txtStudentNumber.Text;
                row2.Cells[1].Value = txtFirstName.Text;
                row2.Cells[2].Value = txtLastName.Text;
                row2.Cells[3].Value = label5;
                row2.Cells[4].Value = dtpBday.Value;
                row2.Cells[5].Value = txtReligion.Text;
                row2.Cells[6].Value = cbostatus.SelectedItem;
                row2.Cells[7].Value = txtCNum.Text;
                row2.Cells[8].Value = cboYearLevel.SelectedItem;
                row2.Cells[9].Value = txtEmail.Text;
                row2.Cells[10].Value = label7;
                row2.Cells[11].Value = PicImage;
            }
            else
            {
                MessageBox.Show("Record not Updated", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chckPHP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Message)
        }
    }
}




