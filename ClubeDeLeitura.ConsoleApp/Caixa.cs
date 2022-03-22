using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Caixa
    {
        public int quantidadederevistaCaixa;
        public string corCaixa;
        public string entiquetaCaixa;



        public void idRegistrarCaixa()
        {

            Console.WriteLine("Insira a quantidade de revistas da caixa?");
            quantidadederevistaCaixa = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a cor da caixa?");
            corCaixa = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Digite a entiqueta da caixa?");
            entiquetaCaixa = Convert.ToString(Console.ReadLine());
        }
        public void Mostrar()
        {
            Console.WriteLine("Quantidade de revistas da caixa: " + quantidadederevistaCaixa);

            Console.WriteLine("Cor da caixa: " + corCaixa);

            Console.WriteLine("Entiqueta da caixa: " + entiquetaCaixa);

            Console.ReadLine();
        }
    }
}
