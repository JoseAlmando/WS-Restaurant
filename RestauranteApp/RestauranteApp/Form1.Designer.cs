namespace RestauranteApp
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPersonaACargo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCantEmpleado = new System.Windows.Forms.TextBox();
            this.tbVenMensuales = new System.Windows.Forms.TextBox();
            this.tbTIpoCOmida = new System.Windows.Forms.TextBox();
            this.tbRNC = new System.Windows.Forms.TextBox();
            this.llbRegGuid = new System.Windows.Forms.Label();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.tbId = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.dtFechaCrea = new System.Windows.Forms.DateTimePicker();
            this.dtFechaMod = new System.Windows.Forms.DateTimePicker();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 321);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(966, 171);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "RNC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Persona a  Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad de empleados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha Creación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha Modificación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo Comiga:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ventas mensuales:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Registro Guid:";
            // 
            // tbPersonaACargo
            // 
            this.tbPersonaACargo.Location = new System.Drawing.Point(307, 274);
            this.tbPersonaACargo.Name = "tbPersonaACargo";
            this.tbPersonaACargo.Size = new System.Drawing.Size(151, 20);
            this.tbPersonaACargo.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(307, 80);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(151, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // tbCantEmpleado
            // 
            this.tbCantEmpleado.Location = new System.Drawing.Point(677, 37);
            this.tbCantEmpleado.Name = "tbCantEmpleado";
            this.tbCantEmpleado.Size = new System.Drawing.Size(151, 20);
            this.tbCantEmpleado.TabIndex = 14;
            // 
            // tbVenMensuales
            // 
            this.tbVenMensuales.Location = new System.Drawing.Point(677, 274);
            this.tbVenMensuales.Name = "tbVenMensuales";
            this.tbVenMensuales.Size = new System.Drawing.Size(151, 20);
            this.tbVenMensuales.TabIndex = 15;
            // 
            // tbTIpoCOmida
            // 
            this.tbTIpoCOmida.Location = new System.Drawing.Point(677, 219);
            this.tbTIpoCOmida.Name = "tbTIpoCOmida";
            this.tbTIpoCOmida.Size = new System.Drawing.Size(151, 20);
            this.tbTIpoCOmida.TabIndex = 16;
            // 
            // tbRNC
            // 
            this.tbRNC.Location = new System.Drawing.Point(307, 122);
            this.tbRNC.Name = "tbRNC";
            this.tbRNC.Size = new System.Drawing.Size(151, 20);
            this.tbRNC.TabIndex = 17;
            // 
            // llbRegGuid
            // 
            this.llbRegGuid.AutoSize = true;
            this.llbRegGuid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRegGuid.Location = new System.Drawing.Point(583, 297);
            this.llbRegGuid.Name = "llbRegGuid";
            this.llbRegGuid.Size = new System.Drawing.Size(98, 21);
            this.llbRegGuid.TabIndex = 18;
            this.llbRegGuid.Text = "___________";
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInsert.Location = new System.Drawing.Point(12, 75);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(87, 25);
            this.rbInsert.TabIndex = 19;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "Insertar";
            this.rbInsert.UseVisualStyleBackColor = true;
            this.rbInsert.CheckedChanged += new System.EventHandler(this.rbInsert_CheckedChanged);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(307, 34);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(151, 20);
            this.tbId.TabIndex = 20;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(307, 216);
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(151, 20);
            this.mtbTelefono.TabIndex = 21;
            // 
            // dtFechaCrea
            // 
            this.dtFechaCrea.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCrea.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCrea.Location = new System.Drawing.Point(677, 81);
            this.dtFechaCrea.Name = "dtFechaCrea";
            this.dtFechaCrea.Size = new System.Drawing.Size(151, 20);
            this.dtFechaCrea.TabIndex = 22;
            // 
            // dtFechaMod
            // 
            this.dtFechaMod.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaMod.Location = new System.Drawing.Point(677, 148);
            this.dtFechaMod.Name = "dtFechaMod";
            this.dtFechaMod.Size = new System.Drawing.Size(151, 20);
            this.dtFechaMod.TabIndex = 23;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdate.Location = new System.Drawing.Point(12, 147);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(108, 25);
            this.rbUpdate.TabIndex = 24;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Actualizar";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelete.Location = new System.Drawing.Point(12, 204);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(87, 25);
            this.rbDelete.TabIndex = 25;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Eliminar";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(132, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 258);
            this.panel1.TabIndex = 26;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(852, 96);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 133);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(307, 175);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(151, 20);
            this.tbDireccion.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Direccion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 492);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbDelete);
            this.Controls.Add(this.rbUpdate);
            this.Controls.Add(this.dtFechaMod);
            this.Controls.Add(this.dtFechaCrea);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.rbInsert);
            this.Controls.Add(this.llbRegGuid);
            this.Controls.Add(this.tbRNC);
            this.Controls.Add(this.tbTIpoCOmida);
            this.Controls.Add(this.tbVenMensuales);
            this.Controls.Add(this.tbCantEmpleado);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbPersonaACargo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPersonaACargo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCantEmpleado;
        private System.Windows.Forms.TextBox tbVenMensuales;
        private System.Windows.Forms.TextBox tbTIpoCOmida;
        private System.Windows.Forms.TextBox tbRNC;
        private System.Windows.Forms.Label llbRegGuid;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.DateTimePicker dtFechaCrea;
        private System.Windows.Forms.DateTimePicker dtFechaMod;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label12;
    }
}

