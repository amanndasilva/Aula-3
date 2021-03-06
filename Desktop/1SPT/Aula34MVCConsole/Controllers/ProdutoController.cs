using System.Collections.Generic;
using Aula34MVCConsole.Models;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            produtoView.MostrarNoConsle(produtoModel.Ler());
        }

        public void Buscar(string _preco)
        {
            List<Produto> busca = produtoModel.Ler().FindAll
            (x => x.Preco == float.Parse(_preco));
            
            produtoView.MostrarNoConsle(busca);
        }
    }
}