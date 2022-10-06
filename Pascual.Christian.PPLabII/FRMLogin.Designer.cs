
namespace Pascual.Christian.PPLabII
{
    partial class FRMLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTEntrar = new System.Windows.Forms.Button();
            this.BTSalir = new System.Windows.Forms.Button();
            this.RBModoJefe = new System.Windows.Forms.RadioButton();
            this.RBModoVendedor = new System.Windows.Forms.RadioButton();
            this.TxtBoxUsuario = new System.Windows.Forms.TextBox();
            this.TxTBoxPassword = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTEntrar
            // 
            this.BTEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTEntrar.FlatAppearance.BorderSize = 0;
            this.BTEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTEntrar.Location = new System.Drawing.Point(143, 129);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(98, 37);
            this.BTEntrar.TabIndex = 0;
            this.BTEntrar.Text = "Login";
            this.BTEntrar.UseVisualStyleBackColor = false;
            this.BTEntrar.Click += new System.EventHandler(this.BTEntrar_Click);
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTSalir.Location = new System.Drawing.Point(248, 129);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(98, 37);
            this.BTSalir.TabIndex = 1;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // RBModoJefe
            // 
            this.RBModoJefe.AutoSize = true;
            this.RBModoJefe.BackColor = System.Drawing.Color.Transparent;
            this.RBModoJefe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBModoJefe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RBModoJefe.Location = new System.Drawing.Point(23, 129);
            this.RBModoJefe.Name = "RBModoJefe";
            this.RBModoJefe.Size = new System.Drawing.Size(84, 19);
            this.RBModoJefe.TabIndex = 2;
            this.RBModoJefe.TabStop = true;
            this.RBModoJefe.Text = "Modo Jefe";
            this.RBModoJefe.UseVisualStyleBackColor = false;
            this.RBModoJefe.CheckedChanged += new System.EventHandler(this.RBModoJefe_CheckedChanged);
            // 
            // RBModoVendedor
            // 
            this.RBModoVendedor.AutoSize = true;
            this.RBModoVendedor.BackColor = System.Drawing.Color.Transparent;
            this.RBModoVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBModoVendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBModoVendedor.Location = new System.Drawing.Point(23, 147);
            this.RBModoVendedor.Name = "RBModoVendedor";
            this.RBModoVendedor.Size = new System.Drawing.Size(114, 19);
            this.RBModoVendedor.TabIndex = 3;
            this.RBModoVendedor.TabStop = true;
            this.RBModoVendedor.Text = "Modo Vendedor";
            this.RBModoVendedor.UseVisualStyleBackColor = false;
            this.RBModoVendedor.CheckedChanged += new System.EventHandler(this.RBModoVendedor_CheckedChanged);
            // 
            // TxtBoxUsuario
            // 
            this.TxtBoxUsuario.Location = new System.Drawing.Point(23, 29);
            this.TxtBoxUsuario.Name = "TxtBoxUsuario";
            this.TxtBoxUsuario.Size = new System.Drawing.Size(323, 23);
            this.TxtBoxUsuario.TabIndex = 4;
            // 
            // TxTBoxPassword
            // 
            this.TxTBoxPassword.Location = new System.Drawing.Point(23, 79);
            this.TxTBoxPassword.Name = "TxTBoxPassword";
            this.TxTBoxPassword.Size = new System.Drawing.Size(323, 23);
            this.TxTBoxPassword.TabIndex = 5;
            this.TxTBoxPassword.UseSystemPasswordChar = true;
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LblContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblContraseña.Location = new System.Drawing.Point(23, 55);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(96, 21);
            this.LblContraseña.TabIndex = 7;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblUsuario.Location = new System.Drawing.Point(23, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(66, 20);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "Usuario:";
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.BlueLock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 187);
            this.ControlBox = false;
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.TxTBoxPassword);
            this.Controls.Add(this.TxtBoxUsuario);
            this.Controls.Add(this.RBModoVendedor);
            this.Controls.Add(this.RBModoJefe);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.BTEntrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMLogin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.RadioButton RBModoJefe;
        private System.Windows.Forms.RadioButton RBModoVendedor;
        private System.Windows.Forms.TextBox TxtBoxUsuario;
        private System.Windows.Forms.TextBox TxTBoxPassword;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblUsuario;
    }
}

