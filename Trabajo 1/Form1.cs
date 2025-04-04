using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_1
{
    public partial class Form1 : Form
    {
        private List<Proveedor> proveedores;
        public Form1()
        {
            InitializeComponent();
            proveedores = new List<Proveedor>();

            dgv_lista.AutoGenerateColumns = true;
        }

        private void btn_guardar_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_id_pro.Text) ||
                string.IsNullOrWhiteSpace(txtbx_nombre_empresa.Text) ||
                string.IsNullOrWhiteSpace(txtbx_nombre_contacto.Text) ||
                string.IsNullOrWhiteSpace(txtbx_correo.Text) ||
                string.IsNullOrWhiteSpace(txtbx_telefono.Text) ||
                string.IsNullOrWhiteSpace(txtbx_producto.Text) ||
                string.IsNullOrWhiteSpace(txtbx_peso.Text) ||
                string.IsNullOrWhiteSpace(txtbx_precio.Text) ||
                string.IsNullOrWhiteSpace(txtbx_presupuesto.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Proveedor nuevoProveedor = new Proveedor(int.Parse(txtbx_id_pro.Text), txtbx_nombre_empresa.Text, txtbx_nombre_contacto.Text, txtbx_correo.Text, int.Parse(txtbx_telefono.Text),
                                                           txtbx_producto.Text, int.Parse(txtbx_peso.Text), int.Parse(txtbx_precio.Text), int.Parse(txtbx_presupuesto.Text));
                proveedores.Add(nuevoProveedor);

                dgv_lista.DataSource = null;
                dgv_lista.DataSource = proveedores;

                txtbx_id_pro.Clear();
                txtbx_nombre_empresa.Clear();
                txtbx_nombre_contacto.Clear();
                txtbx_correo.Clear();
                txtbx_telefono.Clear();
                txtbx_producto.Clear();
                txtbx_peso.Clear();
                txtbx_precio.Clear();
                txtbx_presupuesto.Clear();
                txtbx_prec_total_men.Clear();
            }
        }

        public class Proveedor
        {
            private int id;
            private string nombreEmpresa;
            private string nombreContacto;
            private string correo;
            private int telefono;
            private string producto;
            private int peso;
            private int precio;
            private int presupuesto;

            public Proveedor(int id, string nombreEmpresa, string nombreContacto, string correo, int telefono, string producto, int peso, int precio, int presupuesto)
            {
                this.id = id;
                this.nombreEmpresa = nombreEmpresa;
                this.nombreContacto = nombreContacto;
                this.correo = correo;
                this.telefono = telefono;
                this.producto = producto;
                this.peso = peso;
                this.precio = precio;
                this.presupuesto = presupuesto;

            }

        }
    }
}
