using System;

namespace Personagens_rpg
{
    class Arqueiro : Ser_vivo
    {
        private int quantidade_flechas;
        private string nome_arqueiro;

        public int getQuantidade_flechas()
        {
            return quantidade_flechas;
        }

        public void setQuantidade_flechas(int quantidade_flechas)
        {
            this.quantidade_flechas = quantidade_flechas;
        }

        public string getNome_arqueiro()
        {
            return nome_arqueiro;
        }

        public void setNomeArqueiro(string nome_arqueiro)
        {
            this.nome_arqueiro = nome_arqueiro;
        }
        public void atirar_flecha()
        {
            preencher_arqueiro();
            if (getQuantidade_flechas() == 0)
            {
                //Pede ao usuário para recarregar as flechas
                Console.WriteLine("\n ->>>>> Sem flechas para atirar! Vá recarregar na guilda.");
            }
            else
            {
                Console.WriteLine("\n ->>>>> Eu sempre acerto. Atirando uma flecha rápida!");
                quantidade_flechas--;
            }
        }

        public void recarregar_flecha()
        {
            preencher_arqueiro();
            //Somando mais uma flecha
            quantidade_flechas++;
            Console.WriteLine("\n ->>>>> Comprando mais uma flecha!");
        }


        public void verificar_flechas()
        {
            preencher_arqueiro();
            if (getQuantidade_flechas() == 0)
            {
                Console.WriteLine("\n ->>>>> Você não possui nenhuma flecha!");
            }
            else
            {
                Console.WriteLine("\n ->>>>> Voce possui " + getQuantidade_flechas() + " de flechas!");
            }
        }

        public void codigo_cadastro()
        {
            Console.WriteLine("diga: Qual seu nome, arqueiro?  ");
            setNomeArqueiro(Console.ReadLine());

            Console.WriteLine("\n ->>>>> Muito bem. Agora vá comprar flechas na guilda! ");
            //Vai na classe principal 'Programa'  e registra as informações da herança
            Program.servivo_arqueiro();
        }

        public void preencher_arqueiro()
        {
            if (getNome_arqueiro() == null)
            {
                Console.WriteLine("\n Perai, aventureiro! Antes de ir pra luta, tem algo que a guilda está faltando saber sobre você!");
                codigo_cadastro();
            }
        }

        public void cadastrar_arqueiro()
        {
            if (getNome_arqueiro() != null)
            {
                Console.WriteLine("\n ->>>>> Arqueiro já registrado na guilda!");
            }
            else
            {
                Console.WriteLine("\n Bem vindo à guilda! Temos um novo arqueiro no pedaço.");
                codigo_cadastro();
            }
        }
        public void alterar_arqueiro()
        {
            if (getNome_arqueiro() == null)
            {
                Console.WriteLine("\n ->>>>> Vá registrar um arqueiro primeiro!");
            }
            else
            {
                Console.WriteLine("\n Olá! Temos um novo arqueiro por aqui!");
                codigo_cadastro();
            }
        }

    }

}