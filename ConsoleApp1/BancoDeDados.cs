class BancoDeDados
{
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Sala> salas = new List<Sala>();

    public List<Usuario> GetUsuarios()
    {
        return this.usuarios;
    }

    public void AdicionarUsuarioAoBanco(Usuario[] usuario)
    {
        foreach (Usuario user in usuario)
        {
            this.usuarios.Add(user);
        }
    }

    public void AdicionarSalaAoBanco(Sala[] sala)
    {
        foreach (Sala sal in sala)
        {
            this.salas.Add(sal);
        }
    }

    public void RemoverUsuarioDoBanco(int id)
    {
        for (int i = 0; i < this.usuarios.Count; i++)
        {
            if (this.usuarios[i].GetId() == id)
            {
                this.usuarios.RemoveAt(i);
                break;
            }
        }
    }
}