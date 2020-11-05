using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Farsight
{
    class LCUInterface
    {
        public LCUInterface()
        {
            Console.WriteLine(GetProcessListScript());
            Console.WriteLine(GetClientPort(GetProcessListScript()));
            Console.WriteLine(GetRemotingAuthToken(GetProcessListScript()));
        }

        public static bool IsLCUActive()
        {
            Process[] processes = Process.GetProcessesByName("LeagueClientUx");
            if (processes.Length != 0)
            {
                return true;
            }
            return false;
        }

        private string GetProcessListScript()
        {
            string output = "";

            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/C wmic PROCESS WHERE name='LeagueClientUx.exe' GET commandline";

            process.StartInfo = startInfo;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;
        }

        private string GetClientPort(string input)
        {
            string appPortPattern = @"--app-port=[0-9]*";

            Regex regex = new Regex(appPortPattern);
            Match match = regex.Match(input);
            string resultString = match.Value;

            return resultString.Substring(resultString.IndexOf("=") + 1);
        }

        private string GetRemotingAuthToken(string input)
        {
            string remotingAuthTokenPattern = @"--remoting-auth-token=[\w-_]*";

            Regex regex = new Regex(remotingAuthTokenPattern);
            Match match = regex.Match(input);
            string resultString = match.Value;

            return resultString.Substring(resultString.IndexOf("=") + 1);
        }
    }
}
