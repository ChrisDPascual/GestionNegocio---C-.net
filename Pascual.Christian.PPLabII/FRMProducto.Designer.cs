
namespace Pascual.Christian.PPLabII
{
    partial class FRMProducto
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
            this.TBoxArticulo = new System.Windows.Forms.TextBox();
            this.TBoxCodigo = new System.Windows.Forms.TextBox();
            this.TBoxPrecio = new System.Windows.Forms.TextBox();
            this.CBoxCategoria = new System.Windows.Forms.ComboBox();
            this.CBoxTipo = new System.Windows.Forms.ComboBox();
            this.BTSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBoxMarca = new System.Windows.Forms.TextBox();
            this.TBoxStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBoxArticulo
            // 
            this.TBoxArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxArticulo.Location = new System.Drawing.Point(33, 37);
            this.TBoxArticulo.Name = "TBoxArticulo";
            this.TBoxArticulo.Size = new System.Drawing.Size(346, 23);
            this.TBoxArticulo.TabIndex = 0;
            // 
            // TBoxCodigo
            // 
            this.TBoxCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxCodigo.Location = new System.Drawing.Point(33, 209);
            this.TBoxCodigo.Name = "TBoxCodigo";
            this.TBoxCodigo.ReadOnly = true;
            this.TBoxCodigo.Size = new System.Drawing.Size(163, 23);
            this.TBoxCodigo.TabIndex = 2;
            // 
            // TBoxPrecio
            // 
            this.TBoxPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxPrecio.Location = new System.Drawing.Point(282, 93);
            this.TBoxPrecio.Name = "TBoxPrecio";
            this.TBoxPrecio.Size = new System.Drawing.Size(95, 23);
            this.TBoxPrecio.TabIndex = 3;
            // 
            // CBoxCategoria
            // 
            this.CBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBoxCategoria.FormattingEnabled = true;
            this.CBoxCategoria.Location = new System.Drawing.Point(33, 148);
            this.CBoxCategoria.Name = "CBoxCategoria";
            this.CBoxCategoria.Size = new System.Drawing.Size(163, 23);
            this.CBoxCategoria.TabIndex = 5;
            // 
            // CBoxTipo
            // 
            this.CBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBoxTipo.FormattingEnabled = true;
            this.CBoxTipo.Location = new System.Drawing.Point(216, 148);
            this.CBoxTipo.Name = "CBoxTipo";
            this.CBoxTipo.Size = new System.Drawing.Size(161, 23);
            this.CBoxTipo.TabIndex = 6;
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(215, 213);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(79, 46);
            this.BTSalir.TabIndex = 9;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Articulo";
            // 
            // LbProducto
            // 
            this.LbProducto.AutoSize = true;
            this.LbProducto.BackColor = System.Drawing.Color.Transparent;
            this.LbProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbProducto.Location = new System.Drawing.Point(33, 189);
            this.LbProducto.Name = "LbProducto";
            this.LbProducto.Size = new System.Drawing.Size(52, 17);
            this.LbProducto.TabIndex = 11;
            this.LbProducto.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(218, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(218, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(282, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio";
            // 
            // BTGuardar
            // 
            this.BTGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTGuardar.FlatAppearance.BorderSize = 0;
            this.BTGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTGuardar.Location = new System.Drawing.Point(300, 213);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(79, 46);
            this.BTGuardar.TabIndex = 16;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = false;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(33, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Marca";
            // 
            // TBoxMarca
            // 
            this.TBoxMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxMarca.Location = new System.Drawing.Point(33, 93);
            this.TBoxMarca.Name = "TBoxMarca";
            this.TBoxMarca.Size = new System.Drawing.Size(163, 23);
            this.TBoxMarca.TabIndex = 18;
            // 
            // TBoxStock
            // 
            this.TBoxStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxStock.Location = new System.Drawing.Point(218, 93);
            this.TBoxStock.Name = "TBoxStock";
            this.TBoxStock.Size = new System.Drawing.Size(41, 23);
            this.TBoxStock.TabIndex = 19;
            // 
            // FRMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 282);
            this.ControlBox = false;
            this.Controls.Add(this.TBoxStock);
            this.Controls.Add(this.TBoxMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.CBoxTipo);
            this.Controls.Add(this.CBoxCategoria);
            this.Controls.Add(this.TBoxPrecio);
            this.Controls.Add(this.TBoxCodigo);
            this.Controls.Add(this.TBoxArticulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxArticulo;
        private System.Windows.Forms.TextBox TBoxCodigo;
        private System.Windows.Forms.TextBox TBoxPrecio;
        private System.Windows.Forms.ComboBox CBoxCategoria;
        private System.Windows.Forms.ComboBox CBoxTipo;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBoxMarca;
        private System.Windows.Forms.TextBox TBoxStock;
    }
}