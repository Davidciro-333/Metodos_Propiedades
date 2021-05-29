using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Metodos_Propiedades
{
    public partial class frmLinea : MaterialForm
    {
        Graphics Graphics;
        public frmLinea()
        {
            InitializeComponent();
            Graphics = CreateGraphics();
        }

        private void btnCrearLinea_Click(object sender, EventArgs e)
        {
            try
            {
                Pen pen = new Pen(Brushes.BurlyWood);
                double Xinicial = double.Parse(txtXinicial.Text);
                double Yinicial = double.Parse(txtYinicial.Text);
                double Xfinal = double.Parse(txtXfinal.Text);
                double Yfinal = double.Parse(txtYfinal.Text);

                Lineas line = new Lineas(Xinicial, Yinicial, Xfinal, Yfinal);

                Graphics.DrawLine(pen, line.obtenerXinicial(), line.obtenerYinicial(), line.obtenerXfinal(), line.obtenerYfinal());

                txtCantLineas.Text = Convert.ToString(Lineas.obtenerCont());
            }
            catch
            {
                MessageBox.Show("Digite valores de tipo numerico");
            }
            
        }

        private void btnPasarPrendas_Click(object sender, EventArgs e)
        {
            frmPrendas prendas = new frmPrendas();
            prendas.Show();
        }
    }
}
