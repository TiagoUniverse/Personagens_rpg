using System;

namespace Personagens_rpg
{
    class Program
    {
        //Objeto global
        static Mago mago1 = new Mago();
        static Arqueiro arqueiro1 = new Arqueiro();
        static Assassino assassino1 = new Assassino();
        static Guerreiro guerreiro1 = new Guerreiro();
        //  static public int decisao;
        static void Main(string[] args)
        {
            int decisaoMain;

            do
            {
                Console.WriteLine("\n Qual classe você quer usar? ");
                Console.WriteLine("0- Sair | 1-Mago (" + mago1.getTipo_mago() + ")_ | 2- Arqueiro(" + arqueiro1.getNome_arqueiro() + ") | 3- Assassino(" + assassino1.getNome() + ") | 4- Guerreiro (" + guerreiro1.getNome() + ") :");
                decisaoMain = Convert.ToInt32(Console.ReadLine());
                switch (decisaoMain)
                {
                    case 0:
                        Console.WriteLine("\n Saindo da guilda! Até!");
                        break;
                    case 1:
                        MenuMago();
                        break;
                    case 2:
                        MenuArqueiro();
                        break;
                    case 3:
                        MenuAssassino();
                        break;
                    case 4:
                        MenuGuerreiro();
                        break;
                    default:
                        Console.WriteLine("Não entendi o que você quis dizer");
                        break;
                }

            } while (decisaoMain != 0);

        }

