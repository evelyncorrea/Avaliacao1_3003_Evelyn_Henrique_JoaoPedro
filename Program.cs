using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Itens
{
    public string nome;
    public string cor;
    public float tamanho;
    public int posicao;

    public Itens next;

    public Itens(string nome, int posicao)
    {
        this.nome = nome;
        this.posicao = posicao;
    }
}

namespace Avaliacao1_3003_Evelyn_Henrique_JoaoPedro
{
    class Program
    {
        static void Main(string[] args)
        {

            Itens Item1 = new Itens("abacaxi", 1);
            Itens Item2 = new Itens("banana", 2);
            Itens Item3 = new Itens("uva", 3);
            Itens Item4 = new Itens("morango", 4);
            Itens Item5 = new Itens("framboesa", 5);
            Itens Item6 = new Itens("laranja", 6);
            Itens Item7 = new Itens("caqui", 7);
            Itens Item8 = new Itens("manga", 8);
            Itens Item9 = new Itens("pera", 9);
            Itens Item10 = new Itens("limao", 10);
            Itens CurrentItem = Item1;
            bool continuar = true;
            string pesquisa;

            Item1.next = Item2;
            Item2.next = Item3;
            Item3.next = Item4;
            Item4.next = Item5;
            Item5.next = Item6;
            Item6.next = Item7;
            Item7.next = Item8;
            Item8.next = Item9;
            Item9.next = Item10;

            Console.WriteLine("Insira o nome de uma fruta: ");
            pesquisa = Console.ReadLine();

            while (continuar)
              {
                  switch (pesquisa)
                  {
                      case "abacaxi":
                          Console.WriteLine("Item encontrado na posicao " + Item1.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "banana":
                          Console.WriteLine("Item encontrado na posicao " + Item2.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "uva":
                          Console.WriteLine("Item encontrado na posicao " + Item3.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "morango":
                          Console.WriteLine("Item encontrado na posicao " + Item4.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "framboesa":
                          Console.WriteLine("Item encontrado na posicao " + Item5.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "laranja":
                          Console.WriteLine("Item encontrado na posicao " + Item6.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "caqui":
                          Console.WriteLine("Item encontrado na posicao " + Item7.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "manga":
                          Console.WriteLine("Item encontrado na posicao " + Item8.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "pera":
                          Console.WriteLine("Item encontrado na posicao " + Item9.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      case "limao":
                          Console.WriteLine("Item encontrado na posicao " + Item10.posicao);
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;

                      default:
                          Console.WriteLine("Fruta nao encontrada.");
                          Console.WriteLine("");
                          Console.WriteLine("Insira o nome de uma fruta: ");
                          pesquisa = Console.ReadLine();
                          break;
                  }
              }
        }
    }
}
