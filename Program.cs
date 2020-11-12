using System;
using StudioRMLib;
using StudioCoreLib;

namespace p1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IDmApplication rm = new StudioRMLib.DmApplication();
			rm.ControlBars.Output.WriteLine("Hello from Mono!");
            
			Console.WriteLine("Hello World!");
            
            Console.ReadKey();

		}
	}
}
