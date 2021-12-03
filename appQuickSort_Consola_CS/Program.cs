using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appQuickSort_Consola_CS
{
  class Program
  {
    static void Main(string[] args)
    {
      int n;
      //Console.WriteLine("Metodo de Quick Sort");
      Console.Write("Longitud del vector: ");
      n = Int32.Parse(Console.ReadLine());
      int[] vector;
      vector = new int[n];
      for (int i = 0; i < n; i++)
      {
        Console.Write("ingrese valor {0}: ", i + 1);
        vector[i] = Int32.Parse(Console.ReadLine());
      }
      //quicksort(vector, 0, n - 1);
      bubbleSort(vector);
      Console.WriteLine("Vector ordenado en forma ascendente");
      for (int i = 0; i < vector.Length; i++)
      {
        Console.Write("{0} ", vector[i]);
      }
      Console.ReadKey();
    }
    //VECTOR  de 10 ELEMENTOS   --  0  -->  9
    // 0 1 2 3 4 5 6 7 8 9   POSSSS
    // 1 3 5 4 2 6 8 9 7 0   VALORES
    private static void quicksort(int[] vector, int primero, int ultimo)
    {
      int i, j, central;
      double pivote;
      central = (primero + ultimo) / 2;
      pivote = vector[central];
      i = primero;
      j = ultimo;
      do
      {
        while (vector[i] < pivote)
          i++;
        while (vector[j] > pivote)
          j--;
        if (i <= j)
        {
          //swap
          int temp;
          temp = vector[i];
          vector[i] = vector[j];
          vector[j] = temp;
          i++;
          j--;
        }
      } while (i <= j);

      if (primero < j)
      {
        quicksort(vector, primero, j);
      }
      if (i < ultimo)
      {
        quicksort(vector, i, ultimo);
      }
    }

    private static void bubbleSort(int[] vector)
    {
      int t;
      for (int a = 0; a < vector.Length; a++)
        for (int b =0; b < vector.Length-1 ; b++)
        {
          if (vector[b] > vector[b+1])
          {
            t = vector[b];
            vector[b] = vector[b+1];
            vector[b+1] = t;
          }
        }
    }

  }

}
