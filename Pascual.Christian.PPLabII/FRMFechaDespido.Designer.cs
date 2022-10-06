
namespace Pascual.Christian.PPLabII
{
    partial class FRMFechaDespido
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
            this.NUpDia = new System.Windows.Forms.NumericUpDown();
            this.NUpMes = new System.Windows.Forms.NumericUpDown();
            this.TBoxAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTModificar = new System.Windows.Forms.Button();
            this.BTSalir = new System.Windows.Forms.Button();
            this.TxBoxLegajo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBoxFechaDespido = new System.Windows.Forms.TextBox();
            this.TBoxInicioActiv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpMes)).BeginInit();
            this.SuspendLayout();
            // 
            // NUpDia
            // 
            this.NUpDia.Location = new System.Drawing.Point(137, 162);
            this.NUpDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NUpDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUpDia.Name = "NUpDia";
            this.NUpDia.Size = new System.Drawing.Size(45, 23);
            this.NUpDia.TabIndex = 0;
            this.NUpDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUpMes
            // 
            this.NUpMes.Location = new System.Drawing.Point(188, 162);
            this.NUpMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUpMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUpMes.Name = "NUpMes";
            this.NUpMes.Size = new System.Drawing.Size(46, 23);
            this.NUpMes.TabIndex = 1;
            this.NUpMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TBoxAnio
            // 
            this.TBoxAnio.Location = new System.Drawing.Point(240, 162);
            this.TBoxAnio.Name = "TBoxAnio";
            this.TBoxAnio.Size = new System.Drawing.Size(122, 23);
            this.TBoxAnio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(251, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha despido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(137, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nueva fecha despido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(137, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(188, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(240, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Año";
            // 
            // BTModificar
            // 
            this.BTModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTModificar.FlatAppearance.BorderSize = 0;
            this.BTModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTModificar.Location = new System.Drawing.Point(270, 215);
            this.BTModificar.Name = "BTModificar";
            this.BTModificar.Size = new System.Drawing.Size(92, 42);
            this.BTModificar.TabIndex = 9;
            this.BTModificar.Text = "Modificar";
            this.BTModificar.UseVisualStyleBackColor = false;
            this.BTModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSalir.FlatAppearance.BorderSize = 0;
            this.BTSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTSalir.Location = new System.Drawing.Point(157, 215);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(93, 42);
            this.BTSalir.TabIndex = 10;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxBoxLegajo
            // 
            this.TxBoxLegajo.Location = new System.Drawing.Point(117, 35);
            this.TxBoxLegajo.Name = "TxBoxLegajo";
            this.TxBoxLegajo.ReadOnly = true;
            this.TxBoxLegajo.Size = new System.Drawing.Size(245, 23);
            this.TxBoxLegajo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(117, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Legajo";
            // 
            // TBoxFechaDespido
            // 
            this.TBoxFechaDespido.Location = new System.Drawing.Point(251, 92);
            this.TBoxFechaDespido.Name = "TBoxFechaDespido";
            this.TBoxFechaDespido.ReadOnly = true;
            this.TBoxFechaDespido.Size = new System.Drawing.Size(111, 23);
            this.TBoxFechaDespido.TabIndex = 13;
            // 
            // TBoxInicioActiv
            // 
            this.TBoxInicioActiv.Location = new System.Drawing.Point(116, 92);
            this.TBoxInicioActiv.Name = "TBoxInicioActiv";
            this.TBoxInicioActiv.ReadOnly = true;
            this.TBoxInicioActiv.Size = new System.Drawing.Size(115, 23);
            this.TBoxInicioActiv.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(116, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inicio actividades";
            // 
            // FRMFechaDespido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Alerta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 269);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBoxInicioActiv);
            this.Controls.Add(this.TBoxFechaDespido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxBoxLegajo);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.BTModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoxAnio);
            this.Controls.Add(this.NUpMes);
            this.Controls.Add(this.NUpDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMFechaDespido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fecha despido";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUpDia;
        private System.Windows.Forms.NumericUpDown NUpMes;
        private System.Windows.Forms.TextBox TBoxAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTModificar;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.TextBox TxBoxLegajo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBoxFechaDespido;
        private System.Windows.Forms.TextBox TBoxInicioActiv;
        private System.Windows.Forms.Label label7;
    }
}