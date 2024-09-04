
class Carro
{
    public string nome;
    public string placa;
    public string cor;
    private double kmrodados;

    //MÉTODO CONSTRUTOR
    public Carro(string nome, string placa, string cor, double kmrodados)
    {
        this.nome = nome;
        this.placa = placa;
        this.cor = cor;
        this.kmrodados = kmrodados;
    }

    public double GetKmRodados()
    {
        return kmrodados;
    }

    public static string GeradorDePlaca()
    {
        Random random = new Random();
        string placaEscolhida = "";

        for (int i = 0; i < 3; i++)
        {
            char letraEscolhida = Convert.ToChar(random.Next(65, 91));
            placaEscolhida += letraEscolhida;
        }
        placaEscolhida += '-';

        for (int i = 0; i < 4; i++)
        {
            placaEscolhida += random.Next(0, 10);
        }

        return placaEscolhida;
    }
}
