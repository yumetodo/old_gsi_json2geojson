using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using System.ComponentModel;
using CommandLine;
using CommandLine.Text;

namespace old_gsi_json2geojson
{
	public class Style
	{
		public string strokeColor { get; set; }
		public string strokeWidth { get; set; }
		public double strokeOpacity { get; set; }
		public string strokeLinecap { get; set; }
	}
	public class Geometry
	{
		public string type { get; set; }
		public List<Point> coordinates { get; set; }
	}
	public class Datum
	{
		public string name { get; set; }
		public string type { get; set; }
		public Geometry geometry { get; set; }
	}
	public class Layer
	{
		public string name { get; set; }
		public Style style { get; set; }
		public List<Datum> data { get; set; }
	}
	public class Properties
	{
		public string name { get; set; }
		//Icon/DivIcon/Circle/CircleMarker
		[DefaultValue("Icon")]
		public string _markerType { get; set; }
		//https://www.mapbox.com/mapbox.js/api/v3.0.1/l-path/
		[DefaultValue("")]
		public string _className { get; set; }
		public bool _stroke { get; set; }
		[DefaultValue("#03f")]
		public string _color { get; set; }
		[DefaultValue(5)]
		public int _weight { get; set; }
		[DefaultValue(0.5)]
		public double _opacity { get; set; }
		public bool _fill { get; set; }
		[DefaultValue("#03f")]
		public string _fillColor { get; set; }
		[DefaultValue(0.2)]
		public double _fillOpacity { get; set; }
		public string _dashArray { get; set; }
		public string _lineCap { get; set; }
		public string _lineJoin { get; set; }
		[DefaultValue(true)]
		public bool _clickable { get; set; }
		//https://www.mapbox.com/mapbox.js/api/v3.0.1/l-icon/
		public string iconUrl { get; set; }
		public Point _iconSize { get; set; }
		public Point _iconAnchor { get; set; }
		//https://www.mapbox.com/mapbox.js/api/v3.0.1/l-divicon/
		public string _html { get; set; }
		//https://www.mapbox.com/mapbox.js/api/v3.0.1/l-circle/
		//https://www.mapbox.com/mapbox.js/api/v3.0.1/l-circlemarker/
		public double _radius { get; set; }
	}
	public class Feature
	{
		public string type { get; set; }
		public Properties properties { get; set; }
		public Geometry geometry { get; set; }
	}
	public class OldGSIJson
	{
		public List<Layer> layer { get; set; }
	}
	public class GeoJson
	{
		public string type { get; set; }
		public List<Feature> features { get; set; }
	}
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
