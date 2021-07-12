
namespace Interfaz
{
    partial class frmCiudad
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
            this.btnNuevoCiudad = new System.Windows.Forms.Button();
            this.btnEditarCiudad = new System.Windows.Forms.Button();
            this.btnLimpiarCiudad = new System.Windows.Forms.Button();
            this.lsbCiudad = new System.Windows.Forms.ListBox();
            this.btnEliminarCiudad = new System.Windows.Forms.Button();
            this.btnCancelarCiudad = new System.Windows.Forms.Button();
            this.btnGuardarCiudad = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoCiudad
            // 
            this.btnNuevoCiudad.Location = new System.Drawing.Point(386, 12);
            this.btnNuevoCiudad.Name = "btnNuevoCiudad";
            this.btnNuevoCiudad.Size = new System.Drawing.Size(77, 27);
            this.btnNuevoCiudad.TabIndex = 21;
            this.btnNuevoCiudad.Text = "Nuevo";
            this.btnNuevoCiudad.UseVisualStyleBackColor = true;
            // 
            // btnEditarCiudad
            // 
            this.btnEditarCiudad.Location = new System.Drawing.Point(386, 73);
            this.btnEditarCiudad.Name = "btnEditarCiudad";
            this.btnEditarCiudad.Size = new System.Drawing.Size(77, 27);
            this.btnEditarCiudad.TabIndex = 20;
            this.btnEditarCiudad.Text = "Editar";
            this.btnEditarCiudad.UseVisualStyleBackColor = true;
            this.btnEditarCiudad.Click += new System.EventHandler(this.btnEditarCiudad_Click);
            // 
            // btnLimpiarCiudad
            // 
            this.btnLimpiarCiudad.Location = new System.Drawing.Point(386, 130);
            this.btnLimpiarCiudad.Name = "btnLimpiarCiudad";
            this.btnLimpiarCiudad.Size = new System.Drawing.Size(77, 27);
            this.btnLimpiarCiudad.TabIndex = 19;
            this.btnLimpiarCiudad.Text = "Limpiar";
            this.btnLimpiarCiudad.UseVisualStyleBackColor = true;
            this.btnLimpiarCiudad.Click += new System.EventHandler(this.btnLimpiarCiudad_Click);
            // 
            // lsbCiudad
            // 
            this.lsbCiudad.FormattingEnabled = true;
            this.lsbCiudad.ItemHeight = 15;
            this.lsbCiudad.Location = new System.Drawing.Point(469, 12);
            this.lsbCiudad.Name = "lsbCiudad";
            this.lsbCiudad.Size = new System.Drawing.Size(189, 154);
            this.lsbCiudad.TabIndex = 18;
            this.lsbCiudad.SelectedIndexChanged += new System.EventHandler(this.lsbCiudad_SelectedIndexChanged);
            // 
            // btnEliminarCiudad
            // 
            this.btnEliminarCiudad.Location = new System.Drawing.Point(238, 130);
            this.btnEliminarCiudad.Name = "btnEliminarCiudad";
            this.btnEliminarCiudad.Size = new System.Drawing.Size(77, 27);
            this.btnEliminarCiudad.TabIndex = 17;
            this.btnEliminarCiudad.Text = "Eliminar";
            this.btnEliminarCiudad.UseVisualStyleBackColor = true;
            this.btnEliminarCiudad.Click += new System.EventHandler(this.btnEliminarCiudad_Click);
            // 
            // btnCancelarCiudad
            // 
            this.btnCancelarCiudad.Location = new System.Drawing.Point(125, 130);
            this.btnCancelarCiudad.Name = "btnCancelarCiudad";
            this.btnCancelarCiudad.Size = new System.Drawing.Size(77, 27);
            this.btnCancelarCiudad.TabIndex = 16;
            this.btnCancelarCiudad.Text = "Cancelar";
            this.btnCancelarCiudad.UseVisualStyleBackColor = true;
            this.btnCancelarCiudad.Click += new System.EventHandler(this.btnCancelarCiudad_Click);
            // 
            // btnGuardarCiudad
            // 
            this.btnGuardarCiudad.Location = new System.Drawing.Point(13, 130);
            this.btnGuardarCiudad.Name = "btnGuardarCiudad";
            this.btnGuardarCiudad.Size = new System.Drawing.Size(77, 27);
            this.btnGuardarCiudad.TabIndex = 15;
            this.btnGuardarCiudad.Text = "Guardar";
            this.btnGuardarCiudad.UseVisualStyleBackColor = true;
            this.btnGuardarCiudad.Click += new System.EventHandler(this.btnGuardarCiudad_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(88, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 23);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(88, 38);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(156, 23);
            this.txtCiudad.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(13, 41);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(28, 15);
            this.lblCiudad.TabIndex = 11;
            this.lblCiudad.Text = "Pais";
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 202);
            this.Controls.Add(this.btnNuevoCiudad);
            this.Controls.Add(this.btnEditarCiudad);
            this.Controls.Add(this.btnLimpiarCiudad);
            this.Controls.Add(this.lsbCiudad);
            this.Controls.Add(this.btnEliminarCiudad);
            this.Controls.Add(this.btnCancelarCiudad);
            this.Controls.Add(this.btnGuardarCiudad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCiudad);
            this.Name = "frmCiudad";
            this.Text = "Ciudad";
            this.Load += new System.EventHandler(this.frmCiudad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnNuevoCiudad;
        private System.Windows.Forms.Button btnEditarCiudad;
        private System.Windows.Forms.Button btnLimpiarCiudad;
        private System.Windows.Forms.ListBox lsbCiudad;
        private System.Windows.Forms.Button btnEliminarCiudad;
        private System.Windows.Forms.Button btnCancelarCiudad;
        private System.Windows.Forms.Button btnGuardarCiudad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCiudad;
    }
}