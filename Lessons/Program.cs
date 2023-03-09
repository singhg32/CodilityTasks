using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Solution
{
    public static int BinaryCount(int n)
    {

        int greatestcount = 0;
        int counter = 0;
        string check = Convert.ToString(n, 2);
        foreach (char c in check)
        {
            if (c == '1')
            {
                if (counter > greatestcount)
                {
                    greatestcount = counter;
                }
                counter = 0;
            }
            else
            {
                counter++;
            }
        }

        return greatestcount;
    }




    public static int[] CyclicalRotation(int[] A, int K)
    {
        int[] B = new int[A.Length];
        for (int i = 0; i < K; i++)
        {
            for (int j = 0; j < A.Length; j++)
            {
                if (j == 0)
                {
                    B[j] = A[A.Length - 1];
                }
                else
                {
                    B[j] = A[j - 1];
                }
            }
        }
        return A;
    }
    public static int OddOccurences(int[] A)
    {
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        foreach (int a in A)
        {
            if (pairs.ContainsKey(a))
            {
                pairs[a]++;
            }
            else
            {
                pairs.Add(a, 1);
            }
        }
        foreach (var x in pairs)
        {
            if (x.Value % 2 == 1)
            {
                return x.Value;
            }
        }
        return 0;
    }
    public static int FrogJump(int X, int Y, int D)
    {
        int distance = Math.Abs(Y - X);
        double check = distance / D;

        int Jumps = (int)check;
        if (distance % D > 0)
        {
            Jumps++;
        }
        return Jumps;
    }

    public static int PermMissingElem(int[] A)
    {
        Array.Sort(A);
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != (i + 1))
            {
                return i + 1;
            }

        }
        return 0;

    }
    public static int solution(int[] A)
    {
        int lowest = 100000000;
        for (int i = 0; i < A.Length; i++)
        {
            int a = A.Skip(i).Sum();
            int b = Math.Abs(a - A.Sum());
            int c = Math.Abs(b - a);
            if (c < lowest)
            {
                lowest = c;
            }
        }
        return lowest;
    }
    static int test()
    {
        double L = 3.6444;
        return (int)L;
    }

    static void Main()
    {
        Console.WriteLine(test());
    }

}