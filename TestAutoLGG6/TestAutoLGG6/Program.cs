using KAutoHelper;
using System;

namespace TestAutoLGG6
{
    class Program
    {
        static void Main(string[] args)
        {
            ADBHelper.SetADBFolderPath(Environment.CurrentDirectory);
            var devices = ADBHelper.GetDevices();

        }
    }
}
