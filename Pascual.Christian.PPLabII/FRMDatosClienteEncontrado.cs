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
        private long DNI;
        public FRMDatosClienteEncontrado(Duenio duenio, long DNI)
        {
            this.duenio = duenio;
            this.DNI = DNI;
            InitializeComponent();
            this.RTBoxDatosCliente.Text = this.duenio.MostrarUnCliente(this.duenio, this.DNI);
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTModificar_Click(object sender, EventArgs e)
        {
            FRMCliente datosCliente = new FRMCliente(this.duenio, this.DNI);
            datosCliente.ShowDialog();
            Dispose();
        }
    }
}
