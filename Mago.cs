using System;

namespace Personagens_rpg
{
    class Mago : Ser_vivo
    {

        private string feitiço1;
        private string tipo_mago;
        private string feitiço2;

        public string getTipo_mago()
        {
            return tipo_mago;
        }

        public string getFeitiço1()
        {
            return feitiço1;
        }

        public string getFeitiço2()
        {
            return feitiço2;
        }

        public void setTipo_mago(string tipo_mago)
        {
            this.tipo_mago = tipo_mago;
        }

        public void setFeitiço1(string feitiço1)
        {
            this.feitiço1 = feitiço1;
        }

        public void setFeitiço2(string feitiço2)
        {
            this.feitiço2 = feitiço2;
        }


        public void lançar_feitiço1()
        {
            if (tipo_mago == null   || feitiço1 == null || feitiço2 == null   )
            {
                Console.WriteLine("Perai, aventureiro! Antes de ir pra luta, tem algo faltando saber sobre você!");
                Console.WriteLine("diga: que tipo de mago você é? ");
                setTipo_mago(Console.ReadLine());

                Console.WriteLine("Selecione seu 1ª feitiço ofensivo: ");
                setFeitiço1(Console.ReadLine());
                
                Console.WriteLine("Selecione seu 2ª feitiço ofensivo: ");
                setFeitiço2(Console.ReadLine());
                
            }

            Console.WriteLine("Toma essa! Feitiço: " + getFeitiço1());

        }

        

    }
}