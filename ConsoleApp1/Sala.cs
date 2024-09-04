class Sala : Comum
{
    Usuario[] usuarios;

    public Sala(Usuario[] usuarios)
    {
        Random valor = new Random();
        this.id = valor.Next();
        this.usuarios = usuarios;
    }

    public bool EntraNaFila(Fila fila)
    {
        foreach (Usuario usuario in this.usuarios)
        {
            if (usuario.prontoParaJogar == false)
            {
                return false;
            }
        }
        fila.adicionarSalas(new Sala[] { this });
        return true;
    }

}