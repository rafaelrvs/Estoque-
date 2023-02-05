using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoDoUsuario.Models
{
    public class ProdutoDUsuario
    {
        List<string> Status = new List<string>();
        public void Adicionar()
        {
        
            Console.WriteLine("Qual Produto você quer Adicionar");

            string itemAdicionado = Console.ReadLine();

            while(itemAdicionado == " " || itemAdicionado == "")
            {
                Console.WriteLine($" O item digitado {itemAdicionado} é invalido Por favor digite novamente");
                 itemAdicionado = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"O produto {itemAdicionado} foi Adicionado no estoque com sucesso");
             Status.Add(itemAdicionado);
            

        }
        public void Remover()
        {
        
            Console.WriteLine("Qual Produto você quer remover");
            string itemRemovido = Console.ReadLine();
            if (Status.Any(x => x.ToUpper() == itemRemovido.ToUpper()))
            {
                Console.WriteLine($" O produto {itemRemovido} foi removido do estoque com sucesso");
                Status.Remove(itemRemovido);
        
            }
            else
            {
                Console.WriteLine("O produto não Existe");
            }
        }
        public void Consultar()
        {
      
            foreach (var item in Status)
            {
                Console.WriteLine(item);

            }

        }
            
    }

}