using System;

namespace binary_clock;

class Program
{

    static void Main(string[] args)
    {
        string[] orarr = Console.ReadLine().Split(':');
        string ora = string.Join("", orarr);
        string[] linii = {
            "8 ",
            "4 ",
            "2 ",
            "1 ",
        };

        int i = 1;
        foreach (char d in ora)
        {
            int digit = Convert.ToInt32(Convert.ToString(d));
            if (digit >= 8)
            {
                digit -= 8;
                linii[0] += "● ";
            }
            else
            {
                if (i % 2 == 0)
                    linii[0] += "○ ";
                else linii[0] += "  ";
            }

            if (digit >= 4)
            {
                digit -= 4;
                linii[1] += "● ";
            }
            else
            {
                if (i != 1)
                    linii[1] += "○ ";
                else linii[1] += "  ";
            }

            if (digit >= 2)
            {
                digit -= 2;
                linii[2] += "● ";
            }
            else linii[2] += "○ ";

            if (digit >= 1)
            {
                digit -= 1;
                linii[3] += "● ";
            }
            else linii[3] += "○ ";

            i++;
        }

        
        Console.WriteLine(string.Join('\n', linii));
        Console.Write(' ');
        foreach (char bbb in ora)
            Console.Write($" {bbb}");
        Console.ReadLine();
    }

    
}

