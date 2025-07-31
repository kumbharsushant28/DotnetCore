using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{

    internal class AccessModifierInternal
    {
        internal void ShowInternalMessage()
        {
            Console.WriteLine("This is an internal method.");
        }

        static void Main()
        {
            AccessModifierInternal ami = new AccessModifierInternal();
            ami.ShowInternalMessage();
        }
    }
}
