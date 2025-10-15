using System;
using System.IO;
namespace Full_GRASP_And_SOLID.Library;

public class File2: IPrinter
{
    public void Print(Recipe recipe)
    {
        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
}