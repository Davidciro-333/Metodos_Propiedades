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
    public partial class frmPrendas : MaterialForm
    {
        public frmPrendas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string TipoPrenda = cmbTipoPrenda.Text;
                string Marca = cmbMarca.Text;
                int Talla = Convert.ToInt32(txtTalla.Text);
                string Color = cmbColor.Text;
                double Precio = Convert.ToDouble(txtPrecio.Text);

                clsDatosPrendas datosPrendas = new clsDatosPrendas(TipoPrenda, Marca, Talla, Color, Precio);

                dtgPrendas.Rows.Add(datosPrendas.obtenerTipoPrenda(), datosPrendas.obtenerMarca(), datosPrendas.obtenerTalla(), datosPrendas.obtenerColor(), datosPrendas.obtenerPrecio());
                txtContPrenda.Text = Convert.ToString(clsDatosPrendas.ContPrendas());
            }
            catch
            {
                MessageBox.Show("Digite valores de tipo númerico");
                txtTalla.Text = "";
            }
            
        }
    }
}