        public static void MenuMago()
        {
            int decisao;
            //objeto local
            // Mago mago1 = new Mago();
            do
            {
                Console.WriteLine("\n O que deseja fazer, Sr. " + mago1.getTipo_mago() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("0- Escolher outra classe | 1- Definir tipo de mago | 2- Lançar o 1ª feitiço | 3- Lançar 2ª feitiço | 4- Registrar outro mago | 5- Socar | 6- Beber no bar");
                decisao = Convert.ToInt32(Console.ReadLine());
                //Menu do mago
                switch (decisao)
                {
                    case 0:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                    case 1:
                        mago1.cadastro_mago();
                        break;
                    case 2:
                        mago1.lançar_feitiço1();
                        break;
                    case 3:
                        mago1.lançar_feitiço2();
                        break;
                    case 4:
                        mago1.alterarPerfil();
                        break;
                    case 5:
                        mago1.Socar();
                        break;
                    case 6:
                        mago1.BeberNoBar();
                        break;
                    default:
                        Console.WriteLine("\n ->>>>> Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0);
        }


        public static void MenuArqueiro()
        {
            int decisao;
            do
            {
                Console.WriteLine("\n O que deseja fazer, Sr. " + arqueiro1.getNome_arqueiro() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("0- Escolher outra classe | 1- Definir seu nome |2- Verificar quantidade de flechas | 3- Comprar flechas | 4- Atirar flechas | 5- Registrar outro arqueiro | 6- Socar | 7- Beber no bar");
                decisao = Convert.ToInt32(Console.ReadLine());
                //Menu do arqueiro
                switch (decisao)
                {
                    case 0:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                    case 1:
                        arqueiro1.cadastrar_arqueiro();
                        break;
                    case 2:
                        arqueiro1.verificar_flechas();
                        break;
                    case 3:
                        arqueiro1.recarregar_flecha();
                        break;
                    case 4:
                        arqueiro1.atirar_flecha();
                        break;
                    case 5:
                        arqueiro1.alterar_arqueiro();
                        break;
                    case 6:
                        arqueiro1.Socar();
                        break;
                    case 7:
                        arqueiro1.BeberNoBar();
                        break;
                    default:
                        Console.WriteLine("\n ->>>>> Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0);
        }


public static void servivo_arqueiro()
      {
        Console.WriteLine("Qual é a altura do arqueiro?");
        arqueiro1.setAltura(Console.ReadLine());

        Console.WriteLine("Qual a cor do cabelo?");
        arqueiro1.setCor_Cabelo(Console.ReadLine());
       
        Console.WriteLine("Por fim, qual o peso do arqueiro?");
        arqueiro1.setPeso(Console.ReadLine());
       
      } 
public static void servivo_guerreiro()
      {
        Console.WriteLine("Qual é a altura do guerreiro?");
        guerreiro1.setAltura(Console.ReadLine());

        Console.WriteLine("Qual a cor do cabelo?");
        guerreiro1.setCor_Cabelo(Console.ReadLine());
       
        Console.WriteLine("Por fim, qual o peso do guerreiro?");
        guerreiro1.setPeso(Console.ReadLine());
       
      } 
public static void servivo_mago()
      {
        Console.WriteLine("Qual é a altura do mago?");
        mago1.setAltura(Console.ReadLine());

        Console.WriteLine("Qual a cor do cabelo?");
        mago1.setCor_Cabelo(Console.ReadLine());
       
        Console.WriteLine("Por fim, qual o peso do mago?");
        mago1.setPeso(Console.ReadLine());
       
      } 
public static void servivo_assassino()
      {
        Console.WriteLine("Qual é a altura do assassino?");
        assassino1.setAltura(Console.ReadLine());

        Console.WriteLine("Qual a cor do cabelo?");
        assassino1.setCor_Cabelo(Console.ReadLine());
       
        Console.WriteLine("Por fim, qual o peso do assassino?");
        assassino1.setPeso(Console.ReadLine());
       
      } 
        public static void MenuAssassino()
        {
            int decisao;
            do
            {
                Console.WriteLine("\n O que deseja fazer, Sr. " + assassino1.getNome() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("0- Escolher outra classe | 1- Definir o tipo de assassino | 2- Registrar outro assassino | 3- Camuflar | 4- Aparecer | 5- Treinar velocidade | 6- checar velocidade |7- Roubar moedas | 8- Socar | 9- Beber no bar");
                decisao = Convert.ToInt32(Console.ReadLine());
                //Menu do assassino
                switch (decisao)
                {
                    case 0:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                    case 1:
                        assassino1.cadastro_assassino();
                        break;
                    case 2:
                        assassino1.alterar_assassino();
                        break;
                    case 3:
                        assassino1.camuflar();
                        break;
                    case 4:
                        assassino1.aparecer();
                        break;
                    case 5:
                        assassino1.treinar_velocidade();
                        break;
                    case 6:
                        assassino1.checar_velocidade();
                        break;
                    case 7:
                        assassino1.roubar_moedas();
                        break;
                    case 8:
                        assassino1.Socar();
                        break;
                    case 9:
                        assassino1.BeberNoBar();
                        break;
                    default:
                        Console.WriteLine("\n ->>>>> Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0);
        }

        public static void MenuGuerreiro()
        {
            int decisao;
            do
            {
                Console.WriteLine("\n O que deseja fazer, Sr. " + guerreiro1.getNome() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("0- Escolher outra classe | 1- Definir o tipo de guerreiro |2- Registrar outro guerreiro | 3- verificar destruição conquistada | 4- Machadar uma mesa | 5- Socar | 6- Beber no bar");
                decisao = Convert.ToInt32(Console.ReadLine());
                //Menu do guerreiro
                switch (decisao)
                {
                    case 0:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                    case 1:
                        guerreiro1.cadastro_nome();
                        break;
                    case 2:
                       guerreiro1.alteracao_nome();
                        break;
                    case 3:
                        guerreiro1.destruicao_conquistada();
                        break;
                    case 4:
                        guerreiro1.machadada_mesa();
                        break;
                    case 5:
                        guerreiro1.Socar();
                        break;
                    case 6:
                        guerreiro1.BeberNoBar();
                        break;
                    default:
                        Console.WriteLine("\n ->>>>> Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0);
        }

    }
}
