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
    public partial class FRMEliminarEmpleado : Form
    {
        private Duenio duenio;
        public FRMEliminarEmpleado(Duenio duenio)
        {
            this.duenio = duenio;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(this.TBoxLegajo.Text, out numero))
            {

                if (numero > 999 && numero < 9999)
                {
                    this.RTBoxDatosEmpleado.Text = this.duenio.MostrarUnEmpleado(numero, this.duenio);
                    if (string.IsNullOrWhiteSpace(this.RTBoxDatosEmpleado.Text))
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

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            string respuesta;
            int legajo;


            respuesta = Convert.ToString(MessageBox.Show("Desea borrar los datos del siguente empleado, luego no se podran recuperar","Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if(respuesta == "Yes" && int.TryParse(this.TBoxLegajo.Text, out legajo)) 
            {
                if (this.duenio.EliminarEmpleado(duenio, legajo))
                {
                    MessageBox.Show("Datos del empleado borrado exitosamente");
                    Dispose();
                }
                else 
                {
                    MessageBox.Show("Error no se pudo borrar el empleado");
                }
            }
            else 
            {
                Dispose();
            }
        }
    }
}
