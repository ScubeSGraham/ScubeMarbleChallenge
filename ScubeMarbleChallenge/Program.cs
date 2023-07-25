// See https://aka.ms/new-console-template for more information
using ScubeMarbleChallenge;
using System.Text;

String command = "";

while (command != "exit")
{
    Console.WriteLine("Enter a command");
    command = Console.ReadLine().ToLower();
    Console.WriteLine("You entered: " + command);

    if (command == "testsetup")
    {
        // Do something
    }
    else if (command == "testmarble")
    {
        Marble marble = new Marble();
        marble.Id = 1;
        marble.Name = "Bob";
        marble.Color = "blue";
        marble.Weight = 0.5;

        Console.WriteLine(marble);
    }
    else if (command == "testclean")
    {
        String testString = "Bob o’Bob";
        String cleanString = testString.ToLower();
        char[] testArray = testString.ToCharArray();
        StringBuilder builder = new StringBuilder();

        foreach (char testChar in testArray)
        {
            if (char.IsLetterOrDigit(testChar))
            {
                builder.Append(testChar);
            }
        }
        cleanString = builder.ToString();

        Console.WriteLine("Input: " + testString + ", Output: " + cleanString);
    }
    else if (command == "testpalindrome")
    {
        String testString = "bob";
        char[] testArray = testString.ToCharArray();
        Array.Reverse(testArray);
        String reverseString = new String(testArray);

        bool isPalindrome = false;
        if (testString == reverseString)
        {
            isPalindrome = true;
        }

        Console.WriteLine("Input: " + testString + ", Output: " + reverseString + ", Palindrome: " + isPalindrome);
    }
    else if (command == "testfilter")
    {
        List<Marble> marbleList = new List<Marble>()
        {
            new Marble() {Id = 1, Color = "blue", Weight = 0.5, Name = "bob"},
            new Marble() {Id = 2, Color = "red", Weight = 0.4, Name = "fred"},
            new Marble() {Id = 3, Color = "violet", Weight = 0.6, Name = "sam"}
        };

        Console.WriteLine("Original List:");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        List<Marble> filteredList = new List<Marble>();

        foreach (Marble marble in marbleList)
        {
            // Copied this from test clean
            String cleanString = marble.Name.ToLower(); // marble name cleaned
            char[] testArray = cleanString.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (char testChar in testArray)
            {
                if (char.IsLetterOrDigit(testChar))
                {
                    builder.Append(testChar);
                }
            }
            cleanString = builder.ToString();

            // Copied from test palindrome
            testArray = cleanString.ToCharArray();
            Array.Reverse(testArray);
            String reverseString = new String(testArray); // marble name reversed

            bool isPalindrome = false;
            if (cleanString == reverseString)
            {
                isPalindrome = true;
            }

            // Added to the filter test
            if (marble.Weight >= 0.5 && isPalindrome == true)
            {
                filteredList.Add(marble);
            }
        }

        Console.WriteLine("Filtered List:");
        foreach (Marble marble in filteredList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();
    }
    else if (command == "testsort")
    {
        List<Marble> marbleList = new List<Marble>()
        {
            // ROYGBIV
            // BRVIOYG
            new Marble() {Id = 1, Color = "blue", Weight = 0.5, Name = "bob"},
            new Marble() {Id = 2, Color = "red", Weight = 0.4, Name = "fred"},
            new Marble() {Id = 3, Color = "violet", Weight = 0.6, Name = "sam"},
            new Marble() {Id = 4, Color = "indigo", Weight = 0.7, Name = "racecar"},
            new Marble() {Id = 5, Color = "orange", Weight = 0.5, Name = "Bob o'Bob"},
            new Marble() {Id = 6, Color = "yellow", Weight = 0.2, Name = "Bob Dad-Bob"},
            new Marble() {Id = 7, Color = "green", Weight = 1.0, Name = "tom"},
        };

        Console.WriteLine("Original List:");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        Dictionary<string, int> colorLookup = new Dictionary<string, int>()
        {
            {"red", 1},
            {"orange", 2},
            {"yellow", 3},
            {"green", 4},
            {"blue", 5},
            {"indigo", 6},
            {"violet" , 7}
        };

        List<Marble> sortedMarbles = marbleList.OrderBy(m => colorLookup[m.Color]).ToList();

        Console.WriteLine("Sorted List:");
        foreach (Marble marble in sortedMarbles)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

    }
    else if (command == "testsortandfilter")
    {
        // Test filter
        List<Marble> marbleList = new List<Marble>()
        {
            new Marble() {Id = 1, Color = "blue", Weight = 0.5, Name = "Bob"},
            new Marble() {Id = 2, Color = "red", Weight = 0.25, Name = "John Smith"},
            new Marble() {Id = 3, Color = "violet", Weight = 0.5, Name = "Bob O'Bob"},
            new Marble() {Id = 4, Color = "indigo", Weight = 0.75, Name = "Bob Dad-Bob"},
            new Marble() {Id = 5, Color = "yellow", Weight = 0.5, Name = "John"},
            new Marble() {Id = 6, Color = "orange", Weight = 0.25, Name = "Bob"},
            new Marble() {Id = 7, Color = "blue", Weight = 0.5, Name = "Smith"},
            new Marble() {Id = 8, Color = "blue", Weight = 0.25, Name = "Bob"},
            new Marble() {Id = 9, Color = "green", Weight = 0.75, Name = "Bobb Ob"},
            new Marble() {Id = 10, Color = "blue", Weight = 0.5, Name = "Bob"}
        };

        Console.WriteLine("Original List:");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        List<Marble> filteredList = new List<Marble>();

        foreach (Marble marble in marbleList)
        {
            // Copied this from test clean
            String cleanString = marble.Name.ToLower(); // marble name cleaned
            char[] testArray = cleanString.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (char testChar in testArray)
            {
                if (char.IsLetterOrDigit(testChar))
                {
                    builder.Append(testChar);
                }
            }
            cleanString = builder.ToString();

            // Copied from test palindrome
            testArray = cleanString.ToCharArray();
            Array.Reverse(testArray);
            String reverseString = new String(testArray); // marble name reversed

            bool isPalindrome = false;
            if (cleanString == reverseString)
            {
                isPalindrome = true;
            }

            // Added to the filter test
            if (marble.Weight >= 0.5 && isPalindrome == true)
            {
                filteredList.Add(marble);
            }
        }

        Dictionary<string, int> colorLookup = new Dictionary<string, int>()
        {
            {"red", 1},
            {"orange", 2},
            {"yellow", 3},
            {"green", 4},
            {"blue", 5},
            {"indigo", 6},
            {"violet" , 7}
        };

        List<Marble> sortedMarbles = filteredList.OrderBy(m => colorLookup[m.Color]).ToList();

        Console.WriteLine("Sorted and Filtered List:");
        foreach (Marble marble in sortedMarbles)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();
    }
    else if (command != "exit")
    {
        Console.WriteLine("Unknown command, try again");
    }
}