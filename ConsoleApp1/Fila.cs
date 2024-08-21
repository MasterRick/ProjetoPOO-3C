class Fila
{
    int id;
    Sala[] salas;

    public Fila()
    {
        Random valor = new Random();
        this.id = valor.Next();
    }

    public void adicionarSalas(Sala[] salas)
    {
        this.salas = salas;
    }

}
