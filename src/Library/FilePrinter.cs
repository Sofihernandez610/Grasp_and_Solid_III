using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
   public class FilePrinter : IPrinterInterface
   {
      public void PrinterMethod(Recipe recipe)
      {
       File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
      }  
   }
    
}