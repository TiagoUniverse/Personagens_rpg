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

        public void Mago_possuiCadastro()
        {
            preencherPerfil();
            if (tipo_mago != null)
            {
                Console.WriteLine("->>>>> O seu mago está agora registrado na guilda!");
            }
        }
        public void lançar_feitiço1()
        {
            preencherPerfil();
            Console.WriteLine("->>>>> Toma essa! Feitiço: " + getFeitiço1());
        }

        public void lançar_feitiço2()
        {
            preencherPerfil();
            Console.WriteLine("->>>>> Agora! Lá vai o Feitiço: " + getFeitiço2());
        }

        public void codigo_cadastro()
        {
            Console.WriteLine("diga: que tipo de mago você é? ");
            setTipo_mago(Console.ReadLine());

            Console.WriteLine("Selecione seu 1ª feitiço ofensivo: ");
            setFeitiço1(Console.ReadLine());

            Console.WriteLine("Selecione seu 2ª feitiço ofensivo: ");
            setFeitiço2(Console.ReadLine());
        }
        public void preencherPerfil()
        {
            if (tipo_mago == null || feitiço1 == null || feitiço2 == null)
            {
                Console.WriteLine("\n Perai, aventureiro! Antes de ir pra luta, tem algo que a guilda está faltando saber sobre você!");
                codigo_cadastro();
            }
        }

        public void cadastro_mago(){
            Console.WriteLine("Seja bem vindo à guilda, seu mago!");
            codigo_cadastro();
        }
        public void alterarPerfil()
        {
            if (tipo_mago == null || feitiço1 == null || feitiço2 == null)
            {
                //Mandar o usuário ir pro cadastro e não pra alteração
                Console.WriteLine("->>>>> Primeiro, vá registrar o seu mago!");
            }
            else
            {
                Console.WriteLine("\n Muito bem, aventureiro! Vamos registrar outro mago.");
                codigo_cadastro();
            }

        }

    }
}