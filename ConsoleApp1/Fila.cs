class Fila : Comum
{
    Sala[] salas;

    public Fila()
    {
        Random valor = new Random();
        SetId(valor.Next());
    }

    protected override int GetId()
    {
        return this.id + 10;
    }

    public void adicionarSalas(Sala[] salas)
    {
        this.salas = salas;
    }

}
