using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDeLeitura.ConsoleApp
{
    internal class Pessoa
    {
        public string amigo;
        public string amigoDoResponsavel;
        public int telefone;
        public string endereco;
        

        public void idRegistrarAmigo()
        {

            Console.WriteLine("Qual o nome do amigo?");
            amigo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual o nome do responsavel?");
            amigoDoResponsavel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual o numero do responsavel?");
            telefone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o endereço?");
            endereco = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("amigo registrado !! :-)");
            Console.ResetColor();
            Console.ReadLine();
        }
        public void Mostrar()
        {
            Console.WriteLine("Amigo: " + amigo);

            Console.WriteLine("Nome do responsavel" + amigoDoResponsavel);

            Console.WriteLine("Endereço: " + endereco);

            Console.WriteLine("Numero do responsavel: " + telefone);

            
            Console.ReadLine();
        }
    }
}