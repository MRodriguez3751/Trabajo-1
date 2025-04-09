using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
                string.IsNullOrWhiteSpace(txtbx_producto.Text) ||
                string.IsNullOrWhiteSpace(txtbx_peso.Text) ||
                string.IsNullOrWhiteSpace(txtbx_precio.Text) ||
                string.IsNullOrWhiteSpace(txtbx_presupuesto.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbx_id_pro.Text.Length < 4)
            {
                MessageBox.Show("El ID del proveedor debe contener al menos 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //verifica si existe ID duplicado
                bool idExistente = proveedores.Any(m => m.Id.ToString().Equals(txtbx_id_pro.Text, StringComparison.OrdinalIgnoreCase));


                if (idExistente)
                {
                    // si existe ID duplicado, se muestra mensaje
                    MessageBox.Show("ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Proveedor nuevoProveedor = new Proveedor(int.Parse(txtbx_id_pro.Text), txtbx_nombre_empresa.Text, txtbx_nombre_contacto.Text, txtbx_correo.Text, txtbx_telefono.Text,
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
        }
        private void txtbx_id_pro_KeyPress(object sender, KeyPressEventArgs e) // solo numeros y 4 digitos
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtbx_id_pro.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbx_telefono.Clear();
                txtbx_telefono.Enabled = true;
            }
            else
            {
                txtbx_telefono.Text = "No Aplica";
                txtbx_telefono.Enabled = false;
            }
        }

        public class Proveedor
        {
            private int id;
            private string nombreEmpresa;
            private string nombreContacto;
            private string correo;
            private string telefono;
            private string producto;
            private int peso;
            private int precio;
            private int presupuesto;

            public Proveedor(int id, string nombreEmpresa, string nombreContacto, string correo, string telefono, string producto, int peso, int precio, int presupuesto)
            {
                Id = id;
                NombreEmpresa = nombreEmpresa;
                NombreContacto = nombreContacto;
                Correo = correo;
                Telefono = telefono;
                Producto = producto;
                Peso = peso;
                Precio = precio;
                Presupuesto = presupuesto;
            }

            public int Id { get => id; set => id = value; }
            public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
            public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
            public string Correo { get => correo; set => correo = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Producto { get => producto; set => producto = value; }
            public int Peso { get => peso; set => peso = value; }
            public int Precio { get => precio; set => precio = value; }
            public int Presupuesto { get => presupuesto; set => presupuesto = value; }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            bool proveedorExistente = proveedores.Any(p => p.Id.Equals(int.Parse(txtbx_buscar.Text)));
            if (proveedorExistente)
            {
                txtbx_buscar_id.Enabled = true;
                txtbx_buscar_nombre.Enabled = true;
                txtbx_buscar_contacto.Enabled = true;
                txtbx_buscar_nombre.Enabled = true;
                txtbx_buscar_correo.Enabled = true;
                txtbx_buscar_telefono.Enabled = true;
                txtbx_buscar_producto.Enabled = true;
                txtbx_buscar_peso.Enabled = true;
                txtbx_buscar_precio.Enabled = true;

                Proveedor pe = proveedores.FirstOrDefault(p => p.Id.Equals(int.Parse(txtbx_buscar.Text)));
                txtbx_buscar_id.Text = pe.Id.ToString();
                txtbx_buscar_nombre.Text = pe.NombreEmpresa;
                txtbx_buscar_contacto.Text = pe.NombreContacto;
                txtbx_buscar_nombre.Text = pe.NombreEmpresa;
                txtbx_buscar_correo.Text = pe.Correo;
                txtbx_buscar_telefono.Text = pe.Telefono;
                txtbx_buscar_producto.Text = pe.Producto;
                txtbx_buscar_peso.Text = pe.Peso.ToString();
                txtbx_buscar_precio.Text = pe.Precio.ToString();
                txtbx_buscar_presupuesto.Text = pe.Presupuesto.ToString();

                MessageBox.Show("Proveedor modificado con exito.");

                txtbx_buscar_id.Enabled = false;
                txtbx_buscar_nombre.Enabled = false;
                txtbx_buscar_contacto.Enabled = false;
                txtbx_buscar_nombre.Enabled = false;
                txtbx_buscar_correo.Enabled = false;
                txtbx_buscar_telefono.Enabled = false;
                txtbx_buscar_producto.Enabled = false;
                txtbx_buscar_peso.Enabled = false;
                txtbx_buscar_precio.Enabled = false;


            }
            else
            {
                MessageBox.Show("Proveedor no encontrado. Verifique el ID e intente nuevamente.");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_nombre_empresa_KeyPress(object sender, KeyPressEventArgs e) // solo letras
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtbx_id_pro.Clear();
            txtbx_nombre_empresa.Clear();
            txtbx_nombre_contacto.Clear();
            txtbx_correo.Clear();
            txtbx_telefono.Text = "No Aplica";
            txtbx_producto.Clear();
            txtbx_peso.Clear();
            txtbx_precio.Clear();
            txtbx_presupuesto.Clear();
            txtbx_prec_total_men.Clear();
        }

        private void txtbx_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
