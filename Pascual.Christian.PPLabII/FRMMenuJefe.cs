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
        private Proveedor prov1;
        private Proveedor prov2;
        public FRMMenuJefe(Duenio d, Proveedor p1, Proveedor p2)
        {
            this.duenio = new Duenio();
            this.duenio = d;
            this.prov1 = new Proveedor();
            this.prov1 = p1;
            this.prov2 = new Proveedor();
            this.prov2 = p2;
            InitializeComponent();
 
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
            FRMStock inventario = new FRMStock(this.duenio,this.prov1,this.prov2);
            inventario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
