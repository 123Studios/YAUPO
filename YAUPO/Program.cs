using System;

namespace YAUPO {
    internal class Program {
        public static string obfIP;
        static void Main(string[] args) {
            try {
                if (args[0] == null) Console.WriteLine("[-] Couldn't Obfuscate IP/URL Correctly. use \"-help\" for support.");
                if (args[0] == "--help") Console.WriteLine("--ip=Obfuscate ip to hexadecimal format that can be run in  browser.(Ex: dotnet YAUPO.dll --ip 127.0.0.1)\n--help=Displays this message.\n\nComing Soon: --url=Obfuscate url to run in the browser.");
                if (args[0] == "--ip") IP(args[1]);
            } catch {
                Console.WriteLine("Something went wrong. Run \"--help\" for support.");
            }
            Console.WriteLine(obfIP);
        }
        static void IP(string i) {
            try {
                string[] it = i.Split('.');
                obfIP = $"Created By 123Studios\n[+] Result: http://0x{Convert.ToByte(it[0]).ToString("x2")}.0x{Convert.ToByte(it[1]).ToString("x2")}.0x{Convert.ToByte(it[2]).ToString("x2")}.0x{Convert.ToByte(it[3]).ToString("x2")}";
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}