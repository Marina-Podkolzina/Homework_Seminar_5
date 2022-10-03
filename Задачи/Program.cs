//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Zadacha34()
{
    int size = 4;
    int [] numbers = new int [size];
    FillArray( numbers);
    PrintArray ( numbers);
    Console.WriteLine();
    FindArray (numbers);
    


    void FillArray ( int[] numbers)
    {
        Random random = new Random();
        for( int i = 0; i < numbers.Length;  i++) 
        {
            numbers[i] = random.Next (100, 1000);
        }

    }
    void PrintArray (int[] numbers)

    {
        Console.WriteLine("Вывод массива:");
        Console.WriteLine();
         for( int i = 0; i < numbers.Length;  i++)
         {
         Console.Write ( numbers[i] + ", ");
         }
        Console.WriteLine();
    }
    
    void FindArray (int[] numbers)
    {
        int result = 0;
        for( int i = 0; i < numbers.Length;  i++) 
        {
            if( numbers[i] % 2 == 0)
            {
                result++;
            }
        }
        Console.WriteLine ($"Количество чётных чисел - {result}");
        Console.WriteLine();

    }
}   
//Zadacha34();



//Задача 36. Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов с нечётными индексами.

void Zadacha36()
{
        int size = 6;
    int [] numbers = new int [size];
    FillArray( numbers);
    PrintArray ( numbers);
    Console.WriteLine("Сумма элементов с нечётными индексами = " + GetSummUneven (numbers));
   
    

     void FillArray ( int[] numbers)
    {
        Random random = new Random();
        for( int i = 0; i < numbers.Length;  i++) 
        {
            numbers[i] = random.Next (-100, 100);
        }
    }


    void PrintArray (int[] numbers)

    {
        Console.WriteLine("Вывод массива:");
        Console.WriteLine();
         for( int i = 0; i < numbers.Length;  i++)
         {
         Console.Write ( numbers[i] + ", ");
         }
        Console.WriteLine();
    }    


    int GetSummUneven ( int[] numbers)
    {
        int sum = 0;
        for( int i=1; i<numbers.Length; i+=2)
        {
            sum += numbers[i];
        }
        return sum;
    }

}
//Zadacha36();



//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38()
{
    int size = 4;
    double [] numbers = new double [size];
    FillArray (numbers);
    PrintArray (numbers);
    Difference (numbers);


    void FillArray ( double[] numbers)
        {
            Random random = new Random();
            for( int i = 0; i < numbers.Length;  i++) 
            {
                numbers[i] = random.Next (-10000, 10000);
                numbers[i]= numbers[i]/100;
            }
        }
    void PrintArray (double[] numbers)

    {
        Console.WriteLine("Вывод массива:");
        Console.WriteLine();
         for( int i = 0; i < numbers.Length;  i++)
         {
         Console.Write ( numbers[i] + "  ");
         }
        Console.WriteLine();
    }
    void Difference ( double[] numbers)
    {
        int i = 0;
        double diff = 0;
        double max = numbers[i];
        double min = numbers[i];
        while ( i <numbers.Length)
        {
            if ( numbers[i]>max)
            {
                max = numbers[i];

                
            }       
            if (numbers[i]<min)
            {
                min = numbers[i];

            }
        i++;   
        }
        diff = Math.Abs(min-max);
        Console.WriteLine($"Разница между max({max}) и min({min}) значениями = {diff}");
    }
}
//Zadacha38();
    