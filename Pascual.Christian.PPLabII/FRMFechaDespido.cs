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
    public partial class FRMFechaDespido : Form
    {
        private Duenio duenio;
        private Vendedor vendedor;
        public FRMFechaDespido(Duenio duenio, Vendedor vendedor)
        {
            this.duenio = duenio;
            this.vendedor = vendedor;
            InitializeComponent();
            this.TxBoxLegajo.ReadOnly = true;
            this.TBoxFechaDespido.ReadOnly = true;
            this.TBoxInicioActiv.ReadOnly = true;

            this.TxBoxLegajo.Text = Convert.ToString(vendedor.GetLegajo);
            if(vendedor.GetSetFinActividades == new DateTime(1, 1, 1)) 
            {
                this.TBoxFechaDespido.Text = "sin fecha asignada";
            }
            else 
            {
                this.TBoxFechaDespido.Text = vendedor.GetSetFinActividades.ToString("dd/MM/yyyy");
            }
            this.TBoxInicioActiv.Text = vendedor.GetSetInicioActividades.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nuevaFechaDespido;
            int dia;
            int mes;
            int anio;
            string dato;

            dia = Convert.ToInt32(this.NUpDia.Value);
            mes = Convert.ToInt32(this.NUpMes.Value);
            dato = this.TBoxAnio.Text;

            if (!(int.TryParse(dato, out anio)))
            {
                anio = 1;
            }

            if (Validaciones.Validaciones.ValidarFecha(dia, mes, anio))
            {
                nuevaFechaDespido = new DateTime(anio, mes, dia);
                if (nuevaFechaDespido > this.vendedor.GetSetInicioActividades)
                {
                    this.vendedor.GetSetFinActividades = nuevaFechaDespido;
                    if (this.duenio.ModificarVendedor(this.duenio, this.vendedor, this.vendedor.GetLegajo))
                    {
                        MessageBox.Show("Se modificio la fecha de despido correctamente");
                        Dispose();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la fecha de despido");
                    }
                }
                else 
                {
                    MessageBox.Show("No puede la fecha de despido ser menor a la fecha de contratacion");
                }
            }
            else 
            {
                MessageBox.Show("Ingrese una fecha valida");
            }
        }
    }
}
