namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var str = "amazon";

        var str2 = "010";

        Console.WriteLine(GetMatches(str,str2));
    }

   static int GetMatches(string str1, string str2)
    {
        var count = 0;

        for (int i = 0; i < str1.Length - (str2.Length); i++)
        {
            var substring = str1.Substring(i, str2.Length);
            if (ismatch(substring, str2))
            {
                Console.WriteLine(substring);
                count++;
            }

        }


        return count;
    }

    static bool ismatch(string str1, string str2)
    {

        if (str1.Length != str2.Length)
        {
            return false;

        }

        for (int i = 0; i < str1.Length; i++)
        {
            if ((isVowel(str1[i].ToString()) && str2[i] == '0') || (!isVowel(str1[i].ToString()) && str2[i] == '1'))
            {
                continue;
            }
            return false;
        }
        return true;

    }

    static bool isVowel(string c)
    {

        switch (c.ToLower())
        {

            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                return true;
        }
        return false;

    }
}
