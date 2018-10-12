using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibComponentes
{
    public class ConvTemperaturas: Component
    {
        private decimal _celsius;
        private decimal _fahrenheit;
        private decimal _kelvin;

        public ConvTemperaturas()
        {
            Celsius = 0;
        }


        [Category("Medidas de Temperatura"),
         Description("Temperatura em graus Celsius"),
         RefreshProperties(RefreshProperties.Repaint)]
        public decimal Celsius
        {
            get
            {
                return _celsius;
            }

            set
            {
                if (value >= -273)
                {
                    _celsius = value;
                    _fahrenheit = (_celsius * 9 / 5) + 32;
                    _kelvin = _celsius + 273;
                }
                else
                    throw new Exception("Celsius não pode ser menor que -273");
            }
        }

        [Category("Medidas de Temperatura"),
 Description("Temperatura em graus Fahrenheit"),
 RefreshProperties(RefreshProperties.Repaint)]
        public decimal Fahrenheit
        {
            get
            {
                return _fahrenheit;
            }

            set
            {
                if (value >= -459.4m)
                {
                    _fahrenheit = value;
                    _celsius = 5 * (_fahrenheit - 32) / 9;
                    _kelvin = _celsius + 273;
                }
                else
                    throw new Exception("Fahrenheit não pode ser menor que -459.4");
            }
        }

        [Category("Medidas de Temperatura"),
 Description("Temperatura em graus Kelvin"),
 RefreshProperties(RefreshProperties.Repaint)]
        public decimal Kelvin
        {
            get
            {
                return _kelvin;
            }

            set
            {
                if (value >= 0)
                {
                    _kelvin = value;
                    _celsius = _kelvin - 273;
                    _fahrenheit = (_celsius * 9 / 5) + 32;
                }
                else
                    throw new Exception("Kelvin não pode ser menor que 0");
            }
        }
    }
}
