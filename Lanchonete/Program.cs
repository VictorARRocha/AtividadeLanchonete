namespace Lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<Produto> cardapio = new List<Produto>();


                Produto hamburguer = new Produto();
                hamburguer.NomeProduto = "Hamburguer";
                hamburguer.PrecoProduto = 20;
                cardapio.Add(hamburguer);

                Produto batata = new Produto();
                batata.NomeProduto = "Batata frita";
                batata.PrecoProduto = 9;
                cardapio.Add(batata);

                Produto bebida = new Produto();
                bebida.NomeProduto = "Bebidas";
                bebida.PrecoProduto = 5;
                cardapio.Add(bebida);

                Produto hotdog = new Produto();
                hotdog.NomeProduto = "HotDog";
                hotdog.PrecoProduto = 20;
                cardapio.Add(hotdog);


                Console.WriteLine("Digite o nome do novo produto: ");
                Produto novoProduto = new Produto();
                novoProduto.NomeProduto = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto");
                novoProduto.PrecoProduto = double.Parse(Console.ReadLine());
                cardapio.Add(novoProduto);


                Console.Clear();
                Console.WriteLine("Vamos anotar os pedidos: ");
                Console.WriteLine("Qual produto você quer adicionar no pedido? ");
                string sair = "n";
                while (sair != "s")
                {
                    Console.WriteLine("Quantos produtos você deseja adicionar?");
                    int numProd = int.Parse(Console.ReadLine());
                    Pedido pedido = new Pedido();
                    for (int i = 0; i < numProd; i++)
                    {

                        Console.WriteLine($"0 - Hamburguer, 1 - Batata, 2 - Bebidas, 3 - HotDog, 4 - {novoProduto.NomeProduto}");
                        Console.WriteLine("Qual Produto você deseja adicionar");

                        int ql = int.Parse(Console.ReadLine());
                        switch (ql)
                        {
                            case 0:
                                pedido.ListaProdutos.Add(hamburguer);
                                i++;
                                break;

                            case 1:
                                pedido.ListaProdutos.Add(batata);
                                i++;
                                break;

                            case 2:
                                pedido.ListaProdutos.Add(bebida);
                                i++;
                                break;

                            case 3:
                                pedido.ListaProdutos.Add(hotdog);
                                i++;
                                break;

                            case 4:
                                pedido.ListaProdutos.Add(novoProduto);
                                i++;
                                break;

                            default:
                                Console.WriteLine("Produto inexistente, insira um produto valido");
                                break;
                        }
                    }

                    Console.WriteLine("Você deseja fazer mais pedidos? Digite N para terminar ");
                    sair = Console.ReadLine();
                }


                
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir o numero por 0");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Insira o formato de dado correto.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
