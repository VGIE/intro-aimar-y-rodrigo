using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IntroExercises
{
    public static class Exercises
    {
        //TODO #1
        //Find should return the position in array where value appears for the first time. -1 if the value isn't found or the array is empty/null
        public static int Find(int[] array, int value)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == value) {
                    return i;
                }
            }
            // si llega aquí es que no lo encontró.
            return -1;

        }

        //TODO #2
        //Count should return the number of times value appears in array. 0 if the array is empty/null
        public static int Count(int[] array, int value)
        {
            if (array == null || array.Length == 0)
                return 0;

            int contador = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    contador++;
                }

            }
            return contador;

        }

        //TODO #3
        //Find should return the position in array where value appears for the first time between positions [startIndex,endIndex]. -1 if the value isn't found or the array is empty/null
        //-1 if endIndex is less than startIndex or any of them is outside the array
        public static int Find(int[] array, int value, int startIndex, int endIndex)
        {
            if (array == null || array.Length == 0)

                return -1;

            //comprueba que no haya problemas con el array.

            if (startIndex > array.Length || endIndex > array.Length || startIndex < 0 || endIndex < 0 || startIndex > endIndex)

                return -1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }

            }
            return -1;
        }

        //TODO #4
        //Count should return the number of times value appears in array between positions [startIndex,endIndex]. 0 if the value isn't found or the array is empty/null
        //0 if endIndex is less than startIndex or any of them is outside the array

        public static int Count(int[] array, int value, int startIndex, int endIndex)
        {
            int counter = 0;
            if (array == null || array.Length == 0)

                return counter;

            //comprueba que no haya problemas con el array.
            if (startIndex > array.Length || endIndex > array.Length || startIndex < 0 || endIndex < 0 || startIndex > endIndex)

                return counter;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] == value)
                {
                    counter++;
                }
            }

            return counter;

        }

        //TODO #5
        //AreEqual should return true if both arrays have the same length and each element appears the same number of times in A and B
        //Examples:
        //  AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 2, 1} => true
        //  AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 2} => false
        //  AreEqual(new int[] { 1, 1, 2}, new int[] { 1, 2, 2} => false
        //  AreEqual(new int[] { 1, 1, 2}, null) => false
        //  AreEqual(null, null) => false
        public static bool AreEqual(int[] A, int[] B)
        {
            if (A == null || B == null)
            {
                return false;
            }
            if (A.Length != B.Length)
            {
                return false;
            }
            int sumaA = 0, sumaB = 0;

            // si llega aqui, no son ni nulls ni tienen diferente tamaño

            //suma para A y B
            for (int i = 0; i < A.Length; i++)
            {
                sumaA += A[i];
                sumaB += B[i];
            }
            if (sumaA == sumaB)
            {
                return true;
            }
            return false; 
            
            }
            
        }
        
        
       
        
    }


