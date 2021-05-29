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
        frmLinea linea = new frmLinea();
        public int cont = 0;
        public frmPrendas()
        {
            InitializeComponent();
            tmrCerrarLinea.Enabled = true;
        }

        private void tmrCerrarLinea_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont == 2)
            {
                linea.Close();
                tmrCerrarLinea.Enabled = false;
            }
        }
    }
}
