using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program1
    {
        static void Main(string[] args)
        {
            string gitRepo = @"https://github.com/97rajnish/CaseStudy.git";
            ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
            cmdStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.CreateNoWindow = true;
            string command = "git clone " + gitRepo + " C://Temp//CaseStudy1";
            Process cmdProcess = new Process();
            cmdProcess.StartInfo = cmdStartInfo;
            cmdProcess.Start();
            cmdProcess.StandardInput.WriteLine(command);
            cmdProcess.StandardInput.WriteLine("exit");
            cmdProcess.WaitForExit();
        }
    }
}
