using System;
class program
{
 static void Main(string[] args)
 {
   string? input = "a";
   List<string> palabras = new List<string>();
   while (!string.IsNullOrEmpty(input))
   {
      Console.WriteLine("Ingrese la palabra que desee: ");
      input = Console.ReadLine();
        
     palabras.Add(input);
   }
   palabras.Sort();
   
   foreach ( string palabra in palabras)
   {
     Console.WriteLine(palabra);
   }
    
 
 }

}