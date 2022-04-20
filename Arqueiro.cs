using System;

namespace Personagens_rpg
{
    class Arqueiro : Ser_vivo
    {
        private int quantidade_flechas;
        private string nome_arqueiro;

        public string getQuantidade_flechas()
        {
            return quantidade_flechas;
        }

        public void setQuantidade_flechas(string quantidade_flechas)
        {
            this.quantidade_flechas = quantidade_flechas;
        }

        public void atirar_flecha()
        {
            preencher_arqueiro();
            if (getQuantidade_flechas() == 0)
            {
                //Pede ao usuário para recarregar as flechas
                Console.WriteLine("Sem flechas para atirar! Vá recarregar na guilda.");
            }
            else
            {
                Console.WriteLine("Eu sempre acerto. Atirando uma flecha rápida!");
            }
        }

        public void recarregar_flecha()
        {
            preencher_arqueiro();
            //Somando mais uma flecha
            getQuantidade_flechas()++;
            Console.WriteLine("Comprando mais uma flecha!");
        }

        public void verificar_flechas()
        {
            preencher_arqueiro();
            if (getQuantidade_flechas() == 0)
            {
                Console.WriteLine("Você não possui nenhuma flecha!");
            }
            else
            {
                Console.WriteLine("Voce possui " + getQuantidade_flechas() + "de flechas!");
            }
        }

        public void preencher_arqueiro()
        {
            if (nome_arqueiro == null)
            {
                Console.WriteLine("\n Perai, aventureiro! Antes de ir pra luta, tem algo que a guilda está faltando saber sobre você!");
                Console.WriteLine("diga: que tipo de arqueiro você é? ");
                setTipo_mago(Console.ReadLine());

                Console.WriteLine("Muito bem. Agora vá comprar flechas na guilda! ");
            }
        }

        public void cadastrar_arqueiro()
        {
            if (nome_arqueiro != null)
            {
                Console.WriteLine("Arqueiro já registrado na guilda!");
            }
            else
            {
                Console.WriteLine("\n Bem vindo à guilda! Seja bem vindo.");
                Console.WriteLine("diga: que tipo de arqueiro você é? ");
                setTipo_mago(Console.ReadLine());

                Console.WriteLine("Muito bem. Agora vá comprar flechas na guilda! ");
            }
        }
           public void alterar_arqueiro()
        {
            if (nome_arqueiro == null)
            {
                Console.WriteLine("Vá registrar um arqueiro primeiro!");
            }
            else
            {
                Console.WriteLine("\n Olá! Temos um novo arqueiro por aqui!");
                Console.WriteLine("diga: que tipo de arqueiro você é? ");
                setTipo_mago(Console.ReadLine());

                Console.WriteLine("Muito bem. Agora vá comprar flechas na guilda! ");
            }
        }

    }

}