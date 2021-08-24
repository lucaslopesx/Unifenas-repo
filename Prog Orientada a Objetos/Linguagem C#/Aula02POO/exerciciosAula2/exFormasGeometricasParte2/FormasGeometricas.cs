using System;
using System.Collections.Generic;
using System.Text;

namespace exFormasGeometricasParte2
{
    class FormasGeometricas
    {
        private double largura;
        private double altura;
        private double areaTriangulo;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        

        public double Largura { get => largura; set => largura = value > 0 ? value : 0; }
        public double Altura { get => altura; set => altura = value > 0 ? value : 0; }
        //public double Largura
        //{
        //    get { return largura; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            this.largura = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Valor negativo inválido! Convertendo para positivo");
        //            value = value * (-1);
        //            this.largura = value;
        //        }
        //    }
        //}

        //public double Altura
        //{
        //    get { return altura; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            this.altura = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Valor negativo inválido! Convertendo para positivo");
        //            value = value * (-1);
        //            this.altura = value;
        //        }
        //    }
        //}
        public double AreaTriangulo
        {
            get
            {
                return (double)(largura * altura) / 2;
            }
        }
        

        public void gravarValores(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
        public string Mostrar()
        {
            string aux = "";

            aux += "Largura: " + Largura.ToString("0.00") + "\n Altura: " + Altura.ToString("0.00");
            aux += "\n Area: " + AreaTriangulo.ToString("0.00");
            return aux;
        }
    }
}
