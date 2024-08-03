using System.Diagnostics;

System.Diagnostics.Process.Start(new ProcessStartInfo(@"c:\windows\system32\winebrowser.exe")
{
	Arguments = "steam://run/438100/" + args[0],
	CreateNoWindow = true,	
	UseShellExecute = true
});