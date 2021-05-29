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
        private string Color;
        private double Precio;

        private static int CantPrendas = 0;

        public clsDatosPrendas()
        {
            TipoPrenda = "";
            Marca = "";
            Talla = 0;
            Color = "";
            Precio = 0;
        }

        public clsDatosPrendas(string TipoPrenda, string Marca, int Talla, string Color, double Precio)
        {
            this.TipoPrenda = TipoPrenda;
            this.Marca = Marca;
            this.Talla = Talla;
            this.Color = Color;
            this.Precio = Precio;
        }

        public clsDatosPrendas(string TipoPrenda, string Marca, double Talla, string Color, double Precio)
        {
            this.TipoPrenda = TipoPrenda;
            this.Marca = Marca;
            this.Talla = (int) Talla;
            this.Color = Color;
            this.Precio = (int) Precio;
        }

        public string obtenerTipoPrenda()
        {
            return TipoPrenda;
        }

        public string obtenerMarca()
        {
            return Marca;
        }
        public int obtenerTalla()
        {
            return Talla;
        }

        public string obtenerColor()
        {
            return Color;
        }

        public double obtenerPrecio()
        {
            return Precio;
        }

        public void cambiarTipoPrenda(string TipoPrenda)
        {
            this.TipoPrenda = TipoPrenda;
        }

        public void cambiarMarca(string Marca)
        {
            this.Marca = Marca;
        }

        public void cambiarTalla(int Talla)
        {
            this.Talla = Talla;
        }

        public void cambiarColor(string Color)
        {
            this.Color = Color;
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
