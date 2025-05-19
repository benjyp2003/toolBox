using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Tool
    {

        public string Name { get;  set; }
        public float Weight { get; set; }
        public string Category;
        public int UseCount = 0;


        public Tool(string name, float weight, string category) 
        {
            Name = name;
            Weight = weight;
            Category = category;
        }

        public  virtual void Describe()
        {
            Console.WriteLine($"Tool name: {Name} \n" +
                   $"Tool weight: {Weight} \n" +
                   $"Tool category: {Category}");
        }

        public virtual void Use()
        {
            Console.WriteLine("Tool is being used..");
            UseCount++;
        }
    }
}
