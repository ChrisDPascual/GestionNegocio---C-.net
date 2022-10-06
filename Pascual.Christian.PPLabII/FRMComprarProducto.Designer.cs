
namespace Pascual.Christian.PPLabII
{
    partial class FRMComprarProducto
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
            this.NUpStock = new System.Windows.Forms.NumericUpDown();
            this.RBMostrarProducto = new System.Windows.Forms.RichTextBox();
            this.BTComprar = new System.Windows.Forms.Button();
            this.BTSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxProveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUpStock)).BeginInit();
            this.SuspendLayout();
            // 
            // NUpStock
            // 
            this.NUpStock.Location = new System.Drawing.Point(398, 182);
            this.NUpStock.Name = "NUpStock";
            this.NUpStock.Size = new System.Drawing.Size(71, 23);
            this.NUpStock.TabIndex = 0;
            // 
            // RBMostrarProducto
            // 
            this.RBMostrarProducto.Location = new System.Drawing.Point(166, 32);
            this.RBMostrarProducto.Name = "RBMostrarProducto";
            this.RBMostrarProducto.Size = new System.Drawing.Size(303, 124);
            this.RBMostrarProducto.TabIndex = 1;
            this.RBMostrarProducto.Text = "";
            // 
            // BTComprar
            // 
            this.BTComprar.BackColor = System.Drawing.Color.Maroon;
            this.BTComprar.FlatAppearance.BorderSize = 0;
            this.BTComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTComprar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTComprar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTComprar.Location = new System.Drawing.Point(343, 224);
            this.BTComprar.Name = "BTComprar";
            this.BTComprar.Size = new System.Drawing.Size(126, 61);
            this.BTComprar.TabIndex = 2;
            this.BTComprar.Text = "Comprar";
            this.BTComprar.UseVisualStyleBackColor = false;
            this.BTComprar.Click += new System.EventHandler(this.BTComprar_Click);
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(207, 224);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(126, 61);
            this.BTSalir.TabIndex = 3;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle producto";
            // 
            // CBoxProveedores
            // 
            this.CBoxProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxProveedores.FormattingEnabled = true;
            this.CBoxProveedores.Location = new System.Drawing.Point(166, 182);
            this.CBoxProveedores.Name = "CBoxProveedores";
            this.CBoxProveedores.Size = new System.Drawing.Size(225, 23);
            this.CBoxProveedores.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(166, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(398, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // FRMComprarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Alerta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 307);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.BTComprar);
            this.Controls.Add(this.RBMostrarProducto);
            this.Controls.Add(this.NUpStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMComprarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar producto";
            ((System.ComponentModel.ISupportInitialize)(this.NUpStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUpStock;
        private System.Windows.Forms.RichTextBox RBMostrarProducto;
        private System.Windows.Forms.Button BTComprar;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}