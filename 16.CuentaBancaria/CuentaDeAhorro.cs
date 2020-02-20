using System;

namespace _14.CuentaBancaria
{
    class CuentaDeAhorro : CuentaBancaria { //Heredamos de cuenta bancaria.
        private double tasaInteres;

        public CuentaDeAhorro(double saldo, double tasaInteres)
            :base(saldo){
                this.tasaInteres=tasaInteres;
            } //llamada explicita al constructor de la clase base.

        public void CalcularInteres(){
            saldo+=(saldo*tasaInteres);
        }
    }
}