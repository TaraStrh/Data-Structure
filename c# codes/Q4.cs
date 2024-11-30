
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        for(int i=0 ; i<input+1 ; i++)
        {
            int count=0;
            int num =i;
            while(num>0)
            {
                if(num%2 == 1)
            {
                 count++;
            }
                num /= 2;
            }
            Console.Write(count +" ");
            
            
           
        }
         
    } 
    }
   
}