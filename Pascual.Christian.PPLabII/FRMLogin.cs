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
    public partial class FRMLogin : Form
    {
        private Duenio elDueño = new Duenio();
        private Vendedor Vendedor1;
        private Vendedor Vendedor2;
        private Vendedor Vendedor3;
        private Vendedor Vendedor4;
        private Mercaderia articulo1;
        private Mercaderia articulo2;
        private Mercaderia articulo3;
        private Mercaderia articulo4;
        private Mercaderia articulo5;
        private Mercaderia articulo6;
        private Mercaderia articulo7;
        private Mercaderia articulo8;
        private Mercaderia articulo9;
        private Mercaderia articulo10;
        private Mercaderia articulo11;
        private Mercaderia articulo12;
        private Mercaderia articulo13;
        private Mercaderia articulo14;
        private Mercaderia articulo15;
        private Mercaderia articulo16;
        private Mercaderia articulo17;
        private Mercaderia articulo18;
        private Mercaderia articulo19;
        private Mercaderia articulo20;
        private Cliente cliente1;
        private Cliente cliente2;
        private Cliente cliente3;
        private Cliente cliente4;

        public FRMLogin()
        {
            InitializeComponent();

            bool validacion = false;
            this.elDueño = Sobrecargas.SobreCargaDuenio();
            this.Vendedor1 =Sobrecargas.SobrecargaVendedor1();
            this.Vendedor2 = Sobrecargas.SobrecargaVendedor2();
            this.Vendedor3 = Sobrecargas.SobrecargaVendedor3();
            this.Vendedor4 = Sobrecargas.SobrecargaVendedor4();
            this.articulo1 = Sobrecargas.SobrecargaMercaderia1();
            this.articulo2 = Sobrecargas.SobrecargaMercaderia2();
            this.articulo3 = Sobrecargas.SobrecargaMercaderia3();
            this.articulo4 = Sobrecargas.SobrecargaMercaderia4();
            this.articulo5 = Sobrecargas.SobrecargaMercaderia5();
            this.articulo6 = Sobrecargas.SobrecargaMercaderia6();
            this.articulo7 = Sobrecargas.SobrecargaMercaderia7();
            this.articulo8 = Sobrecargas.SobrecargaMercaderia8();
            this.articulo9 = Sobrecargas.SobrecargaMercaderia9();
            this.articulo10 = Sobrecargas.SobrecargaMercaderia10();
            this.articulo11 = Sobrecargas.SobrecargaMercaderia11();
            this.articulo12 = Sobrecargas.SobrecargaMercaderia12();
            this.articulo13 = Sobrecargas.SobrecargaMercaderia13();
            this.articulo14 = Sobrecargas.SobrecargaMercaderia14();
            this.articulo15 = Sobrecargas.SobrecargaMercaderia15();
            this.articulo16 = Sobrecargas.SobrecargaMercaderia16();
            this.articulo17 = Sobrecargas.SobrecargaMercaderia17();
            this.articulo18 = Sobrecargas.SobrecargaMercaderia18();
            this.articulo19 = Sobrecargas.SobrecargaMercaderia19();
            this.articulo20 = Sobrecargas.SobrecargaMercaderia20();
            this.cliente1 = Sobrecargas.Cliente1();
            this.cliente2 = Sobrecargas.Cliente2();
            this.cliente3 = Sobrecargas.Cliente3();
            this.cliente4 = Sobrecargas.Cliente4();

            validacion = this.elDueño + this.Vendedor1;
            validacion = this.elDueño + this.Vendedor2;
            validacion = this.elDueño + this.Vendedor3;
            validacion = this.elDueño + this.Vendedor4;
            validacion = this.elDueño + this.articulo1;
            validacion = this.elDueño + this.articulo2;
            validacion = this.elDueño + this.articulo3;
            validacion = this.elDueño + this.articulo4;
            validacion = this.elDueño + this.articulo5;
            validacion = this.elDueño + this.articulo6;
            validacion = this.elDueño + this.articulo7;
            validacion = this.elDueño + this.articulo8;
            validacion = this.elDueño + this.articulo9;
            validacion = this.elDueño + this.articulo10;
            validacion = this.elDueño + this.articulo11;
            validacion = this.elDueño + this.articulo12;
            validacion = this.elDueño + this.articulo13;
            validacion = this.elDueño + this.articulo14;
            validacion = this.elDueño + this.articulo15;
            validacion = this.elDueño + this.articulo16;
            validacion = this.elDueño + this.articulo17;
            validacion = this.elDueño + this.articulo18;
            validacion = this.elDueño + this.articulo19;
            validacion = this.elDueño + this.articulo20;
            validacion = this.elDueño + this.cliente1;
            validacion = this.elDueño + this.cliente2;
            validacion = this.elDueño + this.cliente3;
            validacion = this.elDueño + this.cliente4;


        }
        public string GetUsuarioTextBox 
        {
            get {return this.TxtBoxUsuario.Text; }
        }

        public string GetPaswwordTextBox 
        {
            get { return this.TxTBoxPassword.Text; }
        }

        private void RBModoJefe_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtBoxUsuario.Text = this.elDueño.GetUsuario;
            this.TxTBoxPassword.Text = this.elDueño.GetContraseña;
;        }

        private void RBModoVendedor_CheckedChanged(object sender, EventArgs e)
        {
            this.TxtBoxUsuario.Text = this.Vendedor1.GetUsuario;
            this.TxTBoxPassword.Text = this.Vendedor1.GetContraseña;
        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;
            int contador = 0;

            usuario = this.GetUsuarioTextBox;
            contraseña = this.GetPaswwordTextBox;

            if(this.elDueño.VerificarUsuarioJefe(this.elDueño,usuario,contraseña)) 
            {
                FRMMenuJefe menuJefe = new FRMMenuJefe(this.elDueño);
                menuJefe.ShowDialog();
            }
            else 
            {
                contador++;
            }

            if (this.elDueño.ValidarLogin(this.elDueño, usuario, contraseña))
            {
                FRMVentas menuVentas = new FRMVentas(this.elDueño,usuario);
                menuVentas.ShowDialog();
            }
            else
            {
                contador++;
            }
 

            if (contador == 2) 
            {
                MessageBox.Show("Usuario o contraseña invalido");
            }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
