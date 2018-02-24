using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr,simb="";
            int s=0, m=0, flajok = 0;
            Console.WriteLine("Vvedite virajenie ");
            expr = Console.ReadLine();
            for (int i = 0; i < expr.Length; i++)
            if (expr[i] == '*' || expr[i] == '+') s++;
            int[] digt = new int[s+1];
            s = 0;
            for (int i = 0; i < expr.Length; i++)
            {
                switch (expr[i])
                {
                     case '0':
                        s = s * 10;
                        break;
                     case '1':
                        s = s * 10 + 1;
                        break;
                     case '2':
                        s = s * 10 + 2;
                        break;
                     case '3':
                        s = s * 10 + 3;
                        break;
                     case '4':
                        s = s * 10 + 4;
                        break;
                     case '5':
                        s = s * 10 + 5;
                        break;
                     case '6':
                        s = s * 10 + 6;
                        break;
                     case '7':
                        s = s * 10 + 7;
                        break;
                     case '8':
                        s = s * 10 + 8;
                        break;
                     case '9':
                        s = s * 10 + 9;
                        break;
                     case '+':
                        digt[m] = s;
                        s = 0;
                        simb += '+';
                        m++;
                        if (expr[i - 1] == '+' || expr[i - 1] == '*') flajok = 1;
                        break;
                     case '*':
                        digt[m] = s;
                        s = 0;
                        simb += '*';
                        m++;
                        if (expr[i - 1] == '+' || expr[i - 1] == '*') flajok = 1;
                        break;
                     default:
                        flajok = 1;
                         break;
                }
            }
            digt[m] = s; s = 0;
            if (flajok == 1)
                Console.WriteLine("Ochibka vvoda");
            else
                if(expr[0]=='*' || expr[0] == '+') Console.WriteLine("Ochibka vvoda");
                else
                {
                    for (int i = 0; i < m; i++)
                    {
                        if (simb[i] == '*') { digt[i + 1] = digt[i + 1] * digt[i]; digt[i] = 0; }
                    }
                    for (int i = 0; i < m+1; i++)
                    {
                        s = s + digt[i];
                    }
                    Console.Write(expr);
                    Console.Write("=");
                    Console.Write(s);
                }
            Console.ReadKey(true);
        }
    }
}
