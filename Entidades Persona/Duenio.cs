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
            int bandera = 0;

            if (!(d is null || venta is null))
            {
                foreach (var item in d.listaDeVentas)
                {
                    if (item.GetSetNumeroFactura == venta.GetSetNumeroFactura)
                    {
                        bandera = 1;
                        break;
                    }
                }
            }

            if (bandera == 0)
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
        
        public bool VerificarLegajo(int numeroLegajo, Duenio v) 
        {
            bool retorno = false;

            if(!(numeroLegajo<0 || v is null)) 
            {
                foreach (var item in v.listaVendedores)
                {
                    if (v.GetSetDNI == item.DNI)
                    {
                        if (numeroLegajo == item)
                        {
                            retorno = true;
                            break;
                        }
                    }
                    
                }
            }

            return retorno;
        }

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
                    if (usuario == item.GetUsuario)
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

        

        public string MostrarUnEmpleado(int legajo, Duenio d) 
        {
            StringBuilder cadena = new StringBuilder();
            int bandera = 0;
            if (!(d is null) && legajo > 0 )
            {
                foreach (var item in d.listaVendedores)
                {
                    if(legajo == item.GetLegajo) 
                    {
                        cadena.Append($"Nombre: {item.GetSetNombre}\t");
                        cadena.AppendLine($"Apellido: {item.GetSetApellido}");
                        cadena.Append($"DNI: {item.GetSetDNI}\t");
                        cadena.Append($"Genero: {item.GetSetGenero}\t");
                        cadena.AppendLine($"Edad: {item.GetEdad(item.fechaNacimiento)}\t");
                        cadena.Append($"Estado: {item.GetSetEstado}\t");
                        cadena.Append($"Legajo: {item.GetLegajo}\t");
                        cadena.AppendLine($"Telefono: {item.GetSetelefono}");
                        cadena.Append($"email: {item.GetSetEmail}\t");
                        cadena.AppendLine($"domicilio: {item.GetSetDomicilio}");
                        cadena.Append("Inicio de actividades: " + item.GetSetInicioActividades.ToString("dd/MM/yyyy"));

                        if (item.GetSetEstado == "despedido") 
                        { 
                       
                            cadena.AppendLine("\tFecha de despido: " + item.GetSetFinActividades.ToString("dd/MM/yyyy\n"));
                        }
                        bandera = 1;
                        break;
                    }
   
                }
            }
            if(bandera == 1) 
            {
                return Convert.ToString(cadena);
            }
            else 
            {
                return null;
            }

        }

        public string MostrarEmpleados(string filtro, Duenio d) 
        {
            StringBuilder cadena = new StringBuilder();
            if(!(string.IsNullOrWhiteSpace(filtro) || d is null))
            {
                foreach (var item in d.listaVendedores) 
                {
                
                    if(item.GetSetEstado == filtro) 
                    {
                        cadena.Append($"Nombre: {item.GetSetNombre}\t");
                        cadena.AppendLine($"Apellido: {item.GetSetApellido}");
                        cadena.Append($"DNI: {item.GetSetDNI}\t");
                        cadena.Append($"Genero: {item.GetSetGenero}\t");
                        cadena.AppendLine($"Edad: {item.GetEdad(item.fechaNacimiento)}\t");
                        cadena.Append($"Estado: {item.GetSetEstado}\t");
                        cadena.Append($"Legajo: {item.GetLegajo}\t");
                        cadena.AppendLine($"Telefono: {item.GetSetelefono}");
                        cadena.Append($"Email: {item.GetSetEmail}\t");
                        cadena.AppendLine($"Domicilio: {item.GetSetDomicilio}");
                        cadena.Append("Inicio de actividades: " + item.GetSetInicioActividades.ToString("dd/MM/yyyy"));

                        if (item.GetSetEstado == "despedido")
                        {

                            cadena.AppendLine("\tFecha de despido: " + item.GetSetFinActividades.ToString("dd/MM/yyyy\n"));
                            cadena.AppendLine();
                            cadena.AppendLine();
                        }
                        else
                        {
                            cadena.AppendLine();
                            cadena.AppendLine();
                        }
                    }
                }
                
                if(filtro == "todos") 
                {
                    foreach (var item in d.listaVendedores)
                    {

                        cadena.Append($"Nombre: {item.GetSetNombre}\t");
                        cadena.AppendLine($"Apellido: {item.GetSetApellido}");
                        cadena.Append($"DNI: {item.GetSetDNI}\t");
                        cadena.Append($"Genero: {item.GetSetGenero}\t");
                        cadena.AppendLine($"Edad: {item.GetEdad(item.fechaNacimiento)}\t");
                        cadena.Append($"Estado: {item.GetSetEstado}\t");
                        cadena.Append($"Legajo: {item.GetLegajo}\t");
                        cadena.AppendLine($"Telefono: {item.GetSetelefono}");
                        cadena.Append($"Email: {item.GetSetEmail}\t");
                        cadena.AppendLine($"Domicilio: {item.GetSetDomicilio}");
                        cadena.Append("Inicio de actividades: " + item.GetSetInicioActividades.ToString("dd/MM/yyyy"));

                        if (item.GetSetEstado == "despedido")
                        {

                            cadena.AppendLine("\tFecha de despido: " + item.GetSetFinActividades.ToString("dd/MM/yyyy\n"));
                            cadena.AppendLine();
                            cadena.AppendLine();
                        }
                        else 
                        {
                            cadena.AppendLine();
                            cadena.AppendLine();
                        }

                    }
                }
            }

            return Convert.ToString(cadena);
        }

        public string ValidarNuevoEmpleado(Duenio d, string nombre, string apellido, long DNI, string genero, DateTime fechaNac, string estado, DateTime inicioActividades) 
        {
            string cadena = string.Empty;
            StringBuilder Error = new StringBuilder();
            int edad;

            if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(estado) || d is null) 
            {
                Error.AppendLine("Complete nombre, apellido y genero");
            }

            if(!(DNI >= 999999 && DNI <= 99999999)) 
            {
                Error.AppendLine("Ingrese un DNI valido");
            }
            else 
            {
                if (DNI == d.GetSetDNI) 
                {
                    Error.AppendLine("El DNI ya se encuentra registrado");
                }
                else 
                {
                    foreach (var item in d.listaVendedores)
                    {
                        if (item.GetSetDNI == DNI)
                        {
                            Error.AppendLine("El DNI ya se encuentra registrado");
                            break;
                        }
                    }
                }
               
            }

            if (!(Validaciones.Validaciones.ValidarFecha(fechaNac.Day,fechaNac.Month,fechaNac.Year))) 
            {
                Error.AppendLine("la fecha ingresada no es valida");
            }
            else 
            {
                edad = d.GetEdad(fechaNac);
                if (edad < 17) 
                {
                    Error.AppendLine("No tiene edad suficiente para trabajar");
                }
            }

            if(inicioActividades > DateTime.Now) 
            {
                Error.AppendLine("No concuerda la fecha de inicio"); ;
            }
            cadena = Convert.ToString(Error);
            return cadena;
        }

        public Vendedor RetornarUnVendedor(Duenio d, int legajo) 
        {
            Vendedor unVendedor = null;
            if(!(d is null) && legajo > 0) 
            {
                foreach(var item in d.listaVendedores) 
                {
                    if(item.GetLegajo == legajo) 
                    {
                        unVendedor = item;
                        break;
                    }
                }
            }

            return unVendedor;
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
            if(!(d is null) || legajo<0 || fecha > DateTime.Now) 
            {
                foreach(var item in d.listaVendedores) 
                {
                    if(legajo == item.GetLegajo) 
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
        public bool ModificarVendedor(Duenio d, Vendedor v, int legajo) 
        {
            bool validacion = false;

            if(!(d is null || v is null) && legajo > 0) 
            {
                foreach(var item in d.listaVendedores) 
                {
                    if(legajo == item.GetLegajo) 
                    {
                        item.nombre = v.nombre;
                        item.apellido = v.apellido;
                        item.DNI = v.DNI;
                        item.genero = v.genero;
                        item.fechaNacimiento = v.fechaNacimiento;
                        item.telefono = v.telefono;
                        item.email = v.email;
                        item.domicilio = v.domicilio;
                        item.GetSetEstado = v.GetSetEstado;
                        item.GetSetInicioActividades = v.GetSetInicioActividades;
                        item.GetSetFinActividades = v.GetSetFinActividades;
                        validacion = true;
                        break;
                    }
                }
            }

            return validacion;
        }

        public bool ComparaDNI(Duenio d, long DNI) 
        {
            bool retorno = false;
            if(!(d is null) && DNI > 0) 
            {
                foreach(var item in d.listaVendedores) 
                {
                    if(item.GetSetDNI == DNI) 
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public int RetonarLegajoUsuario(Duenio d, string usuario) 
        {
            int legajo = 0;

            if(!(d is null || string.IsNullOrWhiteSpace(usuario)))
            {
                foreach(var item in d.listaVendedores) 
                {
                    if(item.GetUsuario == usuario) 
                    {
                        legajo = item.GetLegajo;
                        break;
                    }
                }
            }

            return legajo;
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

        public bool BuscarClienteDNI(Duenio d, long DNI) 
        {
            bool validacion = false;
            if(!(d is null) || DNI < 1) 
            {
                foreach(var item in d.listaClientes) 
                {
                    if(item.GetSetDNI == DNI) 
                    {
                        validacion = true;
                        break;
                    }
                }
            }
            return validacion;
        }
        public Cliente RetornarUnCliente(Duenio d, long DNI)
        {
            Cliente unCliente = null;
            if (BuscarClienteDNI(d, DNI))
            {
                foreach (var item in d.listaClientes)
                {
                    if (item.GetSetDNI == DNI)
                    {
                        unCliente = item;
                        break;
                    }
                }
            }

            return unCliente;
        }
        public string MostrarUnCliente(Duenio d, long DNI)
        {
            StringBuilder cadena = new StringBuilder();
            int bandera = 0;

            if (BuscarClienteDNI(d, DNI))
            {
                foreach (var item in d.listaClientes)
                {
                    if (item.GetSetDNI == DNI)
                    {
                        cadena.AppendLine($"Nombre: {item.GetSetNombre}");
                        cadena.AppendLine($"Apellido: {item.GetSetApellido}");
                        cadena.AppendLine($"DNI: {item.GetSetDNI}");
                        cadena.Append($"Sexo: {item.GetSetGenero}\t");
                        cadena.AppendLine($"edad: {item.GetEdad(item.GetSetFechaNacimiento)}");
                        cadena.AppendLine($"Email: {item.GetSetEmail}");
                        cadena.AppendLine($"Direccion: {item.GetSetDomicilio}");
                        cadena.AppendLine($"Telefono: {item.GetSetelefono}");
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

        public string ValidarCliente(Duenio d, string nombre, string apellido, long DNI, string genero, DateTime fechaNac)
        {
            string cadena = string.Empty;
            StringBuilder Error = new StringBuilder();
            int edad;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(genero)  || d is null)
            {
                Error.AppendLine("Complete nombre, apellido y genero");
            }

            if (!(DNI >= 999999 && DNI <= 99999999))
            {
                Error.AppendLine("Ingrese un DNI valido");
            }
            else
            {
                    foreach (var item in d.listaClientes)
                    {
                        if (item.GetSetDNI == DNI)
                        {
                            Error.AppendLine("El DNI ya se encuentra registrado");
                            break;
                        }
                    }

            }

            if (!(Validaciones.Validaciones.ValidarFecha(fechaNac.Day, fechaNac.Month, fechaNac.Year)))
            {
                Error.AppendLine("la fecha ingresada no es valida");
            }
            else
            {
                edad = d.GetEdad(fechaNac);
                if (edad < 17)
                {
                    Error.AppendLine("No tiene edad suficiente para trabajar");
                }
            }

            cadena = Convert.ToString(Error);
            return cadena;
        }

        public bool ModificarCliente(Duenio d, Cliente c, long DNI) 
        {
            bool validacion = false;
            if(BuscarClienteDNI(d, DNI) || !(c is null)) 
            {
                foreach(var item in d.listaClientes) 
                {
                    if(DNI == item.GetSetDNI) 
                    {
                        item.GetSetNombre = c.GetSetNombre;
                        item.GetSetApellido = c.GetSetApellido;
                        item.GetSetDNI = c.GetSetDNI;
                        item.GetSetDomicilio = c.GetSetDomicilio;
                        item.GetSetFechaNacimiento = c.GetSetFechaNacimiento;
                        item.GetSetGenero = c.GetSetGenero;
                        item.GetSetEmail = c.GetSetEmail;
                        item.GetSetelefono = c.GetSetelefono;
                        validacion = true;
                        break;
                    }
                }
            }

            return validacion;
        }

        public int GenerarNroFactura(Duenio d)
        {
            Random numeroRandom = new Random();
            int numeroFactura = 0;

            if (!(d is null))
            {
                do
                {
                    numeroFactura = numeroRandom.Next(111111, 999999);
                    foreach (var item in d.listaDeVentas)
                    {
                        if (item.GetSetNumeroFactura == numeroFactura)
                        {
                            numeroFactura = 1;
                            break;
                        }
                    }
                } while (numeroFactura == 0);
            }

            return numeroFactura;
        }

        public int CantidadDeVentas(Duenio d) 
        {
            return d.listaDeVentas.Count;
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
                precio = item.GetSetPrecio;
                acumulador = acumulador + precio;
            }

            promedio = acumulador / d.listaDeVentas.Count;

            return promedio;
        }

       
    }
}
