using System;

namespace Personagens_rpg
{
    class Program
    {
        //  static public int decisao;
        static void Main(string[] args)
        {
            Mago mago1 = new Mago();

            // mago1.Socar();

            //mago1.lançar_feitiço1();

            int decisao;


            do
            {   
                Console.WriteLine("\n O que deseja fazer, Sr. " + mago1.getTipo_mago() + "? Caso Queira parar, digite '0' ");
                Console.WriteLine("1- Definir tipo de mago | 2- Lançar o 1ª feitiço | 3- Lançar 2ª feitiço ");
                decisao = Convert.ToInt32(Console.ReadLine());

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

                
                }

            } while (decisao != 0);
        }
    }
}
