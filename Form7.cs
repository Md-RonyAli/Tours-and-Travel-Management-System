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
using System.Data.SqlClient;
using System.IO;

namespace TravelManagementProject4
{
    public partial class Form7 : Form
    {
        DBAccess objnew = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        private int ImageNumber = 1;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmmd;
        string imgLoc = "";
        string Gender;
        //bool isShow;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label31.Text = DateTime.Now.ToLongTimeString();
            label30.Text = DateTime.Now.ToLongDateString();
            label42.Text = DateTime.Now.ToLongTimeString();
            label41.Text = DateTime.Now.ToLongDateString();
            label78.Text = DateTime.Now.ToLongTimeString();
            label77.Text = DateTime.Now.ToLongDateString();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
            panel4.Hide();
            panel1.Hide();
            panel11.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            label1.Text = Form5.setvaluetext;
        }
        private void ClearData8()
        {
            textboxfirstname8.Clear();
            textboxlastname8.Clear();
            textboxfathersname8.Clear();
            textboxmothersname8.Clear();
            textboxaddress8.Clear();
            textboxphonenumber8.Clear();
            textboxphonenumber28.Clear();
            textboxnationality8.Clear();
            textboxusername8.Clear();
            textboxpassword8.Clear();
            textboxconfirmpassword8.Clear();
            pictureBox5.Image = null;
        }
        private void ClearData9()
        {
            textboxfirstname9.Clear();
            textboxlastname9.Clear();
            textboxfathersname9.Clear();
            textboxmothersname9.Clear();
            textboxaddress9.Clear();
            textboxphonenumber9.Clear();
            textboxphonenumber29.Clear();
            textboxnationality9.Clear();
            textboxusername9.Clear();
            textboxpassword9.Clear();
            textboxconfirmpassword9.Clear();
            textboxbirth9.Clear();
            pictureBox6.Image = null;
        }
        private void movepanel(Control btn)
        {
            panel4.Width = btn.Width;
            panel4.Left = btn.Left;
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

        private void button6_Click(object sender, EventArgs e)
        {
            movepanel(button6);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            movepanel(button5);
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Hide();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            movepanel(button4);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Hide();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movepanel(button4);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            movepanel(button5);
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            movepanel(button7);
            panel6.Visible = false;
            panel8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            movepanel(button9);
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            movepanel(button8);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            movepanel(button6);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Hide();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            movepanel(button8);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Hide();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            movepanel(button7);
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = false;
            panel10.Hide();
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            movepanel(button9);
            panel6.Visible = false;
            panel7.Visible = false;
            panel10.Hide();
            panel8.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel10.Show();
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To Sign Out?", "Sign Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel13.Show();
            panel12.Hide();
            try
            {
                string sql = "SELECT [First Name], [Last Name], [Father's Name], [Mother's Name], Address, [Phone Number], [Phone Number 2], [Email Address], [Date of Birth], Gender, Nationality,Images FROM UserInfo WHERE [User Name] = '" + label1.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    //textBox2.Text = reader[0].ToString();
                    textboxfirstname7.Text = reader[0].ToString();
                    textboxlastname7.Text =reader[1].ToString();
                    textboxfathersname7.Text = reader[2].ToString();
                    textboxmothersname7.Text = reader[3].ToString();
                    textboxaddress7.Text = reader[4].ToString();
                    textboxphonenumber7.Text = reader[5].ToString();
                    textboxphonenumber27.Text = reader[6].ToString();
                    textboxemailaddress7.Text = reader[7].ToString();
                    dateTimePicker1.Text = reader[8].ToString();
                    textboxgender7.Text = reader[9].ToString();
                    textboxnationality7.Text = reader[10].ToString();
                    byte[] img = (byte[])(reader[11]);
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
                    MessageBox.Show("This Does Not Exist.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from UserInfo where [User Name] ='" + textboxusername10.Text + "' and Password = '" + textboxpassword10.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                panel11.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textboxnewpassword.Text == textboxconfirmpassword.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7K57AH\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET Password = '" + textboxconfirmpassword.Text + "' WHERE [User Name]='" + textboxusername10.Text + "' ", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Changed Successfully");
                textboxusername10.Clear();
                textboxpassword10.Clear();
                textboxnewpassword.Clear();
                textboxconfirmpassword.Clear();
                panel12.Show();
                panel1.Hide();
                panel11.Hide();
            }
            else
            {
                MessageBox.Show("Password Doesn't Matched...!\nPlease Enter Same Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Change Password?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panel1.Hide();
                panel11.Hide();
                panel12.Show();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form5 user = new Form5();
            user.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel14.Show();
            try
            {
                string sql = "SELECT [First Name], [Last Name], [Father's Name], [Mother's Name], Address, [Phone Number], [Phone Number 2], [Email Address], [Date of Birth],Nationality,[User Name],Images FROM UserInfo WHERE [User Name] = '" + label1.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    //textBox2.Text = reader[0].ToString();
                    textboxfirstname8.Text = reader[0].ToString();
                    textboxlastname8.Text = reader[1].ToString();
                    textboxfathersname8.Text = reader[2].ToString();
                    textboxmothersname8.Text = reader[3].ToString();
                    textboxaddress8.Text = reader[4].ToString();
                    textboxphonenumber8.Text = reader[5].ToString();
                    textboxphonenumber28.Text = reader[6].ToString();
                    textboxemailaddress8.Text = reader[7].ToString();
                    dateTimePicker2.Text = reader[8].ToString();
                    textboxnationality8.Text = reader[9].ToString();
                    textboxusername8.Text = reader[10].ToString();
                    byte[] img = (byte[])(reader[11]);
                    if (img == null)
                    {
                        pictureBox5.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox5.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    MessageBox.Show("This Does Not Exist.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel15.Show();
            try
            {
                string sql = "SELECT [First Name], [Last Name], [Father's Name], [Mother's Name], Address, [Phone Number], [Phone Number 2], [Email Address], [Date of Birth], Gender,Nationality,[User Name],Images FROM UserInfo WHERE [User Name] = '" + label1.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textboxfirstname9.Text = reader[0].ToString();
                    textboxlastname9.Text = reader[1].ToString();
                    textboxfathersname9.Text = reader[2].ToString();
                    textboxmothersname9.Text = reader[3].ToString();
                    textboxaddress9.Text = reader[4].ToString();
                    textboxphonenumber9.Text = reader[5].ToString();
                    textboxphonenumber29.Text = reader[6].ToString();
                    textboxemailaddress9.Text = reader[7].ToString();
                    textboxbirth9.Text = reader[8].ToString();
                    textboxgender9.Text = reader[9].ToString();
                    textboxnationality9.Text = reader[10].ToString();
                    textboxusername9.Text = reader[11].ToString();
                    byte[] img = (byte[])(reader[12]);
                    if (img == null)
                    {
                        pictureBox6.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox6.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    MessageBox.Show("This Does Not Exist.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel13.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel14.Hide();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel15.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox5.ImageLocation = imgLoc;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textboxpassword8.UseSystemPasswordChar = true;
                textboxconfirmpassword8.UseSystemPasswordChar = true;
            }
            else
            {
                textboxpassword8.UseSystemPasswordChar = false;
                textboxconfirmpassword8.UseSystemPasswordChar = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textboxpassword8.Text == textboxconfirmpassword8.Text)
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
                        string sql = "UPDATE UserInfo SET [First Name] ='" + textboxfirstname8.Text + "',[Last Name] ='" + textboxlastname8.Text + "',[Full Name] ='" + textboxfirstname8.Text + " " + textboxlastname8.Text + "',[Father's Name] ='" + textboxfathersname8.Text + "',[Mother's Name] ='" + textboxmothersname8.Text + "', Address ='" + textboxaddress8.Text + "',[Phone Number] ='" + textboxphonenumber8.Text + "', [Phone Number 2] ='" + textboxphonenumber28.Text + "', [Email Address] ='" + textboxemailaddress8.Text + "', [Date of Birth] ='" + dateTimePicker2.Text + "', Gender ='" + Gender + "', Nationality = '" + textboxnationality8.Text + "', [User Name] = '" + textboxusername8.Text + "', Images = @img, [Modify Time] ='" + label42.Text + "', [Modify Date] ='" + label41.Text + "' where Password='" + textboxpassword8.Text + "'";
                        conn.Open();
                        cmmd = new SqlCommand(sql, conn);
                        cmmd.Parameters.Add(new SqlParameter("@img", img));
                        int x = cmmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData8();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Matched...!\nPlease Enter Same Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (textboxpassword9.Text == textboxconfirmpassword9.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.dataSend("Delete from UserInfo where Password='" + textboxpassword9.Text + "'");
                    MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData9();
                    Form1 home = new Form1();
                    home.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Matched...!\nPlease Enter Same Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
