using System;
using System.Xml.Serialization;

// void StartsWithLFruits () 
// {
//     // Find the words in the collection that start with the letter 'L'
//     List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

//     IEnumerable<string> LFruits = from string fruit in fruits 
//         where fruit.StartsWith("L")
//         select fruit;

//     foreach (string fruit in LFruits)
//     {
//         Console.WriteLine(fruit);
//     }
// }



// void MultiplesOf4Or6 ()
// {
//     // Which of the following numbers are multiples of 4 or 6
//     List<int> numbers = new List<int>()
//     {
//         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
//     };

//     IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num %  6 == 0);

//     foreach (int num in fourSixMultiples)
//     {
//         Console.WriteLine(num);
//     }
// }



// void ReverseAlphabeticalOrder ()
// {
//     // Order these student names alphabetically, in descending order (Z to A)
//     List<string> names = new List<string>()
//     {
//         "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//         "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//         "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//         "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//         "Francisco", "Tre"
//     };

//     List<string> descend = names.OrderByDescending(name => name).ToList();

//     foreach (string name in descend)
//     {
//         Console.WriteLine(name);
//     }
// }



// void AscendingNumbers ()
// {
//     // Build a collection of these numbers sorted in ascending order
//     List<int> numbers = new List<int>()
//     {
//         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
//     };

//     List<int> ascend = numbers.OrderBy(n => n).ToList();

//     foreach (int num in ascend)
//     {
//         Console.WriteLine(num);
//     }
// }



// void NumberOfNumbersInList ()
// {
//     // Output how many numbers are in this list
//     List<int> numbers = new List<int>()
//     {
//         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
//     };

//     Console.WriteLine(numbers.Count);
// }



// void TallyIncome ()
// {
//     // How much money have we made?
//     List<double> purchases = new List<double>()
//     {
//         2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
//     };

//     double income = 0;
//     purchases.ForEach(purchase => income += purchase);

//     Console.WriteLine(income);
// }



// void MostExpensivist ()
// {
//     // What is our most expensive product?
//     List<double> prices = new List<double>()
//     {
//         879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
//     };

//     IEnumerable<double> sorted = prices.OrderByDescending(price => price);

//     Console.WriteLine(sorted.First());
// }



// void LookForPerfectSquare ()
// {
//     List<int> wheresSquaredo = new List<int>()
//     {
//         66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
//     };
//     /*
//         Store each number in the following List until a perfect square
//         is detected.

//         Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

//         Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
//     */
//     List<int> PreSquaredoFound = new List<int>();

//     foreach (int num in wheresSquaredo)
//     {
//         if (Math.Sqrt(num) % 1 != 0)
//         {
//             PreSquaredoFound.Add(num);
//         }
//         else
//         {
//             break;
//         }
//     }

//     Console.Write("{ ");
//     foreach (int num in PreSquaredoFound)   
//     {
//         Console.Write($"{num} ");
//     }
//     Console.Write("}");
// }
public class MillionaireReport
{
    public string? BankName { get; set; }

    public int MillionaireQty { get; set; }

}
public class Program
{
    public static void Main() {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        List<Customer> MillionaireCustomers = customers.Where(curr => curr.Balance >= 1000000).ToList();

        List<MillionaireReport> MillionairesReport = (from customer in MillionaireCustomers
            group customer by customer.Bank into bankGroup
            select new MillionaireReport {
                BankName = bankGroup.Key,
                MillionaireQty = bankGroup.Count()
            }).ToList();

            foreach (MillionaireReport entry in MillionairesReport)
            {
                Console.WriteLine($"{entry.BankName} {entry.MillionaireQty}");
            }
    }
}



// StartsWithLFruits();
// MultiplesOf4Or6();
// ReverseAlphabeticalOrder();
// AscendingNumbers();
// NumberOfNumbersInList();
// TallyIncome();
// MostExpensivist();
// LookForPerfectSquare();

