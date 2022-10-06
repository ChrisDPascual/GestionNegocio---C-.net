
namespace Pascual.Christian.PPLabII
{
    partial class FRMContador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbCantidadVentas = new System.Windows.Forms.Label();
            this.CBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTSalir = new System.Windows.Forms.Button();
            this.TBoxGanaciasTotales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxVentasTotales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(143, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(395, 234);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbCantidadVentas
            // 
            this.lbCantidadVentas.AutoSize = true;
            this.lbCantidadVentas.Location = new System.Drawing.Point(16, 15);
            this.lbCantidadVentas.Name = "lbCantidadVentas";
            this.lbCantidadVentas.Size = new System.Drawing.Size(103, 15);
            this.lbCantidadVentas.TabIndex = 2;
            this.lbCantidadVentas.Text = "CantidadDeVentas";
            // 
            // CBoxCategorias
            // 
            this.CBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCategorias.FormattingEnabled = true;
            this.CBoxCategorias.Location = new System.Drawing.Point(16, 81);
            this.CBoxCategorias.Name = "CBoxCategorias";
            this.CBoxCategorias.Size = new System.Drawing.Size(121, 23);
            this.CBoxCategorias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorias";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "El mas vendido de la categoria";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "promedio por categoria";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTSalir
            // 
            this.BTSalir.Location = new System.Drawing.Point(16, 257);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(100, 34);
            this.BTSalir.TabIndex = 7;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = true;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // TBoxGanaciasTotales
            // 
            this.TBoxGanaciasTotales.Location = new System.Drawing.Point(321, 257);
            this.TBoxGanaciasTotales.Name = "TBoxGanaciasTotales";
            this.TBoxGanaciasTotales.ReadOnly = true;
            this.TBoxGanaciasTotales.Size = new System.Drawing.Size(217, 23);
            this.TBoxGanaciasTotales.TabIndex = 8;
            this.TBoxGanaciasTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ganacia totales";
            // 
            // TBoxVentasTotales
            // 
            this.TBoxVentasTotales.Location = new System.Drawing.Point(19, 37);
            this.TBoxVentasTotales.Name = "TBoxVentasTotales";
            this.TBoxVentasTotales.Size = new System.Drawing.Size(100, 23);
            this.TBoxVentasTotales.TabIndex = 10;
            this.TBoxVentasTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FRMContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 303);
            this.ControlBox = false;
            this.Controls.Add(this.TBoxVentasTotales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxGanaciasTotales);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxCategorias);
            this.Controls.Add(this.lbCantidadVentas);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FRMContador";
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbCantidadVentas;
        private System.Windows.Forms.ComboBox CBoxCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.TextBox TBoxGanaciasTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxVentasTotales;
    }
}