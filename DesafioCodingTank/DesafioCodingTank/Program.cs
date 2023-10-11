namespace DesafioCodingTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            /*
            // Lista vazia para adicionar os números.
            List<int> lista = new List<int>();

            // Variáveis de soma iniciadas com valor padrão 0.
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            // Utilizei o for pois eu sabia que tinha que perguntar ao usuário apenas 5 números.
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i+1} número: ");
                
                int numero;

                // Tryparse para certificar que o usuário vai digitar apenas números.
                if (int.TryParse(Console.ReadLine(), out numero))
                { 
                    lista.Add(numero);
                }
                else
                {
                    Console.WriteLine("Você não digitou um número!!! ");
                }
            }

            // Decidi usar o operador ternário para diminuir a quantidade de IF's.
            // Juntamente com o foreach para percorrer a lista.
            foreach (var numero in lista)
            {
                pares += numero % 2 == 0 ? 1 : 0;
                impares += numero % 2 != 0 ? 1 : 0;
                positivos += numero > 0 ? 1 : 0;
                negativos += numero < 0 ? 1 : 0;
            }

            Console.WriteLine();

            // RESULTADO
            Console.WriteLine("VALORES PARES: " + pares);
            Console.WriteLine("VALORES IMPARES: " + impares);
            Console.WriteLine("VALORES POSITIVOS: " + positivos);
            Console.WriteLine("VALORES NEGATIVOS: " + negativos);
            #endregion

            #region Exercicio 2
            */
            #endregion

            #region Exercicio 2
            /*
            // USO DO TRY PARA ACEITAR APENAS NUMEROS INTEIROS
            try
            {
                Console.Write("Digite o primeiro número inteiro (N1): ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro (N2): ");
                int n2 = int.Parse(Console.ReadLine());

                // Certificando que não teremos o 0 em nossas operações
                if (n1 != 0 && n2 != 0)
                {
                    // POR QUESTÃO DE ORGANIZAÇÃO DECIDI CRIAR FUNCÕES COM RETORNO PARA DEIXAR O CÓDIGO MAIS LEGÍVEL
                    int multiplicao = Multiplicar(n1, n2);
                    int divisao = Dividir(n1, n2);

                    Console.WriteLine($"Multiplicação de N1 por N2: {multiplicao}");
                    Console.WriteLine($"Divisão de N1 por N2: {Math.Abs(divisao)}");
                }
                else
                {
                    Console.WriteLine("Programa não aceita divisão por 0.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error = " + ex.Message);
            }
            */
            #endregion

            #region Exercicio 3
            /*
            // todas as letras maiusculas
            // todas as letras minusculas
            // todas iniciam com letra maiuscula
            // todas iniciam com letra minuscula

            Console.WriteLine("Digite um texto: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');

            int maiusculas = 0;
            int minusculas = 0;
            int primeiraMaiuscula = 0;
            int primeiraMinuscula = 0;

            foreach (var palavra in palavras)
            {
                if (string.IsNullOrEmpty(palavra))
                {
                    continue; // Ignora palavras vazias (espaços em branco)
                }
                // PALAVRAS MAIUSCULAS
                if (char.IsUpper(palavra[0]))
                {
                    primeiraMaiuscula++;
                }
                // PALAVRAS MINUSCULAS
                else
                {
                    primeiraMinuscula++;
                }
                // INICIAM COM MAIUSCULA
                if (palavra.Equals(palavra.ToUpper()))
                {
                    maiusculas++;
                }
                // INICIAM COM MINUSCULA
                else if (palavra.Equals(palavra.ToLower()))
                {
                    minusculas++;
                }
            }

            int totalPalavras = palavras.Length;

            Console.WriteLine($"Palavras maiúsculas: {maiusculas}");
            Console.WriteLine($"Palavras minúsculas: {minusculas}");
            Console.WriteLine($"Palavras que começam com letra maiúscula: {primeiraMaiuscula}");
            Console.WriteLine($"Palavras que começam com letra minúscula: {primeiraMinuscula}");
            Console.WriteLine($"Total de palavras: {totalPalavras}");
            */
            #endregion

            #region Exercicio 4
            /*
            Int32 numero;
            numero = Convert.ToInt16(!(21 > 21));
            Console.WriteLine(numero);
            */

            /*
            Questão 4 - Letra C - 21 É MAIOR QUE 21? FALSO, PORÉM O SINAL DE ! INVERTE A CONDIÇÃO TORNANDO A MESMA VERDADEIRA OU
            SEJA numero = Convert.ToInt16(true); <- quando convertemos um boolean para um inteiro de 16 bits obtemos
            o valor 1 para true e 0 para false.
            */
            #endregion

            #region Exercicio 5
            /*
            for (int i = -5; i <= 7; i += 3)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Questão 5 - Letra E - ESTAMOS USANDO A ESTRUTURA FOR PARA FAZER COM QUE NOSSA VARIÁVEL I IMPRIMA NÚMEROS DE -5 A 7 
            PULANDO DE 3 EM 3 ENQUANTO O MESMO FOR MENOR OU IGUAL A 7, É UMA FORMA DE ITERAR E IMPRIMIR VALORES DESEJADOS EM 
            UM CERTO INTERVALO DE TEMPO.
            */
            #endregion
        }

        static int Multiplicar(int n1, int n2)
        {
            int multiplicacao = 0;
            int absN1 = Math.Abs(n1);
            int absN2 = Math.Abs(n2);

            // O segundo número digitado vai ser a quantidade de vezes que o primeiro número sera adicionado na variável.
            // POR EXEMPLO -> 4 = N1 E 2 = N2 -> ADICIONO O N1 NA VARIÁVEL MULTIPLICAÇÃO N2 VEZES
            for (int i = 0; i < absN2; i++)
            {
                multiplicacao += n1;
            }

            // Certifico que o sinal sera ajustado conforme um dos valores for negativo
            if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
            {
                multiplicacao = -multiplicacao;
            }

            return multiplicacao;
        }

        static int Dividir(int n1, int n2)
        {
            int divisao = 0;
            int absN1 = Math.Abs(n1);
            int absN2 = Math.Abs(n2);

            /* 
               Subtrai o valor N2 de N1 até que o mesmo seja menor N2, a variável divisão vai contar quantas vezes
               esse processo foi realizado -> TRADUZINDO: quantos N2 consigo tirar de N1? A resposta será a divisão
               inteira.
            */
            while (absN1 >= absN2)
            {
                absN1 -= absN2;
                divisao++;
            }

            return divisao;
        }
    }
}