namespace TargetQuestoes;

class Program
{
    static void Main(string[] args)
    {
        CalculateFibonacci(4);
        VerifyString("BANANA");
        Soma();

        Console.Write(@"
        4)
        a) 1,3,5,7,9 -- números ímpares.
        b) 2,4,8,16,32,64,128 -- potências de base 2.
        c) 0,1,4,9,16,25,36,49 -- sequência de números elevados ao quadrado.
        d) 4,16,36,64,100 -- números pares elevados ao quadrado
        e) 1,1,2,3,5,8,13 -- Sequência de Fibonacci
        f) 2,10,12,16,17,18,19 -- números que começam com a letra 'd' ");

        Console.WriteLine(@"
        5)
        Eu ligaria o interruptor 1, esperaria tempo suficiente para a lâmpada esquentar, depois desligaria o interruptor 1, ligaria o interruptor 2 e iria direto para a sala 1. Caso a lâmpada estivesse apagada e quente, eu saberia que a sala 1 é o interruptor 1. Caso a lâmpada estivesse apagada e fria, eu saberia que a sala 1 é acesa com o interruptor 3, e caso estivesse acesa, saberia que foi ligada pelo interruptor 2. Depois de saber qual interruptor acende a sala 1, eu só precisaria de mais uma ida a sala 2 ou 3 para saber se o próximo interruptor acenderia uma delas, ou não. ");
    }

    public static void CalculateFibonacci(int valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("O valor presente na sequência de fibonacci deve ser maior que zero");
            return;
        }
        var listFibo = new List<int>();
        int num1 = 0;
        int num2 = 1;
        int aux;
        int qtd;
        
        if (valor == 0)
        {
            listFibo.Add(num1);
        }
        else if (valor == 1)
        {
            listFibo.Add(num2);
        }
        else
        {
            listFibo.Add(num1);
            listFibo.Add(num2);
        }

        if (valor <= 10)
        {
            qtd = 10;
        }
        else
        {
            qtd = valor;
        }


        for (int i = 2; i < qtd; i++)
        {
            aux = num1 + num2;
            num1 = num2;
            num2 = aux;
            listFibo.Add(aux);
        }

        foreach (var n in listFibo)
        {
            Console.Write(" " + n);
        }
        Console.WriteLine(" ...");

        if (listFibo.Contains(valor))
        {
            Console.WriteLine($"O valor {valor} está presente na sequencia de Fibonacci");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não faz parte da sequencia de Fibonacci");
        }
    }

    public static void VerifyString(string text)
    {

        string text1 = text.ToLower();
        int cont = 0;
        foreach (var letter in text1)
        {
            if (letter == 'a')
            {
                cont++;
            }
        }
        if (cont > 0)
        {
            Console.WriteLine($"A palavra {text} possui {cont} letras \"a\"");
        }
        else
        {
            Console.WriteLine($"A palavra {text} não possui letra a");

        }

    }

    public static void Soma()
    {
        int indice = 12;
        int soma = 0;
        int k = 1;
        while (k < indice)
        {
            k += 1;
            soma += k;
        }
        Console.WriteLine($"A soma é {soma}");
    }
}

