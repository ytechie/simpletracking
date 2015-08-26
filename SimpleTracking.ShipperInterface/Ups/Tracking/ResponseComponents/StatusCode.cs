using System;
using System.Xml.Serialization;

namespace SimpleTracking.ShipperInterface.Ups.Tracking.ResponseComponents
{
	public class StatusCode
	{
		[XmlElement("Code")]
		public string Code;

		public StatusCode()
		{
		}
	}
}
