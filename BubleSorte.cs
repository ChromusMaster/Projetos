using System;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {   
            int Min = 1;
            int Max = 1001; /* SA BOSTA USA MAX -1 APANHEI POR BURRICE */ 
            int[] number = new int[50]; 

            HashSet<int> uniqueNumbers = new HashSet<int>();
            Random randNum = new Random();

            while (uniqueNumbers.Count < 50)
            {
                uniqueNumbers.Add(randNum.Next(Min, Max));
            }

            number = uniqueNumbers.ToArray();

            bool flag = true;
            int temp;
            int numLength = number.Length;

            Console.WriteLine("Digite 'A' para Ascendente ou 'D' para Descendente:");
            char ordem = Console.ReadLine().ToUpper()[0];

            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    // Altere o if para:
                    if ((ordem == 'A' && number[j] > number[j + 1]) ||  (ordem == 'D' && number[j] < number[j + 1]))
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            foreach (int num in number)
            {
                Console.Write("\t \n {0}",num);
            }
            Console.WriteLine("\nParça, aperta alguma tecla ai namoralzinha.");
            Console.ReadLine();
        }
    }
}