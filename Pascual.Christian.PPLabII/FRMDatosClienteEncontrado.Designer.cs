
namespace Pascual.Christian.PPLabII
{
    partial class FRMDatosClienteEncontrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDatosClienteEncontrado));
            this.RTBoxDatosCliente = new System.Windows.Forms.RichTextBox();
            this.BTSalir = new System.Windows.Forms.Button();
            this.BTModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RTBoxDatosCliente
            // 
            this.RTBoxDatosCliente.Location = new System.Drawing.Point(23, 42);
            this.RTBoxDatosCliente.Name = "RTBoxDatosCliente";
            this.RTBoxDatosCliente.Size = new System.Drawing.Size(285, 115);
            this.RTBoxDatosCliente.TabIndex = 0;
            this.RTBoxDatosCliente.Text = "";
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(120, 173);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(91, 32);
            this.BTSalir.TabIndex = 1;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // BTModificar
            // 
            this.BTModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTModificar.FlatAppearance.BorderSize = 0;
            this.BTModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTModificar.Location = new System.Drawing.Point(217, 173);
            this.BTModificar.Name = "BTModificar";
            this.BTModificar.Size = new System.Drawing.Size(91, 32);
            this.BTModificar.TabIndex = 2;
            this.BTModificar.Text = "Modificar";
            this.BTModificar.UseVisualStyleBackColor = false;
            this.BTModificar.Click += new System.EventHandler(this.BTModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos Cliente";
            // 
            // FRMDatosClienteEncontrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTModificar);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.RTBoxDatosCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMDatosClienteEncontrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBoxDatosCliente;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.Button BTModificar;
        private System.Windows.Forms.Label label1;
    }
}