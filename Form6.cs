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
    public partial class Form6 : Form
    {
        DBAccess objnew = new DBAccess();
        DBAccess con = new DBAccess();
        DataTable dtUsers = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmd;
        string randomCode;
        public static string to;
        string imgLoc = "";
        string Gender;
        private int ImageNumber = 1;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel10.Hide();
            panel7.Hide();
            label31.Text = DateTime.Now.ToLongTimeString();
            label30.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }
        private void Slider()
        {
            if (ImageNumber == 10)
            {
                ImageNumber = 1;
            }
            pictureBox3.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        private void ClearData7()
        {
            textboxfirstname7.Clear();
            textboxlastname7.Clear();
            textboxfathersname7.Clear();
            textboxmothersname7.Clear();
            textboxaddress7.Clear();
            textboxphonenumber7.Clear();
            textboxphonenumber27.Clear();
            textboxnationality7.Clear();
            textboxusername7.Clear();
            textboxpassword7.Clear();
            textboxconfirmpassword7.Clear();
            pictureBox2.Image = null;
        }
        private void movepanel(Control btn)
        {
            panel4.Width = btn.Width;
            panel4.Left = btn.Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            movepanel(button6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movepanel(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            movepanel(button5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            movepanel(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            movepanel(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            movepanel(button9);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Sign Up?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textboxpassword7.UseSystemPasswordChar = true;
                textboxconfirmpassword7.UseSystemPasswordChar = true;
            }
            else
            {
                textboxpassword7.UseSystemPasswordChar = false;
                textboxconfirmpassword7.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textboxpassword7.Text == textboxconfirmpassword7.Text)
            {
                
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textboxemailaddress7.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello Sir/Madam,\n\nWe recieved a request of Email verification code to access a new Registration for User Account. Your Email verification code is: " + randomCode + "\n\nThank you\n\nHappy Travelling\n\nThe RSA Tours Team ";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Email Verification code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Verification code sent successfully");
                    panel1.Hide();
                    panel7.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Matched...!\nPlease Enter Same Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Sign Up?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox7.Text).ToString())
            {
                to = textBox7.Text;
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    //string variables = "[First Name],[Last Name],[Full Name],[Father's Name],[Mother's Name],Address,[Phone Number],[Phone Number 2],[Email Address],[Date of Birth],Gender,Nationality,[User Name],Password,Images,[Registration Time],[Registration Date]"; /*Database Column Name*/
                    //string values = "'" + textboxfirstname7.Text + "','" + textboxlastname7.Text + "','" + textboxfirstname7.Text + " " + textboxlastname7.Text + "','" + textboxfathersname7.Text + "','" + textboxmothersname7.Text + "','" + textboxaddress7.Text + "','" + textboxphonenumber7.Text + "','" + textboxphonenumber27.Text + "','" + textboxemailaddress7.Text + "','" + dateTimePicker1.Text + "','" + Gender + "','" + textboxnationality7.Text + "','" + textboxusername7.Text + "','" + textboxpassword7.Text + "',@img,'" + label31.Text + "','" + label30.Text + "'"; //TextBox
                    string sql = "INSERT INTO UserInfo([First Name],[Last Name],[Full Name],[Father's Name],[Mother's Name],Address,[Phone Number],[Phone Number 2],[Email Address],[Date of Birth],Gender,Nationality,[User Name],Password,Images,[Registration Time], [Registration Date])Values('" + textboxfirstname7.Text + "','" + textboxlastname7.Text + "','" + textboxfirstname7.Text + " " + textboxlastname7.Text + "','" + textboxfathersname7.Text + "','" + textboxmothersname7.Text + "','" + textboxaddress7.Text + "','" + textboxphonenumber7.Text + "','" + textboxphonenumber27.Text + "','" + textboxemailaddress7.Text + "','" + dateTimePicker1.Text + "','" + Gender + "','" + textboxnationality7.Text + "','" + textboxusername7.Text + "','" + textboxpassword7.Text + "',@img,'" + label31.Text + "','" + label30.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    conn.Close();
                    //con.dataSend("INSERT INTO UserInfo(" + variables + ")  values ( " + values + " )");
                    
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
                to = (textboxemailaddress7.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello Sir/Madam,\n\nCongratulations,\nYour Request For Registration of an User Account has been successfully done. So, experience our services on your computer. See for yourself the convenience of booking travel online. \n\nThank you\n\nHappy Travelling\n\nThe RSA Tours Team ";
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
                    ClearData7();
                    panel1.Show();
                    panel7.Hide();
                    textBox7.Clear();
                    MessageBox.Show("Record Saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong code!!!\nPlease Enter a Valid Code.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Other's";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel10.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form5 signin = new Form5();
            signin.Show();
            this.Hide();
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            panel10.Hide();
        }
    }
}
