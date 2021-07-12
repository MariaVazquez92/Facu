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
    public partial class Marca : Form
    {
        protected enum Accion { Nuevo, Editar, Eliminar, Ninguno }

        Accion accionBoton;
        public Marca()
        {
            InitializeComponent();
        }

        private void Marca_Load(object sender, EventArgs e)
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
            txtMarca.Enabled = false;
            txtDescripcion.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtMarca.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            bool ban = new bool();
            ban = false;

            Marca marca= new Marca(txtMarca.Text, txtDescripcion.Text);
            try
            {
                if (accionBoton == Accion.Nuevo)
                {
                    ban = Marca.AgregarMarca(marca);
                    if (ban)
                    {
                        MessageBox.Show($"La marca{marca.txtMarca}fue agregada");
                    }
                }

                ActualizarMarca();

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
            lsbMarca.DataSource = null;
            lsbMarca.DataSource = frmPais.ObtenerMarcaLista();
        }

        private void LimpiarCampos()
        {
            txtMarca.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnLimpiarMarca_Click(object sender, EventArgs e)
        {
            if (accionBoton == Accion.Nuevo)
            {
                LimpiarCampos();
            }
        }

        private void lsbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbMarca.SelectedItem != null)
            {
                var marca = new Marca();
                marca = (Marca)lsbMarca.SelectedItem;
                txtMarca.Text = marca.Id.ToString();
            }
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (lsbEstado.SelectedItem != null && txtDescripcionEstado.Text != "")
            {
                HabilitarCampos();
                accionBoton = Accion.Editar;
            }
        }
    }
}
