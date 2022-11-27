using System;
using DatabaseProject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace TravelManagementProject4
{
    public partial class Form3 : Form
    {
        
        SqlCommand cmdimage;
        SqlDataAdapter adapterimage;
        DataSet dsImage;
        int noofimage = 0;
        MemoryStream mstImage;
        byte[] ImageArray;
        //string imgLoc = "";

        string Category;
        int ImageProjectID;
        string imgLoc = "";
        string Gender;
        DBAccess objnew = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess con = new DBAccess();
        public static string to;
        public static string setvaluetext4;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet25.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.travelManagementProject4DataSet25.UserInfo);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet24.ViewedFeedback' table. You can move, or remove it, as needed.
            this.viewedFeedbackTableAdapter.Fill(this.travelManagementProject4DataSet24.ViewedFeedback);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet23.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.travelManagementProject4DataSet23.Feedback);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet22.GalleryImages2' table. You can move, or remove it, as needed.
            this.galleryImages2TableAdapter.Fill(this.travelManagementProject4DataSet22.GalleryImages2);
            GetCategoryname();
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet19.RejectedInfo' table. You can move, or remove it, as needed.
            this.rejectedInfoTableAdapter.Fill(this.travelManagementProject4DataSet19.RejectedInfo);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet18.ApprovedInfo' table. You can move, or remove it, as needed.
            this.approvedInfoTableAdapter.Fill(this.travelManagementProject4DataSet18.ApprovedInfo);
            // TODO: This line of code loads data into the 'travelManagementProject4DataSet17.BookingInfo' table. You can move, or remove it, as needed.
            this.bookingInfoTableAdapter.Fill(this.travelManagementProject4DataSet17.BookingInfo);
            label22.Text = DateTime.Now.ToLongTimeString();
            label21.Text = DateTime.Now.ToLongDateString();
            label47.Text = DateTime.Now.ToLongTimeString();
            label46.Text = DateTime.Now.ToLongDateString();
            label43.Text = DateTime.Now.ToLongTimeString();
            label42.Text = DateTime.Now.ToLongDateString();
            label53.Text = DateTime.Now.ToLongTimeString();
            label52.Text = DateTime.Now.ToLongDateString();
            label73.Text = DateTime.Now.ToLongTimeString();
            label72.Text = DateTime.Now.ToLongDateString();
            label74.Text = DateTime.Now.ToLongTimeString();
            label79.Text = DateTime.Now.ToLongDateString();
            label93.Text = DateTime.Now.ToLongTimeString();
            label92.Text = DateTime.Now.ToLongDateString();
            label95.Text = DateTime.Now.ToLongTimeString();
            label94.Text = DateTime.Now.ToLongDateString();
            label128.Text = DateTime.Now.ToLongTimeString();
            label127.Text = DateTime.Now.ToLongDateString();
            panel2.Hide();
            panel3.Hide();
            panel6.Hide();
            panel10.Hide();
            panel4.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel15.Hide();
            panel16.Hide();
            panel20.Hide();
            panel19.Hide();
            panel17.Hide();
            panel21.Hide();
            panel22.Hide();
            panel23.Hide();
            panel24.Hide();
            label17.Text = Form2.setvaluetext3;
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel7.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel14.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel15.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel19.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel21.BackColor = Color.FromArgb(100, 0, 0, 0);

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
            pictureBox7.Image = null;
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
            pictureBox8.Image = null;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Logout", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Form2 back = new Form2();
                back.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 register = new Form3();
            register.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Show();
            groupBox1.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            setvaluetext4 = label17.Text;
            Form8 Package = new Form8();
            Package.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel21.Show();
            groupBox1.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Show();
            groupBox1.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 register = new Form4();
            register.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            groupBox1.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from AdminInfo where [User Name] ='" + textboxusername5.Text + "' and Password = '" + textboxpassword5.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                panel3.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            panel2.Hide();
            panel3.Hide();
            groupBox1.Show();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P7K57AH\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE AdminInfo SET Password = '" + textboxconfirmpassword.Text + "' WHERE [User Name]='" + textboxusername5.Text + "' ", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Password Changed Successfully");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel10.Show();

        }

        private void Form3_MouseHover(object sender, EventArgs e)
        {
            panel10.Hide();
        }

        private void label17_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Show();
            panel2.Hide();
            groupBox1.Hide();
            try
            {
                string sql = "SELECT Name,Address, [Phone Number],[Email Address],[User Name],Image FROM AdminInfo WHERE [User Name] = '" + label17.Text + "'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textboxname2.Text = reader[0].ToString();
                    textboxaddress2.Text = reader[1].ToString();
                    textboxphonenumber2.Text = reader[2].ToString();
                    textboxemailaddress2.Text = reader[3].ToString();
                    textboxusername2.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[5]);
                    if (img == null)
                    {
                        pictureBox3.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox3.Image = Image.FromStream(ms);

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
            panel4.Hide();
            groupBox1.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            groupBox1.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel6.Show();
            panel7.Hide();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel8.Show();
            panel9.Show();
            label19.Text = dataGridView1.SelectedRows[0].Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
            label23.Text = dataGridView1.SelectedRows[0].Cells["packageNameDataGridViewTextBoxColumn"].Value.ToString();
            label20.Text = dataGridView1.SelectedRows[0].Cells["packageTypeDataGridViewTextBoxColumn"].Value.ToString();
            label29.Text = dataGridView1.SelectedRows[0].Cells["packageCategoryDataGridViewTextBoxColumn"].Value.ToString();
            label36.Text = dataGridView1.SelectedRows[0].Cells["packageDestinationDataGridViewTextBoxColumn"].Value.ToString();
            label37.Text = dataGridView1.SelectedRows[0].Cells["packagePriceDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string name = "", phone = "", mail = "", packagename = "", packagetype = "", packagecategory = "", packagedestination = "", packageduration = "", person = "", packagedepdate = "", packageprice = "", bookingtime = "", bookingdate = "";
            con.dataGet("Select * from BookingInfo where [Customer Name] = '" + label19.Text + "' and [Package Name] = '" + label38.Text + "'");
            DataTable approve = new DataTable();
            con.sda.Fill(approve);
            if (approve.Rows.Count > 0)
            {
                foreach (DataRow row in approve.Rows)
                {
                    name = row["Customer Name"].ToString();
                    phone = row["Phone Number"].ToString();
                    mail = row["Email Address"].ToString();
                    packagename = row["Package Name"].ToString();
                    packagetype = row["Package Type"].ToString();
                    packagecategory = row["Package Category"].ToString();
                    packagedestination = row["Package Destination"].ToString();
                    packageduration = row["Package Duration"].ToString();
                    person = row["Package Duration"].ToString();
                    packagedepdate = row["Package Departure Date"].ToString();
                    packageprice = row["Package Price"].ToString();
                    bookingtime = row["Booking Time"].ToString();
                    bookingdate = row["Booking Date"].ToString();
                }
            }
            string variables = "[Customer Name],[Phone Number],[Email Address],[Package Name],[Package Type],[Package Category],[Package Destination],[Package Duration],Persons,[Package Departure Date],[Package Price],[Booking Time],[Booking Date],[Approved Time],[Approved Date]"; /*Database Column Name*/
            string values = "'" + name + "','" + phone + "','" + mail + "','" + packagename + "','" + packagetype + "','" + packagecategory + "','" + packagedestination + "','" + packageduration + "','" + person + "','" + packagedepdate + "','" + packageprice + "','" + bookingtime + "','" + bookingdate + "','" + label47.Text + "', '" + label46.Text + "'"; //TextBox
            con.dataSend("INSERT INTO ApprovedInfo(" + variables + ")  values ( " + values + " )");
            con.dataSend("Delete from BookingInfo where [Customer Name] = '" + label19.Text + "' and [Package Name] = '" + label38.Text + "' and [Package Price]= '"+ label37.Text +"'");
            MessageBox.Show("Package Approved Successfully");
            this.bookingInfoTableAdapter.Fill(this.travelManagementProject4DataSet17.BookingInfo);
            
            string from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = (mail).ToString();
            from = "rsatoursandtravels024@gmail.com";
            pass = "13579024680ronygmail3lgnai";
            messageBody = "Hello " + name + ",\n\nCongratulations,\nYour Request For Booking of " + packagetype + " Package " + packagedestination + " has been successfully Approved. So, Enjoy your trip and share with us your experience.\n\nThank you\n\nHappy Travelling\nRSA Tours and Travels";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Booking Confirmation";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Package Approved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string name = "", phone = "", mail = "", packagename = "", packagetype = "", packagecategory = "", packagedestination = "", packageduration = "", person = "", packagedepdate = "", packageprice = "", bookingtime = "", bookingdate = "";
            con.dataGet("Select * from BookingInfo where [Customer Name] = '" + label19.Text + "' and [Package Name] = '" + label38.Text + "'");
            DataTable approve = new DataTable();
            con.sda.Fill(approve);
            if (approve.Rows.Count > 0)
            {
                foreach (DataRow row in approve.Rows)
                {
                    name = row["Customer Name"].ToString();
                    phone = row["Phone Number"].ToString();
                    mail = row["Email Address"].ToString();
                    packagename = row["Package Name"].ToString();
                    packagetype = row["Package Type"].ToString();
                    packagecategory = row["Package Category"].ToString();
                    packagedestination = row["Package Destination"].ToString();
                    packageduration = row["Package Duration"].ToString();
                    person = row["Package Duration"].ToString();
                    packagedepdate = row["Package Departure Date"].ToString();
                    packageprice = row["Package Price"].ToString();
                    bookingtime = row["Booking Time"].ToString();
                    bookingdate = row["Booking Date"].ToString();
                }
            }
            string variables = "[Customer Name],[Phone Number],[Email Address],[Package Name],[Package Type],[Package Category],[Package Destination],[Package Duration],Persons,[Package Departure Date],[Package Price],[Booking Time],[Booking Date],[Rejected Time],[Rejected Date], [Rejection Details]"; /*Database Column Name*/
            string values = "'" + name + "','" + phone + "','" + mail + "','" + packagename + "','" + packagetype + "','" + packagecategory + "','" + packagedestination + "','" + packageduration + "','" + person + "','" + packagedepdate + "','" + packageprice + "','" + bookingtime + "','" + bookingdate + "','" + label53.Text + "', '" + label52.Text + "', '" + textBox1.Text + "'"; //TextBox
            con.dataSend("INSERT INTO RejectedInfo(" + variables + ")  values ( " + values + " )");
            con.dataSend("Delete from BookingInfo where [Customer Name] = '" + label19.Text + "' and [Package Name] = '" + label38.Text + "'");
            this.bookingInfoTableAdapter.Fill(this.travelManagementProject4DataSet17.BookingInfo);

            string from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = (mail).ToString();
            from = "rsatoursandtravels024@gmail.com";
            pass = "13579024680ronygmail3lgnai";
            messageBody = "Hello " + name + ",\n\nCongratulations,\nYour Request For Booking of " + packagetype + " Package " + packagedestination + " has been Rejected for some specific reason.\nRejection details are:\n"+ textBox1.Text +".\nSorry for the Inconvenience and Please stay with us.\n\nThank you\n\nHappy Travelling\nRSA Tours and Travels";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Booking Rejection";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Package Rejected Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            panel7.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from ApprovedInfo where [Package Name] like '" + textBox2.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel7.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from RejectedInfo where [Package Name] like '" + textBox3.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel11.Show();
            panel7.Hide();
            this.approvedInfoTableAdapter.Fill(this.travelManagementProject4DataSet18.ApprovedInfo);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel7.Hide();
            this.rejectedInfoTableAdapter.Fill(this.travelManagementProject4DataSet19.RejectedInfo);

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Category = comboBox1.SelectedValue.ToString();
            }
            pictureBox4.Image = null;
            ImageArray = null;

            dsImage = null;
            noofimage = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                loadImage();
                ShowData();
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Category");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (pictureBox4.Image != null)
                {
                    try
                    {
                        if (noofimage > 0)
                        {
                            noofimage--;
                            ShowData();
                        }
                        else if (noofimage == 0 && noofimage < dsImage.Tables[0].Rows.Count - 1)
                        {
                            MessageBox.Show("This Is The First Image");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Action");
                    }
                }
                else if (pictureBox4.Image == null)
                {
                    MessageBox.Show("There is no image in this Category");
                }
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Category Name");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (pictureBox4.Image != null)
                {
                    try
                    {
                        if (noofimage < dsImage.Tables[0].Rows.Count - 1)
                        {
                            noofimage++;
                            ShowData();
                        }
                        else
                        {
                            MessageBox.Show("This Is The Last Image");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Action");
                    }
                }
                else if (pictureBox4.Image == null)
                {
                    MessageBox.Show("There is no image in this Category");
                }
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Category Name");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
            {
                cmdimage = new SqlCommand("INSERT INTO GalleryImages(ImageName, Images, ImageNO) VALUES (@ImageName, @Images, @imageNo)", conn);
                ConvertImage();

                conn.Open();
                int no = cmdimage.ExecuteNonQuery();
                conn.Close();
                if (no > 0)
                {
                    MessageBox.Show("New Image Added to this Category");
                    loadImage();
                }
                else
                {
                    MessageBox.Show("Adding Image Failed");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        private void GetCategoryname()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT Category from GalleryImages Where Category IS NOT NULL", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Category";
            comboBox1.ValueMember = "Category";
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedText = "Select Category Name";
            if (comboBox1.SelectedIndex != -1)
            {
                Category = comboBox1.SelectedValue.ToString();
            }
        }
        private void loadImage()
        {
            String CaName = comboBox1.Text;
            adapterimage = new SqlDataAdapter("Select ImageId, Images from GalleryImages where [ImageName] = '" + CaName + "'", conn);
            adapterimage.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dsImage = new DataSet();
            adapterimage.Fill(dsImage, "GalleryImages");
        }
        private void ConvertImage()
        {
            if (pictureBox4.Image != null)
            {
                mstImage = new MemoryStream();
                pictureBox4.Image.Save(mstImage, ImageFormat.Jpeg);
                byte[] Byte_Array = new byte[mstImage.Length];
                mstImage.Position = 0;
                mstImage.Read(Byte_Array, 0, Byte_Array.Length);
                cmdimage.Parameters.AddWithValue("@Category", comboBox1.Text);
                cmdimage.Parameters.AddWithValue("@ImageName", comboBox1.Text);
                cmdimage.Parameters.AddWithValue("@Images", Byte_Array);
                cmdimage.Parameters.AddWithValue("@ImageNo", GetMaxValue("GalleryImages", "ImageId"));
            }
        }
        int MaxValue;
        public int GetMaxValue(string TABLENAME, string FeildName)
        {
            SqlDataAdapter adptMax = new SqlDataAdapter("SELECT MAX(" + FeildName + ") as MAXIMUMID from " + TABLENAME + " where Category=  '" + comboBox1.Text + "'", conn);
            DataTable dtmax = new DataTable();
            adptMax.Fill(dtmax);
            if (dtmax.Rows[0]["MAXIMUMID"] != DBNull.Value)
            {
                MaxValue = Convert.ToInt32(dtmax.Rows[0]["MAXIMUMID"]);
            }
            return MaxValue;
        }
        private void ShowData()
        {
            if (dsImage.Tables[0].Rows.Count > 0)
            {
                if (dsImage.Tables[0].Rows[noofimage][0] != System.DBNull.Value)
                {
                    ImageProjectID = (int)dsImage.Tables[0].Rows[noofimage][0];
                    ImageArray = (byte[])dsImage.Tables[0].Rows[noofimage][1];
                    MemoryStream msi = new MemoryStream(ImageArray);
                    pictureBox4.Image = Image.FromStream(msi);
                }

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel13.Hide();
            panel15.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel15.Show();
            groupBox1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel14.Dispose();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel15.Hide();
            groupBox1.Show();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel13.Show();
            panel15.Hide();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel16.Show();
            panel15.Hide();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel16.Hide();
            panel15.Show();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel18.Show();
            pictureBox6.Show();
            label63.Text = dataGridView4.SelectedRows[0].Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
            label62.Text = dataGridView4.SelectedRows[0].Cells["imageNameDataGridViewTextBoxColumn"].Value.ToString();
            label56.Text = dataGridView4.SelectedRows[0].Cells["imageNoDataGridViewTextBoxColumn"].Value.ToString();
            try
            {
                string sql = "SELECT Images FROM GalleryImages2 WHERE ImageNo ='" + label56.Text + "'";
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

        private void button34_Click(object sender, EventArgs e)
        {
            
            if (pictureBox6.Image != null)
            {
                cmdimage = new SqlCommand("INSERT INTO GalleryImages(ImageName, Images, ImageNO) VALUES (@ImageName, @Images, @ImageNo)", conn);
                ConvertImage2();

                conn.Open();
                int no = cmdimage.ExecuteNonQuery();
                conn.Close();
                if (no > 0)
                {
                    MessageBox.Show("New Image Added to this Category");
                    loadImage();
                }
                else
                {
                    MessageBox.Show("Adding Image Failed");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            con.dataSend("Delete from GalleryImages2 where ImageNo = '" + label56.Text + "'");
            this.galleryImages2TableAdapter.Fill(this.travelManagementProject4DataSet22.GalleryImages2);
            pictureBox6.Image = null;
        }
        private void ConvertImage2()
        {
            if (pictureBox6.Image != null)
            {
                mstImage = new MemoryStream();
                pictureBox6.Image.Save(mstImage, ImageFormat.Jpeg);
                byte[] Byte_Array = new byte[mstImage.Length];
                mstImage.Position = 0;
                mstImage.Read(Byte_Array, 0, Byte_Array.Length);
                cmdimage.Parameters.AddWithValue("@Category", label36.Text);
                cmdimage.Parameters.AddWithValue("@ImageName", label62.Text);
                cmdimage.Parameters.AddWithValue("@Images", Byte_Array);
                cmdimage.Parameters.AddWithValue("@ImageNo", GetMaxValue2("GalleryImages", "ImageId"));
            }
        }
        int MaxValue2;
        public int GetMaxValue2(string TABLENAME2, string FeildName2)
        {
            SqlDataAdapter adptMax2 = new SqlDataAdapter("SELECT MAX(" + FeildName2 + ") as MAXIMUMID from " + TABLENAME2 + " where Category=  '" + label36.Text + "'", conn);
            DataTable dtmax2 = new DataTable();
            adptMax2.Fill(dtmax2);
            if (dtmax2.Rows[0]["MAXIMUMID"] != DBNull.Value)
            {
                MaxValue2 = Convert.ToInt32(dtmax2.Rows[0]["MAXIMUMID"]);
            }
            return MaxValue2;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            con.dataSend("Delete from GalleryImages2 where ImageNo = '" + label56.Text + "'");
            this.galleryImages2TableAdapter.Fill(this.travelManagementProject4DataSet22.GalleryImages2);
            MessageBox.Show("Image Add Rejected Successfully");
            label56.Text = null;
            label63.Text = null;
            label62.Text = null;
            pictureBox6.Image = null;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel17.Hide();
            panel19.Show();
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label65.Text = dataGridView5.SelectedRows[0].Cells["travellersNameDataGridViewTextBoxColumn"].Value.ToString();
            textBox4.Text = dataGridView5.SelectedRows[0].Cells["feedbackDataGridViewTextBoxColumn"].Value.ToString();
            label66.Text = dataGridView5.SelectedRows[0].Cells["dateDataGridViewTextBoxColumn"].Value.ToString();
            label70.Text = dataGridView5.SelectedRows[0].Cells["timeDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string variables = "[Travellers Name],Feedback,Date,Time"; /*Database Column Name*/
            string values = "'" + label65.Text + "','" + textBox4.Text + "','" + label66.Text + "','" + label70.Text + "'"; //TextBox
            con.dataSend("INSERT INTO ViewedFeedback(" + variables + ")  values ( " + values + " )");
            con.dataSend("Delete from Feedback where Time = '" + label70.Text + "' and Date = '"+label66.Text+"'");
            this.feedbackTableAdapter.Fill(this.travelManagementProject4DataSet23.Feedback);
            textBox4.Clear();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel19.Hide();
            groupBox1.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel17.Show();
            panel19.Hide();
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            panel19.Show();
            groupBox1.Hide();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel20.Hide();
            panel19.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel20.Show();
            panel19.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel21.Hide();
            groupBox1.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel21.Hide();
            panel22.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel22.Hide();
            panel21.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select * from UserInfo where [Full Name] like '" + textBox5.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView7.DataSource = dt;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel21.Hide();
            panel23.Show();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            panel23.Hide();
            panel21.Show();
        }

        private void button50_Click(object sender, EventArgs e)
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
                        string sql = "UPDATE UserInfo SET [First Name] ='" + textboxfirstname8.Text + "',[Last Name] ='" + textboxlastname8.Text + "',[Full Name] ='" + textboxfirstname8.Text + " " + textboxlastname8.Text + "',[Father's Name] ='" + textboxfathersname8.Text + "',[Mother's Name] ='" + textboxmothersname8.Text + "', Address ='" + textboxaddress8.Text + "',[Phone Number] ='" + textboxphonenumber8.Text + "', [Phone Number 2] ='" + textboxphonenumber28.Text + "', [Email Address] ='" + textboxemailaddress8.Text + "', [Date of Birth] ='" + dateTimePicker2.Text + "', Gender ='" + Gender + "', Nationality = '" + textboxnationality8.Text + "', [User Name] = '" + textboxusername8.Text + "', Images = @img, [Modify Time] ='" + label94.Text + "', [Modify Date] ='" + label95.Text + "' where Password='" + textboxpassword8.Text + "'";
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
            Gender = "Others";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox7.ImageLocation = imgLoc;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textboxfirstname8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [First Name],[Last Name], [Father's Name], [Mother's Name], Address, [Phone Number], [Phone Number 2], [Email Address], Nationality, Images FROM UserInfo WHERE [Full Name] like '" + textBox6.Text + "%'";
                conn.Open();
                cmmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textboxfirstname8.Text = reader[0].ToString();
                    textboxlastname8.Text = reader[1].ToString();
                    textboxfathersname8.Text = reader[2].ToString();
                    textboxmothersname8.Text = reader[3].ToString();
                    textboxaddress8.Text = reader[4].ToString();
                    textboxphonenumber8.Text = reader[5].ToString();
                    textboxphonenumber28.Text = reader[6].ToString();
                    textboxemailaddress8.Text = reader[7].ToString();
                    textboxnationality8.Text = reader[8].ToString();
                    byte[] img4 = (byte[])(reader[9]);
                    if (img4 == null)
                    {
                        pictureBox7.Image = null;
                    }
                    else
                    {
                        MemoryStream ms4 = new MemoryStream(img4);
                        pictureBox7.Image = Image.FromStream(ms4);

                    }
                }
                else
                {
                    MessageBox.Show("This Does Not Exist.");
                    ClearData8();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
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

        private void button51_Click(object sender, EventArgs e)
        {
            panel24.Hide();
            panel21.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            panel21.Hide();
            panel24.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT [First Name], [Last Name], [Father's Name], [Mother's Name], Address, [Phone Number], [Phone Number 2], [Email Address], [Date of Birth], Gender,Nationality,[User Name],Images FROM UserInfo WHERE [Full Name] like '" + textBox7.Text + "%'";
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
                    MessageBox.Show("This Does Not Exist.");
                    ClearData9();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (textboxpassword9.Text == textboxconfirmpassword9.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.dataSend("Delete from UserInfo where Password='" + textboxpassword9.Text + "'");
                    MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData9();
                    panel24.Hide();
                    panel21.Show();
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Matched...!\nPlease Enter Same Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
