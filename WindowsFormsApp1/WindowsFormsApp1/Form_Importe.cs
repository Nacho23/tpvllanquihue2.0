using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Importe : Form
    {
        string totalVenta;

        public Form_Importe(string totalVenta)
        {
            InitializeComponent();
            this.totalVenta = totalVenta;
        }

        private void Form_Importe_Load(object sender, EventArgs e)
        {
            lbTotalVenta.Text = totalVenta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            totalVenta = "0";
            MessageBox.Show("Venta Realizada con éxito");
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int vuelto = Convert.ToInt32(txtImporte.Text) - Convert.ToInt32(totalVenta);
                lbVuelto.Text = vuelto.ToString();
            } catch
            {
                int vuelto = 0;
                lbVuelto.Text = vuelto.ToString();
            }

        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Hide();
                MessageBox.Show("Venta Realizada con éxito");
            }
        }
    }
}
