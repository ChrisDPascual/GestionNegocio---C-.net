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
    public partial class FRMComprarProducto : Form
    {
        private Duenio duenio;
        private int codigo;

        public FRMComprarProducto(Duenio duenio, int codigo)
        {
            this.duenio = duenio;
            this.codigo = codigo;
            InitializeComponent();
            this.RBMostrarProducto.Text = this.duenio.MostrarUnProducto(duenio, codigo);
            this.CBoxProveedores.Items.Add("Dunder Mifflin");
            this.CBoxProveedores.Items.Add("Compu mundo hiper mega red");
            this.CBoxProveedores.Items.Add("Soluciones tecnologicas");
            this.CBoxProveedores.Items.Add("El rincon gamer");
            this.CBoxProveedores.Items.Add("Mercado tecno");

        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTComprar_Click(object sender, EventArgs e)
        {
            string proveedor;
            string respuesta;
            int cantidad;

            cantidad = Convert.ToInt32(this.NUpStock.Value);
            proveedor = this.CBoxProveedores.Text;
            if(!(string.IsNullOrEmpty(proveedor))&& cantidad >0) 
            {
                respuesta = Convert.ToString(MessageBox.Show("Desea realizar la compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (respuesta == "Yes")
                {
                    if (this.duenio.ComprarProducto(this.duenio, this.codigo, cantidad))
                    {
                        MessageBox.Show("Se compro exitosamente la mercaderia");
                        this.RBMostrarProducto.Text = this.duenio.MostrarUnProducto(this.duenio, this.codigo);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo comprar");
                    }
                }
            }
            else 
            {
                MessageBox.Show("Seleccione un provedor y la cantidad a comprar");
            }
            
        }
    }
}
