using System;

namespace Array_Mashup_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int[] array1 = new int[0];
            int[] array2 = new int[0];
           
            //Get user input to set the arrray size for set 1
            Console.Write("How many numbers do you wan to use in the first array set? ");
            array1 = new int [int.Parse(Console.ReadLine())];

            //Get the user input to set the array size for set 2
            Console.Write("How many numbers do you want to use for the second array set? ");
            array2 = new int[int.Parse(Console.ReadLine())];

            //Send the first array to filled
            Console.WriteLine("Lets fill the first array.");
            FillArray(array1);

            //Send the second array to filled
            Console.WriteLine("Lets fill the second array.");
            FillArray(array2);

            //Initialize a 3rd array and send array1 and array2 to be combined
            int[] array3 = CombineArray (array1, array2);

            //Sewnd the combine array to be printed to the console
            PrintArray(array3);
       
        }
        static void FillArray(int[] arrayFill)
        {
            //Set Variables to be used in this class
            int item = 0;
            int arraylength = arrayFill.Length;

            //Set for loop for the length of the array sent to be filled
            for(int i = 0; i < arraylength; i++)
            {
                Console.Write("Array element {0} = ", item++);
                arrayFill[i] = int.Parse(Console.ReadLine());

                //Line Break
                Console.WriteLine("");
            }
        }
        static int[] CombineArray(int[] cRay1, int[] cRay2)
        {
            //create an int for the array length
            int cRay1Length = cRay1.Length;
            int cRay2Length = cRay2.Length;
            
            //Combine the both array lengths
            int newArrayLength = cRay1Length + cRay2Length;

            //Set the combine array to be reurned
            int[] newAry = new int [newArrayLength];

            //Use a for loop to combine each array into the combine array
            for (int index = 0; index < cRay1.Length; index += 1)
            {
                newAry[index] = cRay1[index];

            }//End loop after adding the first array to the combine array

            for (int i = 0; i < cRay2.Length; i += 1)
            {
                int combinearray = cRay1Length + i;
                newAry[combinearray] = cRay2[i];
                             
            }//End loop after adding the second array to the combine array
           
            //Return combine array
            return newAry;
        }
        static void PrintArray(int[] pArray)
        {

           int printArray = pArray.Length;

            //Printing out the combine array on the same line
            Console.Write("The combine array is -> ");
            Console.Write("[");
            
            for (int index = 0; index < printArray; index++)
            {
               
                Console.Write("{0},", pArray[index]);
                
            }
            Console.Write("]");
            Console.WriteLine("");
        }

    }
}
