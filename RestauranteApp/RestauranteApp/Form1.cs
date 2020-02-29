using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteApp
{
    public partial class Form1 : Form
    {
        ServiceReference1.WebServiceRestauranteSoapClient webService =
            new ServiceReference1.WebServiceRestauranteSoapClient();

        public Form1()
        {
            InitializeComponent();
            dgv.DataSource = webService.getAllRestaurant();
            btnAceptar.Enabled = false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbInsert.Checked)
            {
                string mensaje = webService.postRestaurant(tbNombre.Text, tbDireccion.Text, tbRNC.Text, mtbTelefono.Text,
                    tbPersonaACargo.Text, Convert.ToInt32(tbCantEmpleado.Text), tbTIpoCOmida.Text,
                    Convert.ToDouble(tbVenMensuales.Text));
                MessageBox.Show(mensaje);
                rbInsert.Checked = false;

            }
            else if (rbUpdate.Checked)
            {

                string mensaje = webService.putRestaurant(Convert.ToInt32(tbId.Text),
                    tbNombre.Text, tbDireccion.Text, tbRNC.Text, mtbTelefono.Text,
                   tbPersonaACargo.Text, Convert.ToInt32(tbCantEmpleado.Text), tbTIpoCOmida.Text,
                   Convert.ToDouble(tbVenMensuales.Text));
                MessageBox.Show(mensaje);
                rbUpdate.Checked = false;

            }
            else if (rbDelete.Checked)
            {
                string mensaje = webService.deleteRestaurant(Convert.ToInt32(tbId.Text));
                MessageBox.Show(mensaje);
                rbDelete.Checked = false;
            }
            else
            {
                MessageBox.Show("Seleccione unas de las opciones disponible al inicio");
            }
            btnAceptar.Enabled = false;
            rbInsert.Checked = false;
            rbDelete.Checked = false;
            rbUpdate.Checked = false;
            dgv.DataSource = webService.getAllRestaurant();
            LimpiarCOntroles();
            
           
        }

        private void rbInsert_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControles();
            LimpiarCOntroles();
            btnAceptar.Enabled = true;

            tbId.Enabled = false;
            dtFechaCrea.Enabled = false;
            dtFechaMod.Enabled = false;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControles();
            btnAceptar.Enabled = true;

        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarCOntroles();


            BloquearControles();
            btnAceptar.Enabled = true;

            tbId.Enabled = true;

        }
        void BloquearControles()
        {
            tbId.Enabled = false;
            tbNombre.Enabled = false;
            tbDireccion.Enabled = false;
            tbRNC.Enabled = false;
            mtbTelefono.Enabled = false;
            tbPersonaACargo.Enabled = false;
            tbCantEmpleado.Enabled = false;
            dtFechaCrea.Enabled = false;
            dtFechaMod.Enabled = false;
            tbTIpoCOmida.Enabled = false;
            tbVenMensuales.Enabled = false;
        }
        void ActivarControles()
        {
            tbId.Enabled = true;
            tbNombre.Enabled = true;
            tbDireccion.Enabled = true;
            tbRNC.Enabled = true;
            mtbTelefono.Enabled = true;
            tbPersonaACargo.Enabled = true;
            tbCantEmpleado.Enabled = true;
            dtFechaCrea.Enabled = true;
            dtFechaMod.Enabled = true;
            tbTIpoCOmida.Enabled = true;
            tbVenMensuales.Enabled = true;
        }
        void LimpiarCOntroles()
        {
            tbId.Clear();
            tbNombre.Clear();
            tbDireccion.Clear();
            mtbTelefono.Clear();
            tbPersonaACargo.Clear();
            tbRNC.Clear();
            tbTIpoCOmida.Clear();
            tbVenMensuales.Clear();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[0].Value.ToString();
            tbNombre.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[1].Value.ToString();
            tbDireccion.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[2].Value.ToString();
            tbRNC.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[3].Value.ToString();
            mtbTelefono.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[4].Value.ToString();
            tbPersonaACargo.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[5].Value.ToString();
            tbCantEmpleado.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[6].Value.ToString();
            dtFechaCrea.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[7].Value.ToString();
            dtFechaMod.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[8].Value.ToString();
            tbTIpoCOmida.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[9].Value.ToString();
            tbVenMensuales.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[10].Value.ToString();
            llbRegGuid.Text = dgv.Rows[dgv.CurrentCellAddress.Y].Cells[11].Value.ToString();
        }
    }
}
