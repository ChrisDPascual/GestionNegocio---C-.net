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
    public partial class FRMMenuJefe : Form
    {
        private Duenio duenio;
        public FRMMenuJefe(Duenio d)
        {
            InitializeComponent();
            this.duenio = new Duenio();
            this.duenio = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMVentas menuVentas = new FRMVentas(this.duenio);
            menuVentas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMAdministrarEmpleados administrarEmpleados = new FRMAdministrarEmpleados(this.duenio);
            administrarEmpleados.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMStock inventario = new FRMStock(this.duenio);
            inventario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
