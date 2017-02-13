using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using CommandLine.Text;

namespace old_gsi_json2geojson
{
	class Options
	{
		[Option('b', HelpText = "Beautify output json.", DefaultValue = false)]
		public bool Beautify { get; set; }
		[Option('o', HelpText = "output path. Otherwise, Writeout to stdout.")]
		public string Output { get; set; }
		[Option('i', Required = true, HelpText = "input path")]
		public string Input { get; set; }
		[HelpOption(HelpText = "Display this help screen.")]
		public string GetUsage()
		{
			return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
