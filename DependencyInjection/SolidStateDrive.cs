using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class SolidStateDrive : IDiskDrive
    {
        public string GetDriveType()
        {
            return "Solid State Drive";
        }
    }
}
