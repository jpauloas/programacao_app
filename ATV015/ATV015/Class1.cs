using System;
using System.Collections.Generic;
using System.Text;

namespace ATV015
{
    class Retangulo
    {
        private double _largura;
        private double _altura;


        public Retangulo(double largura, double altura)
        {
            _largura = largura;
            _altura = altura;
        }
        public double GetLargura()
        {
            return _largura;
        }
        public void SetLargura(double largura)
        {
            _largura = largura;
        }
        public double GetAltura()
        {
            return _altura;
        }
        public void SetAltura(double altura)
        {
            _altura = altura;
        }
        public double Area()
        {
            return _largura * _altura;
        }
        public double Perimetro()
        {
            return 2 * (_largura + _altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(_largura, 2.0) + Math.Pow(_altura, 2.0));
        }
        public override string ToString()
        {
            return "Valor da area: " + Area().ToString("F2", CultureInfo.InvariantCulture) +
                "Valor do Perímetro " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                "Valor da Diagonal" + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
