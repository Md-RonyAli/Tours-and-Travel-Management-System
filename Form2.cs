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
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace TravelManagementProject4
{
    public partial class Form2 : Form
    {
        DBAccess objnew = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        string randomCode;
        //string username = Form2.to;
        public static string to;
        public static string setvaluetext3;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You Are Not Logged In. Please Log in First", "Log In", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form2 back = new Form2();
                back.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from AdminInfo where [User Name] ='" + textboxusername.Text + "' and Password = '" + textboxpassword.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setvaluetext3 = textboxusername.Text;
                Form3 AdminMenu = new Form3();
                AdminMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You Are Not Logged In. Please Log in First", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form2 back = new Form2();
                back.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Reset Your Password", "Reset Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panel2.Hide();
                panel3.Show();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Reset Your Password", "Reset Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                textBox1.Clear();
                panel3.Hide();
                panel2.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from AdminInfo where [Email Address] ='" + textBox1.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                panel4.Show();
                panel3.Hide();
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textBox1.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello Sir/Madam,\n\nWe recieved a request to access your Admin Account for password reset. Your password reset code is: "+ randomCode + "\n\nThank you\n\nHappy Travelling\n\nThe RSA Tours Team ";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Reset code sent successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email Address...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Cancel Your Password Reset", "Reset Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                panel4.Hide();
                panel2.Show();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (randomCode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                textBox2.Clear();
                panel4.Hide();
                panel5.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel2.Show();
            if (textBox4.Text == textBox3.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7K57AH\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE AdminInfo SET Password = '" + textBox3.Text + "' WHERE [User Name]='" + textBox5.Text + "' ", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Reset Successfully");
            }
            else
            {
                MessageBox.Show("The New Password Do Not Match So Enter Same Password");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Cancel Your Password Reset", "Reset Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                panel5.Hide();
                panel2.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel8.Dispose();
        }
    }
}