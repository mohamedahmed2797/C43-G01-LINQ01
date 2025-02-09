using C43_G01_LINQ01.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using static C43_G01_LINQ01.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C43_G01_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("dictionary_english.txt");
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var result = from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result =  from p in ProductsList
            //              where p.UnitsInStock > 0 && p.UnitPrice > 3
            //              select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Returns digits whose name is shorter than their value. String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((A, I) => A.Length < I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = ProductsList.Where( p => p.UnitsInStock == 0).First();
            //var result = (from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select p).First();
            //Console.WriteLine(result);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductsList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(result?.ProductName ?? "Not Found");
            #endregion
            #region 3. Retrieve the second number greater than 5 Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var result = Arr.Where(A => A > 5).ElementAt(1);

            //Console.WriteLine(result);


            #endregion

            #endregion
            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(A => A % 2 == 1).Count();
            //Console.WriteLine(result);
            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var result = from c in CustomersList
            //             from o in c.Orders

            //             select new
            //             {
            //                 c.CustomerName,
            //                 total = c.Orders.Count(c => c != null)
            //             };
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}



            #endregion
            #region 3. Return a list of categories and how many products each has
            //var result = from p in ProductsList

            //             select new
            //             {
            //                 categories = p.Category,
            //                 count = p.Category.Count(),

            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 4. Get the total of the numbers in an array. Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}; 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum(x=> x);
            //Console.WriteLine(result);
            #endregion
            #region 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var result = words.Count();
            //Console.WriteLine(result);

            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = words.Min(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = words.Max(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = words.Average(x => x.Length);
            //Console.WriteLine(result);

            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array. String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x );
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = from p in ProductsList
            //             orderby p.UnitsInStock descending
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself. string [] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy(x => x.Length).ThenBy(x => x);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array   string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length)
            // .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductsList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x).ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.            string[] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(x => x.Length > 1 && x[1] == 'i').Reverse().ToArray();

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #endregion
            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var result = ProductsList.Select(x => x.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = from w in words
            //             select new
            //             {
            //                 Original = w,
            //                 lowerCase = w.ToLower(),
            //                 upperCase = w.ToUpper(),
            //             };
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = from p in ProductsList
            //             select new  {ProductId = p.ProductID, ProductName = p.ProductName,Price = p.UnitPrice};
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Determine if the value of int in an array matches their position in the array.int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result02 = Arr.Select(x => x);
            //Console.Write("result02 = ");
            //foreach (var x in Arr)
            //{
            //    Console.Write($"{x} ");
            //}
            //Console.WriteLine("\n");
            //var result01 = Arr.OrderBy(x => x);
            //    Console.Write("result01 = ");
            //foreach (int i in result01)
            //{
            //    Console.Write($"{i} ");
            //}

            //    Console.WriteLine("\n");
            //    if (result01 == result02)
            //    {
            //        Console.WriteLine("matched");
            //    }
            //    else
            //    {
            //        Console.WriteLine("there is no matching");
            //    }

            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };
            //Console.WriteLine("Pairs where a < b:");

            //foreach (var x in result)
            //{
            //    Console.WriteLine($"{x.a} is less than {x.b}");
            //}

            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var result = from x in CustomersList
            //                     from o in x.Orders
            //                     where o.Total < 500M
            //                     select o;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //var result = from c in CustomersList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1998
            //             select o;
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #endregion

        }
    }   
}
    