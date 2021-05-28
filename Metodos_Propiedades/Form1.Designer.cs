
namespace Metodos_Propiedades
{
    partial class frmLinea
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXinicial = new System.Windows.Forms.Label();
            this.lblYinicial = new System.Windows.Forms.Label();
            this.lblXfinal = new System.Windows.Forms.Label();
            this.lblYfinal = new System.Windows.Forms.Label();
            this.txtXinicial = new System.Windows.Forms.TextBox();
            this.txtYinicial = new System.Windows.Forms.TextBox();
            this.txtXfinal = new System.Windows.Forms.TextBox();
            this.txtYfinal = new System.Windows.Forms.TextBox();
            this.lblCantLineas = new System.Windows.Forms.Label();
            this.txtCantLineas = new System.Windows.Forms.TextBox();
            this.btnCrearLinea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXinicial
            // 
            this.lblXinicial.AutoSize = true;
            this.lblXinicial.Location = new System.Drawing.Point(47, 104);
            this.lblXinicial.Name = "lblXinicial";
            this.lblXinicial.Size = new System.Drawing.Size(44, 13);
            this.lblXinicial.TabIndex = 0;
            this.lblXinicial.Text = "X Inicial";
            // 
            // lblYinicial
            // 
            this.lblYinicial.AutoSize = true;
            this.lblYinicial.Location = new System.Drawing.Point(189, 104);
            this.lblYinicial.Name = "lblYinicial";
            this.lblYinicial.Size = new System.Drawing.Size(44, 13);
            this.lblYinicial.TabIndex = 1;
            this.lblYinicial.Text = "Y Inicial";
            // 
            // lblXfinal
            // 
            this.lblXfinal.AutoSize = true;
            this.lblXfinal.Location = new System.Drawing.Point(52, 138);
            this.lblXfinal.Name = "lblXfinal";
            this.lblXfinal.Size = new System.Drawing.Size(39, 13);
            this.lblXfinal.TabIndex = 2;
            this.lblXfinal.Text = "X Final";
            // 
            // lblYfinal
            // 
            this.lblYfinal.AutoSize = true;
            this.lblYfinal.Location = new System.Drawing.Point(194, 138);
            this.lblYfinal.Name = "lblYfinal";
            this.lblYfinal.Size = new System.Drawing.Size(39, 13);
            this.lblYfinal.TabIndex = 3;
            this.lblYfinal.Text = "Y Final";
            // 
            // txtXinicial
            // 
            this.txtXinicial.Location = new System.Drawing.Point(97, 101);
            this.txtXinicial.Name = "txtXinicial";
            this.txtXinicial.Size = new System.Drawing.Size(60, 20);
            this.txtXinicial.TabIndex = 4;
            // 
            // txtYinicial
            // 
            this.txtYinicial.Location = new System.Drawing.Point(239, 101);
            this.txtYinicial.Name = "txtYinicial";
            this.txtYinicial.Size = new System.Drawing.Size(60, 20);
            this.txtYinicial.TabIndex = 5;
            // 
            // txtXfinal
            // 
            this.txtXfinal.Location = new System.Drawing.Point(97, 135);
            this.txtXfinal.Name = "txtXfinal";
            this.txtXfinal.Size = new System.Drawing.Size(60, 20);
            this.txtXfinal.TabIndex = 6;
            // 
            // txtYfinal
            // 
            this.txtYfinal.Location = new System.Drawing.Point(239, 135);
            this.txtYfinal.Name = "txtYfinal";
            this.txtYfinal.Size = new System.Drawing.Size(60, 20);
            this.txtYfinal.TabIndex = 7;
            // 
            // lblCantLineas
            // 
            this.lblCantLineas.AutoSize = true;
            this.lblCantLineas.Location = new System.Drawing.Point(325, 197);
            this.lblCantLineas.Name = "lblCantLineas";
            this.lblCantLineas.Size = new System.Drawing.Size(94, 13);
            this.lblCantLineas.TabIndex = 9;
            this.lblCantLineas.Text = "Cantidad de lineas";
            // 
            // txtCantLineas
            // 
            this.txtCantLineas.Location = new System.Drawing.Point(328, 222);
            this.txtCantLineas.Name = "txtCantLineas";
            this.txtCantLineas.ReadOnly = true;
            this.txtCantLineas.Size = new System.Drawing.Size(44, 20);
            this.txtCantLineas.TabIndex = 10;
            // 
            // btnCrearLinea
            // 
            this.btnCrearLinea.Location = new System.Drawing.Point(136, 179);
            this.btnCrearLinea.Name = "btnCrearLinea";
            this.btnCrearLinea.Size = new System.Drawing.Size(83, 31);
            this.btnCrearLinea.TabIndex = 8;
            this.btnCrearLinea.Text = "Crear Linea";
            this.btnCrearLinea.UseVisualStyleBackColor = true;
            // 
            // frmLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 421);
            this.Controls.Add(this.btnCrearLinea);
            this.Controls.Add(this.txtCantLineas);
            this.Controls.Add(this.lblCantLineas);
            this.Controls.Add(this.txtYfinal);
            this.Controls.Add(this.txtXfinal);
            this.Controls.Add(this.txtYinicial);
            this.Controls.Add(this.txtXinicial);
            this.Controls.Add(this.lblYfinal);
            this.Controls.Add(this.lblXfinal);
            this.Controls.Add(this.lblYinicial);
            this.Controls.Add(this.lblXinicial);
            this.Name = "frmLinea";
            this.Text = "Crear Linea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXinicial;
        private System.Windows.Forms.Label lblYinicial;
        private System.Windows.Forms.Label lblXfinal;
        private System.Windows.Forms.Label lblYfinal;
        private System.Windows.Forms.TextBox txtXinicial;
        private System.Windows.Forms.TextBox txtYinicial;
        private System.Windows.Forms.TextBox txtXfinal;
        private System.Windows.Forms.TextBox txtYfinal;
        private System.Windows.Forms.Label lblCantLineas;
        private System.Windows.Forms.TextBox txtCantLineas;
        private System.Windows.Forms.Button btnCrearLinea;
    }
}

