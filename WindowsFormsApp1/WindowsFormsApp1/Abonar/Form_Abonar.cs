using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Abonar;

namespace WindowsFormsApp1
{
    public partial class Form_Abonar : Form
    {
        string monto, rut;

        public Form_Abonar(string rut, string monto)
        {
            InitializeComponent();
            lblDeuda.Text = monto;
            this.monto = monto;
            this.rut = rut;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            int deuda_nueva;
            if (txtAbono.Text == "")
            {
                lblDeuda.Text = monto;
            } else
            {
                deuda_nueva = Convert.ToInt32(monto) - Convert.ToInt32(txtAbono.Text);
                if(deuda_nueva < 0)
                {
                    MessageBox.Show("El pago supera a la deuda");
                    txtAbono.Text = "";
                    txtAbono.Focus();
                } else
                {
                    lblDeuda.Text = deuda_nueva.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            Controller_Abonar.updateDebt(this.rut, lblDeuda.Text);

            this.Hide();
        }
    }
}
