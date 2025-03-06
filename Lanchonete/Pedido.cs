using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Pedido
    {
        public int NumeroPedido;
        public List<Produto> ListaProdutos = new List<Produto>();


        public void MostrarPedidos()
        {
            double totalPedido = 0;
            foreach (var produto in ListaProdutos)
            {

                totalPedido += produto.PrecoProduto;

            }

            Console.WriteLine();
            Console.WriteLine( );
            Console.WriteLine();
            Console.WriteLine($"O numero do pedido é: {NumeroPedido}");
            foreach (var item in ListaProdutos)
            {
                Console.WriteLine($"O nome do produto é: {item.NomeProduto}");
                Console.WriteLine($"O valor do produto é: {item.PrecoProduto}");
            }

            Console.WriteLine($"O total do pedido é: {totalPedido}");
        }

        public void AdicionarPedido(Produto produto)
        {

            ListaProdutos.Add(produto);
        }

    }


}
