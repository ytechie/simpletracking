using System;
using System.Xml.Serialization;

namespace SimpleTracking.ShipperInterface.Ups.Tracking.ResponseComponents
{
	public class Service
	{
		[XmlElement("Code")]
		public string Code;
		[XmlElement("Description")]
		public string Description;

		public Service()
		{
		}
	}
}
