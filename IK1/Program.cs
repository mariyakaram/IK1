using System;

class Program
{
    public static List<string> Result(string[] input_array){
        List<string> ret_l = new List<string>();

        // по очереди ищем что нам не подходит
        foreach(string item in input_array)
        {
            if(item.Length <= 3){
                ret_l.Add(item);
            }
        }
        return ret_l;

    }
    static void Main()
    {

        Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        //[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
        //[“Russia”, “Denmark”, “Kazan”] → []

        Console.WriteLine(string.Join(",", Result(inputArray)));
    }
}


