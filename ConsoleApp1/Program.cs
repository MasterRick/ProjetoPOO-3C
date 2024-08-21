
/*Fila filaAram = new Fila();
Fila filaRankeada = new Fila();
Fila filaTFT = new Fila();



usuario1.queroJogar();
usuario2.queroJogar();


Sala sala1 = new Sala(new Usuario[] { usuario1, usuario2, usuario3 });
Sala sala2 = new Sala(new Usuario[] { usuario4, usuario5, usuario6 });

Console.WriteLine("Entrou " + sala1.EntraNaFila(filaAram));*/

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

while (opcao.Key != ConsoleKey.D5)
{

    System.Threading.Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Olá! Seja bem-vindo ao nosso sistema de filas de jogos!");
    Console.WriteLine("Digite uma das opções abaixo:");
    Console.WriteLine("1 - Cadastrar um novo usuário");
    if (usuario == null)
    {
        Console.WriteLine("2 - Login");
    }
    else
    {
        Console.WriteLine("Logado como " + usuario.nome);
        Console.WriteLine("2 - Logout");
    }
    Console.WriteLine("3 - Cadastrar uma nova sala");
    Console.WriteLine("4 - Entrar em uma fila");
    Console.WriteLine("5 - Sair do sistema");
    opcao = Console.ReadKey();

    switch (opcao.Key)
    {
        case ConsoleKey.D1:
            Console.Clear();
            Console.WriteLine("Digite o nome do usuário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário:");
            string senha = Console.ReadLine();
            banco.AdicionarUsuarioAoBanco(new Usuario[] { new Usuario(nome, senha) });
            break;

        case ConsoleKey.D2:
            if (usuario == null)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do usuário:");
                string nomeUsuario = Console.ReadLine();
                Console.WriteLine("Digite a senha do usuário:");
                string senhaUsuario = Console.ReadLine();
                usuario = banco.BuscarUsuario(nomeUsuario, senhaUsuario);
                if (usuario != null)
                {
                    Console.WriteLine("Usuário logado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos!");
                }
            }
            else
            {
                usuario = null;
                Console.WriteLine("Usuário deslogado com sucesso!");
            }
            break;

    }





}


