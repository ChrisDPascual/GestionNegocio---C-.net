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
using Validaciones;

namespace Pascual.Christian.PPLabII
{
    public partial class FRMDatosEmpleado : Form
    {
        private Duenio duenio;
        public FRMDatosEmpleado(Duenio duenio, bool estado)
        {
            InitializeComponent();
            this.duenio = duenio;
            this.CBoxEmail.Items.Add("@yahoo.com");
            this.CBoxEmail.Items.Add("@gmail.com");
            this.CBoxEmail.Items.Add("@hotmail.com");
            this.CBoxGenero.Items.Add("masculino");
            this.CBoxGenero.Items.Add("femenino");
            this.CBoxGenero.Items.Add("no binario");
            this.CBoxEstado.Items.Add("activo");
            this.CBoxEstado.Items.Add("despedido");
            this.CBoxEstado.Visible = estado;
            this.CBoxEstado.Visible = estado;
            this.BTFechaDespido.Visible = estado;
            this.LBEstado.Visible = estado;
            this.LBModificar.Visible = estado;
            this.TBoxLegajo.Visible = estado;
            this.BTBuscar.Visible = estado;
            this.CBoxEmail.Visible = !(estado);
            this.TxtBoxNro.Visible = !(estado);
            this.LabelAltura.Visible = !(estado);
            this.TxtBoxDNI.ReadOnly = true;

        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            Vendedor unVendedor;
            string cadena;
            string nombre;
            string apellido;
            long DNI;
            string usuario = string.Empty;
            string contraseña = string.Empty;
            string genero;
            DateTime fechaNac;
            string estado;
            DateTime inicioActividades;
            bool bandera = false;
            bool validacion = false;
            string dato;
            int dia;
            int mes;
            int anio = 1;

            nombre = this.TxtBoxNombre.Text;
            apellido = this.TxtBoxApellido.Text;
            genero = this.CBoxGenero.Text;
            estado = "activo";
            dia = Convert.ToInt32(this.NUpDias.Value);
            mes = Convert.ToInt32(this.NUpMes.Value);
            dato = this.TxtBoxAnio.Text;

            if (!(int.TryParse(dato, out anio)))
            {
                anio = 1;
            }
            inicioActividades = DateTime.Now;

            if (Validaciones.Validaciones.ValidarFecha(dia, mes, anio))
            {
                fechaNac = new DateTime(anio, mes, dia);
            }
            else
            {
                fechaNac = new DateTime(1, 1, 1);
            }

            if (this.CBoxEmail.Visible == true)
            {

                if (long.TryParse(this.TxtBoxDNI.Text, out DNI))
                {
                    cadena = this.duenio.ValidarNuevoEmpleado(this.duenio, nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades);
                    if (string.IsNullOrWhiteSpace(cadena))
                    {
                        unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades);
                        bandera = true;

                        if (bandera == true)
                        {
                            long telefono = 0;
                            string email = "NN";
                            string arroba = this.CBoxEmail.Text;
                            string domicilio = "NN";
                            int altura = 0;

                            email = this.TxtBoxEmail.Text;
                            domicilio = this.TxtBoxDireccion.Text;

                            if (long.TryParse(this.TxtBoxTelefono.Text, out telefono))
                            {
                                unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono);
                            }
                            else
                            {
                                unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono);
                            }

                            if (!(string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(arroba)))
                            {
                                email = string.Concat(email + arroba);
                                unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email);
                            }
                            else
                            {
                                unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email);
                            }

