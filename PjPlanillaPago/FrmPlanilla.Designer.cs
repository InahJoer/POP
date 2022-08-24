namespace PjPlanillaPago
{
    partial class FrmPlanilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblGratificacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBasico = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalAportaciones = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILA DE PAGOS DE EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE INGRESO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE CONSULTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "MES CONSULTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "CARGO";
            // 
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Location = new System.Drawing.Point(669, 26);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(38, 15);
            this.lblFechaConsulta.TabIndex = 6;
            this.lblFechaConsulta.Text = "label7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.lblFechaConsulta);
            this.groupBox1.Controls.Add(this.dtFechaIngreso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(52, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION GENERAL DE EMPLEADOS";
            // 
            // txtAño
            // 
            this.txtAño.Enabled = false;
            this.txtAño.Location = new System.Drawing.Point(499, 102);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(181, 23);
            this.txtAño.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "AÑOS DE SERVICIO";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(245, 102);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(181, 23);
            this.txtMes.TabIndex = 9;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(245, 44);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(200, 23);
            this.dtFechaIngreso.TabIndex = 8;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Coordinador",
            "Jefe ",
            "Capacitador",
            "Asistente"});
            this.cboCargo.Location = new System.Drawing.Point(24, 102);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(181, 23);
            this.cboCargo.TabIndex = 6;
            this.cboCargo.Text = "(Selecccione cargo)";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(24, 44);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(181, 23);
            this.txtEmpleado.TabIndex = 2;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(52, 243);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 8;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblComision);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblGratificacion);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblBasico);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(74, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 111);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGRESOS";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComision.Location = new System.Drawing.Point(139, 89);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 17);
            this.lblComision.TabIndex = 11;
            this.lblComision.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "COMISION";
            // 
            // lblGratificacion
            // 
            this.lblGratificacion.AutoSize = true;
            this.lblGratificacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGratificacion.Location = new System.Drawing.Point(139, 55);
            this.lblGratificacion.Name = "lblGratificacion";
            this.lblGratificacion.Size = new System.Drawing.Size(52, 17);
            this.lblGratificacion.TabIndex = 14;
            this.lblGratificacion.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "GRATIFICACION";
            // 
            // lblBasico
            // 
            this.lblBasico.AutoSize = true;
            this.lblBasico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBasico.Location = new System.Drawing.Point(139, 19);
            this.lblBasico.Name = "lblBasico";
            this.lblBasico.Size = new System.Drawing.Size(45, 17);
            this.lblBasico.TabIndex = 11;
            this.lblBasico.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "SUELDO BASICO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCooperativa);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(320, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 80);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DESCUENTOS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDescuentos.Location = new System.Drawing.Point(472, 369);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(52, 17);
            this.lblTotalDescuentos.TabIndex = 18;
            this.lblTotalDescuentos.Text = "label17";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(342, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "TOTAL DESCUENTOS";
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCooperativa.Location = new System.Drawing.Point(152, 19);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(52, 17);
            this.lblCooperativa.TabIndex = 14;
            this.lblCooperativa.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 15);
            this.label19.TabIndex = 15;
            this.label19.Text = "COOPERATIVA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSeguro);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(593, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 80);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "APORTACIONES";
            // 
            // lblTotalAportaciones
            // 
            this.lblTotalAportaciones.AutoSize = true;
            this.lblTotalAportaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAportaciones.Location = new System.Drawing.Point(740, 375);
            this.lblTotalAportaciones.Name = "lblTotalAportaciones";
            this.lblTotalAportaciones.Size = new System.Drawing.Size(52, 17);
            this.lblTotalAportaciones.TabIndex = 22;
            this.lblTotalAportaciones.Text = "label23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(593, 375);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 15);
            this.label24.TabIndex = 23;
            this.label24.Text = "TOTAL APORTACIONES";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeguro.Location = new System.Drawing.Point(147, 19);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(52, 17);
            this.lblSeguro.TabIndex = 20;
            this.lblSeguro.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 15);
            this.label22.TabIndex = 21;
            this.label22.Text = "SEGURO SOCIAL";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(73, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIngresos.Location = new System.Drawing.Point(213, 400);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(52, 17);
            this.lblTotalIngresos.TabIndex = 15;
            this.lblTotalIngresos.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(83, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "TOTAL INGRESOS";
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalNeto.Location = new System.Drawing.Point(740, 433);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(52, 17);
            this.lblTotalNeto.TabIndex = 24;
            this.lblTotalNeto.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(593, 433);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 15);
            this.label26.TabIndex = 25;
            this.label26.Text = "TOTAL NETO";
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(895, 545);
            this.Controls.Add(this.lblTotalNeto);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblTotalIngresos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalDescuentos);
            this.Controls.Add(this.lblTotalAportaciones);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPlanilla";
            this.Text = "FrmPlanilla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblFechaConsulta;
        private GroupBox groupBox1;
        private TextBox txtAño;
        private Label label8;
        private TextBox txtMes;
        private DateTimePicker dtFechaIngreso;
        private ComboBox cboCargo;
        private TextBox txtEmpleado;
        private Button btnProcesar;
        private GroupBox groupBox2;
        private Label lblComision;
        private Label label14;
        private Label lblGratificacion;
        private Label label11;
        private Label lblBasico;
        private Label label10;
        private GroupBox groupBox3;
        private Label lblCooperativa;
        private Label label19;
        private GroupBox groupBox4;
        private Label lblTotalDescuentos;
        private Label label20;
        private Label lblTotalAportaciones;
        private Label label24;
        private Label lblSeguro;
        private Label label22;
        private Button btnCancelar;
        private Button btnSalir;
        private Label lblTotalIngresos;
        private Label label16;
        private Label lblTotalNeto;
        private Label label26;
    }
}