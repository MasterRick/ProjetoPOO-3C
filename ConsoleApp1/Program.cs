BancoDeDados banco = new BancoDeDados();

Usuario usuario1 = new Usuario("Richardson", "123456");
Usuario usuario2 = new Usuario("Bruno", "654321");
Usuario usuario3 = new Usuario("Rafael", "123456");
Usuario usuario4 = new Usuario("Renner", "111111");
Usuario usuario5 = new Usuario("Tiny", "88888");
Usuario usuario6 = new Usuario("Wesley", "88888");
Usuario usuario7 = new Usuario("Gustavo", "123456");
Usuario usuario8 = new Usuario("Bianca", "123456");
Usuario usuario9 = new Usuario("Beatriz", "123456");
Usuario usuario10 = new Usuario("Silvio", "123456");

banco.AdicionarUsuarioAoBanco(new Usuario[] { usuario1, usuario2, usuario3, usuario4, usuario5, usuario6, usuario7, usuario8, usuario9, usuario10 });


ConsoleKeyInfo opcao = new ConsoleKeyInfo();
Usuario usuario = null;

while (opcao.Key != ConsoleKey.Escape)
{
    MostrarMenuPrincipal();
    opcao = Console.ReadKey();
    switch (opcao.Key)
    {
        case ConsoleKey.D1:
            Console.Clear();
            Console.WriteLine("Digite uma das opções abaixo:");
            Console.WriteLine("1 - Adicionar um novo usuário");
            Console.WriteLine("2 - Remover um usuário");
            Console.WriteLine("3 - Listar usuários");
            opcao = Console.ReadKey();

            switch (opcao.Key)
            {
                case ConsoleKey.D1:
                    Usuario.Adicionar(banco);
                    break;
                case ConsoleKey.D2:
                    Usuario.Remover(banco);
                    break;
                case ConsoleKey.D3:
                    Usuario.Listar(banco);
                    break;
            }

            break;

    }

    void MostrarMenuPrincipal()
    {
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Olá! Seja bem-vindo ao nosso sistema de filas de jogos!");
        Console.WriteLine("Digite uma das opções abaixo:");
        Console.WriteLine("1 - Gerenciar contas");
        Console.WriteLine("2 - Gerenciar Sala");
        Console.WriteLine("3 - Gerenciar Fila");
        Console.WriteLine("4 - Gerenciar Jogos");
    }

}


