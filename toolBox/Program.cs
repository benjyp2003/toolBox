using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRUN();
        }
        
        static void TestRUN()
        {
            Hammer hammer1 = new Hammer("hammer", 3.4f, "making holes");
            Hammer hammer2 = new Hammer("hammer", 3.9f, "making holes");
            Drill drill = new Drill("drill", 7.0f, "making holes");
            Saw saw = new Saw("saw", 11.2f, "cutting");
            PipeCutter pipeCutter = new PipeCutter("pipe cutter", 5.8f, "cutting");
            Screwdriver screwDriver = new Screwdriver("screwdriver", 2.2f, "making holes");
            WireStripper wireStripper = new WireStripper("WireStripper", 0.5f, "cutting");
            NailGun nailGun = new NailGun("nailGun", 2.9f, "making holes");

            Tool[] toolArr = { hammer1, hammer2, drill, saw, pipeCutter, screwDriver, wireStripper, nailGun };

            foreach (Tool item in toolArr)
            {
                item.Describe();
                item.Use();
            }

            Toolbox toolbox1 = new Toolbox();
            toolbox1.AddToolsToList(hammer1);
            toolbox1.AddToolsToList(hammer2);
            toolbox1.AddToolsToList(drill);
            toolbox1.AddToolsToList(pipeCutter);
            toolbox1.AddToolsToList(nailGun);
            Console.WriteLine();

            toolbox1.GenerateCategoryzedDict();
            toolbox1.ShowCategoryzedDict();


            hammer2.Use();
            Console.WriteLine(hammer2.UseCount);

            nailGun.Use();
            nailGun.Use();
            nailGun.Use();
            nailGun.Use();
            Console.WriteLine(nailGun.UseCount);
        }
    }
}

