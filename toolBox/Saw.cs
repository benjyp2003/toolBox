
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Saw : Tool
    {
        public Saw(string name, float weight, string category) : base(name, weight, category)
        {
            Name = name;
            Weight = weight;
            Category = category;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"Tool name: {Name} \n" +
                   $"Tool weight: {Weight} \n" +
                   $"Tool category: {Category}");
        }

        public override void Use()
        {
            Console.WriteLine("sew is sawing trees..");
            UseCount++;
        }
    }
}
