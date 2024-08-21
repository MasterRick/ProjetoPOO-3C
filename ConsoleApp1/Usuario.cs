class Usuario
{
    public int id;
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
}
