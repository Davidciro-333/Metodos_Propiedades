
namespace Metodos_Propiedades
{
    partial class frmPrendas
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
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoPrenda = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtContPrenda = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dtgPrendas = new System.Windows.Forms.DataGridView();
            this.clmTipoPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrenda.Location = new System.Drawing.Point(48, 116);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(82, 19);
            this.lblTipoPrenda.TabIndex = 0;
            this.lblTipoPrenda.Text = "Tipo Prenda";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.Location = new System.Drawing.Point(48, 152);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(36, 19);
            this.lblTalla.TabIndex = 1;
            this.lblTalla.Text = "Talla";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(48, 191);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 19);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(299, 116);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 19);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(299, 152);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 19);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contador prendas";
            // 
            // cmbTipoPrenda
            // 
            this.cmbTipoPrenda.FormattingEnabled = true;
            this.cmbTipoPrenda.Items.AddRange(new object[] {
            "Juvenil",
            "Deportiva",
            "Elegante",
            "Casual"});
            this.cmbTipoPrenda.Location = new System.Drawing.Point(137, 113);
            this.cmbTipoPrenda.Name = "cmbTipoPrenda";
            this.cmbTipoPrenda.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPrenda.TabIndex = 6;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Arquitect",
            "Pat Primo",
            "Nike",
            "Gef"});
            this.cmbMarca.Location = new System.Drawing.Point(353, 117);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 7;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(137, 150);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(121, 20);
            this.txtTalla.TabIndex = 8;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Gris",
            "Azul"});
            this.cmbColor.Location = new System.Drawing.Point(353, 153);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(137, 190);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtContPrenda
            // 
            this.txtContPrenda.Location = new System.Drawing.Point(442, 227);
            this.txtContPrenda.Name = "txtContPrenda";
            this.txtContPrenda.ReadOnly = true;
            this.txtContPrenda.Size = new System.Drawing.Size(32, 20);
            this.txtContPrenda.TabIndex = 12;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(137, 222);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 23);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dtgPrendas
            // 
            this.dtgPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTipoPrenda,
            this.clmMarca,
            this.clmTalla,
            this.clmColor,
            this.clmPrecio});
            this.dtgPrendas.Location = new System.Drawing.Point(52, 253);
            this.dtgPrendas.Name = "dtgPrendas";
            this.dtgPrendas.ReadOnly = true;
            this.dtgPrendas.Size = new System.Drawing.Size(562, 169);
            this.dtgPrendas.TabIndex = 13;
            // 
            // clmTipoPrenda
            // 
            this.clmTipoPrenda.HeaderText = "Tipo Prenda";
            this.clmTipoPrenda.Name = "clmTipoPrenda";
            this.clmTipoPrenda.ReadOnly = true;
            // 
            // clmMarca
            // 
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            // 
            // clmTalla
            // 
            this.clmTalla.HeaderText = "Talla";
            this.clmTalla.Name = "clmTalla";
            this.clmTalla.ReadOnly = true;
            // 
            // clmColor
            // 
            this.clmColor.HeaderText = "Color";
            this.clmColor.Name = "clmColor";
            this.clmColor.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // frmPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.dtgPrendas);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContPrenda);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbTipoPrenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblTipoPrenda);
            this.Name = "frmPrendas";
            this.Text = "Prendas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoPrenda;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtContPrenda;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dtgPrendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
    }
}