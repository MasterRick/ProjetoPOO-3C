class BancoDeDadosCarros
{
    List<Carro> carros = new List<Carro>();

    public BancoDeDadosCarros()
    {
        AdicionarCarrosAleatoriamente();
    }

    public void SalvarCarro(Carro carro)
    {
        carros.Add(carro);
    }

    void AdicionarCarrosAleatoriamente()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            string[] nomes = { "Gol", "Palio", "Uno", "Celta", "Fusca",
         "Brasilia", "Corolla", "Civic", "Fit", "Etios" };

            string[] cores = { "Azul", "Preto", "Branco", "Prata",
        "Vermelho", "Amarelo", "Verde", "Rosa", "Roxo", "Laranja" };

            Carro carro = new Carro(PegarAleatorio(nomes), Carro.GeradorDePlaca(),
             PegarAleatorio(cores), random.Next(0, 80001));

            SalvarCarro(carro);
        }

    }

    string PegarAleatorio(string[] opcoes)
    {
        Random random = new Random();
        string opcaoEscolhida = opcoes[random.Next(0, opcoes.Length)];

        return opcaoEscolhida;

    }

    public void ListarCarros()
    {
        Console.Clear();
        for (int i = 0; i < carros.Count; i++)
        {
            Console.WriteLine("Carro " + (i + 1));
            Console.WriteLine("Nome: " + carros[i].nome);
            Console.WriteLine("Placa: " + carros[i].placa);
            Console.WriteLine("Cor: " + carros[i].cor);
            Console.WriteLine("Km rodados: " + carros[i].GetKmRodados());
            Console.WriteLine();
        }
    }
}