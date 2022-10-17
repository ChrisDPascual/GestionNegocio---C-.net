
namespace Pascual.Christian.PPLabII
{
    partial class FRMVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBoxTipo = new System.Windows.Forms.ComboBox();
            this.CBoxCategoria = new System.Windows.Forms.ComboBox();
            this.BTFiltroTipo = new System.Windows.Forms.Button();
            this.BTOkFiltroCategoria = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RTBoxListado = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTOkBuscarPorCodigo = new System.Windows.Forms.Button();
            this.TBoxBuscarPorCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBoxLegajo = new System.Windows.Forms.TextBox();
            this.NUpCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.TBoxProducto = new System.Windows.Forms.TextBox();
            this.TBBuscarPorCodigo = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBEfectivo = new System.Windows.Forms.RadioButton();
            this.RBCredito = new System.Windows.Forms.RadioButton();
            this.RBDebito = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TBoxEfectivo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TBoxVuelto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTQuitar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RBTClienteGenerico = new System.Windows.Forms.RadioButton();
            this.RTBoxFactura = new System.Windows.Forms.RichTextBox();
            this.BTPagar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.TBoxTotal = new System.Windows.Forms.TextBox();
            this.BTBuscarDNI = new System.Windows.Forms.Button();
            this.TBoxDNICliente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpCantidad)).BeginInit();
            this.TBBuscarPorCodigo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CBoxTipo);
            this.groupBox1.Controls.Add(this.CBoxCategoria);
            this.groupBox1.Controls.Add(this.BTFiltroTipo);
            this.groupBox1.Controls.Add(this.BTOkFiltroCategoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RTBoxListado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTOkBuscarPorCodigo);
            this.groupBox1.Controls.Add(this.TBoxBuscarPorCodigo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 438);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // CBoxTipo
            // 
            this.CBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTipo.FormattingEnabled = true;
            this.CBoxTipo.Location = new System.Drawing.Point(9, 138);
            this.CBoxTipo.Name = "CBoxTipo";
            this.CBoxTipo.Size = new System.Drawing.Size(147, 23);
            this.CBoxTipo.TabIndex = 16;
            // 
            // CBoxCategoria
            // 
            this.CBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCategoria.FormattingEnabled = true;
            this.CBoxCategoria.Location = new System.Drawing.Point(9, 88);
            this.CBoxCategoria.Name = "CBoxCategoria";
            this.CBoxCategoria.Size = new System.Drawing.Size(148, 23);
            this.CBoxCategoria.TabIndex = 17;
            // 
            // BTFiltroTipo
            // 
            this.BTFiltroTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTFiltroTipo.FlatAppearance.BorderSize = 0;
            this.BTFiltroTipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTFiltroTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTFiltroTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTFiltroTipo.Location = new System.Drawing.Point(162, 138);
            this.BTFiltroTipo.Name = "BTFiltroTipo";
            this.BTFiltroTipo.Size = new System.Drawing.Size(32, 24);
            this.BTFiltroTipo.TabIndex = 14;
            this.BTFiltroTipo.Text = "OK";
            this.BTFiltroTipo.UseVisualStyleBackColor = false;
            this.BTFiltroTipo.Click += new System.EventHandler(this.BTFiltroTipo_Click);
            // 
            // BTOkFiltroCategoria
            // 
            this.BTOkFiltroCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTOkFiltroCategoria.FlatAppearance.BorderSize = 0;
            this.BTOkFiltroCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTOkFiltroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOkFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTOkFiltroCategoria.Location = new System.Drawing.Point(162, 88);
            this.BTOkFiltroCategoria.Name = "BTOkFiltroCategoria";
            this.BTOkFiltroCategoria.Size = new System.Drawing.Size(32, 23);
            this.BTOkFiltroCategoria.TabIndex = 13;
            this.BTOkFiltroCategoria.Text = "OK";
            this.BTOkFiltroCategoria.UseVisualStyleBackColor = false;
            this.BTOkFiltroCategoria.Click += new System.EventHandler(this.BTOkFiltroCategoria_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Buscar por codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria:";
            // 
            // RTBoxListado
            // 
            this.RTBoxListado.Location = new System.Drawing.Point(9, 179);
            this.RTBoxListado.Name = "RTBoxListado";
            this.RTBoxListado.ReadOnly = true;
            this.RTBoxListado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBoxListado.Size = new System.Drawing.Size(279, 247);
            this.RTBoxListado.TabIndex = 4;
            this.RTBoxListado.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo:";
            // 
            // BTOkBuscarPorCodigo
            // 
            this.BTOkBuscarPorCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTOkBuscarPorCodigo.FlatAppearance.BorderSize = 0;
            this.BTOkBuscarPorCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTOkBuscarPorCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOkBuscarPorCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTOkBuscarPorCodigo.Location = new System.Drawing.Point(162, 39);
            this.BTOkBuscarPorCodigo.Name = "BTOkBuscarPorCodigo";
            this.BTOkBuscarPorCodigo.Size = new System.Drawing.Size(32, 23);
            this.BTOkBuscarPorCodigo.TabIndex = 3;
            this.BTOkBuscarPorCodigo.Text = "OK";
            this.BTOkBuscarPorCodigo.UseVisualStyleBackColor = false;
            this.BTOkBuscarPorCodigo.Click += new System.EventHandler(this.BTOkBuscarPorCodigo_Click);
            // 
            // TBoxBuscarPorCodigo
            // 
            this.TBoxBuscarPorCodigo.Location = new System.Drawing.Point(9, 39);
            this.TBoxBuscarPorCodigo.Name = "TBoxBuscarPorCodigo";
            this.TBoxBuscarPorCodigo.Size = new System.Drawing.Size(147, 23);
            this.TBoxBuscarPorCodigo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vendedor";
            // 
            // TBoxLegajo
            // 
            this.TBoxLegajo.Location = new System.Drawing.Point(67, 15);
            this.TBoxLegajo.Name = "TBoxLegajo";
            this.TBoxLegajo.Size = new System.Drawing.Size(65, 23);
            this.TBoxLegajo.TabIndex = 18;
            this.TBoxLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUpCantidad
            // 
            this.NUpCantidad.Location = new System.Drawing.Point(96, 161);
            this.NUpCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUpCantidad.Name = "NUpCantidad";
            this.NUpCantidad.Size = new System.Drawing.Size(36, 23);
            this.NUpCantidad.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(92, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cant.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto";
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTAgregar.FlatAppearance.BorderSize = 0;
            this.BTAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTAgregar.Location = new System.Drawing.Point(6, 190);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(126, 45);
            this.BTAgregar.TabIndex = 7;
            this.BTAgregar.Text = "Agregar >>";
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // TBoxProducto
            // 
            this.TBoxProducto.Location = new System.Drawing.Point(6, 161);
            this.TBoxProducto.Name = "TBoxProducto";
            this.TBoxProducto.Size = new System.Drawing.Size(85, 23);
            this.TBoxProducto.TabIndex = 5;
            // 
            // TBBuscarPorCodigo
            // 
            this.TBBuscarPorCodigo.BackColor = System.Drawing.Color.Transparent;
            this.TBBuscarPorCodigo.Controls.Add(this.groupBox2);
            this.TBBuscarPorCodigo.Controls.Add(this.label11);
            this.TBBuscarPorCodigo.Controls.Add(this.TBoxVuelto);
            this.TBBuscarPorCodigo.Controls.Add(this.label10);
            this.TBBuscarPorCodigo.Controls.Add(this.TBoxLegajo);
            this.TBBuscarPorCodigo.Controls.Add(this.BTQuitar);
            this.TBBuscarPorCodigo.Controls.Add(this.label8);
            this.TBBuscarPorCodigo.Controls.Add(this.label9);
            this.TBBuscarPorCodigo.Controls.Add(this.label2);
            this.TBBuscarPorCodigo.Controls.Add(this.label1);
            this.TBBuscarPorCodigo.Controls.Add(this.NUpCantidad);
            this.TBBuscarPorCodigo.Controls.Add(this.RBTClienteGenerico);
            this.TBBuscarPorCodigo.Controls.Add(this.label7);
            this.TBBuscarPorCodigo.Controls.Add(this.RTBoxFactura);
            this.TBBuscarPorCodigo.Controls.Add(this.BTAgregar);
            this.TBBuscarPorCodigo.Controls.Add(this.TBoxProducto);
            this.TBBuscarPorCodigo.Controls.Add(this.label6);
            this.TBBuscarPorCodigo.Controls.Add(this.BTPagar);
            this.TBBuscarPorCodigo.Controls.Add(this.BTCancelar);
            this.TBBuscarPorCodigo.Controls.Add(this.TBoxTotal);
            this.TBBuscarPorCodigo.Controls.Add(this.BTBuscarDNI);
            this.TBBuscarPorCodigo.Controls.Add(this.TBoxDNICliente);
            this.TBBuscarPorCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBBuscarPorCodigo.Location = new System.Drawing.Point(312, 12);
            this.TBBuscarPorCodigo.Name = "TBBuscarPorCodigo";
            this.TBBuscarPorCodigo.Size = new System.Drawing.Size(340, 438);
            this.TBBuscarPorCodigo.TabIndex = 15;
            this.TBBuscarPorCodigo.TabStop = false;
            this.TBBuscarPorCodigo.Text = "Pago";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.RBEfectivo);
            this.groupBox2.Controls.Add(this.RBCredito);
            this.groupBox2.Controls.Add(this.RBDebito);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TBoxEfectivo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(11, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 134);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medio de pago";
            // 
            // RBEfectivo
            // 
            this.RBEfectivo.AutoSize = true;
            this.RBEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBEfectivo.Location = new System.Drawing.Point(6, 17);
            this.RBEfectivo.Name = "RBEfectivo";
            this.RBEfectivo.Size = new System.Drawing.Size(71, 19);
            this.RBEfectivo.TabIndex = 27;
            this.RBEfectivo.TabStop = true;
            this.RBEfectivo.Text = "Efectivo";
            this.RBEfectivo.UseVisualStyleBackColor = true;
            this.RBEfectivo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RBCredito
            // 
            this.RBCredito.AutoSize = true;
            this.RBCredito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBCredito.Location = new System.Drawing.Point(6, 89);
            this.RBCredito.Name = "RBCredito";
            this.RBCredito.Size = new System.Drawing.Size(66, 19);
            this.RBCredito.TabIndex = 26;
            this.RBCredito.TabStop = true;
            this.RBCredito.Text = "Credito";
            this.RBCredito.UseVisualStyleBackColor = true;
            this.RBCredito.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RBDebito
            // 
            this.RBDebito.AutoSize = true;
            this.RBDebito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBDebito.Location = new System.Drawing.Point(6, 64);
            this.RBDebito.Name = "RBDebito";
            this.RBDebito.Size = new System.Drawing.Size(63, 19);
            this.RBDebito.TabIndex = 25;
            this.RBDebito.TabStop = true;
            this.RBDebito.Text = "Debito";
            this.RBDebito.UseVisualStyleBackColor = true;
            this.RBDebito.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(142, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Vuelto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(268, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "Factura";
            // 
            // TBoxEfectivo
            // 
            this.TBoxEfectivo.Location = new System.Drawing.Point(6, 35);
            this.TBoxEfectivo.Name = "TBoxEfectivo";
            this.TBoxEfectivo.ReadOnly = true;
            this.TBoxEfectivo.Size = new System.Drawing.Size(109, 23);
            this.TBoxEfectivo.TabIndex = 18;
            this.TBoxEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(138, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Total:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(246, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pagar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(138, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(142, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Vuelto";
            // 
            // TBoxVuelto
            // 
            this.TBoxVuelto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxVuelto.Location = new System.Drawing.Point(198, 348);
            this.TBoxVuelto.Name = "TBoxVuelto";
            this.TBoxVuelto.ReadOnly = true;
            this.TBoxVuelto.Size = new System.Drawing.Size(136, 25);
            this.TBoxVuelto.TabIndex = 22;
            this.TBoxVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(268, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Factura";
            // 
            // BTQuitar
            // 
            this.BTQuitar.BackColor = System.Drawing.Color.Red;
            this.BTQuitar.FlatAppearance.BorderSize = 0;
            this.BTQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTQuitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTQuitar.Location = new System.Drawing.Point(6, 241);
            this.BTQuitar.Name = "BTQuitar";
            this.BTQuitar.Size = new System.Drawing.Size(126, 45);
            this.BTQuitar.TabIndex = 21;
            this.BTQuitar.Text = "<< Quitar";
            this.BTQuitar.UseVisualStyleBackColor = false;
            this.BTQuitar.Click += new System.EventHandler(this.BTQuitar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "generico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar Cliente DNI:";
            // 
            // RBTClienteGenerico
            // 
            this.RBTClienteGenerico.AutoSize = true;
            this.RBTClienteGenerico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBTClienteGenerico.Location = new System.Drawing.Point(7, 94);
            this.RBTClienteGenerico.Name = "RBTClienteGenerico";
            this.RBTClienteGenerico.Size = new System.Drawing.Size(64, 19);
            this.RBTClienteGenerico.TabIndex = 7;
            this.RBTClienteGenerico.TabStop = true;
            this.RBTClienteGenerico.Text = "Cliente";
            this.RBTClienteGenerico.UseVisualStyleBackColor = true;
            this.RBTClienteGenerico.CheckedChanged += new System.EventHandler(this.RBTClienteGenerico_CheckedChanged);
            // 
            // RTBoxFactura
            // 
            this.RTBoxFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTBoxFactura.Location = new System.Drawing.Point(138, 40);
            this.RTBoxFactura.Name = "RTBoxFactura";
            this.RTBoxFactura.ReadOnly = true;
            this.RTBoxFactura.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBoxFactura.Size = new System.Drawing.Size(196, 270);
            this.RTBoxFactura.TabIndex = 4;
            this.RTBoxFactura.Text = "";
            // 
            // BTPagar
            // 
            this.BTPagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTPagar.FlatAppearance.BorderSize = 0;
            this.BTPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTPagar.Location = new System.Drawing.Point(246, 395);
            this.BTPagar.Name = "BTPagar";
            this.BTPagar.Size = new System.Drawing.Size(88, 31);
            this.BTPagar.TabIndex = 6;
            this.BTPagar.Text = "Pagar";
            this.BTPagar.UseVisualStyleBackColor = false;
            this.BTPagar.Click += new System.EventHandler(this.BTPagar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTCancelar.FlatAppearance.BorderSize = 0;
            this.BTCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTCancelar.Location = new System.Drawing.Point(153, 395);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(90, 31);
            this.BTCancelar.TabIndex = 5;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = false;
            this.BTCancelar.Click += new System.EventHandler(this.BTVSalir_Click);
            // 
            // TBoxTotal
            // 
            this.TBoxTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxTotal.Location = new System.Drawing.Point(198, 315);
            this.TBoxTotal.Name = "TBoxTotal";
            this.TBoxTotal.ReadOnly = true;
            this.TBoxTotal.Size = new System.Drawing.Size(136, 27);
            this.TBoxTotal.TabIndex = 3;
            this.TBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTBuscarDNI
            // 
            this.BTBuscarDNI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTBuscarDNI.FlatAppearance.BorderSize = 0;
            this.BTBuscarDNI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.BTBuscarDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarDNI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTBuscarDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTBuscarDNI.Location = new System.Drawing.Point(77, 94);
            this.BTBuscarDNI.Name = "BTBuscarDNI";
            this.BTBuscarDNI.Size = new System.Drawing.Size(56, 23);
            this.BTBuscarDNI.TabIndex = 1;
            this.BTBuscarDNI.Text = "Buscar";
            this.BTBuscarDNI.UseVisualStyleBackColor = false;
            this.BTBuscarDNI.Click += new System.EventHandler(this.BTBuscarDNI_Click);
            // 
            // TBoxDNICliente
            // 
            this.TBoxDNICliente.Location = new System.Drawing.Point(6, 65);
            this.TBoxDNICliente.Name = "TBoxDNICliente";
            this.TBoxDNICliente.Size = new System.Drawing.Size(126, 23);
            this.TBoxDNICliente.TabIndex = 0;
            // 
            // FRMVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pascual.Christian.PPLabII.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 456);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBBuscarPorCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpCantidad)).EndInit();
            this.TBBuscarPorCodigo.ResumeLayout(false);
            this.TBBuscarPorCodigo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.TextBox TBoxProducto;
        private System.Windows.Forms.RichTextBox RTBoxListado;
        private System.Windows.Forms.Button BTOkBuscarPorCodigo;
        private System.Windows.Forms.TextBox TBoxBuscarPorCodigo;
        private System.Windows.Forms.GroupBox TBBuscarPorCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBTClienteGenerico;
        private System.Windows.Forms.Button BTPagar;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.RichTextBox RTBoxFactura;
        private System.Windows.Forms.TextBox TBoxTotal;
        private System.Windows.Forms.Button BTBuscarDNI;
        private System.Windows.Forms.TextBox TBoxDNICliente;
        private System.Windows.Forms.NumericUpDown NUpCantidad;
        private System.Windows.Forms.Button BTFiltroTipo;
        private System.Windows.Forms.Button BTOkFiltroCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBoxLegajo;
        private System.Windows.Forms.ComboBox CBoxTipo;
        private System.Windows.Forms.ComboBox CBoxCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTQuitar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBoxVuelto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBEfectivo;
        private System.Windows.Forms.RadioButton RBCredito;
        private System.Windows.Forms.RadioButton RBDebito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBoxEfectivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}