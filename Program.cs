using System;

namespace DIO.Series
{
    class Program
    {
    static serieRepositorio  repositorio = new serieRepositorio();

    static void Main(string[] args)
    {
       string opcaoUsuario = ObterOpcaoUsuario();
       while(opcaoUsuario.ToUpper() != "X")
       {
           switch (opcaoUsuario)
           {
               case "1":
               ListarSeries();
               break;
               
               case "2":
               InserirSeries();
               break;

               case "3":
               AtualizarSeries();
               break;

               case "4":
               ExcluirSerie();
               break;

               case "5":
               VisualizarSerie();
               break;

               case "C":
               Console.Clear();
               break;

               default:
               throw new ArgumentOutOfRangeException();

            }
               opcaoUsuario = ObterOpcaoUsuario();
        }   
               Console.WriteLine("Obrigado por utilizar nossos serviços.");
               Console.ReadLine();
             
    }    
            private static void   VisualizarSerie()
            {
               Console.Write("Digite o id da série:");
               int indiceSerie = int.Parse(Console.ReadLine());

               var serie = repositorio.RetornaPorId(indiceSerie);

               Console.WriteLine(serie);
            }
            private static void ExcluirSerie()
            {
               Console.Write("Digite o id sa série:");
               int indiceSerie = int.Parse(Console.ReadLine());

               repositorio.Exclui(indiceSerie);
            }
            private static void AtualizarSeries()
            {
               Console.Write("Digite o id da série:");
               int indiceSerie = int.Parse(Console.ReadLine());
            
                foreach (int i in Enum.GetValues(typeof(Genero)))
               {
                  Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
               }
               Console.Write("Digitar o gênero entre as opções acima:");
                int entradaGenero = int.Parse(Console.ReadLine());

               Console.Write("Digite o Título da Série:");
               string entradaTitulo = Console.ReadLine();

               Console.Write("Digite o Ano da Série:");
               int entradaAno = int.Parse(Console.ReadLine());

               Console.Write("Digite a Descrição da Série:");
               string entradaDescricao = Console.ReadLine();

               Series atualizaSerie = new Series(Id: indiceSerie,
                                              genero:(Genero)entradaGenero,
                                              titulo: entradaTitulo,
                                              ano: entradaAno,
                                              descricao: entradaDescricao);

               repositorio.Atualiza(indiceSerie, atualizaSerie);

            }
             private static void InserirSeries()
             {
               Console.WriteLine("Inserir série");

               foreach (int i in Enum.GetValues(typeof(Genero)))
               {
                  Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
               }
               Console.Write("Digitar o gênero entre as opções acima:");
                int entradaGenero = int.Parse(Console.ReadLine());

               Console.Write("Digite o Título da Série:");
               string entradaTitulo = Console.ReadLine();

               Console.Write("Digite o Ano da Série:");
               int entradaAno = int.Parse(Console.ReadLine());

               Console.Write("Digite a Descrição da Série:");
               string entradaDescricao = Console.ReadLine();

               Series novaSerie = new Series(Id: repositorio.ProximoId(),
                                              genero:(Genero)entradaGenero,
                                              titulo: entradaTitulo,
                                              ano: entradaAno,
                                              descricao: entradaDescricao);

               repositorio.Insere(novaSerie);

         

             }
              private static void ListarSeries()
           {
             Console.WriteLine("Listar séries");
             var Lista = repositorio.Lista();
             if(Lista.Count == 0)
             {
                Console.WriteLine("Nenhums série cadastrada.");
             }
             foreach (var serie in Lista)
             {
                var Excluido = serie.retornaExcluido();
      
                 Console.WriteLine("#Id {0}: - {1} - {2}", serie.retornaId(), serie.retornaTítulo(), (Excluido ? "Excluido" : ""));
             }
            }
             private static string ObterOpcaoUsuario()
               {
                 Console.WriteLine();
                 Console.WriteLine("|DIO Séries a seu dispor!!!");
                 Console.WriteLine("Informa a sua opção desejada:");

                 Console.WriteLine("1- Listar série");
                 Console.WriteLine("2- Inserir série");
                 Console.WriteLine("3- Atualizar série");
                 Console.WriteLine("4- Excluir série");
                 Console.WriteLine("5- Visualizar série");
                 Console.WriteLine("C- Limpar tela");
                 Console.WriteLine("X- Sair");

                 string opcaoUsuario = Console.ReadLine().ToUpper();
                  Console.WriteLine();
                  return opcaoUsuario;
                
                }
    }

}