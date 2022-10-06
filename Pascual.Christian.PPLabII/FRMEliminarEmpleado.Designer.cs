
namespace Pascual.Christian.PPLabII
{
    partial class FRMEliminarEmpleado
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
            this.BTSalir = new System.Windows.Forms.Button();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.RTBoxDatosEmpleado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxLegajo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(299, 220);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(136, 44);
            this.BTSalir.TabIndex = 0;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // BTEliminar
            // 
            this.BTEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTEliminar.FlatAppearance.BorderSize = 0;
            this.BTEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTEliminar.Location = new System.Drawing.Point(441, 220);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(135, 44);
            this.BTEliminar.TabIndex = 1;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.UseVisualStyleBackColor = false;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // RTBoxDatosEmpleado
            // 
            this.RTBoxDatosEmpleado.Location = new System.Drawing.Point(180, 105);
            this.RTBoxDatosEmpleado.Name = "RTBoxDatosEmpleado";
            this.RTBoxDatosEmpleado.ReadOnly = true;
            this.RTBoxDatosEmpleado.Size = new System.Drawing.Size(396, 80);
            this.RTBoxDatosEmpleado.TabIndex = 2;
            this.RTBoxDatosEmpleado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(180, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(180, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese legajo:";
            // 
            // TBoxLegajo
            // 
            this.TBoxLegajo.Location = new System.Drawing.Point(180, 44);
            this.TBoxLegajo.Name = "TBoxLegajo";
            this.TBoxLegajo.Size = new System.Drawing.Size(144, 23);
            this.TBoxLegajo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(347, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Alerta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 285);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBoxLegajo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBoxDatosEmpleado);
            this.Controls.Add(this.BTEliminar);
            this.Controls.Add(this.BTSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMEliminarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.RichTextBox RTBoxDatosEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxLegajo;
        private System.Windows.Forms.Button button1;
    }
}