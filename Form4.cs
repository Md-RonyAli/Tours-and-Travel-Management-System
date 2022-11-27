using System;
using DatabaseProject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace TravelManagementProject4
{
    public partial class Form4 : Form
    {
        DBAccess objnew = new DBAccess();
        DBAccess con = new DBAccess();
        DataTable dtUsers = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmmd;
        string randomCode;
        public static string to;
        string imgLoc = "";
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet2.AdminInfo' table. You can move, or remove it, as needed.
            this.adminInfoTableAdapter.Fill(this.travelManagementProject4DataSet2.AdminInfo);

            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel7.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel8.BackColor = Color.FromArgb(100, 0, 0, 0);
            label15.Text = DateTime.Now.ToLongTimeString();
            label14.Text = DateTime.Now.ToLongDateString();
            label22.Text = DateTime.Now.ToLongTimeString();
            label21.Text = DateTime.Now.ToLongDateString();
            label37.Text = DateTime.Now.ToLongTimeString();
            label36.Text = DateTime.Now.ToLongDateString();
            label47.Text = DateTime.Now.ToLongTimeString();
            label46.Text = DateTime.Now.ToLongDateString();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel2.Hide();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textboxpassword.UseSystemPasswordChar = true;
            }
            else
            {
                textboxpassword.UseSystemPasswordChar = false;
            }
        }
        private void ClearData()
        {
            textboxname.Clear();
            textboxaddress.Clear();
            textboxphonenumber.Clear();
            textboxusername.Clear();
            textboxpassword.Clear();
            pictureBox2.Image = null;
        }
        private void ClearData2()
        {
            textboxname2.Clear();
            textboxaddress2.Clear();
            textboxphonenumber2.Clear();
            textboxemailaddress2.Clear();
            textboxusername2.Clear();
            textboxpassword2.Clear();
            pictureBox3.Image = null;
        }
        private void ClearData3()
         {
             textboxname3.Clear();
             textboxpassword3.Clear();
             pictureBox4.Image = null;
         }

        private void button8_Click(object sender, EventArgs e)
        {

                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textboxemailaddress.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello Sir/Madam,\n\nWe recieved a request of Email verification code to access a new Registration for Admin Account. Your Email verification code is: " + randomCode + "\n\nThank you\n\nHappy Travelling\n\nThe RSA Tours Team ";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Email verification code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Verification code sent successfully");
                    panel7.Show();
                    panel3.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            dlg.Title = "Select Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBox2.ImageLocation = imgLoc;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearData();
            panel3.Hide();
            panel2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "UPDATE AdminInfo SET Name ='" + textboxname2.Text + "', Address ='" + textboxaddress2.Text + "',[Phone Number] ='" + textboxphonenumber2.Text + "', [Email Address] ='" + textboxemailaddress2.Text + "', [User Name] = '" + textboxusername2.Text + "', Image = @img, [Modify Time] ='" + label22.Text + "', [Modify Date] ='" + label21.Text + "' where Password='" + textboxpassword2.Text + "'";
                    conn.Open();
                    cmmd = new SqlCommand(sql, conn);
                    cmmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData2();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearData2();
            panel4.Hide();
            panel2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            dlg.Title = "Select Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBox3.ImageLocation = imgLoc;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            //panel3.Hide();
            panel4.Hide();
            panel5.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClearData3();
            viewwindow.Rows.Clear();
            panel2.Show();
            panel5.Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textboxpassword2.UseSystemPasswordChar = true;
            }
            else
            {
                textboxpassword2.UseSystemPasswordChar = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Image FROM AdminInfo WHERE Name ='" + textboxname3.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        pictureBox4.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox4.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    textBox2.Text = "";
                    pictureBox1.Image = null;
                    MessageBox.Show("This Does Not Exist.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            con.dataGet("Select * from AdminInfo where Name ='" + textboxname3.Text + "' and Password = '" + textboxpassword3.Text + "' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            viewwindow.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int n = viewwindow.Rows.Add();
                    viewwindow.Rows[n].Cells["dgrSlno"].Value = n + 1;
                    viewwindow.Rows[n].Cells["dgrname"].Value = row["Name"].ToString();
                    viewwindow.Rows[n].Cells["dgremailid"].Value = row["Email Address"].ToString();
                    viewwindow.Rows[n].Cells["dgraddress"].Value = row["Address"].ToString();
                    viewwindow.Rows[n].Cells["dgrRegdate"].Value = row["Registration Date"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            viewwindow.Rows.Add();
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from AdminInfo where Password='" + textboxpassword3.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData3();
                viewwindow.Rows.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.adminInfoTableAdapter.Fill(this.travelManagementProject4DataSet2.AdminInfo);
            panel2.Hide();
            con.dataGet("Select * from AdminInfo where Name like '" + textBox2.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void travelManagementProject4DataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            viewwindow.Rows.Clear();
            panel2.Show();
            panel6.Hide();
            con.dataGet("Select * from AdminInfo where Name like '" + textBox2.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from AdminInfo where Name like '" + textBox2.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click_2(object sender, EventArgs e)
        {

            if (randomCode == (textBox1.Text).ToString())
            {
                to = textBox1.Text;
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "INSERT INTO AdminInfo(Name,Address,[Phone Number],[Email Address],[User Name],Password,Image,[Registration Time], [Registration Date])Values('" + textboxname.Text + "','" + textboxaddress.Text + "','" + textboxphonenumber.Text + "','" + textboxemailaddress.Text + "','" + textboxusername.Text + "','" + textboxpassword.Text + "',@img,'" + label15.Text + "','" + label14.Text + "')";
                    conn.Open();
                    cmmd = new SqlCommand(sql, conn);
                    cmmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmmd.ExecuteNonQuery();
                    conn.Close();
                    //con.dataSend("INSERT INTO UserInfo(" + variables + ")  values ( " + values + " )");
                    MessageBox.Show("Record Saved Successfully");
                    

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textboxemailaddress.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello Sir/Madam,\n\nCongratulations,\nYour Request For Registration of an Admin Account has been successfully done. So, experience our services on your computer. See for yourself the convenience of booking travel online. \n\nThank you\n\nHappy Travelling\n\nThe RSA Tours Team ";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Account Confirmation";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    ClearData();
                    panel7.Hide();
                    panel2.Show();
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel7.Hide();
            panel2.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel8.Dispose();
        }
    }
}
