using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraExemplo.Models
{
    public class Calculadora
    {
        private int x;
        private int y;
        private int angulo;
        public Calculadora(int x = 0, int y = 0, int angulo = 0){this.x = x; this.y = y; this.angulo = angulo;}
        public void getX(int x){   this.x = x;   }
        public void getY(int y){   this.y = y;   }
        public void getAngulo(int angulo){  this.angulo = angulo;}
        public string somar(int x, int y){    return $"{x} + {y} = {x + y}";  }
        public string subtrair(int x, int y){     return $"{x} - {y} = {x - y}";   }
        public string multiplicar(int x, int y){     return $"{x} x {y} = {x * y}";   }
        public string dividir(int x, int y){     
            double resultadoDivisao = (double)x / y;
            return $"{x} / {y} = {resultadoDivisao}";   
        }
        public string potencia(int x, int y){     
            double pot = Math.Pow(x, y);
            return$"{x}^{y} = {pot}";
        }
        public string seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            return $"Seno de {angulo}º = {Math.Round(seno, 4)}";
        }
        public string conseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            return $"Coseno de {angulo}º = {Math.Round(coseno, 4)}";
        }
        public string tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            return $"Tangente de {angulo}º = {Math.Round(tangente, 4)}";
        }
        public string raizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            return $"Raiz Quadrada de {x} = {raiz}";
        }
    }
}