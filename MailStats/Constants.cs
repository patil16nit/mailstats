﻿namespace MailStats
{
	public class Constants
	{
		// Google OAuth
		public static string ClientId = "900358175438-rrk0rqp76dd5l24jsevmunjm1277an50.apps.googleusercontent.com";
		public static string ClientSecret = "W6CsgvukJ3YxWrhSs98B7Q22";
		public static string[] Scopes = { "https://mail.google.com", "https://www.googleapis.com/auth/userinfo.email", "https://www.googleapis.com/auth/userinfo.profile" };
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string RedirectUrl = "http://localhost";
		public static string AccessTokenUrl = "https://accounts.google.com/o/oauth2/token";

		// Settings
		public static int DaysAgo = 180; // How far to look back at email
		public static int InitialFetchDaysAgo = 10; // Initial fetch to display some results fast
	}
}

