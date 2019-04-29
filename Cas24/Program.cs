using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program.Nullables();
            //Program.Klase();
            //Program.Nizovi();
            //Program.Nizovi2();
            //Program.Nizovi3();
            //Program.Nizovi4();
            Program.Nizovi5();

            Console.ReadLine();
        }

        // Parametarski nizovi
        public static void Nizovi5()
        {
            int rez = 0;
            rez = Program.Suma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Suma je {0}", rez);
        }

        static int Suma(params int[] niz) 
        {
            int suma = 0;
            foreach(int i in niz)
            {
                suma += i;
            }
            return suma;
        }

        // Prosledjivanje nizova kao argumenata funkcije
        public static void Nizovi4()
        {
            int[] a = new int[3] { 16, 54, 198};
            double rez;

            rez = Program.Prosek(a);

            Console.WriteLine("Prosecna vrednost je: {0}", rez);

        } 

        // Ugnjezdeni nizovi
        public static void Nizovi3()
        {
            int[][] rezultati = new int[5][];
            for (int i = 0; i < rezultati.Length; i++)
            {
                rezultati[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    rezultati[i][j] = j;
                }
            }
            
            for (int i = 0; i < rezultati.Length; i++)
            {
                for (int j = 0; j < rezultati[i].Length; j++)
                {
                    Console.WriteLine("reultati[{0}][{1}] = {2}", i, j, rezultati[i][j]);
                }
            }
        }

        // VIsedimenzionalni nizovi
        public static void Nizovi2()
        {
            int[,] a = new int[4, 2] { { 0, 0 }, { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int i, j;

            Console.WriteLine("*** Nizovi i for petlja ***");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Clan[{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.WriteLine(a[2, 1]);
        }

        // Nizovi / jednodimenzionalni nizovi
        public static void Nizovi()
        {
            int[] n = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            Console.WriteLine("*** Nizovi i foreach petlja ***");
            foreach (int j in n)
            {
                Console.WriteLine("Vrednost clana je {0}", j);
            }

            Console.WriteLine("*** Nizovi i for petlja ***");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Clan[{0}] = {1}", i, n[i]);
                n[i] = n[i] * 2;
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Clan[{0}] = {1}", i, n[i]);
            }

        }

        public static void Nullables()
        {
            double? num1 = null;
            double? num2 = 3.14159;
            double num3;

            num3 = num1 ?? 5.28;
            Console.WriteLine("Vrednost num3 je {0}", num3);

            num3 = num2 ?? 5.28;
            Console.WriteLine("Vrednost num3 je {0}", num3);

            int vrednostS;
            vrednostS = NumClass.AddS(1, 2);
            Console.WriteLine("Vrednost static je {0}", vrednostS);

            NumClass nc = new NumClass();
            int vrednost = 0;
            vrednost = nc.Add(10, 20);

            Console.WriteLine("Vrednost sabiranja je {0}", vrednost);
        }

        public static void Klase()
        {
            Console.WriteLine("Covek kaze {0}", Covek.Vikni("ja sad vicem"));

            Covek mile = new Covek();
            mile.SetName("Mile");

            mile.SetDatumRodjenja(1, 1, 1980);

            Console.WriteLine("Ime coveka je {0}", mile.GetName());
            Console.WriteLine(mile.KaziStarost());
        }

        static double Prosek(int[] niz)
        {
            double suma = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                suma = suma + (double) niz[i];
            }
            return suma / niz.Length;
        }
    }
}
