using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public static class NameDatabase
    {
        public static List<string> maleNames = new List<string>();
        public static List<string> femaleNames = new List<string>();

        public static void createNameDatabase()
        {
            maleNames.AddRange(new List<string> {
                "Ahmed", "Yasser", "Mohammed", "Ali", "Sayed", "Mamdoh", "Saed", "Ibrahim", "Galal", "Kareem" });
            femaleNames.AddRange(new List<string> {
                "Sara", "Iman", "Mariem", "Nada", "Doha", "Sahar", "Nadia", "Samah", "Dina", "Laila", "Asmaa" });
        }
    }
}
