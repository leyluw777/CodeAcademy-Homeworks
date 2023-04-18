#region TASK1
// --------------- TASK1 --------------------
//string[] names = new[] { "Leyla", "Zuleyxa", "Tural", "Kenan" };
//Console.WriteLine(names[names.Length - 1]);

#endregion

#region TASK2
// --------------- TASK2 --------------------
//Random random = new Random();
//string[] names = new[] { "Leyla", "Zuleyxa", "Tural", "Kenan" };
//Console.WriteLine(names[random.Next(names.Length)]); 

#endregion

#region TASK3
// -------------- TASK3 ---------------------
//string[] cities = new[]
//{
//    "ankara",
//    "edirne",
//    "eskisehir",
//    "bursa",
//    "denizli",
//    "kastamonu",
//    "eskisehir",
//    "artvin",
//    "malatya",
//    "suvas"
//};
//string param = "eskisehir";
//if (Array.IndexOf(cities,param) == Array.LastIndexOf(cities, param))
//{
//    Console.WriteLine("This element is used only once");
//}
//else
//{
//    Console.WriteLine("This element is used more than one time");
//}
#endregion



//string[] letters = new[] { "one", "two", "three" };
//Console.WriteLine(string.Join("\n", letters));

//Console.WriteLine("Write any number: ");
//string input = Console.ReadLine();
//if (Array.IndexOf(letters, input) != -1) Console.WriteLine(true);
//else Console.WriteLine(false);


//Array.Resize(ref letters, letters.Length +1);
//letters[letters.Length - 1]= Console.ReadLine();
//Console.WriteLine(letters[letters.Length - 1]);




//string[] strings = new[] {"baku", "moscow", "istanbul", "tbilisi"};
//Console.WriteLine("Enter any city name: ");
//string input = Console.ReadLine();

//if (Array.IndexOf(strings, input) >= 0)
//{
//    Array.Clear(strings, Array.IndexOf(strings, input), 1);
//}    
//else
//{
//    Console.WriteLine("There is no such element");
//}

//Console.WriteLine(string.Join(" ",  strings));



// EXISTS 
//string[] strings = new[] {"baku", "moscow", "istanbul", "tbilisi"};
//Console.WriteLine("Enter any city name: ");
//string input = Console.ReadLine();
//if (!string.IsNullOrEmpty(input))
//{
//    bool result = Array.Exists(strings, c => c == input);
//    Console.WriteLine(result);
//}


//for (int i = 1; i <= 1000 ; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine("Even numbers are  " + i);
//    }

//}



// LOOPS (For)
//int sum  = 0;
//for (int i = 0;i <=100; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);



//for (int i = 1945; i <= DateTime.Now.Year; i++)
//{
//    if (i != 1990 &&  i != 1992)
//    {
//        Console.WriteLine(i);
//    }
//}



// TASK1 
using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;

string[] products = new string[0];
bool end_point = true;
while (end_point)
{
    try
    {
        Console.WriteLine("Select any operation you want to perform: ");
        Console.WriteLine("Enter 1 if you want to add any product");
        Console.WriteLine("Enter 2 if you want to update any product");
        Console.WriteLine("Enter 3 if you want to delete any product");
        Console.WriteLine("Enter 4 if you want to check existence of any product");
        Console.WriteLine("Enter 5 to end operations");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":

                Console.WriteLine("Enter the name of product: ");
                string product = Console.ReadLine();
                products = products.Append(product).ToArray();
                Console.WriteLine("Your product has successfully added!");
                break;
            case "2":

                Console.WriteLine("Enter the id of product which you want to update: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of updated product: ");
                string updated_element = Console.ReadLine();
                products.SetValue(updated_element, id);
                Console.WriteLine("Your product has successfully updated!");
                break;
            case "3":

                Console.WriteLine("Enter the id of product which you want to delete: ");
                int deleted_id = int.Parse(Console.ReadLine());
                Array.Clear(products, deleted_id, 1);
                Console.WriteLine("Your product has successfully deleted!");
                break;

            case "4":

                if (!string.IsNullOrEmpty(string.Join(" \n", products)))
                {
                    Console.WriteLine(string.Join(" \n", products));
                }
                else
                {
                    Console.WriteLine("There is no elements");
                }
                break;

            case "5":

                end_point = false;
                break;
            default:
                throw (new Exception("Please type suitable number"));
                
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}