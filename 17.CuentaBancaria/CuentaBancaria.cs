using System;

namespace _14.CuentaBancaria{
    [Serializable()]
    class CuentaBancaria{
        protected double saldo; // Permite ser accedido por las clases que heredan

        public CuentaBancaria(double saldo){
            this.saldo=saldo;
        }

        public double Saldo {
            get{return saldo;}
            set{saldo+=value;}
        }

        public double Deposita(double cantidad){
            saldo+=cantidad;
            return saldo;
        }

        //Metodo virtual que podra ser sobrecargado
        public virtual bool Retira(double cant){
            if(saldo>=cant){
                saldo-=cant;
                return true;
            }else{
                return false;
            }
        }
    }
}