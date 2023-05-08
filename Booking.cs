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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\singh\OneDrive\Documents\MarraigeOb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void GetCustId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CustId from CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            dt.Load(rdr);
            CustIdCb.ValueMember = "CustId";
            CustIdCb.DataSource = dt;
            Con.Close();
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            GetCustId();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (BeerCheck.Checked == true) 
            {
                BeerPrice.Enabled = true;
                BeerQty.Enabled = true;
            }
            else
            {
                BeerPrice.Enabled = false;
                BeerQty.Enabled = false;
                BeerPrice.Text = "";
                BeerQty.Text = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void SodaCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (SodaCheck.Checked == true)
            {
                SodaPrice.Enabled = true;
                SodaQty.Enabled = true;
            }
            else
            {
                SodaPrice.Enabled = false;
                SodaQty.Enabled = false;
                SodaPrice.Text = "";
                SodaQty.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WineCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WineCheck.Checked == true)
            {
                WinePrice.Enabled = true;
                WineQty.Enabled = true;
            }
            else
            {
                WinePrice.Enabled = false;
                WineQty.Enabled = false;
                WinePrice.Text = "";
                WineQty.Text = "";
            }
        }

        private void Watercheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (Watercheck.Checked == true)
            {
                WaterPrice.Enabled = true;
                WaterQty.Enabled = true;
            }
            else
            {
                WaterPrice.Enabled = false;
                WaterQty.Enabled = false;
                WaterPrice.Text = "";
                WaterQty.Text = "";
            }
        }

        private void JuiceCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (JuiceCheck.Checked == true)
            {
                JuicePrice.Enabled = true;
                JuiceQty.Enabled = true;
            }
            else
            {
                JuicePrice.Enabled = false;
                JuiceQty.Enabled = false;
                JuicePrice.Text = "";
                JuiceQty.Text = "";
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void PannerCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (PannerCheck.Checked == true)
            {
                Pannerprice.Enabled = true;
                PannerQty.Enabled = true;
            }
            else
            {
                Pannerprice.Enabled = false;
                PannerQty.Enabled = false;
                Pannerprice.Text = "";
                PannerQty.Text = "";
            }
        }

        private void ChickenCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (ChickenCheck.Checked == true)
            {
                ChickenPrice.Enabled = true;
                ChickenQty.Enabled = true;
            }
            else
            {
                ChickenPrice.Enabled = false;
                ChickenQty.Enabled = false;
                ChickenPrice.Text = "";
                ChickenQty.Text = "";
            }
        }

        private void FishCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (FishCheck.Checked == true)
            {
                FishPrice.Enabled = true;
                FishQty.Enabled = true;
            }
            else
            {
                FishPrice.Enabled = false;
                FishQty.Enabled = false;
                FishPrice.Text = "";
                FishQty.Text = "";
            }
        }

        private void BiryaniCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (BiryaniCheck.Checked == true)
            {
                BiryaniPrice.Enabled = true;
                BiryaniQty.Enabled = true;
            }
            else
            {
                BiryaniPrice.Enabled = false;
                BiryaniQty.Enabled = false;
                BiryaniPrice.Text = "";
                BiryaniQty.Text = "";
            }
        }

        private void RaitaCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (RaitaCheck.Checked == true)
            {
                RaitaPrice.Enabled = true;
                RaitaQty.Enabled = true;
            }
            else
            {
                RaitaPrice.Enabled = false;
                RaitaQty.Enabled = false;
                RaitaPrice.Text = "";
                RaitaQty.Text = "";
            }
        }
        int bevcost = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            int beer=0, soda=0, wine=0, water = 0, juice = 0;
            if (BeerCheck.Checked == true && BeerPrice.Text == "" && BeerQty.Text == "")
            {
                MessageBox.Show("Enter Beer Quantity");
            }
            else
            {
                beer = Convert.ToInt32(BeerPrice.Text) * Convert.ToInt32(BeerQty.Text);
            }
            if (SodaCheck.Checked == true && SodaPrice.Text == "" && SodaQty.Text == "")
            {
                MessageBox.Show("Enter Soda Quantity");
            }
            else
            {
                soda = Convert.ToInt32(SodaPrice.Text) * Convert.ToInt32(SodaQty.Text);
            }
            if (WineCheck.Checked == true && WinePrice.Text == "" && WineQty.Text == "")
            {
                MessageBox.Show("Enter Wine Quantity");
            }
            else
            {
                wine = Convert.ToInt32(WinePrice.Text) * Convert.ToInt32(WineQty.Text);
            }
            if (Watercheck.Checked == true && WaterPrice.Text == "" && WaterQty.Text == "")
            {
                MessageBox.Show("Enter Water Quantity");
            }
            else
            {
                water = Convert.ToInt32(WaterPrice.Text) * Convert.ToInt32(WaterQty.Text);
            }
            if (JuiceCheck.Checked == true && JuicePrice.Text == "" && JuiceQty.Text == "")
            {
                MessageBox.Show("Enter Beer Quantity");
            }
            else
            {
                juice = Convert.ToInt32(JuicePrice.Text) * Convert.ToInt32(JuiceQty.Text);
            }
            bevcost = beer + soda + wine + water + juice;
            BevCostLbl.Text = "" + bevcost;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int dishcost = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            int panner = 0, chicken = 0, fish = 0, biryani = 0, raita = 0;
            if (PannerCheck.Checked == true && Pannerprice.Text == "" && PannerQty.Text == "")
            {
                MessageBox.Show("Enter Panner Quantity");
            }
            else
            {
                panner = Convert.ToInt32(Pannerprice.Text) * Convert.ToInt32(PannerQty.Text);
            }
            if (ChickenCheck.Checked == true && ChickenPrice.Text == "" && ChickenQty.Text == "")
            {
                MessageBox.Show("Enter Chicken Quantity");
            }
            else
            {
                chicken = Convert.ToInt32(ChickenPrice.Text) * Convert.ToInt32(ChickenQty.Text);
            }
            if (FishCheck.Checked == true && FishPrice.Text == "" && FishQty.Text == "")
            {
                MessageBox.Show("Enter Fish Quantity");
            }
            else
            {
                fish = Convert.ToInt32(FishPrice.Text) * Convert.ToInt32(FishQty.Text);
            }
            if (BiryaniCheck.Checked == true && BiryaniPrice.Text == "" && BiryaniQty.Text == "")
            {
                MessageBox.Show("Enter Biryani Quantity");
            }
            else
            {
                biryani = Convert.ToInt32(BiryaniPrice.Text) * Convert.ToInt32(BiryaniQty.Text);
            }
            if (RaitaCheck.Checked == true && RaitaPrice.Text == "" && RaitaQty.Text == "")
            {
                MessageBox.Show("Enter Raita Quantity");
            }
            else
            {
                raita = Convert.ToInt32(RaitaPrice.Text) * Convert.ToInt32(RaitaQty.Text);
            }
            dishcost = panner + chicken + fish + biryani + raita;
            DishCostLbl.Text = "" + dishcost;
        }
        private void fetchcustName()
        {
            Con.Open();
            string mysql = "select * from CustomerTbl where CustId=" + CustIdCb.SelectedValue.ToString() + " ";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows) 
            {
                CustNameLbl.Text = "" + dr["CustName"].ToString();
            }
            Con.Close();
        }
        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchcustName();
        }
        
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BeerPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void OtherCharges_TextChanged(object sender, EventArgs e)
        {
            if (OtherCharges.Text == "")
            {
                GrdTotal.Text = "";
            }
            else
            {
                GrdTotal.Text = Convert.ToString((bevcost + dishcost) + Convert.ToInt32(OtherCharges.Text));
            }
        }

        private void Advance_TextChanged(object sender, EventArgs e)
        {
            if (GrdTotal.Text == "")
            {
                Advance.Text = "";
            }
            else if (Advance.Text == "")
            {
                Balance.Text = "";
            }
            else
            {
                Balance.Text = Convert.ToString(Convert.ToInt32(GrdTotal.Text) - Convert.ToInt32(Advance.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateDtp.Text == "" || TimeCb.Text == "" || PersonLbl.Text == "" || CustIdCb.Text == "" || OtherCharges.Text == "" || Advance.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookingTbl values('" + DateDtp.Text + "','" + TimeCb.Text + "','" + CustNameLbl.Text + "','" + PersonLbl.Text + "',' Panner Chicken Fish Biryani Raita ',' Beer Soda Wine Water Juice ','" + BevCostLbl.Text + "','" + DishCostLbl.Text + "','" + OtherCharges.Text + "','" + GrdTotal.Text + "','" + Advance.Text + "','" + Balance.Text+ "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully Added");
                    Con.Close();
                    //populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //int bookingkey = 0;
        private void clear()
        {
            TimeCb.Text = "";
            //bookingkey = 0;
            PersonLbl.Text = "";
            CustIdCb.SelectedIndex = -1;
            CustNameLbl.Text = "";
            BevCostLbl.Text = "";
            DishCostLbl.Text = "";
            OtherCharges.Text = "";
            //GrdTotal.Text = "";
            Advance.Text = "";
            Balance.Text = "";
            BeerCheck.Checked = false;
            SodaCheck.Checked = false;
            WineCheck.Checked = false;
            Watercheck.Checked = false;
            JuiceCheck.Checked = false;
            PannerCheck.Checked = false;
            ChickenCheck.Checked = false;
            FishCheck.Checked = false;
            BiryaniCheck.Checked = false;
            RaitaCheck.Checked = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
