using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AlcoolGasolina
{
    public class AlcoolOuGasolina: Component
    {
        private decimal _qtdAlcool;

        public decimal QtdAlcool
        {
            get { return _qtdAlcool; }
        }

        private decimal _qtdGasol;

        public decimal QtdGasol
        {
            get { return _qtdGasol; }
        }

        private void CalcResult()
        {
            _kmTotal = _qtdGasol * _consumoGasolina + _qtdAlcool * _consumoAlcool;
            _valorTotal = _qtdGasol * _precoGasolina + _qtdAlcool * _precoAlcool;
            _valorPorKm = _valorTotal / _kmTotal;
        }

        public event EventHandler MudouDadoEntrada;

        private decimal _litrosTanque;

        public decimal LitrosTanque
        {
            get { return _litrosTanque; }
            set 
            { 
                _litrosTanque = value;
                _qtdAlcool = _litrosTanque * _balancoAlcoolGasolina / 100;
                _qtdGasol = _litrosTanque * _balancoGasolinaAlcool / 100;
                CalcResult();
            }
        }

        private decimal _consumoAlcool;

        public decimal ConsumoAlcool
        {
            get { return _consumoAlcool; }
            set 
            { 
                _consumoAlcool = value;
                CalcResult();
            }
        }

        private decimal _consumoGasolina;

        public decimal ConsumoGasolina
        {
            get { return _consumoGasolina; }
            set 
            { 
                _consumoGasolina = value;
                CalcResult();
            }
        }

        private decimal _precoAlcool;

        public decimal PrecoAlcool
        {
            get { return _precoAlcool; }
            set 
            { 
                _precoAlcool = value;
                CalcResult();
            }
        }

        private decimal _precoGasolina;

        public decimal PrecoGasolina
        {
            get { return _precoGasolina; }
            set 
            { 
                _precoGasolina = value;
                CalcResult();
            }
        }

        private decimal _balancoAlcoolGasolina;

        public decimal BalancoAlcoolGasolina
        {
            get { return _balancoAlcoolGasolina; }
            set 
            {
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                _balancoAlcoolGasolina = value;
                _balancoGasolinaAlcool = 100 - value;
                _qtdAlcool = _litrosTanque * _balancoAlcoolGasolina / 100;
                _qtdGasol = _litrosTanque * _balancoGasolinaAlcool / 100;
                CalcResult();
            }
        }

        private decimal _balancoGasolinaAlcool;

        public decimal BalancoGasolonaAlcool
        {
            get { return _balancoGasolinaAlcool; }
            set 
            {
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                _balancoGasolinaAlcool = value; 
                _balancoAlcoolGasolina = 100 - value;
                _qtdAlcool = _litrosTanque * _balancoAlcoolGasolina / 100;
                _qtdGasol = _litrosTanque * _balancoGasolinaAlcool / 100;
                CalcResult();
            }
        }

        private decimal _kmTotal;

        public decimal KmTotal
        {
            get 
            {
                CalcResult();
                return _kmTotal; 
            }
        }

        private decimal _valorTotal;

        public decimal ValorTotal
        {
            get
            {
                CalcResult();
                return _valorTotal;
            }
        }

        private decimal _valorPorKm;

        public decimal ValorPorKm
        {
            get
            {
                CalcResult();
                return _valorPorKm;
            }
        }

        public AlcoolOuGasolina()
        {
            _litrosTanque = 40;
            _precoAlcool = 1.85m;
            _precoGasolina = 2.80m;
            _consumoAlcool = 6;
            _consumoGasolina = 10;
            _balancoGasolinaAlcool = 0;
        }
    }
}
