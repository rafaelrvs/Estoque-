using ProdutoDoUsuario.Models;
ProdutoDUsuario C = new ProdutoDUsuario();

bool exibirMenu = true;
while (exibirMenu)
{

    Console.WriteLine("Ola tudo bem?  Como posso te ajudar?\n Consultar estoque [1]\n Remover produto [2]\n Adicionar produto [3]\n Sair [4] ");

    switch (Console.ReadLine())
    {
        case "1":
            C.Consultar();
            break;
        case "2":
            C.Remover();
            break;
        case "3":
            C.Adicionar();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
 
}
Console.WriteLine("O programa encerrou");
Console.WriteLine("Pressione qualquer tecla para continuar");
Console.ReadKey();