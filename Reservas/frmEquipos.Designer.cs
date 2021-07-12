
namespace Interfaz
{
    partial class frmEquipos
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
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.lblDescripcionEquipo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFechaAdq = new System.Windows.Forms.Label();
            this.lblCostoEquipo = new System.Windows.Forms.Label();
            this.lblSalaEquipo = new System.Windows.Forms.Label();
            this.lblEstadoEquipo = new System.Windows.Forms.Label();
            this.txtIdEquipo = new System.Windows.Forms.TextBox();
            this.txtDescripcionEquipo = new System.Windows.Forms.TextBox();
            this.btnGuardarEquipo = new System.Windows.Forms.Button();
            this.btnCancelarEquipo = new System.Windows.Forms.Button();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.lsbEquipos = new System.Windows.Forms.ListBox();
            this.btnNuevoEquipo = new System.Windows.Forms.Button();
            this.btnEditarEquipo = new System.Windows.Forms.Button();
            this.btnLimpiarEquipo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdEquipo.Location = new System.Drawing.Point(157, 16);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(23, 20);
            this.lblIdEquipo.TabIndex = 0;
            this.lblIdEquipo.Text = "Id";
            // 
            // lblDescripcionEquipo
            // 
            this.lblDescripcionEquipo.AutoSize = true;
            this.lblDescripcionEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionEquipo.Location = new System.Drawing.Point(92, 53);
            this.lblDescripcionEquipo.Name = "lblDescripcionEquipo";
            this.lblDescripcionEquipo.Size = new System.Drawing.Size(90, 20);
            this.lblDescripcionEquipo.TabIndex = 1;
            this.lblDescripcionEquipo.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(129, 90);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 20);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblFechaAdq
            // 
            this.lblFechaAdq.AutoSize = true;
            this.lblFechaAdq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaAdq.Location = new System.Drawing.Point(45, 125);
            this.lblFechaAdq.Name = "lblFechaAdq";
            this.lblFechaAdq.Size = new System.Drawing.Size(135, 20);
            this.lblFechaAdq.TabIndex = 3;
            this.lblFechaAdq.Text = "Fecha Adquisicion";
            // 
            // lblCostoEquipo
            // 
            this.lblCostoEquipo.AutoSize = true;
            this.lblCostoEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoEquipo.Location = new System.Drawing.Point(129, 159);
            this.lblCostoEquipo.Name = "lblCostoEquipo";
            this.lblCostoEquipo.Size = new System.Drawing.Size(49, 20);
            this.lblCostoEquipo.TabIndex = 4;
            this.lblCostoEquipo.Text = "Costo";
            // 
            // lblSalaEquipo
            // 
            this.lblSalaEquipo.AutoSize = true;
            this.lblSalaEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalaEquipo.Location = new System.Drawing.Point(141, 229);
            this.lblSalaEquipo.Name = "lblSalaEquipo";
            this.lblSalaEquipo.Size = new System.Drawing.Size(37, 20);
            this.lblSalaEquipo.TabIndex = 5;
            this.lblSalaEquipo.Text = "Sala";
            // 
            // lblEstadoEquipo
            // 
            this.lblEstadoEquipo.AutoSize = true;
            this.lblEstadoEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoEquipo.Location = new System.Drawing.Point(70, 264);
            this.lblEstadoEquipo.Name = "lblEstadoEquipo";
            this.lblEstadoEquipo.Size = new System.Drawing.Size(108, 20);
            this.lblEstadoEquipo.TabIndex = 7;
            this.lblEstadoEquipo.Text = "Estado Equipo";
            // 
            // txtIdEquipo
            // 
            this.txtIdEquipo.Location = new System.Drawing.Point(185, 13);
            this.txtIdEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(155, 27);
            this.txtIdEquipo.TabIndex = 8;
            // 
            // txtDescripcionEquipo
            // 
            this.txtDescripcionEquipo.Location = new System.Drawing.Point(185, 48);
            this.txtDescripcionEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionEquipo.Name = "txtDescripcionEquipo";
            this.txtDescripcionEquipo.Size = new System.Drawing.Size(155, 27);
            this.txtDescripcionEquipo.TabIndex = 9;
            // 
            // btnGuardarEquipo
            // 
            this.btnGuardarEquipo.Location = new System.Drawing.Point(46, 531);
            this.btnGuardarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarEquipo.Name = "btnGuardarEquipo";
            this.btnGuardarEquipo.Size = new System.Drawing.Size(87, 29);
            this.btnGuardarEquipo.TabIndex = 16;
            this.btnGuardarEquipo.Text = "Guardar";
            this.btnGuardarEquipo.UseVisualStyleBackColor = true;
            this.btnGuardarEquipo.Click += new System.EventHandler(this.btnGuardarEquipo_Click);
            // 
            // btnCancelarEquipo
            // 
            this.btnCancelarEquipo.Location = new System.Drawing.Point(185, 531);
            this.btnCancelarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarEquipo.Name = "btnCancelarEquipo";
            this.btnCancelarEquipo.Size = new System.Drawing.Size(87, 29);
            this.btnCancelarEquipo.TabIndex = 17;
            this.btnCancelarEquipo.Text = "Cancelar";
            this.btnCancelarEquipo.UseVisualStyleBackColor = true;
            this.btnCancelarEquipo.Click += new System.EventHandler(this.btnCancelarEquipo_Click);
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Location = new System.Drawing.Point(322, 531);
            this.btnEliminarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(87, 29);
            this.btnEliminarEquipo.TabIndex = 18;
            this.btnEliminarEquipo.Text = "Eliminar";
            this.btnEliminarEquipo.UseVisualStyleBackColor = true;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.btnEliminarEquipo_Click);
            // 
            // lsbEquipos
            // 
            this.lsbEquipos.FormattingEnabled = true;
            this.lsbEquipos.ItemHeight = 20;
            this.lsbEquipos.Location = new System.Drawing.Point(797, 13);
            this.lsbEquipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbEquipos.Name = "lsbEquipos";
            this.lsbEquipos.Size = new System.Drawing.Size(564, 164);
            this.lsbEquipos.TabIndex = 19;
            this.lsbEquipos.SelectedIndexChanged += new System.EventHandler(this.lsbEquipos_SelectedIndexChanged);
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.Location = new System.Drawing.Point(704, 44);
            this.btnNuevoEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(87, 29);
            this.btnNuevoEquipo.TabIndex = 20;
            this.btnNuevoEquipo.Text = "Nuevo";
            this.btnNuevoEquipo.UseVisualStyleBackColor = true;
            this.btnNuevoEquipo.Click += new System.EventHandler(this.btnNuevoEquipo_Click);
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.Location = new System.Drawing.Point(704, 79);
            this.btnEditarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(87, 29);
            this.btnEditarEquipo.TabIndex = 21;
            this.btnEditarEquipo.Text = "Editar";
            this.btnEditarEquipo.UseVisualStyleBackColor = true;
            this.btnEditarEquipo.Click += new System.EventHandler(this.btnEditarEquipo_Click);
            // 
            // btnLimpiarEquipo
            // 
            this.btnLimpiarEquipo.Location = new System.Drawing.Point(704, 116);
            this.btnLimpiarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarEquipo.Name = "btnLimpiarEquipo";
            this.btnLimpiarEquipo.Size = new System.Drawing.Size(87, 29);
            this.btnLimpiarEquipo.TabIndex = 22;
            this.btnLimpiarEquipo.Text = "Limpiar";
            this.btnLimpiarEquipo.UseVisualStyleBackColor = true;
            this.btnLimpiarEquipo.Click += new System.EventHandler(this.btnLimpiarEquipo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 27);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(184, 157);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(156, 27);
            this.numericUpDown1.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(185, 190);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(156, 27);
            this.numericUpDown2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Precio";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 261);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 28);
            this.comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(185, 223);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(155, 28);
            this.comboBox3.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(704, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 371);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(136, 35);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(155, 28);
            this.comboBox4.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Caracteristica";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 27);
            this.textBox1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(645, 188);
            this.dataGridView1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 317);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 29);
            this.button3.TabIndex = 32;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 317);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 29);
            this.button4.TabIndex = 31;
            this.button4.Text = "editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarEquipo);
            this.Controls.Add(this.btnEditarEquipo);
            this.Controls.Add(this.btnNuevoEquipo);
            this.Controls.Add(this.lsbEquipos);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Controls.Add(this.btnCancelarEquipo);
            this.Controls.Add(this.btnGuardarEquipo);
            this.Controls.Add(this.txtDescripcionEquipo);
            this.Controls.Add(this.txtIdEquipo);
            this.Controls.Add(this.lblEstadoEquipo);
            this.Controls.Add(this.lblSalaEquipo);
            this.Controls.Add(this.lblCostoEquipo);
            this.Controls.Add(this.lblFechaAdq);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcionEquipo);
            this.Controls.Add(this.lblIdEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.frmEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.Label lblDescripcionEquipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblFechaAdq;
        private System.Windows.Forms.Label lblCostoEquipo;
        private System.Windows.Forms.Label lblSalaEquipo;
        private System.Windows.Forms.Label lblEstadoEquipo;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.TextBox txtDescripcionEquipo;
        private System.Windows.Forms.Button btnGuardarEquipo;
        private System.Windows.Forms.Button btnCancelarEquipo;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.ListBox lsbEquipos;
        private System.Windows.Forms.Button btnNuevoEquipo;
        private System.Windows.Forms.Button btnEditarEquipo;
        private System.Windows.Forms.Button btnLimpiarEquipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}