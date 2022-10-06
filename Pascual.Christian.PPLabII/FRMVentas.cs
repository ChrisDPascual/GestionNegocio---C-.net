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
    public partial class FRMVentas : Form
    {
        private Duenio duenio;
        private Cliente unCliente;
        private List<Mercaderia> listado;
        public FRMVentas(Duenio duenio)
        {
            this.unCliente = new Cliente();
            this.duenio = duenio;
            this.listado = new List<Mercaderia>();
            InitializeComponent();
            this.TBoxLegajo.Text = Convert.ToString(this.duenio.GetLegajo);
            this.TBoxLegajo.ReadOnly = true;
            string[] categorias = this.duenio.RetornarCategoria(duenio);
            for (int i = 0; i < categorias.Length; i++)
            {
                this.CBoxCategoria.Items.Add(categorias[i]);
            }
            this.CBoxTipo.Items.Add(eTipoMercaderia.Generico);
            this.CBoxTipo.Items.Add(eTipoMercaderia.Gaming);
            this.CBoxTipo.Items.Add(eTipoMercaderia.Diseño);
        }

        public FRMVentas(Duenio duenio, string usuario):this(duenio)
        {
  
            this.TBoxLegajo.Text = Convert.ToString(this.duenio.RetonarLegajoUsuario(this.duenio,usuario));
            this.TBoxLegajo.ReadOnly = true;

        }
        private void BTVSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTOkFiltroCategoria_Click(object sender, EventArgs e)
        {
            string opcion;

            opcion = this.CBoxCategoria.Text;

            this.RTBoxListado.Clear();

            if (!(string.IsNullOrWhiteSpace(opcion)))
            {
                this.RTBoxListado.Text = this.duenio.MostrarProductosPorCategoria(this.duenio, opcion);

            }
            else
            {
                MessageBox.Show("Seleccione una categoria");
            }
        }

        private void BTFiltroTipo_Click(object sender, EventArgs e)
        {
            string opcion;

            opcion = this.CBoxTipo.Text;

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

        private void BTOkBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            int codigo;
            string producto = string.Empty;

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

      

        public void RefrescarListado(int codigo) 
        {
            this.RTBoxListado.Text = this.duenio.MostrarUnProducto(this.duenio, codigo);
            
        }

        public void InstanciarNuevoProducto(Mercaderia m, int stock) 
        {
            Mercaderia producto = new Mercaderia(m.GetSetArticulo, m.GetSetMarca, m.GetCodigo, m.GetSetCategoria, m.GetSetTipo, m.GetSetPrecio, stock);
            this.listado.Add(producto);
        }
    
        private void BTAgregar_Click(object sender, EventArgs e)
        {
            Mercaderia producto;
            int cantidad;
            int codigo;
            string cadena = string.Empty;
            float subtotal;
            float total = 0;

            if(!(float.TryParse(this.TBoxTotal.Text, out subtotal))) 
            {
                subtotal = 0;
            }
            else 
            {
                cadena = this.RTBoxFactura.Text;
            }
            if(this.NUpCantidad.Value> 0 && int.TryParse(this.TBoxProducto.Text, out codigo)) 
            {
                cantidad = Convert.ToInt32(this.NUpCantidad.Value);
                if (this.duenio.BuscarMercaderiaPorCodigo(this.duenio, codigo)) 
                {
                    total = this.duenio.PrecioProducto(this.duenio, codigo, cantidad);
                    producto = this.duenio.RetornarMercaderia(this.duenio, codigo);
                    cadena = this.duenio.AgregarProductoFacturacion(this.duenio, codigo, cantidad);

                    if (!(string.IsNullOrWhiteSpace(cadena)))
                    {
                        if(this.listado.Count == 0) 
                        {
                            InstanciarNuevoProducto(producto, cantidad);
                        }
                        else 
                        {
                            int bandera = 0;
                            int stock;
                            foreach(var item in this.listado) 
                            {
                                if(item == producto) 
                                {
                                    stock = item.GetSetStock;
                                    item.GetSetStock = stock + cantidad;
                                    bandera = 1;
                                    break;
                                }
                            }
                            if(bandera == 0) 
                            {
                                InstanciarNuevoProducto(producto, cantidad);
                            }
                            
                        }

                        if (subtotal == 0)
                        {
                            this.TBoxTotal.Text = Convert.ToString(Math.Round(total, 2));
                            this.RTBoxFactura.Text = cadena;
                           
                           
                        }
                        else
                        {
                            string cadena2 = this.RTBoxFactura.Text;
                            total = subtotal + total;
                            this.TBoxTotal.Text = Convert.ToString(Math.Round(total, 2));
                            this.RTBoxFactura.Text = string.Concat(cadena2, cadena);
                            

                        }
                        RefrescarListado(codigo);
                        this.NUpCantidad.Value = 0;

                    }
                    else 
                    {
                        MessageBox.Show("no hay stock suficiente");
                    }

                }
                else 
                {
                    MessageBox.Show("El codigo ingresado no existe");
                }
            }
            else 
            {
                MessageBox.Show("Ingrese una cantidad mayor a cero");
            }

        }


        private void BTQuitar_Click(object sender, EventArgs e)
        {
            int cantidad;
            int codigo;
            string cadena = string.Empty;
            float subtotal;
            float total = 0;
            int bandera = 0;
            int control = 0;
            int stock;


            if (this.listado.Count > 0) 
            {
                foreach(var item in this.listado) 
                {
                    if(item.GetSetStock == 0) 
                    {
                        control++;
                    }
                }
                if (control < this.listado.Count)
                {
                    if (this.NUpCantidad.Value > 0 && int.TryParse(this.TBoxProducto.Text, out codigo))
                    {
                        float precio;
                        cantidad = Convert.ToInt32(this.NUpCantidad.Value);
                        foreach (var item in this.listado)
                        {
                            if (item.GetCodigo == codigo)
                            {
                                if (item.GetSetStock >= cantidad)
                                {
                                    cadena = this.duenio.QuitarProductoFacturacion(this.listado, codigo, cantidad);
                                    stock = item.GetSetStock;
                                    item.GetSetStock = stock - cantidad;
                                    precio = item.GetSetPrecio;
                                    total = precio * cantidad;
                                    bandera = 2;
                                    break;
                                }

                                bandera = 1;
                                break;
                            }
                        }

                        switch (bandera)
                        {
                            case 0:
                                MessageBox.Show("EL codigo ingresado es incorrecto");
                                break;
                            case 1:
                                MessageBox.Show("La cantidad a descontar es mayor de lo que corresponde");
                                break;
                            case 2:
                                if (this.duenio.ComprarProducto(this.duenio, codigo, cantidad))
                                {
                                    if (float.TryParse(this.TBoxTotal.Text, out subtotal))
                                    {
                                        float diferencia;
                                        string cadena2;
                                        diferencia = subtotal - total;
                                        cadena2 = this.RTBoxFactura.Text;
                                        this.TBoxTotal.Text = Convert.ToString(Math.Round(diferencia, 2));
                                        this.RTBoxFactura.Text = string.Concat(cadena2, cadena);
                                    }
                                    RefrescarListado(codigo);
                                    this.NUpCantidad.Value = 0;

                                }
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad mayor a cero");
                    }
                }
                else 
                {
                    MessageBox.Show("Ya se quitaron todos los productos");
                }
            }
            else 
            {
                MessageBox.Show("No hay productos para quitar");
            }
      
        }

        private void RBTClienteGenerico_CheckedChanged(object sender, EventArgs e)
        {
            this.TBoxDNICliente.Text = "11111111";
        }

        private void BTBuscarDNI_Click(object sender, EventArgs e)
        {
            long DNI;
            string respuesta;


            if (long.TryParse(this.TBoxDNICliente.Text, out DNI))
            {
                if (this.unCliente.BuscarClienteDNI(this.duenio, DNI)) 
                {
                    this.TBoxDNICliente.ReadOnly = true;
                    FRMDatosClienteEncontrado datosClienteEncontrado = new FRMDatosClienteEncontrado(this.duenio, DNI);
                    datosClienteEncontrado.ShowDialog();
                }
                else
                {
                    if ((DNI > 99999999 || DNI < 99999) && !(string.IsNullOrWhiteSpace(this.TBoxDNICliente.Text)))
                    {
                        MessageBox.Show("Ingrese un DNI valido");
                    }
                    else 
                    {
                        respuesta = Convert.ToString(MessageBox.Show($"El cliente no se encuentra registrado, desea añadirlo a la base de datos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if(respuesta == "Yes") 
                        {
                            this.TBoxDNICliente.ReadOnly = true;
                            FRMCliente nuevoCliente = new FRMCliente(this.duenio,this.TBoxDNICliente.Text);
                            nuevoCliente.ShowDialog();
                        }

                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.TBoxEfectivo.ReadOnly = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.TBoxEfectivo.Clear();
            this.TBoxEfectivo.ReadOnly = true;
        }

        public void LimpiarDatos() 
        {
            
            this.TBoxDNICliente.ReadOnly = false;
            this.TBoxDNICliente.Text = string.Empty;
            this.TBoxProducto.Clear();
            this.TBoxBuscarPorCodigo.Clear();
            this.RTBoxFactura.Clear();
            this.RTBoxListado.Clear();
            this.TBoxEfectivo.Clear();
            this.TBoxTotal.Clear();
            this.TBoxVuelto.Clear();
            this.NUpCantidad.Value = 0;
            this.listado.Clear();
            this.RBTClienteGenerico.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.TBoxEfectivo.Clear();
            this.TBoxEfectivo.ReadOnly = true;
        }
        public string GenerarFactura(Duenio d, string dni, string cadena, float monto)
        {
            StringBuilder factura = new StringBuilder();
            Cliente datos;
            long DNI;
            
            if (long.TryParse(dni, out DNI)) 
            { 
              if (this.unCliente.BuscarClienteDNI(d, DNI) && !(string.IsNullOrWhiteSpace(cadena)))
              {
                datos = this.unCliente.RetornarUnCliente(d, DNI);
                factura.AppendLine($"Factura\t fecha:{DateTime.Now}");
                factura.AppendLine($"Cliente {datos.GetSetNombre} {datos.GetSetApellido} DNI: {DNI}");
                factura.AppendLine(cadena);
                factura.AppendLine($"\nTotal: ${Math.Round(monto, 2)}\n");

              } 
            }

            return factura.ToString();
        }

        private void BTPagar_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            float total;
            float pago;
            float vuelto;
            string compra;
            float recargo;
            bool verificar;
            int nroFactura= 0;

            if (float.TryParse(this.TBoxTotal.Text, out total)) 
            {
                if (this.TBoxDNICliente.ReadOnly == true)
                {
                    if (this.RBEfectivo.Checked)
                    {
                        bandera = 1;
                        if (float.TryParse(this.TBoxEfectivo.Text, out pago))
                        {
                            if (pago > total || pago == total)
                            {
                                vuelto = pago - total;
                                this.TBoxVuelto.Text = Convert.ToString(Math.Round(vuelto, 2));
                                compra = this.RTBoxFactura.Text;
                                MessageBox.Show(GenerarFactura(this.duenio, this.TBoxDNICliente.Text, compra, total));
                                this.duenio.GenerarNroFactura(this.duenio);
                                foreach (var item in this.listado)
                                {
                                    Ventas unaVenta = new Ventas(item.GetSetArticulo, item.GetSetCategoria, item.GetSetPrecio, item.GetSetStock, nroFactura);
                                    verificar = this.duenio + unaVenta;

                                }
                                LimpiarDatos();

                            }
                            else
                            {
                                MessageBox.Show("Saldo insuficiente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingese un monto valido");
                        }

                    }

                    if (this.RBCredito.Checked)
                    {
                        bandera = 1;
                        
                        compra = this.RTBoxFactura.Text;
                        recargo = (total * 10 / 100) + total;
                        MessageBox.Show(GenerarFactura(this.duenio, this.TBoxDNICliente.Text, compra, recargo));
                        this.duenio.GenerarNroFactura(this.duenio);
                        foreach (var item in this.listado)
                        {
                            Ventas unaVenta = new Ventas(item.GetSetArticulo, item.GetSetCategoria, item.GetSetPrecio, item.GetSetStock, nroFactura);
                            verificar = this.duenio + unaVenta;

                        }
                        LimpiarDatos();
                    }

                    if (this.RBDebito.Checked)
                    {
                        bandera = 1;
                        compra = this.RTBoxFactura.Text;
                        MessageBox.Show(GenerarFactura(this.duenio, this.TBoxDNICliente.Text, compra, total));
                        this.duenio.GenerarNroFactura(this.duenio);
                        foreach (var item in this.listado)
                        {
                            Ventas unaVenta = new Ventas(item.GetSetArticulo, item.GetSetCategoria, item.GetSetPrecio, item.GetSetStock, nroFactura);
                            verificar = this.duenio + unaVenta;

                        }

                        LimpiarDatos();
                    }

                    if (bandera == 0)
                    {
                        MessageBox.Show("Elija el medio de pago");
                    }
                }
                else 
                {
                    MessageBox.Show("Cargue el cliente");
                }
            }
            else
            {
                MessageBox.Show("No hay monto para pagar");
            }
        }
    }
}
