using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Propiedades
{
    class clsDatosPrendas
    {
        private string TipoPrenda;
        private string Marca;
        private int Talla;
        private double Precio;

        private static int CantPrendas = 0;

        public clsDatosPrendas()
        {
            TipoPrenda = "";
            Marca = "";
            Talla = 0;
            Precio = 0;
        }

        public clsDatosPrendas(string TipoPrenda, string Marca, int Talla, double Precio)
        {
            this.TipoPrenda = TipoPrenda;
            this.Marca = Marca;
            this.Talla = Talla;
            this.Precio = Precio;
        }

        public clsDatosPrendas(string TipoPrenda, string Marca, double Talla, double Precio)
        {
            this.TipoPrenda = TipoPrenda;
            this.Marca = Marca;
            this.Talla = (int) Talla;
            this.Precio = (int) Precio;
        }

        public int obtenerTalla()
        {
            return Talla;
        }

        public double obtenerPrecio()
        {
            return Precio;
        }

        public void cambiarTalla(int Talla)
        {
            this.Talla = Talla;
        }

        public void cambiarPrecio(double Precio)
        {
            this.Precio = Precio;
        }

        public static int ContPrendas()
        {
            CantPrendas += 1;
            return CantPrendas;
        }
    }
}
