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
    public partial class frmCiudad : Form
    {
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;
        public frmCiudad()
        {
            InitializeComponent();
        }

        private void frmCiudad_Load(object sender, EventArgs e)
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
            txtCiudad.Enabled = false;
            txtDescripcion.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtCiudad.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void btnGuardarCiudad_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            frmCiudad ciudad = new Ciudad(txtCiudad.Text, txtDescripcion.Text, "");
            try
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = frmCiudad.AgregarCiudad(ciudad);
                    if (ban)
                    {
                        MessageBox.Show($"La ciudad{ciudad.txtCiudad}fue agregado");
                    }
                }

                ActualizarCiudad();

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
        private void ActualizarCiudad()
        {
            lsbCiudad.DataSource = null;
            lsbCiudad.DataSource = frmCiudad.ObtenerCiudadLista();
        }
        private void LimpiarCampos()
        {
            txtCiudad.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnLimpiarCiudad_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
        }

        private void lsbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbCiudad.SelectedItem != null)
            {
                var pais = new frmPais();
                pais = (frmPais)lsbCiudad.SelectedItem;
                txtCiudad.Text = pais.Id.ToString();
            }
        }

        private void btnEditarCiudad_Click(object sender, EventArgs e)
        {
            if (lsbCiudad.SelectedItem != null && txtDescripcion.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            if (lsbCiudad.SelectedItem != null && txtCiudad.Text != "")
            {
                short Id = Convert.ToInt16(txtCiudad.Text);
                frmPais.EliminarCiudad(Id);
            }
            else
            {
                MessageBox.Show("Seleccione Ciudad a eliminar");
            }

            ActualizarCiudad();
            LimpiarCampos();
        }

        private void btnCancelarCiudad_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }
    }
}
