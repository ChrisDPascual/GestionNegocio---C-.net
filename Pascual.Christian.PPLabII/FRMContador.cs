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
    public partial class FRMContador : Form
    {
        private Duenio duenio;
        public FRMContador(Duenio duenio)
        {
            this.duenio = duenio;
            InitializeComponent();
            this.TBoxVentasTotales.Text = Convert.ToString(this.duenio.CantidadDeVentas(this.duenio));
            this.TBoxGanaciasTotales.Text = Convert.ToString(this.duenio.gananciaTotales(this.duenio));
            string[] categorias = this.duenio.RetornarCategoria(duenio);

            for (int i = 0; i < categorias.Length; i++)
            {
                this.CBoxCategorias.Items.Add(categorias[i]);
                
            }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float promedio;

            promedio = this.duenio.promedioPorCategoria(this.duenio, this.CBoxCategorias.Text);
            this.RTBoxPantalla.Text = Convert.ToString(promedio);
        }
    }
}
