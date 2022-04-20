using System;

namespace Personagens_rpg
{
    class Guerreiro : Ser_vivo
    {
        private string nome;
        private string tipo_machado;

        private int quant_destruicao;
        public string getNome()
        {
            return nome;
        }

        public string getTipo_machado()
        {
            return tipo_machado;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setTipo_machado(string tipo_machado)
        {
            this.tipo_machado = tipo_machado;
        }

        public int getQuant_destruicao()
        {
            return quant_destruicao;
        }

        public void setQuant_destruicao(int quant_destruicao)
        {
            this.quant_destruicao = quant_destruicao;
        }

        public void codigo_cadastro()
        {
            Console.WriteLine("diga: qual o seu nome, guerreiro?");
            setNome(Console.ReadLine());

            Console.WriteLine("E que machado é esse?");
            setTipo_machado(Console.ReadLine());
            //Vai na classe principal 'Programa'  e registra as informações da herança
            Program.servivo_guerreiro();
            Console.WriteLine("\n ->>> Ótimo! Seja bem vindo!");
        }
        public void cadastro_nome()
        {
            if (getNome() != null)
            {
                Console.WriteLine("\n ->>> Este guerreiro já está registrado na nossa guilda!");
            }
            else
            {
                Console.WriteLine("\n ->>> Um guerreiro! Seja bem vindo à guilda");
                codigo_cadastro();
            }

        }

        public void alteracao_nome()
        {
            if (getNome() == null)
            {
                Console.WriteLine("\n ->>> Vá se registrar primeiro na guilda!");
            }
            else
            {
                Console.WriteLine("\n ->>> Mais um guerreiro! Pode entrar.");
                codigo_cadastro();
            }
        }

        public void preenche_guerreiro()
        {
            if (getNome() == null || getTipo_machado() == null)
            {
                Console.WriteLine("\n ->>> Alto lá! Não vai se apresentar na guilda?");
                codigo_cadastro();
            }
        }

        public void machadada_mesa()
        {
            preenche_guerreiro();
            Console.WriteLine("\n ->>> Eu uso o poder do meu machado "+ getTipo_machado()  + "! Vou destruir essa mesa!");
            Console.WriteLine("\n ->>> BOOOOM!");
            quant_destruicao++;
        }
        public void destruicao_conquistada()
        {
            preenche_guerreiro();
            if (quant_destruicao == 0){
                Console.WriteLine("\n ->>> Cadê a minha honra?? Sou um guerreiro indigno dos deuses. Preciso de uma oferenda do meu poder!");
            }else{
                Console.WriteLine("\n ->>> Eu já destruí "+getQuant_destruicao() + " monumentos. Glória aos deuses!");
            }
        }
    }
}
