using System;
namespace TercerExamenParcial
{
    class RGBColor
    {
        string color;
        string numeroHexadecimal;
        public RGBColor(byte r,byte g, byte b){
            numeroHexadecimal="Color en hexadecimal "+r+g+b;
        }
        public string ToString(){
            return numeroHexadecimal;
        }
    }
}