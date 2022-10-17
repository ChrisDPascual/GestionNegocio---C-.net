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
    public partial class FRMDatosClienteEncontrado : Form
    {
        private Duenio duenio;
        private Cliente unCliente;
        private long DNI;
        public FRMDatosClienteEncontrado(Duenio duenio, long DNI)
        {
            this.unCliente = new Cliente();
            this.duenio = duenio;
            this.DNI = DNI;
            InitializeComponent();
            this.RTBoxDatosCliente.Text = this.unCliente.MostrarUnCliente(this.duenio, this.DNI);
        }

        public long GetSetDato 
        {
            get {return this.DNI; }
            set {this.DNI = value; }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTModificar_Click(object sender, EventArgs e)
        {
            long DNI;
            FRMCliente datosCliente = new FRMCliente(this.duenio, this.DNI);
            if(datosCliente.ShowDialog() == DialogResult.OK) 
            {
                DNI = datosCliente.GetSetDato;
                this.RTBoxDatosCliente.Text = this.unCliente.MostrarUnCliente(this.duenio, DNI);
            }
        }

        private void TBoxConfirmar_Click(object sender, EventArgs e)
        {
            GetSetDato = this.DNI;
            Dispose();
        }
    }
}
