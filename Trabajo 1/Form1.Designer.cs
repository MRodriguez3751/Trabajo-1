namespace Trabajo_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_prec_total_men = new System.Windows.Forms.TextBox();
            this.txtbx_presupuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_precio = new System.Windows.Forms.TextBox();
            this.txtbx_peso = new System.Windows.Forms.TextBox();
            this.txtbx_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckbx_telefono = new System.Windows.Forms.CheckBox();
            this.txtbx_telefono = new System.Windows.Forms.TextBox();
            this.txtbx_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txtbx_nombre_contacto = new System.Windows.Forms.TextBox();
            this.txtbx_nombre_empresa = new System.Windows.Forms.TextBox();
            this.txtbx_id_pro = new System.Windows.Forms.TextBox();
            this.lbl_nombre_contacto = new System.Windows.Forms.Label();
            this.lbl_nombre_empresa = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_buscar_total = new System.Windows.Forms.TextBox();
            this.txtbx_buscar_presupuesto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbx_buscar_precio = new System.Windows.Forms.TextBox();
            this.txtbx_buscar_peso = new System.Windows.Forms.TextBox();
            this.txtbx_buscar_producto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbx_buscar_telefono = new System.Windows.Forms.TextBox();
            this.txtbx_buscar_correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_buscar_contacto = new System.Windows.Forms.TextBox();
            this.txtbx_buscar_nombre = new System.Windows.Forms.TextBox();
            this.txtbx_buscar_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_buscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso De Proveedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(316, 209);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 41);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar Proveedor";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpiar Formulario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbx_prec_total_men);
            this.groupBox2.Controls.Add(this.txtbx_presupuesto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtbx_precio);
            this.groupBox2.Controls.Add(this.txtbx_peso);
            this.groupBox2.Controls.Add(this.txtbx_producto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(290, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 185);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio Total Por\r\nProducto Mensual";
            // 
            // txtbx_prec_total_men
            // 
            this.txtbx_prec_total_men.Location = new System.Drawing.Point(152, 142);
            this.txtbx_prec_total_men.Name = "txtbx_prec_total_men";
            this.txtbx_prec_total_men.ReadOnly = true;
            this.txtbx_prec_total_men.Size = new System.Drawing.Size(100, 20);
            this.txtbx_prec_total_men.TabIndex = 9;
            // 
            // txtbx_presupuesto
            // 
            this.txtbx_presupuesto.Location = new System.Drawing.Point(152, 110);
            this.txtbx_presupuesto.Name = "txtbx_presupuesto";
            this.txtbx_presupuesto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_presupuesto.TabIndex = 7;
            this.txtbx_presupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Presupuesto mensual: ";
            // 
            // txtbx_precio
            // 
            this.txtbx_precio.Location = new System.Drawing.Point(152, 84);
            this.txtbx_precio.Name = "txtbx_precio";
            this.txtbx_precio.Size = new System.Drawing.Size(100, 20);
            this.txtbx_precio.TabIndex = 5;
            this.txtbx_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            this.txtbx_precio.Leave += new System.EventHandler(this.calcular_total_mensual);
            // 
            // txtbx_peso
            // 
            this.txtbx_peso.Location = new System.Drawing.Point(152, 58);
            this.txtbx_peso.Name = "txtbx_peso";
            this.txtbx_peso.Size = new System.Drawing.Size(100, 20);
            this.txtbx_peso.TabIndex = 4;
            this.txtbx_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            this.txtbx_peso.Leave += new System.EventHandler(this.calcular_total_mensual);
            // 
            // txtbx_producto
            // 
            this.txtbx_producto.Location = new System.Drawing.Point(152, 33);
            this.txtbx_producto.Name = "txtbx_producto";
            this.txtbx_producto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_producto.TabIndex = 3;
            this.txtbx_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio (1 kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Peso (kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckbx_telefono);
            this.groupBox1.Controls.Add(this.txtbx_telefono);
            this.groupBox1.Controls.Add(this.txtbx_correo);
            this.groupBox1.Controls.Add(this.lbl_correo);
            this.groupBox1.Controls.Add(this.txtbx_nombre_contacto);
            this.groupBox1.Controls.Add(this.txtbx_nombre_empresa);
            this.groupBox1.Controls.Add(this.txtbx_id_pro);
            this.groupBox1.Controls.Add(this.lbl_nombre_contacto);
            this.groupBox1.Controls.Add(this.lbl_nombre_empresa);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proveedor";
            // 
            // chckbx_telefono
            // 
            this.chckbx_telefono.AutoSize = true;
            this.chckbx_telefono.Location = new System.Drawing.Point(7, 139);
            this.chckbx_telefono.Name = "chckbx_telefono";
            this.chckbx_telefono.Size = new System.Drawing.Size(117, 17);
            this.chckbx_telefono.TabIndex = 10;
            this.chckbx_telefono.Text = "Teléfono Contacto:";
            this.chckbx_telefono.UseVisualStyleBackColor = true;
            this.chckbx_telefono.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtbx_telefono
            // 
            this.txtbx_telefono.Enabled = false;
            this.txtbx_telefono.Location = new System.Drawing.Point(152, 136);
            this.txtbx_telefono.Name = "txtbx_telefono";
            this.txtbx_telefono.Size = new System.Drawing.Size(100, 20);
            this.txtbx_telefono.TabIndex = 9;
            this.txtbx_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            // 
            // txtbx_correo
            // 
            this.txtbx_correo.Location = new System.Drawing.Point(152, 110);
            this.txtbx_correo.Name = "txtbx_correo";
            this.txtbx_correo.Size = new System.Drawing.Size(100, 20);
            this.txtbx_correo.TabIndex = 7;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(23, 113);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(87, 13);
            this.lbl_correo.TabIndex = 6;
            this.lbl_correo.Text = "Correo Contacto:";
            // 
            // txtbx_nombre_contacto
            // 
            this.txtbx_nombre_contacto.Location = new System.Drawing.Point(152, 84);
            this.txtbx_nombre_contacto.Name = "txtbx_nombre_contacto";
            this.txtbx_nombre_contacto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_nombre_contacto.TabIndex = 5;
            this.txtbx_nombre_contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // txtbx_nombre_empresa
            // 
            this.txtbx_nombre_empresa.Location = new System.Drawing.Point(152, 58);
            this.txtbx_nombre_empresa.Name = "txtbx_nombre_empresa";
            this.txtbx_nombre_empresa.Size = new System.Drawing.Size(100, 20);
            this.txtbx_nombre_empresa.TabIndex = 4;
            this.txtbx_nombre_empresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // txtbx_id_pro
            // 
            this.txtbx_id_pro.Location = new System.Drawing.Point(152, 33);
            this.txtbx_id_pro.Name = "txtbx_id_pro";
            this.txtbx_id_pro.Size = new System.Drawing.Size(100, 20);
            this.txtbx_id_pro.TabIndex = 3;
            this.txtbx_id_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_id_pro_KeyPress);
            // 
            // lbl_nombre_contacto
            // 
            this.lbl_nombre_contacto.AutoSize = true;
            this.lbl_nombre_contacto.Location = new System.Drawing.Point(23, 87);
            this.lbl_nombre_contacto.Name = "lbl_nombre_contacto";
            this.lbl_nombre_contacto.Size = new System.Drawing.Size(93, 13);
            this.lbl_nombre_contacto.TabIndex = 2;
            this.lbl_nombre_contacto.Text = "Nombre Contacto:";
            // 
            // lbl_nombre_empresa
            // 
            this.lbl_nombre_empresa.AutoSize = true;
            this.lbl_nombre_empresa.Location = new System.Drawing.Point(23, 61);
            this.lbl_nombre_empresa.Name = "lbl_nombre_empresa";
            this.lbl_nombre_empresa.Size = new System.Drawing.Size(91, 13);
            this.lbl_nombre_empresa.TabIndex = 1;
            this.lbl_nombre_empresa.Text = "Nombre Empresa:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(23, 36);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(95, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Código Proveedor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btn_modificar);
            this.groupBox4.Controls.Add(this.btn_eliminar);
            this.groupBox4.Controls.Add(this.btn_buscar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtbx_buscar);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 260);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingreso De Datos";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtbx_buscar_total);
            this.groupBox6.Controls.Add(this.txtbx_buscar_presupuesto);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txtbx_buscar_precio);
            this.groupBox6.Controls.Add(this.txtbx_buscar_peso);
            this.groupBox6.Controls.Add(this.txtbx_buscar_producto);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(283, 75);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 185);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos del Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio Total Por\r\nProducto Mensual";
            // 
            // txtbx_buscar_total
            // 
            this.txtbx_buscar_total.Location = new System.Drawing.Point(152, 142);
            this.txtbx_buscar_total.Name = "txtbx_buscar_total";
            this.txtbx_buscar_total.ReadOnly = true;
            this.txtbx_buscar_total.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_total.TabIndex = 9;
            // 
            // txtbx_buscar_presupuesto
            // 
            this.txtbx_buscar_presupuesto.Location = new System.Drawing.Point(152, 110);
            this.txtbx_buscar_presupuesto.Name = "txtbx_buscar_presupuesto";
            this.txtbx_buscar_presupuesto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_presupuesto.TabIndex = 7;
            this.txtbx_buscar_presupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Presupuesto mensual: ";
            // 
            // txtbx_buscar_precio
            // 
            this.txtbx_buscar_precio.Location = new System.Drawing.Point(152, 84);
            this.txtbx_buscar_precio.Name = "txtbx_buscar_precio";
            this.txtbx_buscar_precio.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_precio.TabIndex = 5;
            this.txtbx_buscar_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            // 
            // txtbx_buscar_peso
            // 
            this.txtbx_buscar_peso.Location = new System.Drawing.Point(152, 58);
            this.txtbx_buscar_peso.Name = "txtbx_buscar_peso";
            this.txtbx_buscar_peso.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_peso.TabIndex = 4;
            this.txtbx_buscar_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            // 
            // txtbx_buscar_producto
            // 
            this.txtbx_buscar_producto.Location = new System.Drawing.Point(152, 33);
            this.txtbx_buscar_producto.Name = "txtbx_buscar_producto";
            this.txtbx_buscar_producto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_producto.TabIndex = 3;
            this.txtbx_buscar_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Precio (1 kg)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Peso (kg)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nombre:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtbx_buscar_telefono);
            this.groupBox5.Controls.Add(this.txtbx_buscar_correo);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtbx_buscar_contacto);
            this.groupBox5.Controls.Add(this.txtbx_buscar_nombre);
            this.groupBox5.Controls.Add(this.txtbx_buscar_id);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(6, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 185);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Proveedor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Teléfono Contacto:";
            // 
            // txtbx_buscar_telefono
            // 
            this.txtbx_buscar_telefono.Enabled = false;
            this.txtbx_buscar_telefono.Location = new System.Drawing.Point(152, 136);
            this.txtbx_buscar_telefono.Name = "txtbx_buscar_telefono";
            this.txtbx_buscar_telefono.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_telefono.TabIndex = 9;
            this.txtbx_buscar_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_telefono_KeyPress);
            // 
            // txtbx_buscar_correo
            // 
            this.txtbx_buscar_correo.Location = new System.Drawing.Point(152, 110);
            this.txtbx_buscar_correo.Name = "txtbx_buscar_correo";
            this.txtbx_buscar_correo.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_correo.TabIndex = 7;
            this.txtbx_buscar_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo Contacto:";
            // 
            // txtbx_buscar_contacto
            // 
            this.txtbx_buscar_contacto.Location = new System.Drawing.Point(152, 84);
            this.txtbx_buscar_contacto.Name = "txtbx_buscar_contacto";
            this.txtbx_buscar_contacto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_contacto.TabIndex = 5;
            this.txtbx_buscar_contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // txtbx_buscar_nombre
            // 
            this.txtbx_buscar_nombre.Location = new System.Drawing.Point(152, 58);
            this.txtbx_buscar_nombre.Name = "txtbx_buscar_nombre";
            this.txtbx_buscar_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_nombre.TabIndex = 4;
            this.txtbx_buscar_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_nombre_empresa_KeyPress);
            // 
            // txtbx_buscar_id
            // 
            this.txtbx_buscar_id.Location = new System.Drawing.Point(152, 33);
            this.txtbx_buscar_id.Name = "txtbx_buscar_id";
            this.txtbx_buscar_id.ReadOnly = true;
            this.txtbx_buscar_id.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar_id.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre Contacto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre Empresa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código Proveedor:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(357, 37);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(455, 37);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(229, 37);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ingrese ID:";
            // 
            // txtbx_buscar
            // 
            this.txtbx_buscar.Location = new System.Drawing.Point(102, 39);
            this.txtbx_buscar.Name = "txtbx_buscar";
            this.txtbx_buscar.Size = new System.Drawing.Size(100, 20);
            this.txtbx_buscar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_exportar);
            this.groupBox3.Controls.Add(this.dgv_lista);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 310);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado De Proveedores";
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Location = new System.Drawing.Point(11, 19);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.ReadOnly = true;
            this.dgv_lista.Size = new System.Drawing.Size(560, 249);
            this.dgv_lista.TabIndex = 2;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(224, 274);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(131, 30);
            this.btn_exportar.TabIndex = 14;
            this.btn_exportar.Text = "Exportar Listado";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 639);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nombre_empresa;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbx_nombre_contacto;
        private System.Windows.Forms.TextBox txtbx_nombre_empresa;
        private System.Windows.Forms.TextBox txtbx_id_pro;
        private System.Windows.Forms.Label lbl_nombre_contacto;
        private System.Windows.Forms.CheckBox chckbx_telefono;
        private System.Windows.Forms.TextBox txtbx_telefono;
        private System.Windows.Forms.TextBox txtbx_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_prec_total_men;
        private System.Windows.Forms.TextBox txtbx_presupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_precio;
        private System.Windows.Forms.TextBox txtbx_peso;
        private System.Windows.Forms.TextBox txtbx_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_buscar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_buscar_total;
        private System.Windows.Forms.TextBox txtbx_buscar_presupuesto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbx_buscar_precio;
        private System.Windows.Forms.TextBox txtbx_buscar_peso;
        private System.Windows.Forms.TextBox txtbx_buscar_producto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbx_buscar_telefono;
        private System.Windows.Forms.TextBox txtbx_buscar_correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_buscar_contacto;
        private System.Windows.Forms.TextBox txtbx_buscar_nombre;
        private System.Windows.Forms.TextBox txtbx_buscar_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_exportar;
    }
}

