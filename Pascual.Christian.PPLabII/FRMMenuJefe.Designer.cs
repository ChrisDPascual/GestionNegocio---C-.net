
namespace Pascual.Christian.PPLabII
{
    partial class FRMMenuJefe
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
            this.BTModoVendedor = new System.Windows.Forms.Button();
            this.BTAdminEmpleados = new System.Windows.Forms.Button();
            this.BTStock = new System.Windows.Forms.Button();
            this.BTSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTModoVendedor
            // 
            this.BTModoVendedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTModoVendedor.FlatAppearance.BorderSize = 0;
            this.BTModoVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTModoVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModoVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTModoVendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTModoVendedor.Location = new System.Drawing.Point(73, 12);
            this.BTModoVendedor.Name = "BTModoVendedor";
            this.BTModoVendedor.Size = new System.Drawing.Size(207, 50);
            this.BTModoVendedor.TabIndex = 0;
            this.BTModoVendedor.Text = "Modo Vendedor";
            this.BTModoVendedor.UseVisualStyleBackColor = false;
            this.BTModoVendedor.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTAdminEmpleados
            // 
            this.BTAdminEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTAdminEmpleados.FlatAppearance.BorderSize = 0;
            this.BTAdminEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTAdminEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAdminEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTAdminEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTAdminEmpleados.Location = new System.Drawing.Point(73, 83);
            this.BTAdminEmpleados.Name = "BTAdminEmpleados";
            this.BTAdminEmpleados.Size = new System.Drawing.Size(207, 50);
            this.BTAdminEmpleados.TabIndex = 1;
            this.BTAdminEmpleados.Text = "Administrar empleados";
            this.BTAdminEmpleados.UseVisualStyleBackColor = false;
            this.BTAdminEmpleados.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTStock
            // 
            this.BTStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTStock.FlatAppearance.BorderSize = 0;
            this.BTStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTStock.Location = new System.Drawing.Point(73, 155);
            this.BTStock.Name = "BTStock";
            this.BTStock.Size = new System.Drawing.Size(207, 50);
            this.BTStock.TabIndex = 2;
            this.BTStock.Text = "Stock y producto";
            this.BTStock.UseVisualStyleBackColor = false;
            this.BTStock.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(208, 218);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(124, 39);
            this.BTSalir.TabIndex = 3;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRMMenuJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 269);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.BTStock);
            this.Controls.Add(this.BTAdminEmpleados);
            this.Controls.Add(this.BTModoVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMMenuJefe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Jefe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTModoVendedor;
        private System.Windows.Forms.Button BTAdminEmpleados;
        private System.Windows.Forms.Button BTStock;
        private System.Windows.Forms.Button BTSalir;
    }
}