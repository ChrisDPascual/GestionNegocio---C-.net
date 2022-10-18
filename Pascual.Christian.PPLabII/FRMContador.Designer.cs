
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
            this.RTBoxPantalla = new System.Windows.Forms.RichTextBox();
            this.lbCantidadVentas = new System.Windows.Forms.Label();
            this.CBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTMasVendido = new System.Windows.Forms.Button();
            this.BTPromedio = new System.Windows.Forms.Button();
            this.BTSalir = new System.Windows.Forms.Button();
            this.TBoxGanaciasTotales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxVentasTotales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RTBoxPantalla
            // 
            this.RTBoxPantalla.Location = new System.Drawing.Point(22, 110);
            this.RTBoxPantalla.Name = "RTBoxPantalla";
            this.RTBoxPantalla.ReadOnly = true;
            this.RTBoxPantalla.Size = new System.Drawing.Size(377, 265);
            this.RTBoxPantalla.TabIndex = 0;
            this.RTBoxPantalla.Text = "";
            // 
            // lbCantidadVentas
            // 
            this.lbCantidadVentas.AutoSize = true;
            this.lbCantidadVentas.BackColor = System.Drawing.Color.Transparent;
            this.lbCantidadVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCantidadVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCantidadVentas.Location = new System.Drawing.Point(144, 433);
            this.lbCantidadVentas.Name = "lbCantidadVentas";
            this.lbCantidadVentas.Size = new System.Drawing.Size(121, 17);
            this.lbCantidadVentas.TabIndex = 2;
            this.lbCantidadVentas.Text = "CantidadDeVentas";
            // 
            // CBoxCategorias
            // 
            this.CBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCategorias.FormattingEnabled = true;
            this.CBoxCategorias.Location = new System.Drawing.Point(22, 69);
            this.CBoxCategorias.Name = "CBoxCategorias";
            this.CBoxCategorias.Size = new System.Drawing.Size(134, 25);
            this.CBoxCategorias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorias";
            // 
            // BTMasVendido
            // 
            this.BTMasVendido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTMasVendido.FlatAppearance.BorderSize = 0;
            this.BTMasVendido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTMasVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMasVendido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTMasVendido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTMasVendido.Location = new System.Drawing.Point(182, 20);
            this.BTMasVendido.Name = "BTMasVendido";
            this.BTMasVendido.Size = new System.Drawing.Size(100, 74);
            this.BTMasVendido.TabIndex = 5;
            this.BTMasVendido.Text = "El mas vendido de la categoria";
            this.BTMasVendido.UseVisualStyleBackColor = false;
            this.BTMasVendido.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTPromedio
            // 
            this.BTPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTPromedio.FlatAppearance.BorderSize = 0;
            this.BTPromedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTPromedio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTPromedio.Location = new System.Drawing.Point(299, 22);
            this.BTPromedio.Name = "BTPromedio";
            this.BTPromedio.Size = new System.Drawing.Size(100, 73);
            this.BTPromedio.TabIndex = 6;
            this.BTPromedio.Text = "promedio por categoria";
            this.BTPromedio.UseVisualStyleBackColor = false;
            this.BTPromedio.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(22, 411);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(100, 39);
            this.BTSalir.TabIndex = 7;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // TBoxGanaciasTotales
            // 
            this.TBoxGanaciasTotales.Location = new System.Drawing.Point(271, 396);
            this.TBoxGanaciasTotales.Name = "TBoxGanaciasTotales";
            this.TBoxGanaciasTotales.ReadOnly = true;
            this.TBoxGanaciasTotales.Size = new System.Drawing.Size(128, 25);
            this.TBoxGanaciasTotales.TabIndex = 8;
            this.TBoxGanaciasTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(163, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ganacia totales";
            // 
            // TBoxVentasTotales
            // 
            this.TBoxVentasTotales.Location = new System.Drawing.Point(271, 430);
            this.TBoxVentasTotales.Name = "TBoxVentasTotales";
            this.TBoxVentasTotales.Size = new System.Drawing.Size(128, 25);
            this.TBoxVentasTotales.TabIndex = 10;
            this.TBoxVentasTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FRMContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 469);
            this.ControlBox = false;
            this.Controls.Add(this.TBoxVentasTotales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxGanaciasTotales);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.BTPromedio);
            this.Controls.Add(this.BTMasVendido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxCategorias);
            this.Controls.Add(this.lbCantidadVentas);
            this.Controls.Add(this.RTBoxPantalla);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBoxPantalla;
        private System.Windows.Forms.Label lbCantidadVentas;
        private System.Windows.Forms.ComboBox CBoxCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTMasVendido;
        private System.Windows.Forms.Button BTPromedio;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.TextBox TBoxGanaciasTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxVentasTotales;
    }
}