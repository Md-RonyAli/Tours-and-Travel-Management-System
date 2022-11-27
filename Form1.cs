using DatabaseProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace TravelManagementProject4
{
    public partial class Form1 : Form
    {
        DBAccess objnew = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        Fromto obj1 = new Fromto();
        string table = "Platinum";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmmd;
        string randomCode;
        public static string to;
        public static string setvaluetext2;
        private int ImageNumber = 1;
        string Category;
        string PackageName;
        string PackageName2;
        string Transport;
        public Form1()
        {
            InitializeComponent();
        }
        bool isShow;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
            panel16.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Hide();
            panel6.Hide();
            panel4.Hide();
            panel5.Hide();
            panel10.Hide();
            panel32.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel16.Hide();
            panel20.Hide();
            panel24.Hide();
            panel28.Hide();
            panel23.Hide();
            panel25.Hide();
            panel29.Hide();
            panel36.Hide();
            panel37.Hide();
            label83.Text = label24.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            if (panel1.Visible)
            {
                isShow = false;
                timer1.Start();
                //panel1.Hide();
            }
            else
            {
                isShow = true;
                panel1.Show();
                timer1.Start();
                //panel1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (panel1.Width >= 140)
                    timer1.Stop();

                panel1.Width += 45;
            }
            else
            {
                if (panel1.Width <= 0)
                {
                    panel1.Hide();
                    timer1.Stop();
                }
                panel1.Width -= 45;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel32.Show();
            panel15.Hide();
            panel36.Hide();
            panel37.Hide();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover_1(object sender, EventArgs e)
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

        private void panel6_MouseEnter_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button7_MouseEnter_1(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button7_MouseLeave_1(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button9_MouseEnter_1(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button9_MouseLeave_1(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel32.Hide();
            panel15.Show();
            panel36.Hide();
            panel37.Hide();
            movepanel(button4);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            button1.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel15.Hide();
            panel36.Hide();
            panel32.Hide();
            panel37.Hide();
            movepanel(button5);
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            panel15.Hide();
            panel36.Hide();
            panel32.Hide();
            panel37.Hide();
            movepanel(button7);
            panel6.Visible = false;
            panel8.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel36.Hide();
            panel32.Hide();
            panel15.Hide();
            panel37.Hide();
            movepanel(button9);
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            panel36.Show();
            panel15.Hide();
            panel32.Hide();
            panel37.Hide();
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

        private void button6_MouseHover_1(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel10.Show();
            panel36.Hide();
            panel32.Hide();
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

        private void button5_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {

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

        private void panel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

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

        private void button21_Click(object sender, EventArgs e)
        {
            panel5.Show();
            panel15.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form6 signup = new Form6();
            signup.Show();
            this.Hide();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Sign In?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Reset Password?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Reset Password?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want To cancel Reset Password?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Reset Your Password", "Reset Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panel5.Hide();
                panel12.Show();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from UserInfo where [Email Address] ='" + textBox1.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                panel13.Show();
                panel12.Hide();
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textBox1.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello Sir/Madam,\n\nWe recieved a request to access your User Account for password reset. Your password reset code is: " + randomCode + "\n\nThank you\n\nHappy Travelling\n\nThe RSA Tours Team ";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password reseting code";
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

        private void button26_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                textBox2.Clear();
                panel13.Hide();
                panel14.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel14.Hide();
            if (textBox4.Text == textBox3.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7K57AH\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET Password = '" + textBox3.Text + "' WHERE [User Name]='" + textBox5.Text + "' ", conn);
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textboxpassword6.UseSystemPasswordChar = true;
            }
            else
            {
                textboxpassword6.UseSystemPasswordChar = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from UserInfo where [User Name] ='" + textboxusername6.Text + "' and Password = '" + textboxpassword6.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel5.Hide();
                setvaluetext2 = textboxusername6.Text;
                Form5 User = new Form5();
                User.Show();
                this.Hide();
                textboxpassword6.Clear();

            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Transport = "Bus";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Transport = "Train";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Transport = "Flight";
        }
        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                Fromto.from = textboxfrom.Text;
                Fromto.to = textboxto.Text;
                con.dataGet("select Platinum.[Package From],Platinum.[Package To],Platinum.[Package Category],Gold.[Package From],Gold.[Package To],Gold.[Package Category],Silver.[Package From],Silver.[Package To],Silver.[Package Category] from Platinum,Gold,Silver where (Platinum.[Package From] = '" + textboxfrom.Text + "' and Platinum.[Package To] = '" + textboxto.Text + "' and Platinum.[Package Category] = '" + Category + "') or (Gold.[Package From] = '" + textboxfrom.Text + "' and Gold.[Package To] = '" + textboxto.Text + "' and Gold.[Package Category] = '" + Category + "') or (Silver.[Package From] = '" + textboxfrom.Text + "' and Silver.[Package To] = '" + textboxto.Text + "' and Silver.[Package Category] = '" + Category + "')");
                DataTable pop = new DataTable();
                con.sda.Fill(pop);
                if (pop.Rows.Count > 0)
                {
                    panel15.Hide();
                    panel16.Show();
                    button1.Hide();
                }
                else
                {
                    MessageBox.Show("Package Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Bus";
        }

        public void panel19_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights],[Price By Train],[Package Price],[Special Discount] from Silver where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "", train = "", price = "", sdiscount = "", t2 = "BDT";
            if (plat.Rows.Count > 0)
            {
                table = "Silver";
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Duration Days"].ToString();
                    night = row["Package Duration Nights"].ToString();
                    train = row["Price By Train"].ToString();
                    price = row["Package Price"].ToString();
                    sdiscount = row["Special Discount"].ToString();
                }
                double startprice = 0, dtotal = 0, a, b, c;
                a = double.Parse(train);
                b = double.Parse(price);
                c = double.Parse(sdiscount);
                dtotal += a + b;
                startprice += dtotal - (dtotal * (c / 100));
                string t = startprice.ToString();
                t2 = "BDT " + t + " Taka.";
            }
            sday.Text = day + " days and";
            snight.Text = night + " nights";
            sfrom.Text = "From " + Fromto.from + "\nTo\n" + Fromto.to;
            staka.Text = t2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights] from Platinum where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "";
            if (plat.Rows.Count > 0)
            {
                table = "Silver";
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Duration Days"].ToString();
                    night = row["Package Duration Nights"].ToString();
                }
            }
            ppday.Text = day + " days and";
            ppnight.Text = night;
            ppfrom.Text = Fromto.from;
            ppto.Text = Fromto.to;
            //staka.Text = "BDT " + train;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel20.Hide();
            panel16.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (ptaka.Text != "")
            {

                panel20.Show();
                panel16.Hide();
                try
                {
                    string sql = "SELECT [Image 1] FROM Platinum WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
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
                        pictureBox4.Image = null;
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

            else
            {
                MessageBox.Show("Package Not Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (gtaka.Text != "")
            {

                panel24.Show();
                panel16.Hide();
                try
                {
                    string sql = "SELECT [Image 1] FROM Gold WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                    conn.Open();
                    cmmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);
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
                        pictureBox5.Image = null;
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

            else
            {
                MessageBox.Show("Package Not Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (staka.Text != "")
            {

                panel28.Show();
                panel16.Hide();
                try
                {
                    string sql = "SELECT [Image 1] FROM Silver WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                    conn.Open();
                    cmmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);
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
                        pictureBox6.Image = null;
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

            else
            {
                MessageBox.Show("Package Not Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel16.Hide();
            panel15.Show();
            button1.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                string adult = textBox6.Text;
                string child = textBox7.Text;
                string pbus = "", ptrain = "", pflight = "", pchild = "", pspecial = "", pprice = "0";
                con.dataGet("Select * from Platinum Where [Package From]='" + Fromto.from + "' and [Package To]='" + Fromto.to + "'");
                DataTable pl = new DataTable();
                con.sda.Fill(pl);
                foreach (DataRow row in pl.Rows)
                {
                    //MessageBox.Show("Aise");
                    pbus = row["Price By Bus"].ToString();
                    ptrain = row["Price By Train"].ToString();
                    pflight = row["Price By Flight"].ToString();
                    pprice = row["Package Price"].ToString();
                    pchild = row["Child Discount"].ToString();
                    pspecial = row["Special Discount"].ToString();

                    //MessageBox.Show(row["Package Price"].ToString());
                }
                //MessageBox.Show(pprice);
                string price = "";
                if (Transport == "Bus")
                {
                    price = pbus;
                }
                else if (Transport == "Train")
                {
                    price = ptrain;
                }
                else if (Transport == "Flight")
                {
                    price = pflight;
                }
                int pp, p, a, c;
                double total = 0, dtotal = 0, ctotal = 0, d, f;
                pp = int.Parse(pprice);
                p = int.Parse(price);
                a = int.Parse(adult);
                c = int.Parse(child);
                d = double.Parse(pchild);
                f = double.Parse(pspecial);
                pp += p;
                if (a > 0)
                {
                    total += (pp * a);
                }
                if (c > 0)
                {
                    ctotal += (pp * c);
                    total += ctotal - (ctotal * (d / 100));
                }

                dtotal += total - (total * (f / 100));
                string t = total.ToString();
                string u = dtotal.ToString();

                label77.Text = "BDT " + t;
                label78.Text = "BDT " + u;
                label79.Text = pspecial + "% Discount Price: ";
                panel23.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel25.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel29.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Domestic";
            GetCategoryname();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Regional";
            GetCategoryname();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Category = "International";
            GetCategoryname();
        }

        public void panel17_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights],[Price By Train],[Package Price],[Special Discount] from Platinum where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "", train = "", price = "", sdiscount = "", t3 = "BDT";
            if (plat.Rows.Count > 0)
            {
                table = "Platinum";
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Duration Days"].ToString();
                    night = row["Package Duration Nights"].ToString();
                    train = row["Price By Train"].ToString();
                    price = row["Package Price"].ToString();
                    sdiscount = row["Special Discount"].ToString();
                }
                double startprice = 0, dtotal = 0, a, b, c;
                a = double.Parse(train);
                b = double.Parse(price);
                c = double.Parse(sdiscount);
                dtotal += a + b;
                startprice += dtotal - (dtotal * (c / 100));
                string t = startprice.ToString();
                t3 = "BDT " + t + " Taka.";
            }

            pday.Text = day + " days and";
            pnight.Text = night + " nights";
            pfrom.Text = "From " + Fromto.from + "\nTo\n" +Fromto.to;
            ptaka.Text = t3;
        }

        public void panel16_Paint(object sender, PaintEventArgs e)
        {

            con.dataGet("select [Package Name] from " + table + " where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "";
            if (plat.Rows.Count > 0)
            {
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Name"].ToString();

                }
            }
            label24.Text = day;

        }

        public void panel18_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights],[Price By Train],[Package Price],[Special Discount] from Gold where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "", train = "", price = "", sdiscount = "", t1 = "BDT";
            if (plat.Rows.Count > 0)
            {
                table = "Gold";
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Duration Days"].ToString();
                    night = row["Package Duration Nights"].ToString();
                    train = row["Price By Train"].ToString();
                    price = row["Package Price"].ToString();
                    sdiscount = row["Special Discount"].ToString();
                }
                double startprice = 0, dtotal = 0, a, b, c;
                a = double.Parse(train);
                b = double.Parse(price);
                c = double.Parse(sdiscount);
                dtotal += a + b;
                startprice += dtotal - (dtotal * (c / 100));
                string t = startprice.ToString();
                t1 = "BDT " + t + " Taka.";
            }
            gday.Text = day + " days and";
            gnight.Text = night + " nights";
            gfrom.Text = "From " + Fromto.from + "\nTo\n" + Fromto.to;
            gtaka.Text = t1;
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            label83.Text = label24.Text;
        }

        private void label83_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Details] from Platinum where [Package Name] = '" + label83.Text + "'");
            DataTable ppn = new DataTable();
            con.sda.Fill(ppn);
            string details = "";
            if (ppn.Rows.Count > 0)
            {
                foreach (DataRow row in ppn.Rows)
                {
                    details = row["Package Details"].ToString();
                }
            }
            label74.Text = label83.Text + " : " + details;
        }

        public void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Train";
        }

        public void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Flight";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 1] FROM Platinum WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
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
                    pictureBox4.Image = null;
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

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 2] FROM Platinum WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
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
                    pictureBox4.Image = null;
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

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 3] FROM Platinum WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
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
                    pictureBox4.Image = null;
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

        private void button42_Click_1(object sender, EventArgs e)
        {
            panel24.Hide();
            panel16.Show();
        }

        private void button45_Click_1(object sender, EventArgs e)
        {
            panel28.Hide();
            panel16.Show();
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            label52.Text = label24.Text;
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            label91.Text = label24.Text;
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 1] FROM Gold WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
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
                    pictureBox5.Image = null;
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

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 2] FROM Gold WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
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
                    pictureBox5.Image = null;
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

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 3] FROM Gold WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
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
                    pictureBox5.Image = null;
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

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Details] from Gold where [Package Name] = '" + label52.Text + "'");
            DataTable ppn = new DataTable();
            con.sda.Fill(ppn);
            string details = "";
            if (ppn.Rows.Count > 0)
            {
                foreach (DataRow row in ppn.Rows)
                {
                    details = row["Package Details"].ToString();
                }
            }
            label38.Text = label52.Text + " : " + details;
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights] from Gold where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "";
            if (plat.Rows.Count > 0)
            {
                table = "Silver";
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Duration Days"].ToString();
                    night = row["Package Duration Nights"].ToString();
                }
            }
            ggday.Text = day + " days and";
            ggnight.Text = night;
            ggfrom.Text = Fromto.from;
            ggto.Text = Fromto.to;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Bus";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Train";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Flight";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                string adult = textBox9.Text;
                string child = textBox8.Text;
                string pbus = "", ptrain = "", pflight = "", pchild = "", pspecial = "", pprice = "0";
                con.dataGet("Select * from Gold Where [Package From]='" + Fromto.from + "' and [Package To]='" + Fromto.to + "'");
                DataTable pl = new DataTable();
                con.sda.Fill(pl);
                foreach (DataRow row in pl.Rows)
                {
                    //MessageBox.Show("Aise");
                    pbus = row["Price By Bus"].ToString();
                    ptrain = row["Price By Train"].ToString();
                    pflight = row["Price By Flight"].ToString();
                    pprice = row["Package Price"].ToString();
                    pchild = row["Child Discount"].ToString();
                    pspecial = row["Special Discount"].ToString();

                    //MessageBox.Show(row["Package Price"].ToString());
                }
                //MessageBox.Show(pprice);
                string price = "";
                if (Transport == "Bus")
                {
                    price = pbus;
                }
                else if (Transport == "Train")
                {
                    price = ptrain;
                }
                else if (Transport == "Flight")
                {
                    price = pflight;
                }
                int pp, p, a, c;
                double total = 0, dtotal = 0, ctotal = 0, d, f;
                pp = int.Parse(pprice);
                p = int.Parse(price);
                a = int.Parse(adult);
                c = int.Parse(child);
                d = double.Parse(pchild);
                f = double.Parse(pspecial);
                pp += p;
                if (a > 0)
                {
                    total += (pp * a);
                }
                if (c > 0)
                {
                    ctotal += (pp * c);
                    total += ctotal - (ctotal * (d / 100));
                }

                dtotal += total - (total * (f / 100));
                string t = total.ToString();
                string u = dtotal.ToString();

                label33.Text = "BDT " + t;
                label31.Text = "BDT " + u;
                label32.Text = pspecial + "% Discount Price: ";
                panel25.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 1] FROM Silver WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
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
                    pictureBox6.Image = null;
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

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 2] FROM Silver WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
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
                    pictureBox6.Image = null;
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

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Image 3] FROM Silver WHERE [Package From] ='" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
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
                    pictureBox6.Image = null;
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

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Details] from Silver where [Package Name] = '" + label91.Text + "'");
            DataTable ppn = new DataTable();
            con.sda.Fill(ppn);
            string details = "";
            if (ppn.Rows.Count > 0)
            {
                foreach (DataRow row in ppn.Rows)
                {
                    details = row["Package Details"].ToString();
                }
            }
            label67.Text = label91.Text + " : " + details;
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights] from Silver where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "";
            if (plat.Rows.Count > 0)
            {
                table = "Silver";
                foreach (DataRow row in plat.Rows)
                {
                    day = row["Package Duration Days"].ToString();
                    night = row["Package Duration Nights"].ToString();
                }
            }
            ssday.Text = day + " days and";
            ssnight.Text = night;
            ssfrom.Text = Fromto.from;
            ssto.Text = Fromto.to;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                string adult = textBox11.Text;
                string child = textBox10.Text;
                string pbus = "", ptrain = "", pflight = "", pchild = "", pspecial = "", pprice = "0";
                con.dataGet("Select * from Silver Where [Package From]='" + Fromto.from + "' and [Package To]='" + Fromto.to + "'");
                DataTable pl = new DataTable();
                con.sda.Fill(pl);
                foreach (DataRow row in pl.Rows)
                {
                    //MessageBox.Show("Aise");
                    pbus = row["Price By Bus"].ToString();
                    ptrain = row["Price By Train"].ToString();
                    pflight = row["Price By Flight"].ToString();
                    pprice = row["Package Price"].ToString();
                    pchild = row["Child Discount"].ToString();
                    pspecial = row["Special Discount"].ToString();

                    //MessageBox.Show(row["Package Price"].ToString());
                }
                //MessageBox.Show(pprice);
                string price = "";
                if (Transport == "Bus")
                {
                    price = pbus;
                }
                else if (Transport == "Train")
                {
                    price = ptrain;
                }
                else if (Transport == "Flight")
                {
                    price = pflight;
                }
                int pp, p, a, c;
                double total = 0, dtotal = 0, ctotal = 0, d, f;
                pp = int.Parse(pprice);
                p = int.Parse(price);
                a = int.Parse(adult);
                c = int.Parse(child);
                d = double.Parse(pchild);
                f = double.Parse(pspecial);
                pp += p;
                if (a > 0)
                {
                    total += (pp * a);
                }
                if (c > 0)
                {
                    ctotal += (pp * c);
                    total += ctotal - (ctotal * (d / 100));
                }

                dtotal += total - (total * (f / 100));
                string t = total.ToString();
                string u = dtotal.ToString();

                label55.Text = "BDT " + t;
                label53.Text = "BDT " + u;
                label54.Text = pspecial + "% Discount Price: ";
                panel29.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Bus";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Train";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Flight";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("For Book any Package you have to login first?", "Login", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("For Book any Package you have to login first?", "Login", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("For Book any Package you have to login first?", "Login", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string sql = "SELECT Address,[Phone Number],[Email Address],Image FROM AdminInfo WHERE Name ='" + label133.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    label135.Text = reader[0].ToString();
                    label134.Text = reader[1].ToString();
                    label136.Text = reader[2].ToString();
                    byte[] img = (byte[])(reader[3]);
                    if (img == null)
                    {
                        pictureBox7.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox7.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    pictureBox7.Image = null;
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

        private void panel33_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string sql = "SELECT Address,[Phone Number],[Email Address],Image FROM AdminInfo WHERE Name ='" + label144.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    label142.Text = reader[0].ToString();
                    label143.Text = reader[1].ToString();
                    label141.Text = reader[2].ToString();
                    byte[] img = (byte[])(reader[3]);
                    if (img == null)
                    {
                        pictureBox9.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox9.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    pictureBox9.Image = null;
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

        private void panel34_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string sql = "SELECT Address,[Phone Number],[Email Address],Image FROM AdminInfo WHERE Name ='" + label140.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    label138.Text = reader[0].ToString();
                    label139.Text = reader[1].ToString();
                    label137.Text = reader[2].ToString();
                    byte[] img = (byte[])(reader[3]);
                    if (img == null)
                    {
                        pictureBox8.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox8.Image = Image.FromStream(ms);

                    }
                }
                else
                {
                    pictureBox8.Image = null;
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

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form9 gallery = new Form9();
            gallery.Show();
            this.Hide();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form9 gallery = new Form9();
            gallery.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 gallery = new Form9();
            gallery.Show();
            this.Hide();
        }

        private void textboxfrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (textboxfrom.SelectedIndex != -1)
            {
                PackageName = textboxfrom.SelectedValue.ToString();
            }
        }
        private void GetCategoryname()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT [Package From], [Package Category] from Search Where ([Package From] IS NOT NULL and [Package Category] = '" + Category + "')", conn);
            SqlDataAdapter da2 = new SqlDataAdapter("Select DISTINCT [Package To], [Package Category] from Search Where ([Package To] IS NOT NULL and [Package Category] = '" + Category + "')", conn);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            textboxfrom.DataSource = dt;
            textboxto.DataSource = dt2;
            textboxfrom.DisplayMember = "Package From";
            textboxfrom.ValueMember = "Package From";
            textboxto.DisplayMember = "Package To";
            textboxto.ValueMember = "Package To";
            textboxfrom.SelectedIndex = -1;
            textboxfrom.SelectedText = "Select Package From";
            textboxto.SelectedIndex = -1;
            textboxto.SelectedText = "Select Package To";
            if (textboxfrom.SelectedIndex != -1)
            {
                PackageName = textboxfrom.SelectedValue.ToString();
            }
            else if(textboxto.SelectedIndex != -1)
            {
                PackageName2 = textboxto.SelectedValue.ToString();
            }
        }

        private void textboxto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (textboxto.SelectedIndex != -1)
            {
                PackageName2 = textboxto.SelectedValue.ToString();
            }
        }

        private void pfrom_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel37.Show();
            panel15.Hide();
        }
    }
}
