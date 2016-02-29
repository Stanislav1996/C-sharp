using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_in_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y,first,second;
            int[] array;
            int[] array1;
            int[] copy_array;
            int[] reverse_array;
            int[,] double_array;
            int number;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1.Zadacha 1 ot klas: Prekopirane na masiv");
                Console.WriteLine("2.Zadacha 2 ot klas: Obrushtane na stoinostite na masiv ");
                Console.WriteLine("3.Zadacha 3 ot klas: Proverka dali masiv e simetrichen");
                Console.WriteLine("4.Zadacha 4 ot klas: Dvumeren masiv:Chetni ili nula ");
                Console.WriteLine("5.Zadacha 1 ot domashnoto:Sbor na nechetni chisla v masiv ");
                Console.WriteLine("6.Zadacha 2 ot domashnoto:Chislata na Fibonachi ");
                Console.WriteLine("7.Zadacha 3 ot domashnoto:Umnojenie na indeksite po 10:  ");
                Console.WriteLine("8.Zadacha 4 ot domashnoto:Tursene na chislo v masiv   ");
                Console.WriteLine("9.Zadacha 5 ot domashnoto:Sravnenie na masivi  ");
                Console.WriteLine("10.Zadacha 6 ot domashnoto:Vertikalno populvane na masiv");
                Console.WriteLine("11.Zadacha:Podrejdane na masiv");
                Console.WriteLine("0.EXIT");
                Console.WriteLine("Vuvedete nomer na zadacha: ");
                x = int.Parse(Console.ReadLine());
                if (x==1)
                {
                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    Input_array(array, z);
                    Console.WriteLine("Normaniqt masiv");
                    Output_array(y, array);
                    Console.WriteLine();
                    copy_array = new int[y];
                    Copy_method(y, copy_array, array);

                    Console.WriteLine("Kopiraniqt masiv");
                    Output_array(y, copy_array);
                }
                if (x==2)
                {
                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    Input_array(array, z);
                    Console.WriteLine("Normaniqt masiv");
                    Output_array(y, array);
                    Console.WriteLine();
                    reverse_array = new int[y];
                    Reverse_method(y, reverse_array, array);
                    Console.WriteLine("Oburnatiq masiv");
                    Output_array(y, reverse_array);
                }
                if (x==3)
                {

                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    Input_array(array, z);
                    Console.WriteLine("Normaniqt masiv");
                    Output_array(y, array);
                    Issymetric(y, array);
                    
                }
                if (x==4)
                {
                    Console.WriteLine("Vuvedete golemina na masiva: ");
                    first = int.Parse(Console.ReadLine());
                    second = int.Parse(Console.ReadLine());
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    double_array = new int[first, second];
                    Input_D_array(first, second, double_array,z);
                    Console.WriteLine("Normalniq Masiv: ");
                    Output_D_array(double_array);
                    Odd_check(double_array);
                    Console.WriteLine("Promeneniq Masiv: ");
                    Output_D_array( double_array);
                }
                if (x==5)
                {
                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    Input_array(array, z);
                    Console.WriteLine("Normaniqt masiv");
                    Output_array(y, array);
                    Console.WriteLine();
                    Sbor_Nechetni(array);
                }
                if (x==6)
                {
                    Console.WriteLine("Vuvedete broi chisla na Fibonachi ");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Fibonachi(array);
                }
                if (x==7)
                {
                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Umnojenie_10(array);
                    Output_array(y,array);
                }
                if (x==8)
                {
                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    Input_array( array, z);
                    Console.WriteLine("Normaniqt masiv");
                    Output_array(y, array);
                    Console.WriteLine("Vuvedete tursenoto chislo: ");
                    number = int.Parse(Console.ReadLine());
                    Looking_number(array, number);
                }
                if (x==9)
                {
                    Console.WriteLine("Vuvedete golemina na masiva");
                    y = int.Parse(Console.ReadLine());
                    array = new int[y];
                    array1 = new int[y];
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());
                    Input_array( array, z);
                    Input_array( array1, z);
                    Sravnenie(array,array1);

                }
                if (x==10)
                {
                    Console.WriteLine("Vuvedete golemina na masiva: ");
                    first = int.Parse(Console.ReadLine());
                    second = int.Parse(Console.ReadLine());
                    double_array = new int[first, second];
                    Input_D_array1(first, second, double_array);
                    Output_D_array(double_array);
                }
                if (x==11)
                {
                    Console.WriteLine("Vuvedete golemina na masiva: ");
                    first = int.Parse(Console.ReadLine());
                    second = int.Parse(Console.ReadLine());
                    Console.WriteLine("Izberete Dali sami da: 1.vuvudete masiva ili 2.random");
                    int z = int.Parse(Console.ReadLine());

                    double_array = new int[first + 1, second + 1];
                    Input_D_array(first, second, double_array, z);
                    Console.WriteLine("Normalniq Masiv: ");
                    Output_D_array(double_array);
                    Console.WriteLine();
           
                    Max_to_min(first, second, double_array);
                    Output_D_array(double_array);
                }
            } while (x!=0);
            Console.WriteLine("Chao");

        }

        private static void Max_to_min(int first, int second, int[,] double_array)
        {
            int asd = 0;
           for (int i = 0; i < double_array.GetLength(0); i++)
          {
                for (int j = 0; j < double_array.GetLength(0); j++)
                {
                    for (int l = 0; l < double_array.GetLength(1)-1; l++)
                    {

                       if (double_array[j,l]>double_array[j,l+1])
                        {
                            asd = double_array[j, l];
                            double_array[j, l] = double_array[j, l + 1];
                            double_array[j, l + 1] = asd;
                        }
                    }
              }
            }
        }

        private static void Sravnenie(int[] array, int[] array1)
        {
            int couter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]!=array1[i])
                {
                    couter++;
                    break;
                }
               
            }
            if (couter==0)
                {
                Console.WriteLine("Masivite suvpadat");
                }
            else
            {
                Console.WriteLine("Masivite ne suvpadat");
            }
        }

        private static void Looking_number(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==number)
                {

                    Console.Write("Chisloto e s indeks: "+i);
                    break;
                }
             
            }
        }

        private static void Umnojenie_10(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;
            }
        }

        private static void Fibonachi(int[] array)
        {
            array[0] = 1;
            array[1] = 1;
            Console.WriteLine();
            Console.Write(array[0]+"\t");
            Console.Write(array[1] + "\t");
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
                Console.Write(array[i]+"\t");
            }
        }

        private static void Sbor_Nechetni(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    sum += array[i];  
                }
            }
            Console.WriteLine("Sumata na nechetnite chisla e : "+sum);
        }

        private static void Output_D_array(int[,] double_array)
        {
            for (int i = 0; i < double_array.GetLength(0); i++)
            {
                for (int j = 0; j < double_array.GetLength(1); j++)
                {
                    Console.Write( double_array[i, j]+"\t");
                } Console.WriteLine();
            }
           
        }

        private static void Odd_check(int[,] double_array)
        {
            for (int i = 0; i < double_array.GetLength(0); i++)
            {
                for (int j = 0; j < double_array.GetLength(1); j++)
                {
                    if (double_array[i, j]%2==1)
                    {
                        double_array[i, j] *= 2;
                    }
                  
                }
            }

        }

        private static void Input_D_array(int first, int second, int[,] double_array,int z)
        {
            Random rand = new Random();
            for (int i = 0; i < double_array.GetLength(0); i++)
            {
                for (int j = 0; j < double_array.GetLength(1); j++)
                {
                    if (z==1)
                    {


                        double_array[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        double_array[i, j] = rand.Next(0, 100);
                    }
                }
            }
        }

        private static void Input_D_array1(int first, int second, int[,] double_array)
        {
            int couter = 1;
            Random rand = new Random();
            for (int i = 0; i < double_array.GetLength(0); i++)
            {
                for (int j = 0; j < double_array.GetLength(1); j++)
                {
                 
                        double_array[j,i] = couter;
                    couter++;
                 
                }
            }
        }

        private static void Issymetric(int y, int[] array)
        {
            int sym=0;
            for (int i = 0; i < y/2; i++)
            {
                if (array[i] != array[y - 1 - i])
                {
                    sym++;
                    break;
                }   
            }
            if (sym==0)
            {
                Console.WriteLine("Masiva e simetrichen");
            }
            else
            {
                Console.WriteLine("Masiva e nesimetrichen");
            }
        }

        private static void Reverse_method(int y, int[] reverse_array, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                reverse_array[array.Length - 1 - i] = array[i];
            }
        }

        private static void Copy_method(int y, int[] copy_array,int [] array)
        {
            
            for (int i = 0; i < copy_array.Length; i++)
            {
                copy_array[i] = array[i];
            }
        }

        private static void Output_array(int y,int[] array)
        {
            for (int i = 0; i < y; i++)
            {
                Console.Write(array[i]+"  ");
            }
        }

        private static void Input_array(int[] array,int z)
        {
            Random rand = new Random();
            for (int i = 0; i <array.Length ; i++)
            {
                if (z==1)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    array[i] = rand.Next(0, 100);
                }
            }
        }
    }
}
