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
        public void cadastro_assassino()
        {
            if (getNome() != null)
            {
                Console.WriteLine("\n ->>>> Você já está registrado em nossa guilda!");
            }
            else
            {
                Console.WriteLine("\n ->>>> Seja bem vindo à guilda. Eu deixarei você passar, assasino. Se comporte.");
                codigo_cadastro();
            }

        }

        public void alterar_assassino()
        {
            if (getNome() == null)
            {
                Console.WriteLine("\n ->>>> Vá se registrar na guilda primeiro!");
            }
            else
            {
                Console.WriteLine("\n ->>>> Temos mais encrenca chegando! Depois sirva-se de uma bebida!");
                codigo_cadastro();
            }

        }

        public void preencher_assassino()
        {
            if (getNome() == null || getTipo_lamina() == null)
            {
                Console.WriteLine("\n ->>>> Calma lá, amigo! Quem é você aqui na guilda?");
                codigo_cadastro();
            }

        }
        public void camuflar()
        {
            preencher_assassino();
            if (camuflado == true)
            {
                Console.WriteLine("~~ Você já está camuflado ~~");
            }
            else
            {
                if (getVelocidade() <= 30)
                {
                    // O usuário precisa acumular velocidade para se esconder
                    Console.WriteLine("\n ->>>> Voce precisa ficar mais rápido! Vá treinar.");
                }
                else
                {
                    Console.WriteLine("\n ->>>> Você está camuflado! Depois vá treinar sua velocidade");
                    camuflado = true;
                    //Reduzindo a velocidade para que o usuario tenha que treinar para recarregar a velocidade
                    velocidade = velocidade - 30;
                }
            }

        }

        public void aparecer()
        {
            preencher_assassino();
            if (camuflado == true)
            {
                // O usuário precisa acumular velocidade para se esconder
                Console.WriteLine("\n ->>>> Você está vísivel de novo e descansando.");
                camuflado = false;
                //Sugestão de talvez fazer a velocidade aumentar aqui
            }
            else
            {
                Console.WriteLine("\n ->>>> Você já está à mostra. Todo mundo tá te vendo!");
            }
        }

        public void treinar_velocidade()
        {
            preencher_assassino();
            if (velocidade == 100)
            {
                Console.WriteLine("\n ->>>> Limite de velocidade alcançado! Vá para sua missão.");
            }
            else
            {
                //aumentando 10% de velocidade
                velocidade = velocidade + 10;
                Console.WriteLine("\n ->>>> Treinando! A sua velocidade agora é " + getVelocidade() + "%");
            }
        }

        public void checar_velocidade()
        {
            preencher_assassino();
            if (getVelocidade() == 0)
            {
                Console.WriteLine("Voce está exausto! Descanse e treine mais.");
            }
            else
            {
                Console.WriteLine("A sua velocidade é de " + getVelocidade() + "%");
            }

        }

        public void roubar_moedas()
        {
            preencher_assassino();
            if (camuflado == false)
            {
                Console.WriteLine("\n ->>>> PEGA LADRÃO NA GUILDA!");
            }
            else
            {
                if (getVelocidade() < 30)
                {
                    Console.WriteLine("\n ->>>> SOCORRO! UM BANDIDO!");
                }
                else
                {
                    if (getVelocidade() > 30 && getVelocidade() <= 50)
                    {
                        //Adiciona recompensas de dinheiro ao assassino
                        Console.WriteLine("\n ->>>> Você roubou 3 moedas!");
                        velocidade = velocidade - 30;
                    }
                    else
                    {
                        if (getVelocidade() > 50 && getVelocidade() <= 80)
                        {
                            Console.WriteLine("\n ->>>> Você roubou 6 moedas!");
                            velocidade = velocidade - 50;
                        }
                        else
                        { 
                            if(getVelocidade() == 100){
                                velocidade = 0;
                            }
                            //velocidade > 80
                            Console.WriteLine("\n ->>>> Voce roubou 10 moedas!!! Épico!");
                            velocidade = velocidade - 80;
                        }
                    }


                }
            }
                            Console.WriteLine("\n ->>>> Voce agora não está mais camuflado!");
                            setCamuflado(false);


        }

    }
}