using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1__Test_interface_
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave
        {
            get;
        }
        void ScareLittleChildren();
    }
}
