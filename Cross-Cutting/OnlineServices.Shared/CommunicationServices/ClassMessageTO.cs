﻿using OnlineServices.Common.CommunicationServices.Enumerations;
using OnlineServices.Common.DataAccessHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineServices.Common.CommunicationServices
{
	public class ClassMessageTO
	{
		public int IdMessage { get; set; }
		public int IdSender { get; set; }
		public int IdReceiver { get; set; }
		public string EmailExtern { get; set; }
		public TypeOfMessage TypeOfMessage { get; set; }
		public string Message { get; set; }
		public DateTime Date { get; set; }
		public bool IsSent { get; set; }

	}
}