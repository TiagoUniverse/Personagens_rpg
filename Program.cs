using System;

namespace Personagens_rpg
{
    class Program
    {
      //  static public int decisao;
        static void Main(string[] args)
        {
         //   Mago mago1 = new Mago();

           // mago1.Socar();

            //mago1.lançar_feitiço1();

            int decisao;

             do
           {
               Console.WriteLine("oie");
               decisao = Convert.ToInt32(Console.ReadLine());
           } while (decisao == 0);
        }
    }
}
