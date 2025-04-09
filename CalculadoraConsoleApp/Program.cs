namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // v8 - Somar e subtrair dois números em sequência com escrita três casas decimais, mostrando o histórico de operações

            //vetores
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

            //Estrutura de repetição - Loop de execução
            while (true)
            {
                Console.Clear();    //Limpa o console

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Calculadora 2025");
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de Operações");
                Console.WriteLine("S - Sair");
                Console.WriteLine("----------------------------------------------------");
                string opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "s")
                   break;   //Quebra nossa edtrutura de repetição independente do lugar

                else if (opcao == "5")
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("----------------------------------------------------");

                    Console.WriteLine("Digite o número desejado: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1;  i < 11; i++)
                    {
                        int resultadoTabuada = i * numeroTabuada;

                        Console.WriteLine($"{i} x {numeroTabuada} = {resultadoTabuada}");
                    }

                    historicoOperacoes[contadorHistorico] = $"TABUADA: {numeroTabuada}";
                    contadorHistorico++;

                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("----------------------------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                string dblPrimeiroNumero = Console.ReadLine();
                double primeiroNumero = Convert.ToDouble(dblPrimeiroNumero); //os valores recebidos do usuários sempre são string

                Console.Write("Digite o sugundo número: ");
                string dblSegundoNumero = Console.ReadLine();
                double segundoNumero = Convert.ToDouble(dblSegundoNumero);

                double resultado = 0;

                //Estruturas de decisão
                if (opcao == "1")
                {
                    opcao = "SOMA";
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{opcao}: {primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if (opcao == "2")
                {
                    opcao = "SUBTRAÇÃO";
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{opcao}: {primeiroNumero} - {segundoNumero} = {resultado}";
                }
                else if (opcao == "3")
                {
                    opcao = "MULTIPLICAÇÃO";
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{opcao}: {primeiroNumero} * {segundoNumero} = {resultado}";
                }
                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine(" > Não é possivel divisão por 0. <");
                        Console.WriteLine("Digite o sugundo número novamente: ");
                        segundoNumero = Convert.ToDouble(Console.ReadLine());
                    }
                        opcao = "DIVISÃO";
                        resultado = primeiroNumero / segundoNumero;
                        historicoOperacoes[contadorHistorico] = $"{opcao}: {primeiroNumero} / {segundoNumero} = {resultado}";
                }

                else
                {
                    Console.WriteLine("O valor referênte á operação desejada é inválido.");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ReadLine();
                    continue;   //Sempre joga para o começo do loop
                }

                contadorHistorico++;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("A " + opcao + " dos números " + dblPrimeiroNumero + " e " + dblSegundoNumero + " é igual a: ");

                Console.WriteLine(resultado.ToString("F3")); //F3 = Numero de casas decimais que serão mostradas

                Console.ReadLine();
            }
        }
    }
}
