using System;

namespace Personagens_rpg
{
    class Program
    {   
        //Objeto global
        static Mago mago1 = new Mago();
        static Arqueiro arqueiro1 = new Arqueiro();
        //  static public int decisao;
        static void Main(string[] args)
        {
            int decisaoMain;

            do
            {
                Console.WriteLine("\n Qual classe você quer usar? ");
                Console.WriteLine("0- Sair | 1-Mago | 2- Arqueiro | 3- Assassino :");
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
                Console.WriteLine("0- Escolher outra classe | 1- Definir tipo de mago | 2- Lançar o 1ª feitiço | 3- Lançar 2ª feitiço | 4- Registrar outro mago");
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
                    default:
                        Console.WriteLine("\n ->>>>> Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0 );
        }


        public static void MenuArqueiro()
        {
           int decisao;
            do
            {
                Console.WriteLine("\n O que deseja fazer, Sr. " + arqueiro1.getNome_arqueiro() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("0- Escolher outra classe | 1- Definir seu nome |2- Verificar quantidade de flechas | 3- Comprar flechas | 4- Atirar flechas | 5- Registrar outro arqueiro ");
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
                    default:
                        Console.WriteLine("\n ->>>>> Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0 ); 
        }
    }
}
