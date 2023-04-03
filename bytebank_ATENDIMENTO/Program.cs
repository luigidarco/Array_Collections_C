using bytebank_ATENDIMENTO.bytebank.Atendimento;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
        Array amostra = Array.CreateInstance(typeof(double), 4);
        amostra.SetValue(1.0, 0);
        amostra.SetValue(2.0, 1);
        amostra.SetValue(3.0, 2);
        amostra.SetValue(4.0, 3);
        // amostra.SetValue(8.5, 4); 
        calculeMediana(amostra);

        void calculeMediana(Array array)
        {

            if (array == null || array.Length == 0)
            {
                Console.WriteLine("The provided array is null or empty.");
            }
            else
            {
                double[] numerosOrdenados = (double[])array.Clone();
                Array.Sort(numerosOrdenados);
                int meio = ((array.Length / 2)); // 4>2 5>2
                double mediana = (array.Length % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
                Console.WriteLine($"A mediana deste Array é {mediana}");
            }
        }
    }





    void encontrarElementoNoArray()
    {
        string[] nomes = new string[5];
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("Digite a palavra a ser localizada: ");
        var palavra = Console.ReadLine();

        foreach (var item in nomes.Select((nome, index) => new { nome, index }))
        {
            if (item.nome.Equals(palavra))
            {
                Console.WriteLine($"Encontramos a palavra {item.nome} na posição {item.index + 1} ");
            }

        }
    }
    void testarArrayDeInteiros()
    {

        int[] idades = new int[5];
        idades[0] = 12;
        idades[1] = 24;
        idades[2] = 35;
        idades[3] = 40;
        idades[4] = 50;

        Console.WriteLine($"Tamanho do Array: {idades.Length}");
        for (int i = 0; i < idades.Length; i++)
        {
            Console.WriteLine($"Indíce [{i}]: {idades[i]}");
        }



    }
    void testarArrysDeStrings()
    {
        string[] _diasDaSemana = new string[7];
        _diasDaSemana[0] = "segunda";
        _diasDaSemana[1] = "terça";
        _diasDaSemana[2] = "quarta";
        _diasDaSemana[3] = "quinta";
        _diasDaSemana[4] = "sexta";
        _diasDaSemana[5] = "sábado";
        _diasDaSemana[6] = "domingo";

        string[] convidados = new string[] { "Leonardo", "Simone", "Alexandre", "Vinicius" };
        double[] numerosDecimais = { 2.4, 1.5, 2.1, 5.0, 7.00 };
    }


}

// new ByteBankAtendimento().AtendimentoCliente();

