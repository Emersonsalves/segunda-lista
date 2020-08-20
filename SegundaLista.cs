using System;

namespace segunda_lista
{
    class Program
    {
        static void Exercise1()
		{
            //Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada elemento de C
            //é a subtração do elemento correspondente de A com B.
            
            const int arraysLenght = 15;
            
            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                a[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;
                c[i] = a[i] - result;
            }
		}

		static void Exercise2()
		{
            //Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
            
            var numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem direta de cadastro:");

            foreach (var item in numbers)
            {
               System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Ordem inversa de cadastro:");

            for (int i = numbers.Length - 1; i > -1; i--)
            {
                System.Console.WriteLine(numbers[i]);
            }
		}

		static void Exercise3()
		{
            //Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um
            //número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a
            //mensagem: “O número existe no array” , caso contrário “Número inexistente”.
            
            var numbers = new double[3];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                numbers[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Pesquise um número:");
            var search = Double.Parse(Console.ReadLine());

            var founded = false;

            foreach (var item in numbers)
            {
                if (item == search)
                {
                    founded = true;
                    break;
                }
            }

            if (founded)
            {
               System.Console.WriteLine("O número existe no array"); 
            }
            else
            {
               System.Console.WriteLine("Número inexistente");
            }
		}

		static void Exercise4()
		{
            //Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se
            //os mesmos são iguais ou diferentes.
            
            const int arraysLenght = 3;
            
            var a = new double?[arraysLenght];
            var b = new double[arraysLenght];

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                a[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            var arraysAreEquals = true;

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;

                var hasEquals = false;

                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == result)
                    {
                        hasEquals = true;
                        a[j] = null;
                        break;
                    }   
                }

                if (!hasEquals)
                {
                    arraysAreEquals = false;
                }
            }

            var message = arraysAreEquals ? "Os arrays são iguais" : "Os arrays são diferentes";
            System.Console.WriteLine(message);
		}

        static void Exercise5()
		{
            //Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, em
            //seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            
            var numbers = new double[15];
            var sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um valor");
                var input = Double.Parse(Console.ReadLine());
                numbers[i]= input;
                sum+= input;
            }

            var average = sum / numbers.Length;
            var greater = 0;
            var equals = 0;
            var lesser = 0;

            foreach (var item in numbers)
            {
                if (item>average)
                {
                    greater++;
                }
                else if (item == average)
                {
                    equals++;
                }
                else
                {
                    lesser++;
                }
            }

            System.Console.WriteLine($"{equals} elementos estão na média");
            System.Console.WriteLine($"{greater} elementos estão acima da média");
            System.Console.WriteLine($"{lesser} elementos estão na média");

        }

        static void Exercise6()
        {
            //Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em
            //ordem crescente. Depois ler um array B também com doze elementos, colocar os
            //elementos de B em ordem decrescente. Construir um array C, onde cada elemento de C é a
            //soma do elemento correspondente de A com b. Colocar em ordem crescente a matriz
            //C e apresentar os seus valores.

            const int arraysLenght = 12;
            
            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                Console.WriteLine($"Informe o {i+1}º valor para a primeira lista");
                a[i] = Double.Parse(Console.ReadLine());                
            }
                Console.WriteLine("\n");

            for (int i = 0; i < arraysLenght; i++)
            {
                Console.WriteLine($"Informe o {i+1}º valor para a segunda lista");
                b[i] = Double.Parse(Console.ReadLine());
            }
            //imprimindo os valores do primeiro array em ordem crescente
                Console.WriteLine("\nPrimeira lista em ordem crescente");
                Array.Sort(a);
            foreach (int value in a)
            {
                Console.Write($"{value}, ");
                Console.WriteLine("\n");
            }
            //imprimindo os valores do segundo array em ordem decrescente
                Console.WriteLine("\nSegunda lista em ordem decrescente");
                Array.Sort(b);
                Array.Reverse(b);
            foreach (int value in b)
            {
                Console.Write($"{value}, ");
                Console.WriteLine("\n");
            }
            //somando os valores(array a + array b = array c) e imprimindo o array c em ordem crescente
            for (int i = 0; i < arraysLenght; i++)
            {
                c[i] = a[i] + b[i];
            }

                Console.WriteLine("valores do array C em ordem crescente.");
                Array.Sort(c);
            foreach (int value in c)
            {
                Console.Write($"{value}, ");
            }
                Console.ReadKey();
        }

        static void Main(string[] args) => Exercise6();
    }
}
