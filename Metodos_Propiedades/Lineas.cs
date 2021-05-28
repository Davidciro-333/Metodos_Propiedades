using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Metodos_Propiedades
{
    //La clase linea tiene variables de instancia y métodos
    //Las instancias son privadas y los métodos son públicos, 
    //Las instancias solo pueden obtenerse a través de los métodos.
    class Lineas
    {
        private int Xinicial;   //Variable para la posicion inicial en X
        private int Yinicial;   //Variable para la posicion inicial en X
        private int Xfinal;     //Variable para la posicion inicial en X
        private int Yfinal;     //Variable para la posicion inicial en X

        private static int Cant = 0;    //Variable estática para el conteo de las líneas

        public Lineas()     //Metodo para contruir el objeto sin parámetros
        { 
            //Por defecto tomará estos valores si no se ingresa un valor
            Xinicial = 0;   
            Yinicial = 0;
            Xfinal = 0;
            Yfinal = 0;
        }

        //Método para crear el objeto con parámetros¬
        public Lineas(int Xinicial, int Yinicial, int Xfinal, int Yfinal)   //Se mandan los valores X & Y inicial y final
        {
            this.Xinicial = Xinicial;
            this.Yinicial = Yinicial;
            this.Xfinal = Xfinal;
            this.Yfinal = Yfinal;
        }

        //Aquí observamos la sobrecarga de métodos, por que se pueden mandar valores de tipo
        //double también.
        public Lineas(double Xinicial, double Yinicial, double Xfinal, double Yfinal)
        {
            //Se hace la conversion de double a int
            this.Xinicial = (int) Xinicial;
            this.Yinicial = (int) Yinicial;
            this.Xfinal = (int) Xfinal;
            this.Yfinal = (int) Yfinal;
        }

        public int obtenerXinicial()
        {
            //Metodo que da la coordenada inicial de X
            return Xinicial;
        }

        public int obtenerYinicial()
        {
            //Metodo que da la coordenada inicial de Y
            return Yinicial;
        }

        public int obtenerXfinal()
        {
            //Metodo que da la coordenada final de X
            return Xfinal;
        }

        public int obtenerYfinal()
        {
            //Metodo que da la coordenada final de Y
            return Yfinal;
        }

        //Metodo para cambiar la posicion inicial de X
        public void cambiarXinicial(int Xinicial)
        {
            this.Xinicial = Xinicial;   //this se utiliza porque se esta utilizando (Xinicial)
            //como parámetro y como variable de instancia y esto es para que no se confunda
        }

        //Metodo para cambiar la posicion inicial de Y
        public void cambiarYinicial(int Yinicial)
        {
            this.Yinicial = Yinicial;   //this se utiliza porque se esta utilizando (Yinicial)
            //como parámetro y como variable de instancia y esto es para que no se confunda
        }

        //Metodo para cambiar la posicion final de X
        public void cambiarXfinal(int Xfinal)
        {
            this.Xfinal = Xfinal;   //this se utiliza porque se esta utilizando (Xfinal)
            //como parámetro y como variable de instancia y esto es para que no se confunda
        }

        //Metodo para cambiar la posicion final de Y
        public void cambiarYfinal(int Yfinal)
        {
            this.Yfinal = Yfinal;   //this se utiliza porque se esta utilizando (Yfinal)
            //como parámetro y como variable de instancia y esto es para que no se confunda
        }

        // Método estático, es un método a nivel de clase que se puede invocar a través
        // de ella.
        public static int obtenerCont()
        {
            Cant += 1;
            return Cant;
        }
    }
}
