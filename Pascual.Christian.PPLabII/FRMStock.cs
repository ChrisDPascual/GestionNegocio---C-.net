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
    public partial class FRMStock : Form
    {
        private Duenio duenio;
        private Proveedor prov1;
        private Proveedor prov2;
        public FRMStock(Duenio duenio, Proveedor p1, Proveedor p2)
        {
            
            this.duenio = duenio;
            string[] categorias = this.duenio.RetornarCategoria(duenio);
            this.prov1 = new Proveedor();
            this.prov1 = p1;
            this.prov2 = new Proveedor();
            this.prov2 = p2;
            InitializeComponent();
            this.CBoxFiltrarTipo.Items.Clear();
            this.CBoxFiltroCategoria.Items.Clear();
            
            for(int i = 0; i < categorias.Length; i++) 
            {
                this.CBoxFiltroCategoria.Items.Add(categorias[i]);
            }

            this.CBoxFiltrarTipo.Items.Add(eTipoMercaderia.Generico);
            this.CBoxFiltrarTipo.Items.Add(eTipoMercaderia.Gaming);
            this.CBoxFiltrarTipo.Items.Add(eTipoMercaderia.Diseño);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTBuscarPorCategoria_Click(object sender, EventArgs e)
        {
            string opcion;

            opcion = this.CBoxFiltroCategoria.Text;

            this.RTBoxListado.Clear();

            if (!(string.IsNullOrWhiteSpace(opcion)))
            {
                this.RTBoxListado.Text = this.duenio.MostrarProductosPorCategoria(this.duenio,opcion);

            }
            else
            {
                MessageBox.Show("Seleccione una categoria");
            }
        }

        private void BTBuscarPorTipo_Click(object sender, EventArgs e)
        {
            string opcion;

            opcion = this.CBoxFiltrarTipo.Text;

            this.RTBoxListado.Clear();

            if (!(string.IsNullOrWhiteSpace(opcion)))
            {
                this.RTBoxListado.Text = this.duenio.MostrarProductosPorTipo(this.duenio, opcion);

            }
            else
            {
                MessageBox.Show("Seleccione un tipo");
            }
        }

        private void BTBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            int codigo;
            string producto=  string.Empty;

            this.RTBoxListado.Clear();

            if (int.TryParse(this.TBoxBuscarPorCodigo.Text, out codigo))
            {
                producto = this.duenio.MostrarUnProducto(this.duenio, codigo);
                if (!(string.IsNullOrWhiteSpace(producto)))
                {
                    this.RTBoxListado.Text = producto;
                }
                else
                {
                    this.RTBoxListado.Text = ("El codigo ingresado no existe");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo;
            string producto = string.Empty;

            this.RTBoxListado.Clear();

            if (int.TryParse(this.TboxCodigoIngresado.Text, out codigo))
            {
                producto = this.duenio.MostrarUnProducto(this.duenio, codigo);
                if (!(string.IsNullOrWhiteSpace(producto)))
                {
                    this.RTBoxListado.Text = producto;
                    this.TboxCodigoIngresado.ReadOnly = true;
                }
                else
                {
                    this.RTBoxListado.Text = ("El codigo ingresado no existe");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un codigo valido");
            }
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            this.TboxCodigoIngresado.ReadOnly = false;
            this.TboxCodigoIngresado.Clear();
        }

        private void BTAdministrarCategorias_Click(object sender, EventArgs e)
        {

            FRMAdministrarCategorias administradorCategorias = new FRMAdministrarCategorias(this.duenio);

            if (administradorCategorias.ShowDialog() == DialogResult.OK)
            {
                string[] cadena = administradorCategorias.GetSetDato;
                if (!(cadena is null))
                {
                    this.CBoxFiltroCategoria.Items.Clear();
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        this.CBoxFiltroCategoria.Items.Add(cadena[i]);
                    }
                }

            }

        }

        private void BTModificarProducto_Click(object sender, EventArgs e)
        {
            int codigo;
            if(this.TboxCodigoIngresado.ReadOnly == true && int.TryParse(this.TboxCodigoIngresado.Text, out codigo)) 
            {
                FRMProducto datosProducto = new FRMProducto(this.duenio,codigo,true);
                if (datosProducto.ShowDialog() == DialogResult.OK)
                {
                    string[] cadena = datosProducto.GetSetDato;
                    if (!(cadena is null)) 
                    {
                        this.CBoxFiltroCategoria.Items.Clear();
                        for (int i = 0; i < cadena.Length; i++)
                        {
                            this.CBoxFiltroCategoria.Items.Add(cadena[i]);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Necesita ingresar un codigo valido para modificar un producto");
            }
        }

        private void BTCrearProducto_Click(object sender, EventArgs e)
        {
            FRMProducto nuevoProducto = new FRMProducto(this.duenio,0,false);

            if (nuevoProducto.ShowDialog() == DialogResult.OK)
            {
                string[] cadena = nuevoProducto.GetSetDato;
                if (!(cadena is null))
                {
                    this.CBoxFiltroCategoria.Items.Clear();
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        this.CBoxFiltroCategoria.Items.Add(cadena[i]);
                    }
                }

            }
        }

        private void BTComprarProducto_Click(object sender, EventArgs e)
        {
            int codigo;
            if (this.TboxCodigoIngresado.ReadOnly == true && int.TryParse(this.TboxCodigoIngresado.Text, out codigo))
            {
                FRMComprarProducto comprarProducto = new FRMComprarProducto(this.duenio,this.prov1,this.prov2, codigo);
                comprarProducto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Necesita ingresar un codigo valido para comprar");
            }

        }
    }
}
