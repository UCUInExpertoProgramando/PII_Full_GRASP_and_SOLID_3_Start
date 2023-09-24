using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
                //Cuando PrintRecipe es llamado por un objeto tipo FilePrinter, escribimos el texto en
                //un archivo, esto no modifica la información ni genera ningún resultado inesperado, por
                //lo que cumplimos con el principio LSP
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());   
        }
    }
}
