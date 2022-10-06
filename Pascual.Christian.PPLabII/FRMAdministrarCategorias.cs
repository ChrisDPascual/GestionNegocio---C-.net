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
    public partial class FRMAdministrarCategorias : Form
    {
        private Duenio duenio;
        private string[] dato;
        public FRMAdministrarCategorias(Duenio duenio)
        {
            this.duenio = duenio;
            string[] categorias = this.duenio.RetornarCategoria(duenio);
            InitializeComponent();
            
            for (int i = 0; i < categorias.Length; i++)
            {
                this.CBSeleccionarCategoria.Items.Add(categorias[i]);
                this.CBEliminarCategoria.Items.Add(categorias[i]);
            }
        }

        public string[] GetSetDato 
        {
            get { return this.dato; }
            set { this.dato = value; }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            GetSetDato = this.duenio.RetornarCategoria(duenio);
            Dispose();
        }

        private void BTEliminarCategoria_Click(object sender, EventArgs e)
        {
            string opcion;
            string respuesta;

            opcion = this.CBEliminarCategoria.Text;

            if (!(string.IsNullOrWhiteSpace(opcion))) 
            {
                respuesta = Convert.ToString(MessageBox.Show($"Desea borrar la siguente categoria {opcion}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (respuesta == "Yes") 
                {
                    if (this.duenio.EliminarCategoria(this.duenio, opcion)) 
                    {
                        MessageBox.Show("Se elimino la categoria correctamente");
                        this.CBSeleccionarCategoria.Items.Clear();
                        this.CBEliminarCategoria.Items.Clear();
                        
                        string[] categorias = this.duenio.RetornarCategoria(duenio);
                        for (int i = 0; i < categorias.Length; i++)
                        {
                            this.CBSeleccionarCategoria.Items.Add(categorias[i]);
                            this.CBEliminarCategoria.Items.Add(categorias[i]);
                        }
                        
                    }
                    else 
                    {
                        MessageBox.Show("No se pudo eliminar la categoria");
                    }
                }
            }
            else 
            {
                MessageBox.Show("Elija una categoria para eliminar");
            }
        }

        private void BTRenombrarCategoria_Click(object sender, EventArgs e)
        {
            string opcion;
            string renombre;
            string respuesta;
 
            opcion = this.CBSeleccionarCategoria.Text;
            renombre = this.TBoxRenombrarCategoria.Text;

            if (!(string.IsNullOrWhiteSpace(opcion) || string.IsNullOrWhiteSpace(renombre)))
            {
                respuesta = Convert.ToString(MessageBox.Show($"Desea renombrar la siguente categoria {opcion} a {renombre}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (respuesta == "Yes")
                {
                    if (this.duenio.RenombrarCategoria(this.duenio, opcion, renombre))
                    {
                        MessageBox.Show("Se renombro la categoria correctamente");
                        this.CBSeleccionarCategoria.Items.Clear();
                        this.CBEliminarCategoria.Items.Clear();

                        string[] categorias = this.duenio.RetornarCategoria(duenio);
                        for (int i = 0; i < categorias.Length; i++)
                        {
                            this.CBSeleccionarCategoria.Items.Add(categorias[i]);
                            this.CBEliminarCategoria.Items.Add(categorias[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo renombrar la categoria");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoria e ingrese el nuevo nombre");
            }
            
        }
    }
}
