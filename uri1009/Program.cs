using System;
using System.Globalization;

namespace uri1009{
    class Program {
    static void Main(string[] args){

            //total de vendas - 15% = resultado + salario fixo

            string nome;
            double salariof, vendas, salariot;

         
            nome = Console.ReadLine();
            salariof = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            salariot = vendas * 15.0 / 100 + salariof;





            Console.WriteLine("TOTAL = R$ " + salariot.ToString("F2", CultureInfo.InvariantCulture));

            




        }
    
    }

}