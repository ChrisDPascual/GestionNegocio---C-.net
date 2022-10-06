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
    public partial class FRMCliente : Form
    {
        private Duenio duenio;
        private Cliente unCliente;
        private long DNI;
        public FRMCliente(Duenio duenio)
        {
            this.duenio = duenio;
            InitializeComponent();
            this.CBoxEmail.Items.Add("@yahoo.com");
            this.CBoxEmail.Items.Add("@gmail.com");
            this.CBoxEmail.Items.Add("@hotmail.com");
            this.CBoxGenero.Items.Add("masculino");
            this.CBoxGenero.Items.Add("femenino");
            this.CBoxGenero.Items.Add("no binario");
        }

        public FRMCliente(Duenio duenio, long DNI) : this(duenio)
        {
            this.DNI = DNI;
            this.unCliente = this.duenio.RetornarUnCliente(this.duenio, this.DNI);
            if (!(this.unCliente is null))
            {
                this.TBoxNombre.Text = unCliente.GetSetNombre;
                this.TBoxApellido.Text = unCliente.GetSetApellido;
                this.TBoxDNI.Text = unCliente.GetSetDNI.ToString();
                this.TBoxDireccion.Text = unCliente.GetSetDomicilio;
                this.TBoxTelefono.Text = unCliente.GetSetelefono.ToString();
                this.NUpDias.Value = unCliente.GetSetFechaNacimiento.Day;
                this.NUpMes.Value = unCliente.GetSetFechaNacimiento.Month;
                this.TBoxAnio.Text = unCliente.GetSetFechaNacimiento.Year.ToString();
                this.CBoxGenero.SelectedItem = unCliente.GetSetGenero;
                this.TBoxEmail.Text = unCliente.GetSetEmail;
                this.TBoxAltura.Visible = false;
                this.CBoxEmail.Visible = false;

            }
        }

        public FRMCliente(Duenio duenio, string DNI) : this(duenio)
        {
 
            this.TBoxDNI.Text = DNI;
            this.TBoxDNI.ReadOnly = true;
            
        }
        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTModificar_Click(object sender, EventArgs e)
        {
            Cliente unCliente;
            string cadena;
            string nombre;
            string apellido;
            long DNI;
            string genero;
            DateTime fechaNac;
            string dato;
            int dia;
            int mes;
            int anio = 1;

            nombre = this.TBoxNombre.Text;
            apellido = this.TBoxApellido.Text;
            genero = this.CBoxGenero.Text;
            dia = Convert.ToInt32(this.NUpDias.Value);
            mes = Convert.ToInt32(this.NUpMes.Value);
            dato = this.TBoxAnio.Text;


            if (!(int.TryParse(dato, out anio)))
            {
                anio = 1;
            }

            if (Validaciones.Validaciones.ValidarFecha(dia, mes, anio))
            {
                fechaNac = new DateTime(anio, mes, dia);
            }
            else
            {
                fechaNac = new DateTime(1, 1, 1);
            }

            if (long.TryParse(this.TBoxDNI.Text, out DNI))
            {
                if (this.duenio.BuscarClienteDNI(this.duenio, DNI) && this.TBoxAltura.Visible == false)
                {
                    cadena = this.duenio.ValidarCliente(this.duenio, nombre, apellido, 99999999, genero, fechaNac);

                    if (string.IsNullOrWhiteSpace(cadena))
                    {
                        unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac);

                        if (unCliente.GetSetDNI > 0)
                        {
                            long telefono = 0;
                            string email = "NN";
                            string domicilio = "NN";


                            if (long.TryParse(this.TBoxTelefono.Text, out telefono))
                            {
                                unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac,telefono);
                            }
                            else
                            {
                                unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac,telefono);
                            }

                            if (!(string.IsNullOrWhiteSpace((email = this.TBoxEmail.Text))))
                            {
                                unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac,telefono,email);
                            }
                            else
                            {
                                unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac,telefono,email);
                            }

                            if (!(string.IsNullOrWhiteSpace(domicilio = this.TBoxDireccion.Text)))
                            {
                                unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono,email, domicilio);
                            }
                            else 
                            {
                                unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono,email, domicilio);
                            }

                            if (this.duenio.ModificarCliente(this.duenio, unCliente, DNI)) 
                            {
                                MessageBox.Show("el cliente se modifico con exito");
                                Dispose();
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
                    if(!(this.duenio.BuscarClienteDNI(this.duenio, DNI))) 
                    {
                        cadena = this.duenio.ValidarCliente(this.duenio, nombre, apellido, DNI, genero, fechaNac);

                        if (string.IsNullOrWhiteSpace(cadena))
                        {
                            unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac);

                            if (unCliente.GetSetDNI > 0)
                            {
                                long telefono = 0;
                                string email = "NN";
                                string domicilio = "NN";


                                if (long.TryParse(this.TBoxTelefono.Text, out telefono))
                                {
                                    unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono);
                                }
                                else
                                {
                                    unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono);
                                }

                                if (!(string.IsNullOrWhiteSpace((email = this.TBoxEmail.Text))))
                                {
                                    unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono, email);
                                }
                                else
                                {
                                    unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono, email);
                                }

                                if (!(string.IsNullOrWhiteSpace(domicilio = this.TBoxDireccion.Text)))
                                {
                                    unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono, email, domicilio);
                                }
                                else
                                {
                                    unCliente = new Cliente(nombre, apellido, DNI, genero, fechaNac, telefono, email, domicilio);
                                }

                                if (this.duenio+unCliente)
                                {
                                    MessageBox.Show("el cliente se creo con exito");
                                    Dispose();
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
                        MessageBox.Show("El DNI ingresado no se encuentra disponible");
                    }
                }

            }
            else
            {
                MessageBox.Show("Error, ingrese el DNI");
            }
        }
    }
}
