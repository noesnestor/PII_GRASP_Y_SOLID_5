using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(ISaleContent saleContent)
        {
            Console.WriteLine(saleContent.GetTextToPrint());
        }
    }
}