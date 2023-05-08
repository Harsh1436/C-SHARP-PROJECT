using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarraigeHallMan
{
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\singh\OneDrive\Documents\MarraigeOb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookingDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int bookkey = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookdate = BookingDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (bookdate == "")
            {
                bookkey = 0;
            }
            else
            {
                bookkey = Convert.ToInt32(BookingDGV.SelectedRows[0].Cells[0].Value.ToString());
                if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookkey == 0)
            {
                MessageBox.Show("Select The Booking To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from BookingTbl where BId=" + bookkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Deleted Successfully");
                    Con.Close();
                    populate();
                    //clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Bookid = BookingDGV.SelectedRows[0].Cells[0].Value.ToString();
            string Bookdate = BookingDGV.SelectedRows[0].Cells[1].Value.ToString();
            string Booktime = BookingDGV.SelectedRows[0].Cells[2].Value.ToString();
            string Name = BookingDGV.SelectedRows[0].Cells[3].Value.ToString();
            string Pers = BookingDGV.SelectedRows[0].Cells[4].Value.ToString();
            string Dishes = BookingDGV.SelectedRows[0].Cells[5].Value.ToString();
            string Bev = BookingDGV.SelectedRows[0].Cells[6].Value.ToString();
            string Drinkcost = BookingDGV.SelectedRows[0].Cells[7].Value.ToString();
            string Dishcost = BookingDGV.SelectedRows[0].Cells[8].Value.ToString();
            string OtherChrg = BookingDGV.SelectedRows[0].Cells[9].Value.ToString();
            string Tot = BookingDGV.SelectedRows[0].Cells[10].Value.ToString();
            string Adv = BookingDGV.SelectedRows[0].Cells[11].Value.ToString();
            string Bal = BookingDGV.SelectedRows[0].Cells[12].Value.ToString();
            e.Graphics.DrawString("Booking Summary:- ", new Font("Century Gothic", 25, FontStyle.Regular), Brushes.Red, new Point(230,70));
            e.Graphics.DrawString("Booking Id:- " + Bookid, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,150));
            e.Graphics.DrawString("Booking Date:- " + Bookdate, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,190));
            e.Graphics.DrawString("Booking Time:- " + Booktime, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,230));
            e.Graphics.DrawString("Customer Name:- " + Name, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,270));
            e.Graphics.DrawString("No Persons:- " + Pers, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,310));
            e.Graphics.DrawString("Dishes:- " + Dishes, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,350));
            e.Graphics.DrawString("Beverage:- " + Bev, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.BlueViolet, new Point(100,390));
            e.Graphics.DrawString("Drinks Cost:- " + Drinkcost, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100,430));
            e.Graphics.DrawString("Dishes Cost:- " + Dishcost, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100,470));
            e.Graphics.DrawString("Other Charges:- " + OtherChrg, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100,510));
            e.Graphics.DrawString("Grd Total:- " + Tot, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100,550));
            e.Graphics.DrawString("Advance:- " + Adv, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100,590));
            e.Graphics.DrawString("Balance:- " + Bal, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(100,630));
        }
    }
}
