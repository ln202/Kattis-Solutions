﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UnlockPattern
{
    class Program
    {



        static void Main(string[] args)
        {




        }



        int solution(string str)
        {
            str = "?" + str;
            int count = 0;
            for (int i = 1; i <= 9; i++)
            {
                bool[,] visit = new bool[3, 3];
                count += solution(str, 0, i, 0, visit);
            }
            return count;
        }



        List<int> getNext(char ch, int current, int angle, bool[,] visit)
        {
            List<int> list = new List<int>();
            if (ch == 'S' || ch == '?')
            {
                switch (current)
                {
                    case 1:
                        switch (angle)
                        {
                            case 0: break;
                            case 45: break;
                            case 90: break;
                            case 135: break;
                            case 180: break;
                            case 225: break;
                            case 270: break;
                            case 315: break;
                        }
                        break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: break;
                    case 8: break;
                    case 9: break;
                }
            }
            if (ch == 'A' || ch == '?')
            {



            }
            if (ch == 'L' || ch == '?')
            {



            }
            if (ch == 'R' || ch == '?')
            {



            }
            return list;
        }
        int solution(string str, int index, int current, int angle, bool[,] visit)
        {
            if (index == 9)
                return 1;
            if (str[index] == '?')
            {
                switch (current)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: break;
                    case 8: break;
                    case 9: break;
                }
            }
            else if (str[index] == 'S')
            {
                switch (current)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: break;
                    case 8: break;
                    case 9: break;
                }
            }
            else if (str[index] == 'A')
            {



            }
            else if (str[index] == 'L')
            {



            }
            else if (str[index] == 'R')
            {



            }
            return 0;
        }
    }



    class Pattern
    {
        List<int[]>[] list = new List<int[]>[9];








        bool[,] visited = new bool[3, 3];

        int current;
        int angle;
        public Pattern(int current, int angle)
        {
            for (int i = 0; i < 9; i++)
            {
                list[i] = new List<int[]>();
            }
            list[0].Add(new int[] { 4, 7 });
            list[0].Add(new int[] { 8 });
            list[0].Add(new int[] { 5, 9 });
            list[0].Add(new int[] { 6 });
            list[0].Add(new int[] { 2, 3 });



            list[1].Add(new int[] { 3 });
            list[1].Add(new int[] { 1 });
            list[1].Add(new int[] { 4 });
            list[1].Add(new int[] { 7 });
            list[1].Add(new int[] { 5, 8 });
            list[1].Add(new int[] { 9 });
            list[1].Add(new int[] { 6 });

            list[2].Add(new int[] { 2, 1 });
            list[2].Add(new int[] { 4 });
            list[2].Add(new int[] { 5, 7 });
            list[2].Add(new int[] { 8 });
            list[2].Add(new int[] { 6, 9 });



            list[1].Add(new int[] { 5, 6 });
            list[1].Add(new int[] { 3 });
            list[1].Add(new int[] { 2 });
            list[1].Add(new int[] { 1 });
            list[1].Add(new int[] { 7 });
            list[1].Add(new int[] { 8 });
            list[1].Add(new int[] { 9 });



            list[1].Add(new int[] { 6 });
            list[1].Add(new int[] { 3 });
            list[1].Add(new int[] { 2 });
            list[1].Add(new int[] { 1 });
            list[1].Add(new int[] { 4 });
            list[1].Add(new int[] { 7 });
            list[1].Add(new int[] { 8 });
            list[1].Add(new int[] { 9 });



            list[1].Add(new int[] { 3 });
            list[1].Add(new int[] { 2 });
            list[1].Add(new int[] { 1 });
            list[1].Add(new int[] { 5, 4 });
            list[1].Add(new int[] { 7 });
            list[1].Add(new int[] { 8 });
            list[1].Add(new int[] { 9 });



            list[1].Add(new int[] { 8, 9 });
            list[1].Add(new int[] { 6 });
            list[1].Add(new int[] { 5, 3 });
            list[1].Add(new int[] { 2 });
            list[1].Add(new int[] { 4, 1 });



            list[1].Add(new int[] { 9 });
            list[1].Add(new int[] { 6 });
            list[1].Add(new int[] { 3 });
            list[1].Add(new int[] { 5, 2 });
            list[1].Add(new int[] { 1 });
            list[1].Add(new int[] { 4 });
            list[1].Add(new int[] { 7 });



            list[1].Add(new int[] { 6, 3 });
            list[1].Add(new int[] { 2 });
            list[1].Add(new int[] { 5, 1 });
            list[1].Add(new int[] { 4 });
            list[1].Add(new int[] { 8, 7 });



        }



    }
}
