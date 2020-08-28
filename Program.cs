using System;
using System.Collections.Generic;


namespace SkrmiishApp
{
    class Program
    {

        static void Main(string[] args)
        {
            MainMenu();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static string DictionaryLookupCipher(char[] word)
        {
            char vv;
            List<char> newWord = new List<char>();
            char[] key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Array.Reverse(value);
            Dictionary<char, char> map = new Dictionary<char, char>();
            
            int i = 0;
            foreach (var item in key)
            {
                map.Add(item, value[i]);
                i++;
            }
            foreach (var wrd in word)
                if (map.TryGetValue(wrd, out vv))
                    newWord.Add(vv);
            var myString = new string(newWord.ToArray());
            return myString;
        }
        private static string DictionaryLookupDecipher(char[] word)
        {
            char vv;
            List<char> newWord = new List<char>();
            char[] key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Array.Reverse(value);
            Dictionary<char, char> map = new Dictionary<char, char>();

            int i = 0;
            foreach (var item in key)
            {
                map.Add(item, value[i]);
                i++;
            }
            foreach (var wrd in word)
                if (map.TryGetValue(wrd, out vv))
                    newWord.Add(vv);
            var myString = new string(newWord.ToArray());
            return myString;
        }
        private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("WELCOME TO SKRMIISH APP!");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Cipher String ");
        Console.WriteLine("2) Decipher String ");
        Console.WriteLine("3) Exit");
        Console.WriteLine("---------------------------------------------");
        Console.Write("\r\nSelect an option: ");
      

            switch (Console.ReadLine())
        {
            case "1":
                CipherString();
                return true;
            case "2":
                DecipherString();
                return true;
            case "3":
                return false;
            default:
                return true;
        }
    }

    private static string CaptureInput()
    {
        Console.Write("Enter the string : ");
        string word = Console.ReadLine();
        return word.ToUpper();
    }

    private static void CipherString()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("CIPHER THE STRING !");
        Console.WriteLine("---------------------------------------------");
       

        char[] charArray = CaptureInput().ToCharArray();
        string word= DictionaryLookupCipher(charArray);

         DisplayResult(word);


    }

    private static void DecipherString()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("DECIPHER THE STRING !");
        Console.WriteLine("---------------------------------------------");
        char[] charArray = CaptureInput().ToCharArray();
        string word = DictionaryLookupDecipher(charArray);
        DisplayResult(word);
    }

    private static void DisplayResult(string message)
    {
        Console.WriteLine($"\r\nYour modified string is: {message}");
        Console.Write("\r\nPress Enter to return to Main Menu: ");
        Console.ReadLine();
    }

}
}
