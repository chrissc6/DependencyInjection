using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {


        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.DiskDrive = new MechanicalDrive();
            Console.WriteLine($"Drive type is {comp.DiskDrive.GetDriveType()}"); 
        }
    }
}
