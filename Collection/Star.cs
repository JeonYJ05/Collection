using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Star
    {
        // 순차적 오르고 다시 내리기
        public static void Main()
        {
            string Star = "*";
            //
            // for (int i = 1; i <= 5; i++)                //1  2     
            // {
            //     for (int j = 1; j <= i; j++)          // 1 2
            //     {
            //         Console.Write(Star);
            //
            //     }
            //     Console.WriteLine();
            // }
            //
            // for (int k = 4; k >= 1; k--)
            // {
            //     for (int j = 1; j <= k; j++)
            //     {
            //         Console.Write(Star);
            //     }
            //     Console.WriteLine();
            // }
            //
            //
            //
            //--------------------------------------------------------


            //*****
            //*
            //*****
            //*
            //*****
            //for (int k = 0; k <=1; ++k)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write(Star);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine(Star);
            //}
            //for(int j = 0; j< 5;j++)
            //{
            //    Console.Write(Star);
            //}


            //---홀짝 별찍기
            //    * * * * *
            //     * * * * 
            //    * * * * *
            //     * * * * 
            //    * * * * *

            //      for(int i=0; i < 2; i++)
            //      {
            //          for(int j =0; j< 5; j++)
            //          {
            //              Console.Write(Star);
            //              Console.Write(" ");
            //          }
            //          Console.WriteLine();
            //          for (int k =0; k<5; k++)
            //          {
            //              
            //              Console.Write(" ");
            //              Console.Write(Star);
            //          }
            //          Console.WriteLine();
            //      }
            //      for(int i=0; i<5; i++)
            //      {
            //          Console.Write(Star);
            //          Console.Write(" ");
            //      }


            // ---2배수 별찍기
            //    *
            //    **
            //    ****
            //    ********
            //    ****************
            //    ********************************
            //    ****************************************************************
            //         int Stars = 1;
            //         for(int i = 0; i < 7; i++)
            //         {
            //             for(int j =0; j < Stars; j++)
            //             {
            //                 Console.Write(Star);
            //                 
            //             }
            //             Console.WriteLine();
            //             Stars *= 2;
            //         }
            //     }
            //

            //    --- 피라미드 별찍기
            //    --- 함수 void Pyramid(int number)를 만들고 number 숫자 만큼 피라미드 층을 생성한다. 아래 예시는 number = 5 일 때 출력된다.
            //        *    
            //       ***   
            //      *****  
            //     ******* 
            //    *********
            
            

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; ++j)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= (2 * i) -1; k++)
                {
                    Console.Write(Star);
                }
                Console.WriteLine();

            }


        }

        }
    }
