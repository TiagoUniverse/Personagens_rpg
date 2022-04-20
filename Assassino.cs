using System;

namespace Personagens_rpg
{
    class Assassino
    {
        private string nome;
        private string tipo_lamina;
        private int velocidade;

        private bool camuflado;
        public string getNome()
        {
            return nome;
        }

        public string getTipo_lamina()
        {
            return tipo_lamina;
        }

        public int getVelocidade()
        {
            return velocidade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setTipo_lamina(string tipo_lamina)
        {
            this.tipo_lamina = tipo_lamina;
        }

        public void setVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public bool getCamuflado()
        {
            return camuflado;
        }

        public void setCamuflado(bool camuflado)
        {
            this.camuflado = camuflado;
        }

        public void codigo_cadastro()
        {
            Console.WriteLine("Diga: qual o seu nome, assassino?");
            setNome(Console.ReadLine());

            Console.WriteLine("E que lâmina é essa que está carregando?");
            setTipo_lamina(Console.ReadLine());

            Console.WriteLine("Muito bem. Pode entrar.");
        }
        public cadastro_assassino()
        {
            Console.WriteLine("Seja bem vindo à guilda. Eu deixarei você passar, assasino. Se comporte.");
            codigo_cadastro();
        }

        public alterar_assassino()
        {
            Console.WriteLine("Temos mais encrenca chegando! Sirva-se de uma bebida!");
            codigo_cadastro();
        }

        public preencher_assassino()
        {
            if (getNome() == null || getTipo_lamina == null)
            {
                Console.WriteLine("Calma lá, amigo! Quem é você aqui na guilda?");
                codigo_cadastro();
            }

        }
        public void camuflar()
        {
            if (getVelocidade() <= 30)
            {
                // O usuário precisa acumular velocidade para se esconder
                Console.WriteLine("Voce precisa ficar mais rápido! Vai treinar.");
            }
            else
            {
                Console.WriteLine("Você está camuflado!");
                camuflado = true;
            }
        }

        public void aparecer()
        {
            if (camuflado = true)
            {
                // O usuário precisa acumular velocidade para se esconder
                Console.WriteLine("Você está vísivel de novo e descansando.");
                camuflado = false;
            }
            else
            {
                Console.WriteLine("Todo mundo tá te vendo!");
            }
        }

        public void treinar_velocidade()
        {
            if (velocidade == 100)
            {
                Console.WriteLine("Limite de velocidade alcançado! Vá para sua missão.");
            }
            else
            {
                //aumentando 10% de velocidade
                setVelocidade + 10;
                Console.WriteLine("Treinando! A sua velocidade agora é " + getVelocidade());
            }
        }

        public void roubar_moedas()
        {
            if (camuflado = false)
            {
                Console.WriteLine("PEGA LADRÃO NA GUILDA!");
            }
            else
            {
                if (getVelocidade() < 30)
                {
                    Console.WriteLine("SOCORRO! UM BANDIDO!");
                }
                else
                {
                    if (getVelocidade() > 30 && getVelocidade() <= 50)
                    {
                        //Adiciona recompensas de dinheiro ao assassino
                        Console.WriteLine("Você roubou 3 moedas!");
                    }
                    else
                    {
                        if (getVelocidade() > 50 && getVelocidade() <= 80)
                        {
                            Console.WriteLine("Você roubou 6 moedas!");
                        }
                        else
                        {
                            //velocidade > 80
                            Console.WriteLine("Voce roubou 10 moedas!!! Épico!");
                        }
                    }


                }
            }




        }

    }
}