﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Auth;

namespace MailStats.iOS
{
	[assembly: ExportRendererAttribute (typeof (LoginPage), typeof (LoginPageRenderer))]
	public class LoginPageRenderer : PageRenderer
	{
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);


			var auth = new OAuth2Authenticator (
				"900358175438-rrk0rqp76dd5l24jsevmunjm1277an50.apps.googleusercontent.com", // your OAuth2 client id
				"W6CsgvukJ3YxWrhSs98B7Q22", // client secret
				"gmail.readonly", // the scopes for the particular API you're accessing, delimited by "+" symbols
				new Uri ("https://accounts.google.com/o/oauth2/auth"), // the auth URL for the service
				new Uri ("urn:ietf:wg:oauth:2.0:oob\n"), // redirect URL
				new Uri ("https://accounts.google.com/o/oauth2/token") // access token URL
			);

			auth.Completed += (sender, eventArgs) => {
				// We presented the UI, so it's up to us to dimiss it on iOS.
				App.SuccessfulLoginAction.Invoke();

				if (eventArgs.IsAuthenticated) {
					// Use eventArgs.Account to do wonderful things
					App.SaveToken(eventArgs.Account.Properties["access_token"]);
				} else {
					// The user cancelled
				}
			};

			PresentViewController (auth.GetUI (), true, null);
		}
	}

}

