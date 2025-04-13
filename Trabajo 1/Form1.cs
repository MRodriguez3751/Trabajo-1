using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // Botones
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
            else if (txtbx_precio.Text.Length > 10 || txtbx_peso.Text.Length > 10 || txtbx_presupuesto.Text.Length > 10)
            {
                MessageBox.Show("Precio, Peso o Presupuesto Mensual no debe exceder el largo de 10 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    if (chckbx_telefono.Checked && string.IsNullOrWhiteSpace(txtbx_telefono.Text))
                    {
                        MessageBox.Show("Complete el campo de telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (chckbx_telefono.Checked && !string.IsNullOrWhiteSpace(txtbx_telefono.Text))
                    {
                        Proveedor nuevoProveedor = new Proveedor(int.Parse(txtbx_id_pro.Text), txtbx_nombre_empresa.Text, txtbx_nombre_contacto.Text, txtbx_correo.Text, txtbx_telefono.Text,
                                                               txtbx_producto.Text, int.Parse(txtbx_peso.Text), int.Parse(txtbx_precio.Text), int.Parse(txtbx_presupuesto.Text));
                        proveedores.Add(nuevoProveedor);
                    }
                    else if (!chckbx_telefono.Checked)
                    {
                        Proveedor nuevoProveedor = new Proveedor(int.Parse(txtbx_id_pro.Text), txtbx_nombre_empresa.Text, txtbx_nombre_contacto.Text, txtbx_correo.Text,
                                                                   txtbx_producto.Text, int.Parse(txtbx_peso.Text), int.Parse(txtbx_precio.Text), int.Parse(txtbx_presupuesto.Text));
                        proveedores.Add(nuevoProveedor);

                    }


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
                    chckbx_telefono.Checked = false;
                }
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            bool proveedorExistente = proveedores.Any(p => p.Id.Equals(int.Parse(txtbx_buscar.Text)));
            if (proveedorExistente)
            {
                txtbx_buscar_nombre.Enabled = true;
                txtbx_buscar_contacto.Enabled = true;
                txtbx_buscar_nombre.Enabled = true;
                txtbx_buscar_correo.Enabled = true;
                txtbx_buscar_telefono.Enabled = true;
                txtbx_buscar_producto.Enabled = true;
                txtbx_buscar_peso.Enabled = true;
                txtbx_buscar_precio.Enabled = true;
                txtbx_buscar_presupuesto.Enabled = true;

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
                txtbx_buscar_total.Text = $"$ {int.Parse(txtbx_buscar_precio.Text) * int.Parse(txtbx_buscar_peso.Text)}";
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado. Verifique el ID e intente nuevamente.");
            }
            txtbx_buscar.Clear();
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_buscar_id.Text) ||
                string.IsNullOrWhiteSpace(txtbx_buscar_nombre.Text) ||
                string.IsNullOrWhiteSpace(txtbx_buscar_contacto.Text) ||
                string.IsNullOrWhiteSpace(txtbx_buscar_correo.Text) ||
                string.IsNullOrWhiteSpace(txtbx_buscar_producto.Text) ||
                string.IsNullOrWhiteSpace(txtbx_buscar_peso.Text) ||
                string.IsNullOrWhiteSpace(txtbx_buscar_precio.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbx_buscar_precio.Text.Length > 10 || txtbx_buscar_peso.Text.Length > 10 || txtbx_presupuesto.Text.Length > 10)
            {
                MessageBox.Show("Precio, Peso o Presupuesto Mensual no debe exceder el largo de 10 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Proveedor proveedor = proveedores.FirstOrDefault(p => p.Id.Equals(int.Parse(txtbx_buscar_id.Text)));
                if (proveedor == null)
                {
                    MessageBox.Show("Proveedor no encontrado. Verifique el ID e intente nuevamente.");
                    return;
                }

                if (chckbx_buscar_telefono.Checked && string.IsNullOrWhiteSpace(txtbx_buscar_telefono.Text))
                {
                    MessageBox.Show("Complete el campo de telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (chckbx_buscar_telefono.Checked && !string.IsNullOrWhiteSpace(txtbx_buscar_telefono.Text))
                {
                    proveedor.NombreEmpresa = txtbx_buscar_nombre.Text;
                    proveedor.NombreContacto = txtbx_buscar_contacto.Text;
                    proveedor.Correo = txtbx_buscar_correo.Text;
                    proveedor.Telefono = txtbx_buscar_telefono.Text;
                    proveedor.Producto = txtbx_buscar_producto.Text;
                    proveedor.Peso = int.Parse(txtbx_buscar_peso.Text);
                    proveedor.Precio = int.Parse(txtbx_buscar_precio.Text);
                    proveedor.Presupuesto = int.Parse(txtbx_presupuesto.Text);
                }
                else if (!chckbx_buscar_telefono.Checked)
                {
                    proveedor.NombreEmpresa = txtbx_buscar_nombre.Text;
                    proveedor.NombreContacto = txtbx_buscar_contacto.Text;
                    proveedor.Correo = txtbx_buscar_correo.Text;
                    proveedor.Producto = txtbx_buscar_producto.Text;
                    proveedor.Peso = int.Parse(txtbx_buscar_peso.Text);
                    proveedor.Precio = int.Parse(txtbx_buscar_precio.Text);
                    proveedor.Presupuesto = int.Parse(txtbx_buscar_presupuesto.Text);
                }

                MessageBox.Show("Proveedor modificado con éxito.");

                dgv_lista.DataSource = null;
                dgv_lista.DataSource = proveedores;

                txtbx_buscar_id.Enabled = false;
                txtbx_buscar_nombre.Enabled = false;
                txtbx_buscar_contacto.Enabled = false;
                txtbx_buscar_nombre.Enabled = false;
                txtbx_buscar_correo.Enabled = false;
                txtbx_buscar_telefono.Enabled = false;
                txtbx_buscar_producto.Enabled = false;
                txtbx_buscar_peso.Enabled = false;
                txtbx_buscar_precio.Enabled = false;
                txtbx_buscar_presupuesto.Enabled = false;
            }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
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
        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (proveedores.Count > 0)
            {
                string filepath = "Proveedores.csv";

                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.WriteLine("Id;Empresa;Nombre Contacto;Correo;Teléfono;Producto;Peso;Precio;Presupuesto;Precio Total x Producto Mensual");

                    foreach (Proveedor proveedor in proveedores)
                    {
                        sw.WriteLine($"{proveedor.Id};{proveedor.NombreEmpresa};{proveedor.NombreContacto};{proveedor.Correo};{proveedor.Telefono};{proveedor.Producto};{proveedor.Peso};{proveedor.Precio};{proveedor.Presupuesto};{proveedor.TotalMensual}");
                    }
                }
                MessageBox.Show("El Archivo 'Proveedores.csv' ha sido creado con exito. ");
            }
            else
            {
                MessageBox.Show("No hay proveedores que exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        // Fin botones

        // Validaciones y otros
        private void chckbx_telefono_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbx_telefono.Checked)
            {
                txtbx_telefono.Clear();
                txtbx_telefono.Enabled = true;
            }
            else
            {
                txtbx_telefono.Clear();
                txtbx_telefono.Enabled = false;
            }
        }
        private void chckbx_buscar_telefono_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbx_telefono.Checked)
            {
                txtbx_buscar_telefono.Clear();
                txtbx_buscar_telefono.Enabled = true;
            }
            else
            {
                txtbx_buscar_telefono.Clear();
                txtbx_buscar_telefono.Enabled = false;
            }
        }
        private void txtbx_id_pro_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtbx_nombre_empresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtbx_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void calcular_total_mensual(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_peso.Text) && !string.IsNullOrWhiteSpace(txtbx_precio.Text))
            {
                txtbx_prec_total_men.Text = $"$ {int.Parse(txtbx_precio.Text) * int.Parse(txtbx_peso.Text)}";
            }
        }
        private void modificar_total_mensual(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_buscar_peso.Text) && !string.IsNullOrWhiteSpace(txtbx_buscar_precio.Text))
            {
                txtbx_buscar_total.Text = $"$ {int.Parse(txtbx_buscar_precio.Text) * int.Parse(txtbx_buscar_peso.Text)}";
            }
        }
        // Fin validaciones y otros

        // Clase
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
            private int totalMensual;

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

            public Proveedor(int id, string nombreEmpresa, string nombreContacto, string correo, string producto, int peso, int precio, int presupuesto)
            {
                Id = id;
                NombreEmpresa = nombreEmpresa;
                NombreContacto = nombreContacto;
                Correo = correo;
                Telefono = "";
                Producto = producto;
                Peso = peso;
                Precio = precio;
                TotalMensual = calcularTotalMensual();
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
            public int Presupuesto
            {
                get
                {
                    return presupuesto;
                }
                set
                {
                    double min = totalMensual + (totalMensual * 0.1);
                    if (value < min)
                    {
                        presupuesto = (int)Math.Round(min, 0);
                    }
                    else
                    {
                        presupuesto = value;
                    }
                }
            }
            public int TotalMensual { get => totalMensual; set => totalMensual = value; }

            public int calcularTotalMensual()
            {
                return totalMensual = Precio * Peso;
            }

        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_buscar_id.Text))
            {
                MessageBox.Show("Complete el campo del ID del proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idProveedor = int.Parse(txtbx_buscar_id.Text);
                Proveedor proveedorAEliminar = proveedores.FirstOrDefault(p => p.Id == idProveedor);

                if (proveedorAEliminar != null)
                {

                    proveedores.Remove(proveedorAEliminar);

                    dgv_lista.DataSource = null;
                    dgv_lista.DataSource = proveedores;

                    MessageBox.Show("Proveedor eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtbx_buscar_id.Clear();
                    txtbx_buscar_nombre.Clear();
                    txtbx_buscar_contacto.Clear();
                    txtbx_buscar_correo.Clear();
                    txtbx_buscar_telefono.Clear();
                    txtbx_buscar_producto.Clear();
                    txtbx_buscar_peso.Clear();
                    txtbx_buscar_precio.Clear();
                    txtbx_buscar_presupuesto.Clear();
                    txtbx_buscar_total.Clear();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado. Verifique el ID e intente nuevamente.");
                }

            }

        }
    }
}



