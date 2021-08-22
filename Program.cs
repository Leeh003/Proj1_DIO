using System;

namespace Dio.Animation
{
    class Program
    {
        static AnimationRepositorio repositorio = new AnimationRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario().ToUpper().Trim();
            while(opcaoUsuario != "X"){
                switch(opcaoUsuario){
                    case "1":
                        ListarAnimacoes();
                        break;
                    case "2":
                        InserirAnimacao();
                        break;
                    case "3":
                        AtualizarAnimacao();
                        break;
                    case "4":
                        ExcluirAnimacao();
                        break;
                    case "5":
                        VisualizarAnimacao();
                        break;
                    case "L":
                        Console.Clear();
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario().ToUpper().Trim();
            }
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Catálogo de Animações DIO!");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");

            Console.WriteLine("1- Listar Animação");
            Console.WriteLine("2- Inserir nova Animação");
            Console.WriteLine("3- Atualizar Animação");
            Console.WriteLine("4- Excluir Animação");
            Console.WriteLine("5- Visualizar Animação");
            Console.WriteLine("L- Limpar Tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarAnimacoes(){
            Console.WriteLine("Lista de Animações:");

            var lista = repositorio.Lista();

            if (lista.Count == 0){
                Console.WriteLine("Nenhuma animação cadastrada");
                return;
            }

            foreach (var animacao in lista){
                Console.Write($"{animacao.RetornaId()} - ");
                if(animacao.RetornaExcluido())
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{animacao.RetornaTitulo()} (Animação excluída)");
                Console.ResetColor();
            }
            return;
        }

        private static void InserirAnimacao(){
            Console.WriteLine("Digite o genêro entre as opções abaixo:");
            
            foreach(int i in Enum.GetValues(typeof(EnumGenero))){
                Console.WriteLine($"{i} - {Enum.GetName(typeof(EnumGenero), i)}");
            }
            int inputGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da Animação:");
            string inputTitulo = Console.ReadLine();

            Console.Write("Digite a sinopse da Animação:");
            string inputSinopse = Console.ReadLine();

            Console.Write("Digite o ano da Animação:");
            int inputAno = int.Parse(Console.ReadLine());
            
            Animation novaAnimacao = new Animation(id: repositorio.ProximoId(),
                                                    genero: (EnumGenero)inputGenero,
                                                    titulo: inputTitulo,
                                                    sinopse: inputSinopse,
                                                    ano: inputAno);
            
            repositorio.Insere(novaAnimacao);

            Console.WriteLine("Animação Inserida!");
            return;
        }

        private static void AtualizarAnimacao(){
            Console.WriteLine("Informe o Id da animação");
            int inputId = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o genêro entre as opções abaixo:");
            
            foreach(int i in Enum.GetValues(typeof(EnumGenero))){
                Console.WriteLine($"{i} - {Enum.GetName(typeof(EnumGenero), i)}");
            }
            int inputGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da Animação:");
            string inputTitulo = Console.ReadLine();

            Console.Write("Digite a sinopse da Animação:");
            string inputSinopse = Console.ReadLine();

            Console.Write("Digite o ano da Animação:");
            int inputAno = int.Parse(Console.ReadLine());
            
            Animation novaAnimacao = new Animation(id: inputId,
                                                    genero: (EnumGenero)inputGenero,
                                                    titulo: inputTitulo,
                                                    sinopse: inputSinopse,
                                                    ano: inputAno);
            
            repositorio.Atualiza(novaAnimacao);

            Console.WriteLine("Animação Inserida!");
            return;
        }

        private static void ExcluirAnimacao(){
            Console.WriteLine("Informe o Id da animação");
            int inputId = int.Parse(Console.ReadLine());

            repositorio.Exclui(inputId);
        }

        private static void VisualizarAnimacao(){
            Console.WriteLine("Informe o Id da animação");
            int inputId = int.Parse(Console.ReadLine());

            var animacao = repositorio.RetornaPorId(inputId);

            Console.WriteLine(animacao);
        }
    }
}
