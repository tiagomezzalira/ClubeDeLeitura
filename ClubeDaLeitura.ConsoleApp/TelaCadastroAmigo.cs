using System;

namespace ClubeDaLeitura.ConsoleApp
{
    public class TelaCadastroAmigo
    {
        public Amigo[] amigos;
        public int numeroAmigo;
        public Notificador notificador;

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Amigos");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovoAmigo()
        {
            MostrarTitulo("Inserindo nova Amigo");

            Amigo amigo = ObterAmigo();

            amigo.id = ++numeroAmigo;

            int posicaoVazia = ObterPosicaoVazia();
            amigos[posicaoVazia] = amigo;

       //     notificador.ApresentarMensagem("Amigo inserido com sucesso!", "Sucesso");
        }

        private Amigo ObterAmigo()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do responsável: ");
            string nomeDoResponsavel = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();

            Amigo amigo = new Amigo();

            amigo.nome = nome;
            amigo.nomeDoResponsavel = nomeDoResponsavel;
            amigo.telefone = telefone;
            amigo.endereco = endereco;
            amigo.possuiEmprestimoEmAberto = false;

            return amigo;
        }

        public void EditarAmigo()
        {
            MostrarTitulo("Editando Amigo");

            VisualizarAmigos("Pesquisando");

            Console.Write("Digite o número do amigo que deseja editar: ");
            int numeroCaixa = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].id == numeroCaixa)
                {
                    Amigo amigo = ObterAmigo();

                    amigos[i].id = numeroCaixa;
                    amigos[i] = amigo;

                    break;
                }
            }

            notificador.ApresentarMensagem("Caixa editada com sucesso", "Sucesso");
        }

        public void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public void ExcluirAmigo()
        {
            MostrarTitulo("Excluindo Amigo");

            VisualizarAmigos("Pesquisando");

            Console.Write("Digite o número da caixa que deseja excluir: ");
            int numeroCaixa = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].id == numeroAmigo)
                {
                    amigos[i] = null;
                    break;
                }
            }

           // notificador.ApresentarMensagem("Amigo excluído com sucesso", "Sucesso");
        }

        public void VisualizarAmigos(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Amigos");

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    continue;

                Amigo a = amigos[i];

                Console.WriteLine("Posicao: " + a.id);
                Console.WriteLine("Telefone " +a.telefone );
                Console.WriteLine("Nome " +a.nome);

                Console.WriteLine();
            }
        }

        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    return i;
            }

            return -1;
        }
    }
}