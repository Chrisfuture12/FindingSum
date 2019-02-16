using System;

namespace FindingSum
{
    class sums
    {

       public static int[] findTwoSum(int[] list, int sum) {    
        int listLength=list.Length;
        int[] match=new int[2];

        for(int i=0; i<listLength; i++){
            int x;
            x = sum - list[i];   
            for (int j = 1; j < listLength; j++)
            {
              if (list[j] == x)
              {
                  match[0] = i;
                  match[1] = j;
                  return match;
              }  
            }       
        }
        return null;    
        }

       public static void Main(){
        int[] indices = findTwoSum(new int[] { 1, 3, 5, 7, 9 }, 10);
        Console.WriteLine(indices[0] + " " + indices[1]);
       } 
    }
}