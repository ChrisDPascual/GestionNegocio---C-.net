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
    public partial class FRMProducto : Form
    {
        private Duenio duenio;
        private Mercaderia producto;
        private int codigo;
        private string[] dato;

        public FRMProducto(Duenio duenio, int codigo, bool valor)
        {
            this.duenio = duenio;
            InitializeComponent();
            string[] categorias = this.duenio.RetornarCategoria(duenio);
            for (int i = 0; i < categorias.Length; i++)
            {
                this.CBoxCategoria.Items.Add(categorias[i]);
            }
            this.CBoxTipo.Items.Add(eTipoMercaderia.Gaming);
            this.CBoxTipo.Items.Add(eTipoMercaderia.Diseño);
            this.CBoxTipo.Items.Add(eTipoMercaderia.Generico);
            if (valor == true)
            {
                this.codigo = codigo;
                this.producto = this.duenio.RetornarMercaderia(this.duenio, this.codigo);
                this.TBoxArticulo.Text = this.producto.GetSetArticulo;
                this.TBoxCodigo.Text = Convert.ToString(this.producto.GetCodigo);
                this.TBoxMarca.Text = this.producto.GetSetMarca;
                this.TBoxPrecio.Text = Convert.ToString(this.producto.GetSetPrecio);
                this.TBoxStock.Text = Convert.ToString(this.producto.GetSetStock);
                this.CBoxCategoria.Text = this.producto.GetSetCategoria;
                this.CBoxTipo.Text = Convert.ToString(this.producto.GetSetTipo);
                this.TBoxCodigo.Visible = valor;
            }
            else 
            {
                this.TBoxCodigo.Visible = valor;
                this.LbProducto.Visible = valor;
            }

        }

        public string[] GetSetDato
        {
            get { return this.dato; }
            set { this.dato = value; }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            GetSetDato = this.duenio.RetornarCategoria(duenio);
            Dispose();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            Mercaderia producto = new Mercaderia();
            string valor;
            string articulo = this.TBoxArticulo.Text;
            string marca = this.TBoxMarca.Text;
            float precio;
            int stock;
            int codigo;
            string categoria = this.CBoxCategoria.Text;
            string tipo = this.CBoxTipo.Text;
            eTipoMercaderia tipoMercaderia;

            if(float.TryParse(this.TBoxPrecio.Text, out precio) && (int.TryParse(this.TBoxStock.Text, out stock)))
            {
                valor = producto.ValidarDatosMercaderia(articulo, marca, categoria, tipo, precio, stock);
                if (string.IsNullOrWhiteSpace(valor)) 
                {
                    if (this.TBoxCodigo.Visible == true)
                    {
                        codigo = Convert.ToInt32(this.TBoxCodigo.Text);
                        tipoMercaderia = this.duenio.compararEtipoConString(tipo);
                        producto = new Mercaderia(articulo, marca, codigo, categoria, tipoMercaderia, precio, stock);

                        if (this.duenio.ModificarUnProducto(this.duenio, producto))
                        {
                            MessageBox.Show("Se modificio con exito");
                           
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el producto");
                        }
                    }
                    else 
                    {
                        tipoMercaderia = this.duenio.compararEtipoConString(tipo);
                        codigo = this.duenio.GenerarCodigo(this.duenio);
                        producto = new Mercaderia(articulo, marca, codigo, categoria, tipoMercaderia, precio, stock);
                        if (this.duenio + producto) 
                        {
                            MessageBox.Show("Se creo con exito");
                            this.TBoxArticulo.Clear();
                            this.TBoxMarca.Clear();
                            this.TBoxPrecio.Clear();
                            this.TBoxStock.Clear();
                            this.CBoxCategoria.Items.Clear();
                            string[] categorias = this.duenio.RetornarCategoria(duenio);
                            for (int i = 0; i < categorias.Length; i++)
                            {
                                this.CBoxCategoria.Items.Add(categorias[i]);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el producto");
                        }
                    }
                }
                else 
                {
                    MessageBox.Show($"{valor}");
                }
            }
            else 
            {
                MessageBox.Show("Ingrese el precio  y stock");
            }


        }
    }
}
