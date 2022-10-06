using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Organizacion;

namespace Pascual.Christian.PPLabII
{
    public partial class FRMAdministrarEmpleados : Form
    {
        private Duenio duenio;
        public FRMAdministrarEmpleados(Duenio d)
        {
            InitializeComponent();
            this.duenio = new Duenio();
            duenio = d;
            this.CBoxFiltro.Items.Add("activo");
            this.CBoxFiltro.Items.Add("despedido");
            this.CBoxFiltro.Items.Add("todos");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTFiltroBusqueda_Click(object sender, EventArgs e)
        {
            string opcion;

            opcion = this.CBoxFiltro.Text;

            this.RBListaEmpleados.Clear();

            if (!(string.IsNullOrWhiteSpace(opcion)))
            {
                this.RBListaEmpleados.Text = this.duenio.MostrarEmpleados(opcion, this.duenio);
               
            }
            else
            {
                MessageBox.Show("Seleccione un filtro");
            }
        }

        private void BTSeleccionar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(this.TxtBoxLegajo.Text, out numero))
            {

              if (numero > 999 && numero < 9999)
              {
                    this.RBListaEmpleados.Text = this.duenio.MostrarUnEmpleado(numero, this.duenio);
                    if (string.IsNullOrWhiteSpace(this.RBListaEmpleados.Text))
                    {
                        MessageBox.Show("Legajo inexistente");
                    }
                }
              else
              {
                MessageBox.Show("Ingrese un numero entre 1000 y 9998");
              }
            }
            else 
            {
                MessageBox.Show("Ingrese un numero");
            }
        }

        private void BTNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FRMDatosEmpleado datosEmpleado = new FRMDatosEmpleado(this.duenio,false);
            datosEmpleado.ShowDialog();


        }

        private void BTModificarEmpleado_Click(object sender, EventArgs e)
        {
            FRMDatosEmpleado datosEmpleado = new FRMDatosEmpleado(this.duenio, true);
            datosEmpleado.ShowDialog();
        }

        private void BTBorrarEmpleado_Click(object sender, EventArgs e)
        {
            FRMEliminarEmpleado eliminarEmpleado = new FRMEliminarEmpleado(this.duenio);
            eliminarEmpleado.ShowDialog();
        }
    }
}
