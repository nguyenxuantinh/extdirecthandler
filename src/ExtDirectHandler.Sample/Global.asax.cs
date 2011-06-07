﻿using System;
using System.Web;
using ExtDirectHandler.Configuration;

namespace ExtDirectHandler.Sample
{
	public class Global : HttpApplication
	{
		private void Application_Start(object sender, EventArgs e)
		{
			new ReflectionConfigurator()
				.RegisterType<DirectAction>()
				.Configure();
		}

		private void Application_End(object sender, EventArgs e)
		{
			//  Code that runs on application shutdown
		}

		private void Application_Error(object sender, EventArgs e)
		{
			// Code that runs when an unhandled error occurs
		}

		private void Session_Start(object sender, EventArgs e)
		{
			// Code that runs when a new session is started
		}

		private void Session_End(object sender, EventArgs e)
		{
			// Code that runs when a session ends. 
			// Note: The Session_End event is raised only when the sessionstate mode
			// is set to InProc in the Web.config file. If session mode is set to StateServer 
			// or SQLServer, the event is not raised.
		}
	}
}