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
    public partial class frmPais : Form
    {
      
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;
        public frmPais()
        {
            InitializeComponent();
        }


        private void Pais_Load(object sender, EventArgs e)
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
            txtPais.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtPais.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            frmPais paises = new Pais(txtPais.Text,txtDescripcion.Text,"");
            try
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = frmPais.AgregarPais(paises);
                    if (ban)
                    {
                        MessageBox.Show($"El pais{paises.txtPais}fue agregado");
                    }
                }

                ActualizarPaises();

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
        private void ActualizarAlumnos()
        {
            lsbPaises.DataSource = null;
            lsbPaises.DataSource = frmPais.ObtenerPaisLista();
        }

        private void LimpiarCampos()
        {
            txtPais.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
        }

        private void lsbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbPaises.SelectedItem != null)
            {
                var pais = new frmPais();
                pais = (frmPais)lsbPaises.SelectedItem;
                txtPais.Text = pais.Id.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lsbPaises.SelectedItem != null && txtDescripcion.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lsbPaises.SelectedItem != null && txtPais.Text != "")
            {
                short Id = Convert.ToInt16(txtPais.Text);
                frmPais.EliminarPais(Id);
            }
            else
            {
                MessageBox.Show("Seleccione Pais a eliminar");
            }

            ActualizarAlumnos();
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InhabilitarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
