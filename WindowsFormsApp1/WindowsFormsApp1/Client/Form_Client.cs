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
using WindowsFormsApp1.Client;

namespace WindowsFormsApp1
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            fillGrid();
        }

        private void fillGrid()
        {
            dgvClients.DataSource = Controller_Client.getClientTable(txtSearchClient.Text);
            dgvClients.Columns[3].Visible = false;
            dgvClients.Columns[4].Visible = false;
            dgvClients.Columns[5].Visible = false;
            dgvClients.Columns[6].Visible = false;
            dgvClients.Columns[7].Visible = false;
            dgvClients.Columns[8].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                fillGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_AddClient form_AddClient = new Form_AddClient();
            form_AddClient.ShowDialog();
            fillGrid();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form_Abonar form_Abonar = new Form_Abonar(txtRut.Text, txtDeuda.Text);
            form_Abonar.ShowDialog();
            fillGrid();
        }

        private void dgvClients_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow.Index != -1)
            {
                txtRut.Text = dgvClients.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
                txtDeuda.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
                txtBirthDate.Text = dgvClients.CurrentRow.Cells[3].Value.ToString();
                txtSex.Text = dgvClients.CurrentRow.Cells[4].Value.ToString();
                txtPhone.Text = dgvClients.CurrentRow.Cells[5].Value.ToString();
                txtAddress.Text = dgvClients.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dgvClients.CurrentRow.Cells[7].Value.ToString();
                txtObs.Text = dgvClients.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form_AddClient form_AddClient = new Form_AddClient(txtRut.Text);
            form_AddClient.ShowDialog();
            fillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
