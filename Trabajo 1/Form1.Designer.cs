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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.btn_guardar.Location = new System.Drawing.Point(383, 209);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 41);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar Proveedor";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpiar Formulario";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // txtbx_peso
            // 
            this.txtbx_peso.Location = new System.Drawing.Point(152, 58);
            this.txtbx_peso.Name = "txtbx_peso";
            this.txtbx_peso.Size = new System.Drawing.Size(100, 20);
            this.txtbx_peso.TabIndex = 4;
            // 
            // txtbx_producto
            // 
            this.txtbx_producto.Location = new System.Drawing.Point(152, 33);
            this.txtbx_producto.Name = "txtbx_producto";
            this.txtbx_producto.Size = new System.Drawing.Size(100, 20);
            this.txtbx_producto.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.checkBox1);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Telefono Contacto:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtbx_telefono
            // 
            this.txtbx_telefono.Location = new System.Drawing.Point(152, 136);
            this.txtbx_telefono.Name = "txtbx_telefono";
            this.txtbx_telefono.Size = new System.Drawing.Size(100, 20);
            this.txtbx_telefono.TabIndex = 9;
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
            // 
            // txtbx_nombre_empresa
            // 
            this.txtbx_nombre_empresa.Location = new System.Drawing.Point(152, 58);
            this.txtbx_nombre_empresa.Name = "txtbx_nombre_empresa";
            this.txtbx_nombre_empresa.Size = new System.Drawing.Size(100, 20);
            this.txtbx_nombre_empresa.TabIndex = 4;
            // 
            // txtbx_id_pro
            // 
            this.txtbx_id_pro.Location = new System.Drawing.Point(152, 33);
            this.txtbx_id_pro.Name = "txtbx_id_pro";
            this.txtbx_id_pro.Size = new System.Drawing.Size(100, 20);
            this.txtbx_id_pro.TabIndex = 3;
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
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 260);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingreso De Datos";
            // 
            // groupBox3
            // 
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
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Location = new System.Drawing.Point(11, 34);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(560, 249);
            this.dgv_lista.TabIndex = 2;
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
        private System.Windows.Forms.CheckBox checkBox1;
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
    }
}

