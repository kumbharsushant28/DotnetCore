using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class PrivateDemo
    {
        private void showSecretMessage()
        {
            Console.WriteLine("This is a private method and cannot be accessed outside this class.");
        }
        public void callshowSecretMessage()
        {
            showSecretMessage();
        }
    }

    internal class AccessModifierPrivate
    {
        static void Main()
        {
            PrivateDemo p = new PrivateDemo();
            p.callshowSecretMessage(); // This will work because we are calling the private method through a public method.
            // p.showSecretMessage(); // This line would cause a compile-time error if uncommented, as showSecretMessage is private.
        }
    }


}
