namespace _26._08._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //My version
            //Console.WriteLine("Input a word");
            //string word1 = Console.ReadLine(); 

            //char[] stringArray = word1.ToCharArray();

            //Array.Reverse(stringArray);

            //Console.WriteLine(stringArray);

            //Teacher method
            //string input, output = "";
            //Console.WriteLine("Input a word");
            //input = Console.ReadLine();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    output += input[i];
            //}
            //Console.WriteLine(output);
            #endregion

            #region Task2
            //string input1, reverse = String.Empty;
            //Console.Write("Write a word: ");
            //input1 = Console.ReadLine();
            //for (int i = input1.Length - 1; i >= 0; i--)
            //{
            //    reverse += input1[i].ToString();
            //}
            //if (reverse == input1)
            //{
            //    Console.WriteLine("Your word is palindrome: " + reverse);
            //}
            //else
            //{
            //    Console.WriteLine("Your word is not palindrome");
            //}

            ////Method version

            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();

            //if (IsPalindrome(word))
            //{
            //    Console.WriteLine($"'{word}' is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"'{word}' is not a palindrome.");
            //}

            #endregion

            #region Task3

            //Dictionary<string, string> CountryAndCapitals = new Dictionary<string, string>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Dear user, please input a country: ");
            //    string nameOfCountry = Console.ReadLine();
            //    Console.Write("Dear user, please input the capital of the country: ");
            //    string nameOfCapital = Console.ReadLine();
            //    CountryAndCapitals.Add(nameOfCountry, nameOfCapital);
            //    //we can do with this way, too
            //    //CountryAndCapitals[nameOfCountry] = nameOfCapital;
            //}
            //while (true)
            //{
            //    Console.Write("Enter the country you are looking for: ");
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "all")
            //    {
            //        foreach (var pair in CountryAndCapitals)
            //        {
            //            Console.WriteLine($"Country: {pair.Key}, Capital: {pair.Value} ");
            //        }

            //    }
            //    else if (CountryAndCapitals.ContainsKey(input))
            //    {
            //        Console.WriteLine($"Capital of {input}: {CountryAndCapitals[input]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Country not found in the dictionary");
            //    }
            //    Console.Write("Do you want to search for a new capital? (yes/no): ");
            //    string response = Console.ReadLine().ToLower();
            //    if (response != "yes")
            //    {
            //        break;
            //    }
            //}



            #endregion

            #region Task4

            //Queue<string> Words = new Queue<string>();


            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.Write("Enter a new item: ");
            //    string item = Console.ReadLine();
            //    Words.Enqueue(item);
            //}

            //    if (Words.Count >= 4)
            //    {
            //        Console.WriteLine("Enter another item");
            //        string removeItem = Console.ReadLine();
            //        Words.Dequeue();
            //        Words.Enqueue(removeItem);

            //    }
            //Console.WriteLine("Uptaded List below:");
            //foreach (string item in Words)
            //    {
            //        Console.WriteLine(item);
            //    }



            #endregion

            #region Task5
            //List<int> Numbers = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    Numbers.Add(number);
            //}
            //if (Numbers.Count >= 10)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        int temp = Numbers[i];
            //        Numbers[i] = Numbers[Numbers.Count - 5 + i];
            //        Numbers[Numbers.Count - 5 + i] = temp;
            //    }

            //    Console.WriteLine("List after swapping:");
            //    foreach (int num in Numbers)
            //    {
            //        Console.Write(num + " ");
            //    }

            #endregion

            #region Task6

            //SortedSet<int> uniqueSortedNumbers = new SortedSet<int>();

            //// Step b: Fill the collection with different numbers
            //Console.WriteLine("Enter unique numbers (sorted) to fill the collection:");
            //for (int i = 0; i < 10; i++)
            //{
            //    int number;
            //    while (true)
            //    {
            //        Console.Write($"Enter number {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out number))
            //        {
            //            if (!uniqueSortedNumbers.Contains(number))
            //            {
            //                uniqueSortedNumbers.Add(number);
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Number already exists in the collection. Please enter a different number.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //        }
            //    }
            //}

            //// Step c: Print the result to the screen
            //Console.WriteLine("Collection contents:");
            //foreach (int num in uniqueSortedNumbers)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion
        }
        //static bool IsPalindrome(string word)
        //    {
        //        word = word.ToLower(); // Convert to lowercase to handle case-insensitivity

        //        int left = 0;
        //        int right = word.Length - 1;

        //        while (left < right)
        //        {
        //            if (word[left] != word[right])
        //            {
        //                return false;
        //            }
        //            left++;
        //            right--;
        //        }

        //        return true;
        //    }
        //}
    }
}