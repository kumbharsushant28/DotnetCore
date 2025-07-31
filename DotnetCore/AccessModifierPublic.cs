using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class PublicDemo
    {
        public void showMessage()
        {
            Console.WriteLine("Hi from public class PublicDemo and public function ShowMessage()");
        }
    }
    internal class AccessModifierPublic
    {
        static void Main()
        {
            PublicDemo p = new PublicDemo();
            p.showMessage();
        }
    }
}
