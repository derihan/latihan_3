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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            int cb = cbItem.SelectedIndex;
            switch (cb)
            {
                case 0:
                    txtHarga.Text = "2000";
                    break;
                case 1:
                    txtHarga.Text = "2400";
                    break;
                case 2:
                    txtHarga.Text = "4000";
                    break;
                case 3:
                    txtHarga.Text = "3200";
                    break;
                case 4:
                    txtHarga.Text = "5000";
                    break;
                default:
                    txtHarga.Text = "";
                    break;
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (txtHarga.Text != "") {
                string cb = cbItem.SelectedItem.ToString() + " Rp." + txtHarga.Text;
                listBoxShop.Items.Add(cb);
            }
            else
            {
                MessageBox.Show("Pilih barang terlebih dulu");
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxShop.Items.Clear();
        }
    }
}
