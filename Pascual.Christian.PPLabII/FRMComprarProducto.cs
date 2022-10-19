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
        private Proveedor prov1;
        private Proveedor prov2;
        private bool modo;
        private string nombreProv;

        public FRMComprarProducto(Duenio duenio, Proveedor p1, Proveedor p2, int codigo)
        {
            this.nombreProv = string.Empty;
            this.duenio = duenio;
            this.codigo = codigo;
            this.prov1 = p1;
            this.prov2 = p2;
            nombreProv = prov1.buscarNombreProveedor(codigo);

            InitializeComponent();
            this.RBMostrarProducto.Text = this.duenio.MostrarUnProducto(duenio, codigo);

            if(!(string.IsNullOrEmpty(nombreProv)))
            {
                this.CBoxProveedores.Items.Add(nombreProv);
                this.modo = true;
            }
            else 
            {
                nombreProv = prov2.buscarNombreProveedor(codigo);
                if (!(string.IsNullOrEmpty(nombreProv))) 
                {
                    this.CBoxProveedores.Items.Add(nombreProv);
                    this.modo = true;
                }
                else 
                {
                    this.CBoxProveedores.Items.Add("Otro");
                    this.modo = false;
                }
                   
            }
     

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
                    if (this.modo == true)
                    {
                        if (this.duenio.ComprarProductoProv(this.duenio, prov1, this.codigo, cantidad) || this.duenio.ComprarProductoProv(this.duenio, prov2, this.codigo, cantidad))
                        {
                            MessageBox.Show("Se compro exitosamente la mercaderia");
                            this.RBMostrarProducto.Text = this.duenio.MostrarUnProducto(this.duenio, this.codigo);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo comprar");
                        }
                    }
                    else 
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
            }
            else 
            {
                MessageBox.Show("Seleccione un provedor y la cantidad a comprar");
            }
            
        }
    }
}
