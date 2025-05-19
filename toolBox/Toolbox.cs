using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Toolbox
    {
        public Dictionary<string, List<Tool>> CategoryzedTools = new Dictionary<string, List<Tool>>();
        public List<Tool> ToolList = new List<Tool>();

        public Toolbox() { }

        public void AddToolsToList(Tool tool)
        {
            ToolList.Add(tool);
        }

        public void ShowToolList()
        {
            foreach (Tool tool in ToolList)
            {
                Console.Write(tool.Name + ", ");
            }
        }

        public void GenerateCategoryzedDict()
        {
            foreach (Tool tool in ToolList)
            {
                if (CategoryzedTools.TryGetValue(tool.Category, out _))
                {
                    CategoryzedTools[tool.Category].Add(tool);
                }
                else
                {
                    CategoryzedTools.Add(tool.Category, new List<Tool>());
                    CategoryzedTools[tool.Category].Add(tool);
                }
            }
        }

        public void ShowCategoryzedDict()
        {
            foreach (KeyValuePair<string, List<Tool>> kvp in CategoryzedTools)
            {
                Console.WriteLine($"Category: {kvp.Key} ");
                Console.Write("Tools: ");
                foreach (Tool tool in kvp.Value)
                { Console.Write(tool.Name + " ,"); }
                Console.WriteLine("\n");

            }
        }
    }
}
