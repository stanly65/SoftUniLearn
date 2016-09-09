using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var firstMember = 1;
        var secondMember = 1;
        for (int i = 0; i < n - 1; i++)
        {
            var nextMember = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = nextMember;
        }

        Console.WriteLine(secondMember);
    }
}

