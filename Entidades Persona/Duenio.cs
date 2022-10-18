using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Entidades_Organizacion
{
    public class Duenio : Organizacion
    {
        #region "Atributos"
        protected int legajo;
        protected List<Ventas> listaDeVentas;
        private List<Vendedor> listaVendedores;
        protected List<Cliente> listaClientes;
        protected List<Mercaderia> listaMercaderia; 
        protected string usuario;
        protected string contraseña;

        #endregion

        #region "Constructores"
        public Duenio() : base() 
        {

        }
        public Duenio(string nombre, string apellido, long dni, string genero,int legajo, DateTime fecha) : base(nombre, apellido, dni, genero, fecha)
        {
            this.listaDeVentas = new List<Ventas>();
            this.listaVendedores = new List<Vendedor>();
            this.listaClientes = new List<Cliente>();
            this.listaMercaderia = new List<Mercaderia>();
            this.legajo = legajo;
            this.contraseña = CrearContraseña(nombre, apellido, dni);
            this.usuario = CrearUsuario(nombre, apellido);
        }
        public Duenio(string nombre, string apellido, long dni, string genero, DateTime fecha) : base(nombre, apellido, dni, genero, fecha)
        {
            this.legajo = GenerarLegajo(GetLista);
            this.contraseña = CrearContraseña(nombre, apellido, this.GetSetDNI);
            this.usuario = CrearUsuario(nombre,apellido);
        }
        #endregion

        #region "Geters y Setter"
        public List<Cliente> GetSetListadoClientes 
        {
            get { return this.listaClientes; }
        }
        public List<Mercaderia> GetListaMercaderia 
        {
            get {return this.listaMercaderia; }
        }
        public List<Vendedor> GetLista
        {
            get {return this.listaVendedores; }
        }
        public string GetUsuario
        {
            get { return this.usuario; }
        }
        public int GetLegajo
        {
            get { return this.legajo; }
        }

        public string GetContraseña
        {
            get { return this.contraseña; }
        }
        #endregion

        #region "Sobrecarga"
        public static bool operator +(Duenio d, Cliente c)
        {
            bool retorno = false;
            int bandera = 0;

            if (!(d is null || c is null))
            {
                foreach (var item in d.listaClientes)
                {
                    if (item == c)
                    {
                        bandera = 1;
                        break;
                    }
                }
            }
            if (bandera == 0)
            {
                d.listaClientes.Add(c);
                retorno = true;
            }

            return retorno;
        }


        public static bool operator +(Duenio d, Vendedor v)
        {
            bool retorno = false;
            int bandera = 0;

            if (!(d is null || v is null))
            {
                foreach (var item in d.listaVendedores)
                {
                    if (item == v)
                    {
                        bandera = 1;
                        break;
                    }
                }
            }
            if (bandera == 0)
            {
                d.listaVendedores.Add(v);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator +(Duenio d, Ventas venta)
        {
            bool retorno = false;

            if (!(d is null || venta is null))
            {         
                d.listaDeVentas.Add(venta);
                retorno = true;
            }     

            return retorno;
        }

        public static bool operator +(Duenio d, Mercaderia m)
        {
            bool validacion = false;
            int bandera = 0;


            if (!(d is null || m is null))
            {
                foreach (var item in d.GetListaMercaderia)
                {
                    if (item == m)
                    {
                        bandera = 1;
                        break;
                    }
                }
            }

            if (bandera == 0)
            {
                d.listaMercaderia.Add(m);
                validacion = true;
            }

            return validacion;
        }

        public static bool operator -(Duenio d, Mercaderia m)
        {
            bool validacion = false;
            int contador = 0;

            if (!(d is null || m is null))
            {
                foreach (var item in d.GetListaMercaderia)
                {
                    contador++;
                    if (item == m)
                    {
                        d.listaMercaderia.RemoveAt(contador);
                        validacion = true;
                        break;
                    }
                }
            }

            return validacion;
        }
        #endregion

        #region "Metodos de administracion de vendedores"
        protected int GenerarLegajo(List<Vendedor>lista) 
        {
            Random numeroRandom = new Random();
            int numero = 0;
            do
            {
                if (lista is null)
                {
                    numero = Convert.ToInt32(numeroRandom.Next(1000, 9998));
                }
                else
                {
                    numero = Convert.ToInt32(numeroRandom.Next(1000, 9998));
                    foreach (var item in lista)
                    {
                        if (numero == item.GetLegajo)
                        {
                            numero = 0;
                            break;
                        }
                    }
                }
            } while (numero == 0);

            return numero;
        } 

        public bool VerificarUsuarioJefe(Duenio d, string usuario, string contraseña) 
        {
            bool validacion = false;

            if(!(d is null) && Validaciones.Validaciones.ValidarNombres(usuario) && Validaciones.Validaciones.ValidarNombres(contraseña)) 
            {
                if(usuario == GetUsuario && contraseña == GetContraseña) 
                {
                    validacion = true;
                }
            }
            return validacion;

        }

        public bool EliminarEmpleado(Duenio d, int legajo)
        {
            bool validacion = false;

            if (!(d is null) && legajo > 0)
            {
                foreach (var item in d.listaVendedores)
                {
                    if (legajo == item.GetLegajo)
                    {
                        d.listaVendedores.Remove(item);
                        validacion = true;
                        break;
                    }
                }
            }

            return validacion;
        }

        public bool FechaDespido(Duenio d, int legajo, DateTime fecha)
        {
            bool validacion = false;
            if (!(d is null) || legajo < 0 || fecha > DateTime.Now)
            {
                foreach (var item in d.listaVendedores)
                {
                    if (legajo == item.GetLegajo)
                    {
                        validacion = true;
                        item.GetSetFinActividades = fecha;
                        item.GetSetEstado = "despedido";
                        break;
                    }
                }
            }
            return validacion;
        }
        public bool ModificarVendedor(Duenio d, string nombre, string apellido, string genero, DateTime fechaNac, long telefono, string email, string domicilio, string estado, int legajo)
        {
            bool validacion = false;

            if (!(d is null) && legajo > 0)
            {
                foreach (var item in d.listaVendedores)
                {
                    if (legajo == item.GetLegajo)
                    {
                        item.nombre = nombre;
                        item.apellido = apellido;
                        item.genero = genero;
                        item.fechaNacimiento = fechaNac;
                        item.telefono = telefono;
                        item.email = email;
                        item.domicilio = domicilio;
                        item.GetSetEstado = estado;
                        validacion = true;
                        break;
                    }
                }
            }

            return validacion;
        }



        public int RetonarLegajoUsuario(Duenio d, string usuario)
        {
            int legajo = 0;

            if (!(d is null || string.IsNullOrWhiteSpace(usuario)))
            {
                foreach (var item in d.listaVendedores)
                {
                    if (item.GetUsuario == usuario)
                    {
                        legajo = item.GetLegajo;
                        break;
                    }
                }
            }

            return legajo;
        }
        #endregion

        #region "Login"
        protected string CrearUsuario(string nombre,string apellido) 
        {
            string usuario = string.Empty;


            if(!(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))) 
            {
               usuario = char.ToUpper(nombre[0]) + nombre.Substring(1) + char.ToUpper(apellido[0]) + apellido.Substring(1);
            }

            return usuario;
        }
      
        protected string CrearContraseña(string nombre, string apellido, long dni) 
        {
            string contraseña = string.Empty;

            if (legajo>0 || (!(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))))
            {
                contraseña = string.Concat(nombre[0], apellido[0]);

                contraseña = contraseña.ToUpper();

                contraseña = string.Concat(contraseña, Convert.ToString(dni));
            }

            return contraseña;
        }

        public bool validarUsuarioVendedor(Duenio d, string usuario)
        {
            bool validacion = false;


            if (!(d is null)  || !(string.IsNullOrWhiteSpace(usuario)))
            {
                
                foreach (var item in d.listaVendedores) 
                {
                    if (usuario == item.GetUsuario && item.GetSetEstado == "activo")
                    {
                        validacion = true;
                        break;
 
                    }
                }
            }

            return validacion;
        }

        public bool ValidarContraseñaVendedor(Duenio d, string usuario)
        {
            bool validacion = false;
            if (!(d is null)  || !(string.IsNullOrWhiteSpace(usuario)))
            {

                foreach (var item in d.listaVendedores)
                {
                    if (usuario == item.GetContraseña)
                    {
                        validacion = true;
                        break;
                    }
                }
            }
            return validacion;
        }

        public bool ValidarLogin(Duenio d, string usuario, string contraseña)
        {
            bool validacion = false;
            if (!(d is null)  || !(string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))) 
            { 
                if (validarUsuarioVendedor(d, usuario) && ValidarContraseñaVendedor(d, contraseña))
                {
                    validacion = true;
                }
            }

            return validacion;
        }
        #endregion

        #region "Administrar mercaderia"
        /// <summary>
        /// Lo q hace
        /// </summary>
        /// <param name="d"></param> La lista de mercaderia
        /// <param name="m"></param> mercaderia que tengo actualmente
        /// <returns></returns> retorna el codigo creado 
        protected int CreacionCodigoMercaderia(Duenio d, Mercaderia m) 
        {
            int codigo = 0;
            Random numeroAletorio = new Random();

            if(!(d is null || m is null)) 
            {
                if(d.listaMercaderia is null) 
                {
                    codigo = numeroAletorio.Next(1000000, 2000000);
                }
                else 
                {
                    do
                    {
                        codigo = numeroAletorio.Next(1000000, 2000000);
                        foreach (var item in d.listaMercaderia)
                        {
                            if (codigo == item.GetCodigo)
                            {
                                codigo = 0;
                                break;
                            }
                        }
                    } while (codigo == 0);
                }
            }

            return codigo;
        }
        public bool BuscarMercaderiaPorCodigo(Duenio d, int codigo)
        {
            bool validacion = false;

            if (!(d is null) || codigo >0) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(item.GetCodigo == codigo) 
                    {
                        validacion = true;
                        break;
                    }
                }
            }
            return validacion;
        }
        public string MostrarProductosPorTipo(Duenio d, string filtro) 
        {
            StringBuilder cadena = new StringBuilder();

            if(!(d is null || filtro is null)) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if (filtro == Convert.ToString(item.GetSetTipo))
                    {
                        cadena.Append(MostrarUnProducto(d, item.GetCodigo));
                        cadena.AppendLine();
                        cadena.AppendLine();

                    }
                }

            }

            return Convert.ToString(cadena);
        }

        public string MostrarProductosPorCategoria(Duenio d, string filtro)
        {
            StringBuilder cadena = new StringBuilder();


            if (!(d is null || filtro is null))
            {
                foreach (var item in d.listaMercaderia)
                {
                    if (filtro == item.GetSetCategoria)
                    {
                        cadena.Append(MostrarUnProducto(d, item.GetCodigo));
                        cadena.AppendLine();
                        cadena.AppendLine();


                    }
                }

            }

            return Convert.ToString(cadena);
        }

        public string MostrarUnProducto(Duenio d, int codigo) 
        {
            StringBuilder cadena = new StringBuilder();
            int bandera = 0;

            if (BuscarMercaderiaPorCodigo(d, codigo)) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if (item.GetCodigo == codigo)
                    {
                        cadena.Append($"Articulo: {item.GetSetArticulo}\t");
                        cadena.AppendLine($"Marca: {item.GetSetMarca}");
                        cadena.Append($"Codigo: {item.GetCodigo}\t");
                        cadena.Append($"Precio: {item.GetSetPrecio}\t");
                        cadena.AppendLine($"Stock: {item.GetSetStock}");
                        cadena.Append($"Categoria: {item.GetSetCategoria}\t");
                        cadena.AppendLine($"Tipo: {item.GetSetTipo.ToString()}");
                        bandera = 1;
                        break;
                    }
                }
            }

            if (bandera == 1)
            {
                return Convert.ToString(cadena);
            }
            else
            {
                return string.Empty;
            }

        }

        public bool ComprarProducto(Duenio d, int codigo, int cantidad)
        {
            bool retorno = false;
            int stock = 0;
            int total = 0;

            if(!(d is null) && cantidad > 0)
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(codigo == item.GetCodigo) 
                    {
                        stock = item.GetSetStock;
                        total = stock + cantidad;
                        item.GetSetStock = total;
                        if(ModificarUnProducto(d, item)) 
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }

            return retorno;
        }
        public bool ModificarUnProducto(Duenio d, Mercaderia m)
        {
            bool validacion = false;
            if (!(d is null || m is null)) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(item.GetCodigo == m.GetCodigo) 
                    {
                        item.GetSetArticulo = m.GetSetArticulo;
                        item.GetSetCategoria = m.GetSetCategoria;
                        item.GetSetPrecio = m.GetSetPrecio;
                        item.GetSetTipo = m.GetSetTipo;
                        item.GetSetStock = m.GetSetStock;
                        item.GetSetMarca = m.GetSetMarca;
                        validacion = true;
                        break;
                    }
                }
            }
            return validacion;
        }

        public bool EliminarCategoria(Duenio d, string categoria) 
        {
            bool validacion = false;
            if(!(d is null || categoria is null)) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(item.GetSetCategoria == categoria) 
                    {
                        item.GetSetCategoria = "sin categoria";
                        validacion = true;
                    }
                }
            }
            return validacion;
        }

        public bool RenombrarCategoria(Duenio d, string categoria, string renombre)
        {
            bool validacion = false;
            if (!(d is null || string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(renombre)))
            {
                foreach (var item in d.listaMercaderia)
                {
                    if (item.GetSetCategoria == categoria)
                    {
                        item.GetSetCategoria = renombre;
                        validacion = true;
                    }
                }
            }
            return validacion;
        }

        public string[] RetornarCategoria(Duenio d)
        {

            List<string> categorias = new List<string>();

            if (!(d is null))
            {
                foreach (var item in d.listaMercaderia)
                {
                    categorias.Add(item.GetSetCategoria);
                }

                var categoriasSinRepetir = new HashSet<string>(categorias);
                string[] categoriasRetorno = new string[categoriasSinRepetir.Count];

                categoriasRetorno = categoriasSinRepetir.ToArray();

                return categoriasRetorno;

            }

            return null;
        }

        public eTipoMercaderia compararEtipoConString(string tipo) 
        {
            eTipoMercaderia gaming = eTipoMercaderia.Gaming;
            eTipoMercaderia diseño = eTipoMercaderia.Diseño;
            eTipoMercaderia retorno = eTipoMercaderia.Generico;

            if(tipo == Convert.ToString(gaming)) 
            {
                retorno= eTipoMercaderia.Gaming;
            }

            if(tipo == Convert.ToString(diseño)) 
            {
                retorno= eTipoMercaderia.Diseño;
            }

            return retorno;
        }
        public Mercaderia RetornarMercaderia(Duenio d, int codigo) 
        {
            Mercaderia producto = null;

            if(BuscarMercaderiaPorCodigo(d, codigo)) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(codigo == item.GetCodigo) 
                    {
                        producto = item;
                        break;
                    }
                }
            }

            return producto;
        }

        public int GenerarCodigo(Duenio d) 
        {
            int codigo;
            int bandera;
            Random codigoRandom = new Random();

            do
            {
                bandera = 0; 
                codigo = codigoRandom.Next(1000000,2000000);
                foreach(var item in d.listaMercaderia) 
                {
                    if(item.GetCodigo == codigo) 
                    {
                        bandera = 1;
                        break;
                    }
                }

            } while (bandera == 1);

            return codigo;
        }
        public string QuitarProductoFacturacion(List<Mercaderia> m, int codigo, int cantidad) 
        {
            StringBuilder texto = new StringBuilder();
            float precio;
            float monto;

            if(m.Count>0 && codigo>0 && cantidad > 0) 
            {
                foreach(var item in m) 
                {
                    if(item.GetCodigo == codigo && cantidad <= item.GetSetStock) 
                    {

                        monto = item.GetSetPrecio;
                        precio = cantidad * monto;
                        texto.AppendLine($"ELIMINADO");
                        texto.AppendLine($"Articulo: {item.GetSetArticulo}");
                        texto.AppendLine($"Marca: {item.GetSetMarca}");
                        texto.AppendLine($"Codigo: {item.GetCodigo}");
                        texto.AppendLine($"Precio: ${item.GetSetPrecio}  Cantidad: {cantidad}");
                        texto.AppendLine($"Acumulado: - ${Math.Round(precio, 2)}");
                        texto.AppendLine();
                        break;

                    }
                }
            }

            return Convert.ToString(texto);
        }
        public string AgregarProductoFacturacion(Duenio d,int codigo, int cantidad) 
        {
            int stock = 0;
            int total = 0;
            float monto = 0;
            float precio =0;
            StringBuilder texto = new StringBuilder();

            if (d.BuscarMercaderiaPorCodigo(d, codigo) && cantidad >0) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(item.GetCodigo == codigo && cantidad<=item.GetSetStock) 
                    {
                        stock = item.GetSetStock;
                        total = stock - cantidad;
                        item.GetSetStock = total;
                        monto = item.GetSetPrecio;
                        precio = cantidad * monto;
                        texto.AppendLine($"Articulo: {item.GetSetArticulo}");
                        texto.AppendLine($"Marca: {item.GetSetMarca}");
                        texto.AppendLine($"Codigo: {item.GetCodigo}");
                        texto.AppendLine($"Precio: ${item.GetSetPrecio}  Cantidad: {cantidad}");
                        texto.AppendLine($"Acumulado: ${Math.Round(precio,2)}");
                        texto.AppendLine();
                        break;
                    }
                }
            }

            return Convert.ToString(texto);
        }

        public float PrecioProducto(Duenio d, int codigo, int cantidad)
        {
            float monto = 0;
            float precio = 0;

            if (d.BuscarMercaderiaPorCodigo(d, codigo) && cantidad > 0)
            {
                foreach (var item in d.listaMercaderia)
                {
                    if (item.GetCodigo == codigo && cantidad<=item.GetSetStock)
                    {
                        monto = item.GetSetPrecio;
                        precio = cantidad * monto;

                        break;
                    }
                }
            }

            return precio;
        }
        #endregion

        #region "Examen"
        public int GenerarNroFactura(Duenio d)
        {
            Random numeroRandom = new Random();
            int numeroFactura = 0;

            if (!(d is null))
            {
                if (d.listaDeVentas.Count > 0) 
                {
                    do
                    {
                        numeroFactura = numeroRandom.Next(111111, 999999);
                        foreach (var item in d.listaDeVentas)
                        {
                            if (item.GetSetNumeroFactura == numeroFactura)
                            {
                                numeroFactura = 0;
                                break;
                            }
                        }
                    } while (numeroFactura == 0);
                }
                else 
                {
                    numeroFactura = numeroRandom.Next(111111, 999999);
                }
            }

            return numeroFactura;
        }

        public long CantidadDeVentas(Duenio d)
        {

            List<long> ventas = new List<long>();

            if (!(d is null))
            {
                foreach (var item in d.listaDeVentas)
                {
                   ventas.Add(item.GetSetNumeroFactura);
                }

                var facturas = new HashSet<long>(ventas);

                return facturas.Count;

            }

            return 0;
        }
  
        public float gananciaTotales(Duenio d) 
        {
            float monto = 0;
            float acumulador = 0;
            foreach(var item in d.listaDeVentas) 
            {
                monto = item.GetSetTotal;
                acumulador = acumulador + monto;
            }

            return acumulador;
        }

        public float promedioPorCategoria(Duenio d, string categoria) 
        {
            float promedio;
            float precio;
            float acumulador= 0;

            foreach(var item in d.listaDeVentas)
            {
                if (item.GetSetCategoria == categoria) 
                {
                    precio = item.GetSetTotal;
                    acumulador = acumulador + precio; 
                }
            }

            promedio = (acumulador/gananciaTotales(d))*100;

            return promedio;
        }
        private int CompararString(Ventas v1, Ventas v2)
        {

            if ((v1.GetSetArticulo.CompareTo(v2.GetSetArticulo)) == 0)
            {
                v1.GetSetCantidad = v1.GetSetCantidad + v2.GetSetCantidad;
                v1.GetSetTotal = v1.GetSetTotal + v2.GetSetTotal;
                v2.GetSetArticulo = "vacio";
                v2.GetSetCantidad = 0;
                return 0;
            }
            else
            {
                return v1.GetSetArticulo.CompareTo(v2.GetSetArticulo);
            }

        }

        private bool BorrarVacio(Ventas v)
        {
            bool retorno = false;

            if (v.GetSetArticulo == "vacio")
            {
                retorno = true;
            }
            return retorno;
        }

        private int RetornarCodigoMercaderia(Duenio d, Ventas v) 
        {
            int codigo = 0;

            if(!(d is null || v is null)) 
            {
                foreach(var item in d.listaMercaderia) 
                {
                    if(item.GetSetArticulo == v.GetSetArticulo) 
                    {
                        codigo = item.GetCodigo;
                        break;
                    }
                }
            }
            

            return codigo;
        }

        public string ProductoMasVendidoPorCategoria(Duenio d, string categoria) 
        {
            List<Ventas> articulosVendidos = new List<Ventas>();
            int max = 0;
            StringBuilder cadena = new StringBuilder();


            if (!(d is null || string.IsNullOrWhiteSpace(categoria)))
            {
                foreach (var item in d.listaDeVentas)
                {
                    if (item.GetSetCategoria == categoria)
                    {
                        articulosVendidos.Add(item);

                    }
                }

                articulosVendidos.Sort(CompararString);
                articulosVendidos.RemoveAll(BorrarVacio);

                foreach(var item in articulosVendidos) 
                {
                    if (item.GetSetCantidad > max) 
                    {
                        cadena.Clear();
                        max = item.GetSetCantidad;
                        cadena.AppendLine($"articulo: {item.GetSetArticulo}");
                        cadena.AppendLine($"codigo: {RetornarCodigoMercaderia(d,item)}");
                        cadena.AppendLine($"cantidad vendida: {max}");
                        cadena.AppendLine($"precio unitario: {Math.Round(item.GetSetPrecio,2)}");
                        cadena.AppendLine($"acumulado: {Math.Round(item.GetSetTotal,2)}");
                    }
                }

            }
            articulosVendidos.Clear();

            return Convert.ToString(cadena);
        }
        #endregion

    }
}
