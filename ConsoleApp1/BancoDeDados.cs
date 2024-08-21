class BancoDeDados
{
    List<Usuario> usuarios = new List<Usuario>();

    public void AdicionarUsuarioAoBanco(Usuario[] usuario)
    {
        foreach (Usuario user in usuario)
        {
            this.usuarios.Add(user);
        }
    }

    public Usuario BuscarUsuario(string nome, string senha)
    {
        foreach (Usuario usuario in this.usuarios)
        {
            if (usuario.nome == nome && usuario.GetSenha() == senha)
            {
                return usuario;
            }
        }
        return null;
    }
}