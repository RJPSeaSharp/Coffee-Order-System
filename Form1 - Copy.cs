using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_3._3
{
    public partial class Form1 : Form
    {
        List<Coffee> Coffee =new List<Coffee>();   
        DateTime currentDateTime = DateTime.Now;

        
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           OrderGrid.DataSource = Coffee;
         // OrderGrid.DataSource = Beverages;
            cmboRoast.DataSource = Enum.GetValues(typeof(Roast));
            cmbCupSize.DataSource = Enum.GetValues(typeof(CupSize));
            cmbTemp.DataSource = Enum.GetValues(typeof(Temperature));
            cmboSugar.DataSource = Enum.GetValues(typeof(Sugar));
            CmboCreamer.DataSource = Enum.GetValues(typeof(Creamer));
            Play();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            GrpBoxOrder.Visible = true;
        }
        private void RefreshData()
        {
            txtName.Clear();
            cmbCupSize.SelectedIndex = 0;
            cmbTemp.SelectedIndex = 0;
            cmboRoast.SelectedIndex = 0;
            CmboCreamer.SelectedIndex = 0;
            cmboSugar.SelectedIndex = 0;
            OrderGrid.DataSource = null;
         
            OrderGrid.DataSource = Coffee;
            Play();

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Coffee.RemoveAt(OrderGrid.CurrentRow.Index);
             // Beverages.RemoveAt(OrderGrid.CurrentRow.Index);
            Play();
            RefreshData();                                   
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty)
            {
                Coffee newcoffee= new Coffee();
         
                newcoffee.CustomerName = txtName.Text;
                newcoffee.Roast=(Roast)(cmboRoast.SelectedIndex +1);
                newcoffee.CupSize= (CupSize)(cmbCupSize.SelectedIndex +1);
                newcoffee.Temperature= (Temperature)(cmbTemp.SelectedIndex +1);
                newcoffee.Sugar=(Sugar)(cmboSugar.SelectedIndex +1);
                newcoffee.Creamer=(Creamer)(CmboCreamer.SelectedIndex +1);
                newcoffee.Time = txtTime.Text + currentDateTime;
                Coffee.Add(newcoffee);
                Play();
                MessageBox.Show("Record added!");
                RefreshData();

            }
        }

        private void lblStudentMgmtSys_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Play()
        {


            SystemSounds.Beep.Play();

            
        }

        private void lblRoast_Click(object sender, EventArgs e)
        {

        }

        private void cmboRoast_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
