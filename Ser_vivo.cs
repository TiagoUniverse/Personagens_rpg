
using System;

namespace Personagens_rpg
{

    class Ser_vivo
    {
        private string altura;
        private string cor_cabelo;
        private string peso;

        public string getAltura()
        {
          return altura;
        }

        public string getCor_cabelo()
        {
          return cor_cabelo;
        }

        public string getPeso()
        {
          return peso;
        }

        public void setAltura(string altura)
        {
          this.altura = altura;
        }

        public void setCor_Cabelo(string cor_cabelo)
        {
          this.cor_cabelo = cor_cabelo;
        }

        public void setPeso(string peso)
        {
          this.peso = peso;
        }
        public void Socar (){
          Console.WriteLine("\n ->>>>> Não to acreditando nisso! Vou socar este cara do bar!");  
        }

        public void BeberNoBar()
        {
          Console.WriteLine("\n ->>> Hummmm. Que delícia de bebida. \n GARÇOMMM! Me traz mais uma cerveja!");
        }

     
    }


}