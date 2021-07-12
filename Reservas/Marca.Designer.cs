
namespace Interfaz
{
    partial class Marca
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
            this.btnNuevoMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnLimpiarMarca = new System.Windows.Forms.Button();
            this.lsbMarca = new System.Windows.Forms.ListBox();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoMarca
            // 
            this.btnNuevoMarca.Location = new System.Drawing.Point(387, 15);
            this.btnNuevoMarca.Name = "btnNuevoMarca";
            this.btnNuevoMarca.Size = new System.Drawing.Size(77, 27);
            this.btnNuevoMarca.TabIndex = 32;
            this.btnNuevoMarca.Text = "Nuevo";
            this.btnNuevoMarca.UseVisualStyleBackColor = true;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Location = new System.Drawing.Point(387, 76);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(77, 27);
            this.btnEditarMarca.TabIndex = 31;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnLimpiarMarca
            // 
            this.btnLimpiarMarca.Location = new System.Drawing.Point(387, 133);
            this.btnLimpiarMarca.Name = "btnLimpiarMarca";
            this.btnLimpiarMarca.Size = new System.Drawing.Size(77, 27);
            this.btnLimpiarMarca.TabIndex = 30;
            this.btnLimpiarMarca.Text = "Limpiar";
            this.btnLimpiarMarca.UseVisualStyleBackColor = true;
            this.btnLimpiarMarca.Click += new System.EventHandler(this.btnLimpiarMarca_Click);
            // 
            // lsbMarca
            // 
            this.lsbMarca.FormattingEnabled = true;
            this.lsbMarca.ItemHeight = 15;
            this.lsbMarca.Location = new System.Drawing.Point(470, 15);
            this.lsbMarca.Name = "lsbMarca";
            this.lsbMarca.Size = new System.Drawing.Size(189, 154);
            this.lsbMarca.TabIndex = 29;
            this.lsbMarca.SelectedIndexChanged += new System.EventHandler(this.lsbMarca_SelectedIndexChanged);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(239, 133);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(77, 27);
            this.btnEliminarMarca.TabIndex = 28;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(126, 133);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(77, 27);
            this.btnCancelarMarca.TabIndex = 27;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(14, 133);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(77, 27);
            this.btnGuardarMarca.TabIndex = 26;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(89, 85);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 23);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(89, 41);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 23);
            this.txtMarca.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(14, 44);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 22;
            this.lblPais.Text = "Pais";
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 185);
            this.Controls.Add(this.btnNuevoMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnLimpiarMarca);
            this.Controls.Add(this.lsbMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPais);
            this.Name = "Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnLimpiarMarca;
        private System.Windows.Forms.ListBox lsbMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPais;
    }
}