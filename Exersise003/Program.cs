using System;
public class Exercise7
{
  public static void Main()
  {
    int n1, n2, n3;
    bool Even;
    Console.Write("Input First number: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input Second number: ");
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input Third number: ");
    n3 = Convert.ToInt32(Console.ReadLine());
    
    
    Even = ((n1 % 2 == 0) 
        && (n2 % 2 ==0))? true : false;
        
      Console.WriteLine( Even ?
        "there're numbers Even" : 
        "there's a number odd");
  }
}
