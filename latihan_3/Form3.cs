using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tulisPesan.MaxLength = 28;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tulisPesan_TextChanged(object sender, EventArgs e)
        {
            lblHasilCount.Text = tulisPesan.TextLength.ToString();
            if(tulisPesan.Text.Length == 28)
            {
                MessageBox.Show("Aanda sudah menulis hingga maksimal karakter");
            }
        }
    }
}
