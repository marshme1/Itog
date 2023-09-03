namespace Itog.Rabota1;

class Program
{
    //Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
    //длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
     //либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
      //лучше обойтись исключительно массивами.
    static void Main(string[] args)
    {
        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
        }
        

        string [] str = {"1234", "156", "-2", "computer science"}; 
        
        int count = 0;

        for (int i=0; i<str.Length;i++)
        {
            if (str[i].Length <4)
            {
                count+=1;
            }
        }
        
        string [] newStr = new string[count];
        int j =0;

        for (int i=0; i<str.Length;i++)
        {
            if (str[i].Length <4)
            {
                newStr[j]=str[i];
                j+=1;
            }
        }
        
        PrintArray(newStr);

       
    }
}
