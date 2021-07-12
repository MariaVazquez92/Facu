
namespace Interfaz
{
    partial class frmEstado
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
            this.btnNuevoEstado = new System.Windows.Forms.Button();
            this.btnEditarEstado = new System.Windows.Forms.Button();
            this.btnLimpiarEstado = new System.Windows.Forms.Button();
            this.lsbEstado = new System.Windows.Forms.ListBox();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.btnCancelarEstado = new System.Windows.Forms.Button();
            this.btnGuardarEstado = new System.Windows.Forms.Button();
            this.txtDescripcionEstado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblDescripcionEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoEstado
            // 
            this.btnNuevoEstado.Location = new System.Drawing.Point(389, 15);
            this.btnNuevoEstado.Name = "btnNuevoEstado";
            this.btnNuevoEstado.Size = new System.Drawing.Size(77, 27);
            this.btnNuevoEstado.TabIndex = 32;
            this.btnNuevoEstado.Text = "Nuevo";
            this.btnNuevoEstado.UseVisualStyleBackColor = true;
            // 
            // btnEditarEstado
            // 
            this.btnEditarEstado.Location = new System.Drawing.Point(389, 76);
            this.btnEditarEstado.Name = "btnEditarEstado";
            this.btnEditarEstado.Size = new System.Drawing.Size(77, 27);
            this.btnEditarEstado.TabIndex = 31;
            this.btnEditarEstado.Text = "Editar";
            this.btnEditarEstado.UseVisualStyleBackColor = true;
            this.btnEditarEstado.Click += new System.EventHandler(this.btnEditarEstado_Click);
            // 
            // btnLimpiarEstado
            // 
            this.btnLimpiarEstado.Location = new System.Drawing.Point(389, 133);
            this.btnLimpiarEstado.Name = "btnLimpiarEstado";
            this.btnLimpiarEstado.Size = new System.Drawing.Size(77, 27);
            this.btnLimpiarEstado.TabIndex = 30;
            this.btnLimpiarEstado.Text = "Limpiar";
            this.btnLimpiarEstado.UseVisualStyleBackColor = true;
            this.btnLimpiarEstado.Click += new System.EventHandler(this.btnLimpiarEstado_Click);
            // 
            // lsbEstado
            // 
            this.lsbEstado.FormattingEnabled = true;
            this.lsbEstado.ItemHeight = 15;
            this.lsbEstado.Location = new System.Drawing.Point(472, 15);
            this.lsbEstado.Name = "lsbEstado";
            this.lsbEstado.Size = new System.Drawing.Size(189, 154);
            this.lsbEstado.TabIndex = 29;
            this.lsbEstado.SelectedIndexChanged += new System.EventHandler(this.lsbEstado_SelectedIndexChanged);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.Location = new System.Drawing.Point(241, 133);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(77, 27);
            this.btnEliminarEstado.TabIndex = 28;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = true;
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // btnCancelarEstado
            // 
            this.btnCancelarEstado.Location = new System.Drawing.Point(128, 133);
            this.btnCancelarEstado.Name = "btnCancelarEstado";
            this.btnCancelarEstado.Size = new System.Drawing.Size(77, 27);
            this.btnCancelarEstado.TabIndex = 27;
            this.btnCancelarEstado.Text = "Cancelar";
            this.btnCancelarEstado.UseVisualStyleBackColor = true;
            this.btnCancelarEstado.Click += new System.EventHandler(this.btnCancelarEstado_Click);
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.Location = new System.Drawing.Point(16, 133);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(77, 27);
            this.btnGuardarEstado.TabIndex = 26;
            this.btnGuardarEstado.Text = "Guardar";
            this.btnGuardarEstado.UseVisualStyleBackColor = true;
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click);
            // 
            // txtDescripcionEstado
            // 
            this.txtDescripcionEstado.Location = new System.Drawing.Point(91, 85);
            this.txtDescripcionEstado.Name = "txtDescripcionEstado";
            this.txtDescripcionEstado.Size = new System.Drawing.Size(156, 23);
            this.txtDescripcionEstado.TabIndex = 25;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(91, 41);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(156, 23);
            this.txtEstado.TabIndex = 24;
            // 
            // lblDescripcionEstado
            // 
            this.lblDescripcionEstado.AutoSize = true;
            this.lblDescripcionEstado.Location = new System.Drawing.Point(16, 88);
            this.lblDescripcionEstado.Name = "lblDescripcionEstado";
            this.lblDescripcionEstado.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcionEstado.TabIndex = 23;
            this.lblDescripcionEstado.Text = "Descripcion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 44);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(28, 15);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Pais";
            // 
            // frmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 192);
            this.Controls.Add(this.btnNuevoEstado);
            this.Controls.Add(this.btnEditarEstado);
            this.Controls.Add(this.btnLimpiarEstado);
            this.Controls.Add(this.lsbEstado);
            this.Controls.Add(this.btnEliminarEstado);
            this.Controls.Add(this.btnCancelarEstado);
            this.Controls.Add(this.btnGuardarEstado);
            this.Controls.Add(this.txtDescripcionEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblDescripcionEstado);
            this.Controls.Add(this.lblEstado);
            this.Name = "frmEstado";
            this.Text = "frmEstado";
            this.Load += new System.EventHandler(this.frmEstado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoEstado;
        private System.Windows.Forms.Button btnEditarEstado;
        private System.Windows.Forms.Button btnLimpiarEstado;
        private System.Windows.Forms.ListBox lsbEstado;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnCancelarEstado;
        private System.Windows.Forms.Button btnGuardarEstado;
        private System.Windows.Forms.TextBox txtDescripcionEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblDescripcionEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}