                            if (!(string.IsNullOrWhiteSpace(domicilio)) && int.TryParse(this.TxtBoxNro.Text, out altura))
                            {
                                if (altura > 0)
                                {
                                    domicilio = domicilio + " ";
                                    domicilio = string.Concat(domicilio, altura);
                                    unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email, domicilio);
                                }
                                else
                                {
                                    unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email, domicilio);
                                }
                            }
                            
                            if(validacion = this.duenio + unVendedor) 
                            {
                                usuario = unVendedor.GetUsuario;
                                contraseña = unVendedor.GetContraseña;
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show(cadena);
                    }

                }
                else
                {
                    MessageBox.Show("Error");
                }


                if (validacion == true)
                {
                    MessageBox.Show($"Empleado creado exitosamente\nUsuario: {usuario}\nContraseña: {contraseña}", "Datos del nuevo Empleado");
                    
                    Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el empleado");
                }
            }
            else
            {
                ModificarEmpleado();
            }

        }

        public void ModificarEmpleado() 
        {
            Vendedor unVendedor;
            int legajo;
            string cadena;
            string nombre;
            string apellido;
            long DNI;
            string genero;
            DateTime fechaNac;
            string estado;
            DateTime inicioActividades;
            bool bandera = false;
            bool validacion = false;
            string dato;
            int dia;
            int mes;
            int anio = 1;

            nombre = this.TxtBoxNombre.Text;
            apellido = this.TxtBoxApellido.Text;
            genero = this.CBoxGenero.Text;
            estado = this.CBoxEstado.Text;
            dia = Convert.ToInt32(this.NUpDias.Value);
            mes = Convert.ToInt32(this.NUpMes.Value);
            dato = this.TxtBoxAnio.Text;

            if (!(int.TryParse(dato, out anio)))
            {
                anio = 1;
            }
            inicioActividades = DateTime.Now;

            if (Validaciones.Validaciones.ValidarFecha(dia, mes, anio))
            {
                fechaNac = new DateTime(anio, mes, dia);
            }
            else
            {
                fechaNac = new DateTime(1, 1, 1);
            }

            if (long.TryParse(this.TxtBoxDNI.Text, out DNI))
            {
                if (this.duenio.ComparaDNI(this.duenio, DNI)) 
                {
                    cadena = this.duenio.ValidarNuevoEmpleado(this.duenio, nombre, apellido, 99999999, genero, fechaNac, estado, inicioActividades);
                }
                else 
                {
                    cadena = this.duenio.ValidarNuevoEmpleado(this.duenio, nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades);
                }

                if (string.IsNullOrWhiteSpace(cadena))
                {
                    unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades);
                    bandera = true;

                    if (bandera == true)
                    {
                        long telefono = 0;
                        string email = "NN";
                        string domicilio = "NN";

                        email = this.TxtBoxEmail.Text;
                        domicilio = this.TxtBoxDireccion.Text;

                        if (long.TryParse(this.TxtBoxTelefono.Text, out telefono))
                        {
                            unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono);
                        }
                        else
                        {
                            unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono);
                        }

                        if (!(string.IsNullOrWhiteSpace(email)))
                        {
                            unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email);
                        }
                        else
                        {
                            unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email);
                        }

                        if (!(string.IsNullOrWhiteSpace(domicilio)))
                        {
                                unVendedor = new Vendedor(nombre, apellido, DNI, genero, fechaNac, estado, inicioActividades, telefono, email, domicilio);   
                        }

                        if (int.TryParse(this.TBoxLegajo.Text, out legajo)) 
                        {
                            validacion = this.duenio.ModificarVendedor(this.duenio, unVendedor, legajo);
                            if (validacion == true) 
                            {
                                bandera = true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(cadena);
                }

            }
            else
            {
                MessageBox.Show("Error");
            }


            if (validacion == true)
            {
                MessageBox.Show("Empleado modificado exitosamente");
                Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el empleado");
            }
        }
        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void LimpiarTextBox() 
        {
            this.TxtBoxNombre.Clear();
            this.TxtBoxApellido.Clear();
            this.TxtBoxDireccion.Clear();
            this.TxtBoxDNI.Clear();
            this.TxtBoxTelefono.Clear();
            this.TxtBoxEmail.Clear();
            this.NUpDias.Value = 1;
            this.NUpMes.Value = 1;
            this.TxtBoxAnio.Clear();
            this.CBoxGenero.Items.Clear();
            this.CBoxEstado.Items.Clear();
            this.CBoxGenero.Items.Add("masculino");
            this.CBoxGenero.Items.Add("femenino");
            this.CBoxGenero.Items.Add("no binario");
            this.CBoxEstado.Items.Add("activo");
            this.CBoxEstado.Items.Add("despedido");
        }

        private void BTBuscar_Click(object sender, EventArgs e)
        {
            int legajo;
            Vendedor unVendedor;

            LimpiarTextBox();

            if (int.TryParse(this.TBoxLegajo.Text, out legajo)) 
            {
                if(legajo>999 && legajo < 9998) 
                {
                    unVendedor = this.duenio.RetornarUnVendedor(this.duenio, legajo);
                    if(!(unVendedor is null)) 
                    {
                        DateTime fechaNacimiento = unVendedor.GetSetFechaNacimiento;
                        this.TxtBoxNombre.Text = unVendedor.GetSetNombre;
                        this.TxtBoxApellido.Text = unVendedor.GetSetApellido;
                        this.TxtBoxDNI.Text = Convert.ToString(unVendedor.GetSetDNI);
                        this.CBoxGenero.SelectedItem = unVendedor.GetSetGenero;
                        this.CBoxEstado.SelectedItem = unVendedor.GetSetEstado;
                        this.TxtBoxDireccion.Text = unVendedor.GetSetDomicilio;
                        this.TxtBoxEmail.Text = unVendedor.GetSetEmail;
                        this.TxtBoxTelefono.Text = Convert.ToString(unVendedor.GetSetelefono);
                        this.NUpDias.Value = fechaNacimiento.Day;
                        this.NUpMes.Value = fechaNacimiento.Month;
                        this.TxtBoxAnio.Text = Convert.ToString(fechaNacimiento.Year);


                    }
                    else 
                    {
                        MessageBox.Show("El vendedor con el legajo ingresado no existe");
                    }
                }
                else 
                {
                    MessageBox.Show("ingrese un numero de legajo valido");
                }
            }
            else 
            {
                MessageBox.Show("ingrese un numero de legajo valido");
            }

        }
        private void BTFechaDespido_Click(object sender, EventArgs e)
        {
            int legajo;
            Vendedor unVendedor;

            if(this.CBoxEstado.Text == "despedido") 
            {
                if (int.TryParse(this.TBoxLegajo.Text, out legajo))
                {
                    if (legajo > 999 && legajo < 9998)
                    {
                        unVendedor = this.duenio.RetornarUnVendedor(this.duenio, legajo);
                        if (!(unVendedor is null))
                        {

                            FRMFechaDespido fechaDespido = new FRMFechaDespido(this.duenio,unVendedor);
                            fechaDespido.ShowDialog();
                            Dispose();
                            
                        }
                        else
                        {
                            MessageBox.Show("El vendedor con el legajo ingresado no existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ingrese un numero de legajo valido");
                    }
                }
                else
                {
                    MessageBox.Show("ingrese un numero de legajo valido");
                }
            }
            else 
            {
                MessageBox.Show("El empleado tiene que estar despedido para modificar la fecha de despido");
            }
        }

        //public Vendedor(string nombre, string apellido, long DNI, string genero, DateTime fechaNac, string estado, DateTime fechaInicioActividad) 
        //: base(nombre, apellido, DNI, genero, fechaNac)    
    }
    
 }

