class Usuario : Comum
{
    public string nome;
    private string senha;
    public bool prontoParaJogar = false;

    public Usuario(string nome, string senha)
    {
        Random valor = new Random();
        this.id = valor.Next();
        this.nome = nome;
        this.senha = senha;
    }

    public void queroJogar()
    {
        this.prontoParaJogar = true;
    }

    public void setSenha(string senha)
    {
        this.senha = senha;
    }

    public string GetSenha()
    {
        return this.senha;
    }

    public int GetId()
    {
        return this.id;
    }

    public static void Adicionar(BancoDeDados banco)
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do usuário:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a senha do usuário:");
        string senha = Console.ReadLine();
        banco.AdicionarUsuarioAoBanco(new Usuario[] { new Usuario(nome, senha) });
    }

    public static void Remover(BancoDeDados banco)
    {
        Console.Clear();
        Console.WriteLine("Digite o id do usuário que deseja remover:");
        int id = int.Parse(Console.ReadLine());
        banco.RemoverUsuarioDoBanco(id);
    }

    public static void Listar(BancoDeDados banco)
    {
        Console.Clear();
        foreach (Usuario usuario in banco.GetUsuarios())
        {
            Console.WriteLine("ID: " + usuario.GetId() + " Nome: " + usuario.nome);
        }
        Console.ReadKey();
    }
}
