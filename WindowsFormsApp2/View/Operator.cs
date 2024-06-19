using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.View
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
            textBox1.Text = number.ToString();
            textBox2.Text = chuoi;
        }
        private int number = 12;
        private string chuoi = "200dhd";

        private void changeDataType_Click(object sender, EventArgs e)
        {
            int result = 0, convert = 0;
            if (int.TryParse(chuoi, out convert))
            {
                convert = int.Parse(chuoi);
                result = number + convert;

                MessageBox.Show("Sum is: "+ (result) );
            }
            else
            {
                MessageBox.Show("Cannot convert to plus");
            }
        }

    }
}
