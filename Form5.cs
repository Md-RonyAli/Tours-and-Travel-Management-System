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
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace TravelManagementProject4
{
    public partial class Form5 : Form
    {
        DBAccess objnew = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        string table = "Platinum";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmmd;
        public static string to;
        private int ImageNumber = 1;
        public static string setvaluetext;
        DataTable dt = new DataTable();
        string Category;
        string Transport;
        string PackageName;
        string PackageName2;
        public Form5()
        {
            InitializeComponent();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel4.Hide();
            panel16.Hide();
            panel20.Hide();
            panel24.Hide();
            panel28.Hide();
            panel23.Hide();
            panel25.Hide();
            panel29.Hide();
            panel36.Hide();
            panel37.Hide();
            panel34.Hide();
            label1.Text = Form1.setvaluetext2;
            label105.Text = DateTime.Now.ToLongTimeString();
            label104.Text = DateTime.Now.ToLongDateString();
            label107.Text = DateTime.Now.ToLongTimeString();
            label106.Text = DateTime.Now.ToLongDateString();
            label109.Text = DateTime.Now.ToLongTimeString();
            label108.Text = DateTime.Now.ToLongDateString();
            label160.Text = DateTime.Now.ToLongTimeString();
            label159.Text = DateTime.Now.ToLongDateString();

        }
        private void movepanel(Control btn)
        {
            panel4.Width = btn.Width;
            panel4.Left = btn.Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel13.Show();
            panel15.Hide();
            panel36.Hide();
            panel34.Hide();
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

        private void button4_MouseHover(object sender, EventArgs e)
        {
            movepanel(button4);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Hide();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
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
            panel13.Hide();
            panel15.Show();
            panel36.Hide();
            panel34.Hide();
            panel37.Hide();
            movepanel(button4);
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel15.Hide();
            panel36.Hide();
            panel13.Hide();
            panel34.Hide();
            panel37.Hide();
            movepanel(button5);
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel15.Hide();
            panel36.Hide();
            panel13.Hide();
            panel34.Hide();
            panel37.Hide();
            movepanel(button7);
            panel6.Visible = false;
            panel8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel15.Hide();
            panel36.Hide();
            panel13.Hide();
            panel34.Hide();
            panel37.Hide();
            movepanel(button9);
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel13.Hide();
            panel36.Show();
            panel15.Hide();
            panel34.Hide();
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            setvaluetext = label1.Text;
            Form7 MyAccount = new Form7();
            MyAccount.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //panel12.Hide();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void textboxnationality8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click_2(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {


        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel16.Hide();
            panel15.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel20.Hide();
            panel16.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel24.Hide();
            panel16.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel28.Hide();
            panel16.Show();
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

        private void button32_Click_1(object sender, EventArgs e)
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

        private void panel16_Paint(object sender, PaintEventArgs e)
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

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights],[Price By Train],[Package Price],[Special Discount] from Platinum where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "", train = "", price = "", sdiscount = "", t1 = "BDT";
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
                t1 = "BDT " + t + " Taka.";
            }

            pday.Text = day + " days and";
            pnight.Text = night + " nights";
            pfrom.Text = "From " + Fromto.from + "\nTo\n" + Fromto.to;
            ptaka.Text = t1;
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights],[Price By Train],[Package Price],[Special Discount] from Gold where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "", train = "", price = "", sdiscount = "", t2 = "BDT";
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
                t2 = "BDT " + t + " Taka.";
            }

            gday.Text = day + " days and";
            gnight.Text = night + " nights";
            gfrom.Text = "From " + Fromto.from + "\nTo\n" + Fromto.to;
            gtaka.Text = t2;
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            con.dataGet("select [Package Duration Days],[Package Duration Nights],[Price By Train],[Package Price],[Special Discount] from Silver where [Package From] = '" + Fromto.from + "' and [Package To] = '" + Fromto.to + "'");
            DataTable plat = new DataTable();
            con.sda.Fill(plat);
            string day = "", night = "", train = "", price = "", sdiscount = "", t3 = "BDT";
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
                t3 = "BDT " + t + " Taka.";
            }

            sday.Text = day + " days and";
            snight.Text = night + " nights";
            sfrom.Text = "From " + Fromto.from + "\nTo\n" + Fromto.to;
            staka.Text = t3;
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

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            label83.Text = label24.Text;
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

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Bus";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Train";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Flight";
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
                panel20.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            label52.Text = label24.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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
                panel24.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            label91.Text = label24.Text;
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
                panel28.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string variables = "[Customer Name],[Phone Number],[Email Address],[Package Name],[Package Type],[Package Category],[Package Destination],[Package Duration],Persons,[Package Departure Date],[Package Price],[Booking Time],[Booking Date]"; /*Database Column Name*/
                string values = "'" + label4.Text + "','" + label5.Text + "','" + label6.Text + "','" + label12.Text + "','" + label13.Text + "','" + label14.Text + "','" + label18.Text + "','" + label15.Text + "','" + label16.Text + "','" + label19.Text + "','" + label17.Text + "','" + label107.Text + "','" + label106.Text + "'"; //TextBox

                con.dataSend("INSERT INTO BookingInfo(" + variables + ")  values ( " + values + " )");
                MessageBox.Show("Record Saved Successfully");

                string from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = (label6.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello " + label4.Text + ",\n\nCongratulations,\nYour Request For Booking of " + label28.Text + " from " + ppfrom.Text + " to " + ppto.Text + " has been successfully done.Your Package details are:\n\n" + label12.Text + "\n" + label13.Text + "\n" + label14.Text + "\n" + label18.Text + "\n" + label15.Text + "\n" + label16.Text + "\n\n" + label19.Text + "\n\n" + label17.Text + "\n\nYou will get a Booking Confirmation mail within 24 Hrs. So, Enjoy your trip and share with us your experience.\n\nThank you\n\nHappy Travelling\nRSA Tours and Travels";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Booking Details";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Form5 User = new Form5();
                User.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string variables = "[Customer Name],[Phone Number],[Email Address],[Package Name],[Package Type],[Package Category],[Package Destination],[Package Duration],Persons,[Package Departure Date],[Package Price],[Booking Time],[Booking Date]"; /*Database Column Name*/
                string values = "'" + label101.Text + "','" + label100.Text + "','" + label99.Text + "','" + label93.Text + "','" + label92.Text + "','" + label85.Text + "','" + label46.Text + "','" + label82.Text + "','" + label80.Text + "','" + label44.Text + "','" + label71.Text + "','" + label105.Text + "','" + label104.Text + "'"; //TextBox

                con.dataSend("INSERT INTO BookingInfo(" + variables + ")  values ( " + values + " )");
                MessageBox.Show("Record Saved Successfully");

                string from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = (label99.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello " + label101.Text + ",\n\nCongratulations,\nYour Request For Booking of " + label92.Text + " from " + ggfrom.Text + " to " + ggto.Text + " has been successfully done.Your Package details are:\n\n" + label93.Text + "\n" + label92.Text + "\n" + label85.Text + "\n" + label46.Text + "\n" + label82.Text + "\n" + label80.Text + "\n\n" + label44.Text + "\n\n" + label71.Text + "\n\nYou will get a Booking Confirmation mail within 24 Hrs. So, Enjoy your trip and share with us your experience.\n\nThank you\n\nHappy Travelling\nRSA Tours and Travels";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Booking Details";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Form5 User = new Form5();
                User.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string variables = "[Customer Name],[Phone Number],[Email Address],[Package Name],[Package Type],[Package Category],[Package Destination],[Package Duration],Persons,[Package Departure Date],[Package Price],[Booking Time],[Booking Date]"; /*Database Column Name*/
                string values = "'" + label126.Text + "','" + label125.Text + "','" + label124.Text + "','" + label118.Text + "','" + label117.Text + "','" + label116.Text + "','" + label12.Text + "','" + label115.Text + "','" + label114.Text + "','" + label111.Text + "','" + label113.Text + "','" + label109.Text + "','" + label108.Text + "'"; //TextBox

                con.dataSend("INSERT INTO BookingInfo(" + variables + ")  values ( " + values + " )");
                MessageBox.Show("Record Saved Successfully");

                string from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = (label99.Text).ToString();
                from = "rsatoursandtravels024@gmail.com";
                pass = "13579024680ronygmail3lgnai";
                messageBody = "Hello " + label126.Text + ",\n\nCongratulations,\nYour Request For Booking of " + label17.Text + " from " + ssfrom.Text + " to " + ssto.Text + " has been successfully done.Your Package details are:\n\n" + label118.Text + "\n" + label117.Text + "\n" + label116.Text + "\n" + label112.Text + "\n" + label115.Text + "\n" + label114.Text + "\n\n" + label111.Text + "\n\n" + label113.Text + "\n\nYou will get a Booking Confirmation mail within 24 Hrs. So, Enjoy your trip and share with us your experience.\n\nThank you\n\nHappy Travelling\nRSA Tours and Travels";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Booking Details";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Form5 User = new Form5();
                User.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint_1(object sender, PaintEventArgs e)
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel32_Paint(object sender, PaintEventArgs e)
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

        private void label155_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 user = new Form10();
            user.Show();
            this.Hide();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Form10 user = new Form10();
            user.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form10 user = new Form10();
            user.Show();
            this.Hide();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textboxfrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (textboxfrom.SelectedIndex != -1)
            {
                PackageName = textboxfrom.SelectedValue.ToString();
            }
        }

        private void textboxto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (textboxto.SelectedIndex != -1)
            {
                PackageName2 = textboxto.SelectedValue.ToString();
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
            else if (textboxto.SelectedIndex != -1)
            {
                PackageName2 = textboxto.SelectedValue.ToString();
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 239;
            int startx2 = 131;
            int starty = 120;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("RSA Tours And Travels", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            string top = "DATE:" + label106.Text.PadRight(5) + " TIME:" + label107.Text.PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx2, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("-----------------------------------------------", font, new SolidBrush(Color.Black), startx2, starty + offset);
            offset = offset + 60;
            graphics.DrawString("Congratulation", new Font("Courier New", 18), new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 45;
            string top2 = label4.Text.PadRight(5);
            graphics.DrawString(top2, font, new SolidBrush(Color.Black), startx + 110, starty + offset);
            offset = offset + 30;
            string top3 = label5.Text.PadRight(5);
            graphics.DrawString(top3, font, new SolidBrush(Color.Black), startx + 25, starty + offset);
            offset = offset + 30;
            string top4 = label40.Text.PadRight(5) + " " + label6.Text.PadRight(5);
            graphics.DrawString(top4, font, new SolidBrush(Color.Black), startx + 10, starty + offset);
            offset = offset + 60;
            string top5 = label11.Text.PadRight(5);
            graphics.DrawString(top5, font, new SolidBrush(Color.Black), startx + 77, starty + offset);
            offset = offset + 30;
            string top6 = label129.Text.PadRight(5) + " " + label12.Text.PadRight(5);
            graphics.DrawString(top6, font, new SolidBrush(Color.Black), startx + 18, starty + offset);
            offset = offset + 30;
            string top7 = label13.Text.PadRight(5);
            graphics.DrawString(top7, font, new SolidBrush(Color.Black), startx + 50, starty + offset);
            offset = offset + 30;
            string top8 = label14.Text.PadRight(5);
            graphics.DrawString(top8, font, new SolidBrush(Color.Black), startx + 28, starty + offset);
            offset = offset + 30;
            string top9 = label18.Text.PadRight(5);
            graphics.DrawString(top9, font, new SolidBrush(Color.Black), startx + 40, starty + offset);
            offset = offset + 30;
            string top10 = label15.Text.PadRight(5);
            graphics.DrawString(top10, font, new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 30;
            string top11 = label16.Text.PadRight(5);
            graphics.DrawString(top11, font, new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 30;
            string top12 = label19.Text.PadRight(5);
            graphics.DrawString(top12, font, new SolidBrush(Color.Black), startx -50, starty + offset);
            offset = offset + 60;
            string top13 = label17.Text.PadRight(5);
            graphics.DrawString(top13, font, new SolidBrush(Color.Black), startx + 65, starty + offset);
            offset = offset + 90;
            string top14 = label7.Text.PadRight(5);
            graphics.DrawString(top14, font, new SolidBrush(Color.Green), startx - 60, starty + offset);
            offset = offset + 30;
            string top15 = label8.Text.PadRight(5);
            graphics.DrawString(top15, font, new SolidBrush(Color.Black), startx - 55, starty + offset);
            offset = offset + 60;
            string top16 = label9.Text.PadRight(5);
            graphics.DrawString(top16, font, new SolidBrush(Color.Black), startx + 50, starty + offset);
            offset = offset + 30;
            string top17 = label10.Text.PadRight(5);
            graphics.DrawString(top17, font, new SolidBrush(Color.Black), startx + 47, starty + offset);

        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            panel23.Hide();
            panel20.Show();
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            try
            {
                string adult = textBox6.Text;
                string child = textBox7.Text;
                con.dataGet("select [Full Name], [Phone Number], [Email Address] from UserInfo where [User Name] = '" + label1.Text + "'");
                DataTable pop = new DataTable();
                con.sda.Fill(pop);
                string name = "", phone = "", email = "";
                if (pop.Rows.Count > 0)
                {
                    foreach (DataRow row in pop.Rows)
                    {
                        name = row["Full Name"].ToString();
                        phone = row["Phone Number"].ToString();
                        email = row["Email Address"].ToString();
                    }
                }
                panel1.Show();
                panel23.Hide();
                label4.Text = name;
                label5.Text = "Contact No: " + phone;
                label6.Text = email;
                label12.Text = label83.Text;
                label13.Text = "Package Type: " + label25.Text;
                label14.Text = "Package Category: " + Category;
                label15.Text = ppday.Text + " " + ppnight.Text + " nights";
                label16.Text = adult + " Adult and " + child + " Child";
                label17.Text = "Price: " + label78.Text + " Taka.";
                label18.Text = "From: " + ppfrom.Text + " to " + ppto.Text;
                label19.Text = "Departure Date: " + dateTimePicker1.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            try
            {
                string adult = textBox9.Text;
                string child = textBox8.Text;
                con.dataGet("select [Full Name], [Phone Number], [Email Address] from UserInfo where [User Name] = '" + label1.Text + "'");
                DataTable pop = new DataTable();
                con.sda.Fill(pop);
                string name = "", phone = "", email = "";
                if (pop.Rows.Count > 0)
                {
                    foreach (DataRow row in pop.Rows)
                    {
                        name = row["Full Name"].ToString();
                        phone = row["Phone Number"].ToString();
                        email = row["Email Address"].ToString();
                    }
                }
                panel11.Show();
                panel25.Hide();
                label101.Text = name;
                label100.Text = "Contact No: " + phone;
                label99.Text = email;
                label93.Text = label52.Text;
                label92.Text = "Package Type: " + label26.Text;
                label85.Text = "Package Category: " + Category;
                label82.Text = ggday.Text + " " + ggnight.Text + " nights";
                label80.Text = adult + " Adult and " + child + " Child";
                label71.Text = "Price: " + label31.Text + " Taka.";
                label46.Text = "From: " + ggfrom.Text + " to " + ggto.Text;
                label44.Text = "Departure Date: " + dateTimePicker2.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            panel25.Hide();
            panel24.Show();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            printDialog2.Document = printDocument2;
            DialogResult result = printDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 239;
            int startx2 = 131;
            int starty = 120;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("RSA Tours And Travels", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            string top = "DATE:" + label104.Text.PadRight(5) + " TIME:" + label105.Text.PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx2, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("-----------------------------------------------", font, new SolidBrush(Color.Black), startx2, starty + offset);
            offset = offset + 60;
            graphics.DrawString("Congratulation", new Font("Courier New", 18), new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 45;
            string top2 = label101.Text.PadRight(5);
            graphics.DrawString(top2, font, new SolidBrush(Color.Black), startx + 110, starty + offset);
            offset = offset + 30;
            string top3 = label100.Text.PadRight(5);
            graphics.DrawString(top3, font, new SolidBrush(Color.Black), startx + 25, starty + offset);
            offset = offset + 30;
            string top4 = label42.Text.PadRight(5) + " " + label99.Text.PadRight(5);
            graphics.DrawString(top4, font, new SolidBrush(Color.Black), startx + 10, starty + offset);
            offset = offset + 60;
            string top5 = label94.Text.PadRight(5);
            graphics.DrawString(top5, font, new SolidBrush(Color.Black), startx + 77, starty + offset);
            offset = offset + 30;
            string top6 = label130.Text.PadRight(5) + " " + label93.Text.PadRight(5);
            graphics.DrawString(top6, font, new SolidBrush(Color.Black), startx + 18, starty + offset);
            offset = offset + 30;
            string top7 = label92.Text.PadRight(5);
            graphics.DrawString(top7, font, new SolidBrush(Color.Black), startx + 50, starty + offset);
            offset = offset + 30;
            string top8 = label85.Text.PadRight(5);
            graphics.DrawString(top8, font, new SolidBrush(Color.Black), startx + 28, starty + offset);
            offset = offset + 30;
            string top9 = label46.Text.PadRight(5);
            graphics.DrawString(top9, font, new SolidBrush(Color.Black), startx + 40, starty + offset);
            offset = offset + 30;
            string top10 = label82.Text.PadRight(5);
            graphics.DrawString(top10, font, new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 30;
            string top11 = label80.Text.PadRight(5);
            graphics.DrawString(top11, font, new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 30;
            string top12 = label44.Text.PadRight(5);
            graphics.DrawString(top12, font, new SolidBrush(Color.Black), startx - 50, starty + offset);
            offset = offset + 60;
            string top13 = label71.Text.PadRight(5);
            graphics.DrawString(top13, font, new SolidBrush(Color.Black), startx + 65, starty + offset);
            offset = offset + 90;
            string top14 = label98.Text.PadRight(5);
            graphics.DrawString(top14, font, new SolidBrush(Color.Green), startx - 60, starty + offset);
            offset = offset + 30;
            string top15 = label97.Text.PadRight(5);
            graphics.DrawString(top15, font, new SolidBrush(Color.Black), startx - 55, starty + offset);
            offset = offset + 60;
            string top16 = label96.Text.PadRight(5);
            graphics.DrawString(top16, font, new SolidBrush(Color.Black), startx + 50, starty + offset);
            offset = offset + 30;
            string top17 = label95.Text.PadRight(5);
            graphics.DrawString(top17, font, new SolidBrush(Color.Black), startx + 47, starty + offset);
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            try
            {
                string adult = textBox11.Text;
                string child = textBox10.Text;
                con.dataGet("select [Full Name], [Phone Number], [Email Address] from UserInfo where [User Name] = '" + label1.Text + "'");
                DataTable pop = new DataTable();
                con.sda.Fill(pop);
                string name = "", phone = "", email = "";
                if (pop.Rows.Count > 0)
                {
                    foreach (DataRow row in pop.Rows)
                    {
                        name = row["Full Name"].ToString();
                        phone = row["Phone Number"].ToString();
                        email = row["Email Address"].ToString();
                    }
                }
                panel12.Show();
                panel29.Hide();
                label126.Text = name;
                label125.Text = "Contact No: " + phone;
                label124.Text = email;
                label118.Text = label91.Text;
                label117.Text = "Package Type: " + label27.Text;
                label116.Text = "Package Category: " + Category;
                label115.Text = ssday.Text + " " + ssnight.Text + " nights";
                label114.Text = adult + " Adult and " + child + " Child";
                label113.Text = "Price: " + label53.Text + " Taka.";
                label112.Text = "From: " + ssfrom.Text + " to " + ssto.Text;
                label111.Text = "Departure Date: " + dateTimePicker3.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            printDialog3.Document = printDocument3;
            DialogResult result = printDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument3.Print();
            }
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 239;
            int startx2 = 131;
            int starty = 120;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("RSA Tours And Travels", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            string top = "DATE:" + label108.Text.PadRight(5) + " TIME:" + label109.Text.PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx2, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("-----------------------------------------------", font, new SolidBrush(Color.Black), startx2, starty + offset);
            offset = offset + 60;
            graphics.DrawString("Congratulation", new Font("Courier New", 18), new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 45;
            string top2 = label126.Text.PadRight(5);
            graphics.DrawString(top2, font, new SolidBrush(Color.Black), startx + 110, starty + offset);
            offset = offset + 30;
            string top3 = label125.Text.PadRight(5);
            graphics.DrawString(top3, font, new SolidBrush(Color.Black), startx + 25, starty + offset);
            offset = offset + 30;
            string top4 = label110.Text.PadRight(5) + " " + label124.Text.PadRight(5);
            graphics.DrawString(top4, font, new SolidBrush(Color.Black), startx + 10, starty + offset);
            offset = offset + 60;
            string top5 = label119.Text.PadRight(5);
            graphics.DrawString(top5, font, new SolidBrush(Color.Black), startx + 77, starty + offset);
            offset = offset + 30;
            string top6 = label131.Text.PadRight(5) + " " + label118.Text.PadRight(5);
            graphics.DrawString(top6, font, new SolidBrush(Color.Black), startx + 18, starty + offset);
            offset = offset + 30;
            string top7 = label117.Text.PadRight(5);
            graphics.DrawString(top7, font, new SolidBrush(Color.Black), startx + 50, starty + offset);
            offset = offset + 30;
            string top8 = label116.Text.PadRight(5);
            graphics.DrawString(top8, font, new SolidBrush(Color.Black), startx + 28, starty + offset);
            offset = offset + 30;
            string top9 = label112.Text.PadRight(5);
            graphics.DrawString(top9, font, new SolidBrush(Color.Black), startx + 40, starty + offset);
            offset = offset + 30;
            string top10 = label115.Text.PadRight(5);
            graphics.DrawString(top10, font, new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 30;
            string top11 = label114.Text.PadRight(5);
            graphics.DrawString(top11, font, new SolidBrush(Color.Black), startx + 70, starty + offset);
            offset = offset + 30;
            string top12 = label111.Text.PadRight(5);
            graphics.DrawString(top12, font, new SolidBrush(Color.Black), startx - 50, starty + offset);
            offset = offset + 60;
            string top13 = label113.Text.PadRight(5);
            graphics.DrawString(top13, font, new SolidBrush(Color.Black), startx + 65, starty + offset);
            offset = offset + 90;
            string top14 = label123.Text.PadRight(5);
            graphics.DrawString(top14, font, new SolidBrush(Color.Green), startx - 60, starty + offset);
            offset = offset + 30;
            string top15 = label122.Text.PadRight(5);
            graphics.DrawString(top15, font, new SolidBrush(Color.Black), startx - 55, starty + offset);
            offset = offset + 60;
            string top16 = label121.Text.PadRight(5);
            graphics.DrawString(top16, font, new SolidBrush(Color.Black), startx + 50, starty + offset);
            offset = offset + 30;
            string top17 = label120.Text.PadRight(5);
            graphics.DrawString(top17, font, new SolidBrush(Color.Black), startx + 47, starty + offset);

        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            panel29.Hide();
            panel28.Show();
        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            panel37.Show();
            panel34.Hide();
            panel15.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel34.Show();
            panel37.Hide();
            panel15.Hide();
        }

        private void label158_Click(object sender, EventArgs e)
        {
            try
            {
                con.dataGet("Select [Full Name] from UserInfo Where [User Name] = '" + label1.Text + "'");
                DataTable feedback = new DataTable();
                con.sda.Fill(feedback);
                string name = "";
                if (feedback.Rows.Count > 0)
                {
                    foreach (DataRow row in feedback.Rows)
                    {
                        name = row["Full Name"].ToString();
                    }
                }
                string variables = "[Travellers Name],Feedback,Date,Time"; /*Database Column Name*/
                string values = "'" + name + "','" + textBox1.Text + "','" + label159.Text + "','" + label160.Text + "'"; //TextBox

                con.dataSend("INSERT INTO Feedback(" + variables + ")  values ( " + values + " )");
                MessageBox.Show("Feedback Send Successfully");
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
