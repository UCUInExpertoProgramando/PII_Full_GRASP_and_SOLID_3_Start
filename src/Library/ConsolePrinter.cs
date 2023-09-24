using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            //Al llamar a PrintRecipe desde un objeto tipo ConsolePrinter, imprimos por consola los datos de la receta,
            //esto no modifica ninguna información ni genera ningún resultado inesperado, por lo que cumplimos
            //con el principio LSP.
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
