using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
   public class ConsolePrinter : IPrinterInterface
   {
      public void PrinterMethod(Recipe recipe)
      {
        Console.WriteLine(recipe.GetTextToPrint());

      }  
   }
    
}