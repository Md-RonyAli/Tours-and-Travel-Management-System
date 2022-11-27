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

namespace TravelManagementProject4
{
    public partial class Form8 : Form
    {
        DBAccess objnew = new DBAccess();
        DBAccess con = new DBAccess();
        DataTable dtUsers = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmmd;
        public static string to;
        string imgLoc1 = "";
        string imgLoc2 = "";
        string imgLoc3 = "";
        string imgLoc4 = "";
        string imgLoc5 = "";
        string imgLoc6 = "";
        string Category;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet14.Silver' table. You can move, or remove it, as needed.
            this.silverTableAdapter.Fill(this.travelManagementProject4DataSet14.Silver);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet13.Gold' table. You can move, or remove it, as needed.
            this.goldTableAdapter.Fill(this.travelManagementProject4DataSet13.Gold);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet12.Platinum' table. You can move, or remove it, as needed.
            this.platinumTableAdapter.Fill(this.travelManagementProject4DataSet12.Platinum);
            label22.Text = DateTime.Now.ToLongTimeString();
            label21.Text = DateTime.Now.ToLongDateString();
            label47.Text = DateTime.Now.ToLongTimeString();
            label46.Text = DateTime.Now.ToLongDateString();
            label70.Text = DateTime.Now.ToLongTimeString();
            label69.Text = DateTime.Now.ToLongDateString();
            label90.Text = DateTime.Now.ToLongTimeString();
            label89.Text = DateTime.Now.ToLongDateString();
            label95.Text = DateTime.Now.ToLongTimeString();
            label94.Text = DateTime.Now.ToLongDateString();
            label119.Text = DateTime.Now.ToLongTimeString();
            label118.Text = DateTime.Now.ToLongDateString();
            panel3.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel7.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel11.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel12.BackColor = Color.FromArgb(100, 0, 0, 0);
            label17.Text = Form3.setvaluetext4;
        }
        private void ClearData()
        {
            textboxpackagetype.Clear();
        }
        private void ClearData4()
        {
            textboxpackagecategory4.Clear();
            textboxpackagename4.Clear();
            textboxpackagetype4.Clear();
            textboxfromplace4.Clear();
            textboxtoplace4.Clear();
            textboxday4.Clear();
            textboxnight4.Clear();
            textboxprice4.Clear();
            textboxbybus4.Clear();
            textboxbytrain4.Clear();
            textboxbyflight4.Clear();
            textboxchild4.Clear();
            textboxspecial4.Clear();
            textboxpackagedetails4.Clear();
            pictureBox11.Image = null;
            pictureBox10.Image = null;
            pictureBox9.Image = null;
        }
        private void ClearData2()
        {
            textboxpackagename2.Clear();
            textboxpackagetype2.Clear();
            textboxpackagefrom2.Clear();
            textboxpackageto2.Clear();
            textboxday2.Clear();
            textboxnight2.Clear();
            textboxpackageprice2.Clear();
            textboxpricebybus2.Clear();
            textboxpricebytrain2.Clear();
            textboxpricebyflight2.Clear();
            textboxchild2.Clear();
            textboxspecial2.Clear();
            textboxpackagedetails2.Clear();
            pictureBox8.Image = null;
            pictureBox7.Image = null;
            pictureBox6.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 back = new Form3();
            back.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 back = new Form3();
            back.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void Form8_MouseHover(object sender, EventArgs e)
        {
            panel10.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel2.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel6.Show();
            panel2.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel11.Show();
            panel2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel2.Hide();
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

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string variables = "[Package Name],[Package Category],[Package From],[Package To]"; /*Database Column Name*/
            string values = "'" + textboxpackagename.Text + "','" + Category + "','" + textboxfromplace.Text + "','" + textboxtoplace.Text + "'"; //TextBox

            con.dataSend("INSERT INTO Search(" + variables + ")  values ( " + values + " )");

            try
            {
                byte[] img1 = null;
                byte[] img2 = null;
                byte[] img3 = null;
                FileStream fs1 = new FileStream(imgLoc1, FileMode.Open, FileAccess.Read);
                FileStream fs2 = new FileStream(imgLoc2, FileMode.Open, FileAccess.Read);
                FileStream fs3 = new FileStream(imgLoc3, FileMode.Open, FileAccess.Read);
                BinaryReader br1 = new BinaryReader(fs1);
                BinaryReader br2 = new BinaryReader(fs2);
                BinaryReader br3 = new BinaryReader(fs3);
                img1 = br1.ReadBytes((int)fs1.Length);
                img2 = br2.ReadBytes((int)fs2.Length);
                img3 = br3.ReadBytes((int)fs3.Length);
                string sql = "INSERT INTO " + textboxpackagetype.Text + "([Package Category],[Package Name],[Package Type],[Package From],[Package To],[Package Duration Days],[Package Duration Nights],[Package Price],[Price By Bus],[Price By Train],[Price By Flight],[Child Discount],[Special Discount],[Image 1],[Image 2],[Image 3],[Package Details],[Package Creation Time], [Package Creation Date])Values('" + Category + "','" + textboxpackagename.Text + "','" + textboxpackagetype.Text + "','" + textboxfromplace.Text + "','" + textboxtoplace.Text + "','" + textboxday.Text + "','" + textboxnight.Text + "','" + textboxpackageprice.Text + "','" + textboxbusprice.Text + "','" + textboxtrainprice.Text + "','" + textboxflightprice.Text + "','" + textboxchild.Text + "','" + textboxspecial.Text + "',@img1,@img2,@img3,'" + textboxpackagedetails.Text + "','" + label22.Text + "','" + label21.Text + "')";             
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                cmmd.Parameters.Add(new SqlParameter("@img1", img1));
                cmmd.Parameters.Add(new SqlParameter("@img2", img2));
                cmmd.Parameters.Add(new SqlParameter("@img3", img3));
                int x = cmmd.ExecuteNonQuery();
                conn.Close();
                //con.dataSend("INSERT INTO UserInfo(" + variables + ")  values ( " + values + " )");
                MessageBox.Show("Record Saved Successfully");
                ClearData();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc1 = dlg.FileName.ToString();
                    pictureBox3.ImageLocation = imgLoc1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc2 = dlg.FileName.ToString();
                    pictureBox4.ImageLocation = imgLoc2;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc3 = dlg.FileName.ToString();
                    pictureBox5.ImageLocation = imgLoc3;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Domestic";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Regional";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Category = "International";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel7.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from Platinum where [Package To] like '" + textBox2.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            viewwindow.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textboxtoplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Domestic";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Regional";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Category = "International";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img4 = null;
                byte[] img5 = null;
                byte[] img6 = null;
                FileStream fs4 = new FileStream(imgLoc4, FileMode.Open, FileAccess.Read);
                FileStream fs5 = new FileStream(imgLoc5, FileMode.Open, FileAccess.Read);
                FileStream fs6 = new FileStream(imgLoc6, FileMode.Open, FileAccess.Read);
                BinaryReader br4 = new BinaryReader(fs4);
                BinaryReader br5 = new BinaryReader(fs5);
                BinaryReader br6 = new BinaryReader(fs6);
                img4 = br4.ReadBytes((int)fs4.Length);
                img5 = br5.ReadBytes((int)fs5.Length);
                img6 = br6.ReadBytes((int)fs6.Length);
                string sql = "UPDATE " + textboxpackagetype2.Text + " SET [Package Category] ='" + Category + "',[Package Name] ='" + textboxpackagename2.Text + "',[Package Type] ='" + textboxpackagetype2.Text + "',[Package From] ='" + textboxpackagefrom2.Text + "',[Package To] ='" + textboxpackageto2.Text + "',[Package Duration Days] ='" + textboxday2.Text + "',[Package Duration Nights] ='" + textboxnight2.Text + "',[Package Price] ='" + textboxpackageprice2.Text + "', [Price By Bus] ='" + textboxpricebybus2.Text + "', [Price By Train] ='" + textboxpricebytrain2.Text + "', [Price By Flight] ='" + textboxpricebyflight2.Text + "', [Child Discount] ='" + textboxchild2.Text + "', [Special Discount] = '" + textboxspecial2.Text + "',[Package Details] ='" + textboxpackagedetails2.Text + "', [Image 1] = @img4,[Image 2] = @img5,[Image 3] = @img6, [Package Modification Time] ='" + label70.Text + "', [Package Modification Date] ='" + label69.Text + "' where [Package Name]='" + textboxpackagename2.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                cmmd.Parameters.Add(new SqlParameter("@img4", img4));
                cmmd.Parameters.Add(new SqlParameter("@img5", img5));
                cmmd.Parameters.Add(new SqlParameter("@img6", img6));
                int x = cmmd.ExecuteNonQuery();
                conn.Close();
                //con.dataSend("INSERT INTO UserInfo(" + variables + ")  values ( " + values + " )");
                MessageBox.Show("Record Updated Successfully");
                ClearData2();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void textboxpackagename2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Package From], [Package To], [Package Duration Days], [Package Duration Nights], [Package Price], [Price By Bus],[Price By Train],[Price By Flight], [Child Discount],[Special Discount],[Package Details],[Image 1],[Image 2],[Image 3] FROM "+ textboxpackagetype2.Text +" WHERE [Package Name] like '" + textboxpackagename2.Text + "%'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textboxpackagefrom2.Text = reader[0].ToString();
                    textboxpackageto2.Text = reader[1].ToString();
                    textboxday2.Text = reader[2].ToString();
                    textboxnight2.Text = reader[3].ToString();
                    textboxpackageprice2.Text = reader[4].ToString();
                    textboxpricebybus2.Text = reader[5].ToString();
                    textboxpricebytrain2.Text = reader[6].ToString();
                    textboxpricebyflight2.Text = reader[7].ToString();
                    textboxchild2.Text = reader[8].ToString();
                    textboxspecial2.Text = reader[9].ToString();
                    textboxpackagedetails2.Text = reader[10].ToString();
                    byte[] img4 = (byte[])(reader[11]);
                    if (img4 == null)
                    {
                        pictureBox8.Image = null;
                    }
                    else
                    {
                        MemoryStream ms4 = new MemoryStream(img4);
                        pictureBox8.Image = Image.FromStream(ms4);

                    }
                    byte[] img5 = (byte[])(reader[12]);
                    if (img5 == null)
                    {
                        pictureBox7.Image = null;
                    }
                    else
                    {
                        MemoryStream ms5 = new MemoryStream(img5);
                        pictureBox7.Image = Image.FromStream(ms5);

                    }
                    byte[] img6 = (byte[])(reader[13]);
                    if (img6 == null)
                    {
                        pictureBox6.Image = null;
                    }
                    else
                    {
                        MemoryStream ms6 = new MemoryStream(img6);
                        pictureBox6.Image = Image.FromStream(ms6);

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

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc4 = dlg.FileName.ToString();
                    pictureBox8.ImageLocation = imgLoc4;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc5 = dlg.FileName.ToString();
                    pictureBox7.ImageLocation = imgLoc5;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc6 = dlg.FileName.ToString();
                    pictureBox6.ImageLocation = imgLoc6;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.platinumTableAdapter.Fill(this.travelManagementProject4DataSet12.Platinum);
            panel5.Show();
            panel7.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel2.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel7.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from Gold where [Package To] like '" + textBox1.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            viewwindow.DataSource = dt;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.goldTableAdapter.Fill(this.travelManagementProject4DataSet13.Gold);
            panel7.Hide();
            panel8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.silverTableAdapter.Fill(this.travelManagementProject4DataSet14.Silver);
            panel9.Show();
            panel7.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel9.Hide();
            panel7.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from Silver where [Package To] like '" + textBox3.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            viewwindow.DataSource = dt;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            panel2.Show();
        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [Package Category],[Package From], [Package To], [Package Duration Days], [Package Duration Nights], [Package Price], [Price By Bus],[Price By Train],[Price By Flight], [Child Discount],[Special Discount],[Package Details],[Image 1],[Image 2],[Image 3] FROM " + textboxpackagetype4.Text + " WHERE [Package Name] like '" + textboxpackagename4.Text + "%'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textboxpackagecategory4.Text = reader[0].ToString();
                    textboxfromplace4.Text = reader[1].ToString();
                    textboxtoplace4.Text = reader[2].ToString();
                    textboxday4.Text = reader[3].ToString();
                    textboxnight4.Text = reader[4].ToString();
                    textboxprice4.Text = reader[5].ToString();
                    textboxbybus4.Text = reader[6].ToString();
                    textboxbytrain4.Text = reader[7].ToString();
                    textboxbyflight4.Text = reader[8].ToString();
                    textboxchild4.Text = reader[9].ToString();
                    textboxspecial4.Text = reader[10].ToString();
                    textboxpackagedetails4.Text = reader[11].ToString();
                    byte[] img4 = (byte[])(reader[12]);
                    if (img4 == null)
                    {
                        pictureBox11.Image = null;
                    }
                    else
                    {
                        MemoryStream ms4 = new MemoryStream(img4);
                        pictureBox11.Image = Image.FromStream(ms4);

                    }
                    byte[] img5 = (byte[])(reader[13]);
                    if (img5 == null)
                    {
                        pictureBox10.Image = null;
                    }
                    else
                    {
                        MemoryStream ms5 = new MemoryStream(img5);
                        pictureBox10.Image = Image.FromStream(ms5);

                    }
                    byte[] img6 = (byte[])(reader[14]);
                    if (img6 == null)
                    {
                        pictureBox9.Image = null;
                    }
                    else
                    {
                        MemoryStream ms6 = new MemoryStream(img6);
                        pictureBox9.Image = Image.FromStream(ms6);

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

        private void button21_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from "+ textboxpackagetype4.Text +" where [Package Name]='" + textboxpackagename4.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData4();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel12.Dispose();
        }
    }
}
