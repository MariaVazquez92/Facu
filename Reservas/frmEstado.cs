using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmEstado : Form
    {
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;
        public frmEstado()
        {
            InitializeComponent();
        }

        private void frmEstado_Load(object sender, EventArgs e)
        {
            try
            {
                InhabilitarCampos();
                ActualizarAlumnos();
            }
            catch (SqlException esql)
            {
                MessageBox.Show("Ha ocurrido un error con la Base de Datos. Favor verifique" + esql.Message + " " +
                    esql.Source);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message + " " +
                    ex.Source);
            }
        }
        private void InhabilitarCampos()
        {
            txtEstado.Enabled = false;
            txtDescripcionEstado.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtEstado.Enabled = true;
            txtDescripcionEstado.Enabled = true;
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            frmEstado estado= new frmEstado(txtEstado.Text, txtDescripcionEstado.Text);
            try
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = frmEstado.AgregarEstado(estado);
                    if (ban)
                    {
                        MessageBox.Show($"El estado{estado.txtEstado}fue agregado");
                    }
                }

                ActualizarEstado();

            }
            catch (SqlException esql)
            {
                MessageBox.Show("Ha ocurrido un error con la Base de Datos. Favor verifique" + esql.Message + " " +
                    esql.Source);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message + " " +
                    ex.Source);
            }

            LimpiarCampos();
            InhabilitarCampos();
        }
        private void ActualizarEstado()
        {
            lsbEstado.DataSource = null;
            lsbEstado.DataSource = frmPais.ObtenerEstadoLista();
        }
        private void LimpiarCampos()
        {
            txtEstado.Text = "";
            txtDescripcionEstado.Text = "";
        }

        private void btnLimpiarEstado_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
        }

        private void lsbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbEstado.SelectedItem != null)
            {
                var estado = new frmEstado();
                estado = (frmEstado)lsbEstado.SelectedItem;
                txtEstado.Text = estado.Id.ToString();
            }
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            if (lsbEstado.SelectedItem != null && txtDescripcionEstado.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            if (lsbEstado.SelectedItem != null && txtEstado.Text != "")
            {
                short Id = Convert.ToInt16(txtEstado.Text);
                frmPais.EliminarEstado(Id);
            }
            else
            {
                MessageBox.Show("Seleccione estado a eliminar");
            }

            ActualizarEstado();
            LimpiarCampos();
        }

        private void btnCancelarEstado_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
    }
}
