using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagementProject4
{
    public partial class Form10 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P7K57AH\\SQLEXPRESS;Initial Catalog=TravelManagementProject4;Integrated Security=True");
        SqlCommand cmdimage;
        SqlDataAdapter adapterimage;
        DataSet dsImage;
        int noofimage = 0;
        MemoryStream mstImage;
        byte[] ImageArray;
        //string imgLoc = "";

        string Category;
        int ImageProjectID;

        public Form10()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 user = new Form5();
            user.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 user = new Form5();
            user.Show();
            this.Hide();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Category = comboBox1.SelectedValue.ToString();
            }
            pictureBox2.Image = null;
            ImageArray = null;

            dsImage = null;
            noofimage = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (pictureBox2.Image != null)
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
                else if (pictureBox2.Image == null)
                {
                    MessageBox.Show("There is no image in this Category");
                }
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Category Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (pictureBox2.Image != null)
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
                else if (pictureBox2.Image == null)
                {
                    MessageBox.Show("There is no image in this Category");
                }
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Category Name");
            }
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void Form10_Load(object sender, EventArgs e)
        {
            GetCategoryname();
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
            if (pictureBox2.Image != null)
            {
                mstImage = new MemoryStream();
                pictureBox2.Image.Save(mstImage, ImageFormat.Jpeg);
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
                    pictureBox2.Image = Image.FromStream(msi);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((pictureBox2.Image != null) && ((comboBox1.Text == "Domestic") || (comboBox1.Text == "Regional") || (comboBox1.Text == "International")))
            {
                cmdimage = new SqlCommand("INSERT INTO GalleryImages2(Category, ImageName, Images, ImageNO) VALUES (@Category, @ImageName, @Images, @imageNo)", conn);
                ConvertImage();

                conn.Open();
                int no = cmdimage.ExecuteNonQuery();
                conn.Close();
                if (no > 0)
                {
                    MessageBox.Show("New Image Added to this Category");
                    loadImage();
                    pictureBox2.Image = null;
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

    }
}
