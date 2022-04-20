using System;

namespace Personagens_rpg
{
    class Program
    {
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
            Mago mago1 = new Mago();
            do
            {
                Console.WriteLine("\n O que deseja fazer, Sr. " + mago1.getTipo_mago() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("0- Escolher outra classe | 1- Definir tipo de mago | 2- Lançar o 1ª feitiço | 3- Lançar 2ª feitiço");
                decisao = Convert.ToInt32(Console.ReadLine());
                //Menu do mago
                switch (decisao)
                {
                    case 0:
                        Console.WriteLine("\n Até a próxima!");
                        break;
                    case 1:
                        mago1.Mago_possuiCadastro();
                        break;
                    case 2:
                        mago1.lançar_feitiço1();
                        break;
                    case 3:
                        mago1.lançar_feitiço2();
                        break;
                    default:
                        Console.WriteLine("Não entendi o que você quis dizer");
                        break;
                }

            } while (decisao != 0 );
        }


    }
}
