using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;

public class Console2: IPrinter
{
    public void Print(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }    
}