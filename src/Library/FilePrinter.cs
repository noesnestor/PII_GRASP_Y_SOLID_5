using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ISaleContent saleContent)
        {
            File.WriteAllText("Recipe.txt", saleContent.GetTextToPrint());
        }
    }
}