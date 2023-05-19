using System;
class Program{
    static void Main(){
        Console.Write("Enter the number of Pascal's triangle : ");
        int n = int.Parse(Console.ReadLine());
        
        while(n < 0) {
            Console.WriteLine("Invalid Pascal’s triangle row number.");
            n= int.Parse(Console.ReadLine());
        }   
    
            for (int row = 0; row < n+1; row++)
        {

            int num = 1;
            for (int col = 0; col <= row; col++){
            
            Console.Write(num + " ");
            num = num * (row - col) / (col + 1);
            }
            Console.WriteLine();
        }
    }
}
