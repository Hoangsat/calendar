using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            show_month_picture();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            show_month_picture();
        }
        private void show_month_picture()
        {
            string month;
            month = monthCalendar.SelectionStart.Month.ToString();
            try
            {
                pictureBox.Image = Image.FromFile("12\\" + month + ".jpg");
            }
            catch
            {
                MessageBox.Show("Image not found");
                
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        { 
            monthCalendar.Visible = !monthCalendar.Visible; 
        }
    }
}
