using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MarraigeHallMan
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\singh\OneDrive\Documents\MarraigeOb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int staffkey = 0;
        private void clear()
        {
            StaffNameTb.Text = "";
            StaffPhoneTb.Text = "";
            staffkey = 0;
            StaffPassTb.Text = "";
            StaffGenderCb.SelectedIndex = -1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffGenderCb.SelectedIndex == -1 || StaffPassTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into StaffTbl values('" + StaffNameTb.Text + "','" + StaffPhoneTb.Text + "','" + StaffGenderCb.SelectedItem.ToString() + "','" + StaffPassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (staffkey == 0)
            {
                MessageBox.Show("Select The Staff To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from StaffTbl where StaffId=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffNameTb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            StaffPhoneTb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            StaffGenderCb.SelectedItem = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            StaffPassTb.Text = StaffDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (StaffNameTb.Text == "")
            {
                staffkey = 0;
            }
            else
            {
                staffkey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffGenderCb.SelectedIndex == -1 || StaffPassTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update StaffTbl set StaffName='" + StaffNameTb.Text + "',StaffPhone='" + StaffPhoneTb.Text + "',StaffGender='" + StaffGenderCb.Text + "',StaffPassword='" + StaffPassTb.Text + "' where StaffId=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
