static void Main(string[] args)
        {
            string str = "Составить программу печати по одному разу в алфавитном порядке всех строчных русских гласных букв, входящих в заданный текст.";
            HashSet<char> vowels = new HashSet<char>(str);
            vowels.IntersectWith("аеёиоуыэюя");
 
            List<char> lst = new List<char>();
            lst = vowels.ToList<char>();
            lst.Sort();
 
            foreach (char m in lst)
                Console.WriteLine(m);
 
            Console.ReadKey();
        }
