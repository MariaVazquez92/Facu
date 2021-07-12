
namespace Reservas
{
    partial class frmReserva
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnroRerserva = new System.Windows.Forms.Label();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxDetalleEquipos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnEditarEquipo = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnCancelarEquipo = new System.Windows.Forms.Button();
            this.gbxResponsables = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.gbxDetalleEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxResponsables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnroRerserva
            // 
            this.lblnroRerserva.AutoSize = true;
            this.lblnroRerserva.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnroRerserva.Location = new System.Drawing.Point(98, 14);
            this.lblnroRerserva.Name = "lblnroRerserva";
            this.lblnroRerserva.Size = new System.Drawing.Size(104, 20);
            this.lblnroRerserva.TabIndex = 0;
            this.lblnroRerserva.Text = "Reserva Nro.";
            // 
            // lblFechaSolicitud
            // 
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaSolicitud.Location = new System.Drawing.Point(454, 18);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.Size = new System.Drawing.Size(134, 20);
            this.lblFechaSolicitud.TabIndex = 1;
            this.lblFechaSolicitud.Text = "Fecha de Solicitud";
            this.lblFechaSolicitud.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(208, 11);
            this.txtReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(132, 27);
            this.txtReserva.TabIndex = 8;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(1513, 14);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(94, 36);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1513, 95);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 36);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1513, 54);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 36);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(1369, 652);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(87, 20);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(1475, 649);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(132, 27);
            this.txtPrecioTotal.TabIndex = 20;
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(592, 13);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(132, 27);
            this.dtpFechaSolicitud.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de Inicio de Reserva";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(592, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(410, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha de Fin de Reserva";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(208, 96);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Horario Retiro";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(592, 96);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker4.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(442, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Horario Devolucion";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(208, 129);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker5.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Horario Devolucion Real";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(55, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Lugar de Utilización";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 165);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(516, 73);
            this.textBox2.TabIndex = 33;
            // 
            // gbxDetalleEquipos
            // 
            this.gbxDetalleEquipos.Controls.Add(this.btnCancelarEquipo);
            this.gbxDetalleEquipos.Controls.Add(this.btnEliminarEquipo);
            this.gbxDetalleEquipos.Controls.Add(this.dataGridView1);
            this.gbxDetalleEquipos.Controls.Add(this.btnAgregarEquipo);
            this.gbxDetalleEquipos.Controls.Add(this.btnEditarEquipo);
            this.gbxDetalleEquipos.Controls.Add(this.numericUpDown1);
            this.gbxDetalleEquipos.Controls.Add(this.label9);
            this.gbxDetalleEquipos.Controls.Add(this.cboEquipo);
            this.gbxDetalleEquipos.Controls.Add(this.label7);
            this.gbxDetalleEquipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxDetalleEquipos.Location = new System.Drawing.Point(24, 256);
            this.gbxDetalleEquipos.Name = "gbxDetalleEquipos";
            this.gbxDetalleEquipos.Size = new System.Drawing.Size(773, 293);
            this.gbxDetalleEquipos.TabIndex = 34;
            this.gbxDetalleEquipos.TabStop = false;
            this.gbxDetalleEquipos.Text = "Equipos Reservados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Equipos";
            // 
            // cboEquipo
            // 
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(87, 30);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(312, 28);
            this.cboEquipo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(518, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 27);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.Location = new System.Drawing.Point(659, 88);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(94, 29);
            this.btnEditarEquipo.TabIndex = 4;
            this.btnEditarEquipo.Text = "Edit";
            this.btnEditarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(611, 25);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(58, 37);
            this.btnAgregarEquipo.TabIndex = 5;
            this.btnAgregarEquipo.Text = "+";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(623, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Location = new System.Drawing.Point(659, 123);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(94, 29);
            this.btnEliminarEquipo.TabIndex = 7;
            this.btnEliminarEquipo.Text = "Eliminar";
            this.btnEliminarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEquipo
            // 
            this.btnCancelarEquipo.Location = new System.Drawing.Point(659, 158);
            this.btnCancelarEquipo.Name = "btnCancelarEquipo";
            this.btnCancelarEquipo.Size = new System.Drawing.Size(94, 29);
            this.btnCancelarEquipo.TabIndex = 8;
            this.btnCancelarEquipo.Text = "Cancelar";
            this.btnCancelarEquipo.UseVisualStyleBackColor = true;
            // 
            // gbxResponsables
            // 
            this.gbxResponsables.Controls.Add(this.button1);
            this.gbxResponsables.Controls.Add(this.button2);
            this.gbxResponsables.Controls.Add(this.dataGridView2);
            this.gbxResponsables.Controls.Add(this.button3);
            this.gbxResponsables.Controls.Add(this.button4);
            this.gbxResponsables.Controls.Add(this.cboResponsable);
            this.gbxResponsables.Controls.Add(this.label10);
            this.gbxResponsables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxResponsables.Location = new System.Drawing.Point(834, 256);
            this.gbxResponsables.Name = "gbxResponsables";
            this.gbxResponsables.Size = new System.Drawing.Size(773, 293);
            this.gbxResponsables.TabIndex = 35;
            this.gbxResponsables.TabStop = false;
            this.gbxResponsables.Text = "Responsables de Reserva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(623, 188);
            this.dataGridView2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cboResponsable
            // 
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(120, 30);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(312, 28);
            this.cboResponsable.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Responsable";
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Location = new System.Drawing.Point(810, 10);
            this.btnAgregarReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(94, 36);
            this.btnAgregarReserva.TabIndex = 36;
            this.btnAgregarReserva.Text = "+ RESERVA";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 696);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.gbxResponsables);
            this.Controls.Add(this.gbxDetalleEquipos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaSolicitud);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblFechaSolicitud);
            this.Controls.Add(this.lblnroRerserva);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxDetalleEquipos.ResumeLayout(false);
            this.gbxDetalleEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxResponsables.ResumeLayout(false);
            this.gbxResponsables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnroRerserva;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbxDetalleEquipos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelarEquipo;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button btnEditarEquipo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.GroupBox gbxResponsables;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarReserva;
    }
}

