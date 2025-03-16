using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace average_marksCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, s5, sum, avg;
            s1 = Convert.ToInt32(tb_physics.Text);
            s2 = Convert.ToInt32(tb_maths.Text);
            s3 = Convert.ToInt32(tb_history.Text);
            s4 = Convert.ToInt32(tb_sociology.Text);
            s5 = Convert.ToInt32(tb_chemistry.Text);
            sum = s1 + s2 + s3 + s4 + s5;
            avg = sum / 5;
            tb_average.Text = avg.ToString();
        }
    }
}
