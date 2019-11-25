using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        // Tipi int

        public static void LeggiArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserisci il valore dell'array i posizione {1}");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void StampaArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static int[] CopiaArrayInt(int [] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayInt(int [] array, int elemento)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiInt(int [] array1, int [] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risposta = false;
            }
            return risposta;
        }
        public static void RiempiArray(int[] array)
        {
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int randomnumber = random.Next();
                array[i] = randomnumber;
            }
        }

        // Tipi double

        public static void LeggiArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserisci il valore dell'array i posizione {1}");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void StampaArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static double[] CopiaArrayDouble(double[] array)
        {
            double[] array2 = new double [array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayDouble(double[] array, double elemento)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiDouble(double[] array1, double[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risposta = false;
            }
            return risposta;
        }

        // Tipi string

        public static void LeggiArrayString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserisci il valore dell'array i posizione {1}");
                array[i] = Console.ReadLine();
            }
        }
        public static void StampaArrayString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static string[] CopiaArrayString(string[] array)
        {
            string[] array2 = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayString(string[] array, string elemento)
        {
            bool trovato = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                    trovato = true;
            }
            return trovato;
        }
        public static bool SonoUgualiString(string[] array1, string[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            bool risposta = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    risposta = false;
            }
            return risposta;
        }

        // Altri metodi

        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static bool Crescente (int [] array)
        {
            bool risposta = true;
            for ( int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                    risposta = false;
            }
            return risposta;
        }
        public static bool Decrescente(int[] array)
        {
            bool risposta = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    risposta = false;
            }
            return risposta;
        }
    }
}
