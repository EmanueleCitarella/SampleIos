﻿// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using iOSExampleApplication.Services;
using UIKit;

namespace iOSExampleApplication
{
	public partial class LoginViewController : UIViewController
	{
		private UsersService _userService = new UsersService();
		private User _userInfo;
		public LoginViewController(IntPtr handle) : base(handle)
		{
			
		}

		partial void LoginAction(UIButton sender)
		{
			var usernameValue = usernameField.Text;
			var passwordValue = passwordField.Text;
			_userInfo = new User{username = usernameValue, password = passwordValue };

			var userFound = _userService.GetUser(_userInfo);
			
			if (userFound != null)
			{
				PerformSegue("LoginSegue", this);
			}
			else
			{
				ShowErrorMessage("Username o password non validi.");			
			}
		}
		
		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "LoginSegue")
			{
				var nextVC = segue.DestinationViewController as DashboardViewController;

				if (nextVC != null)
				{
					nextVC._usernameDashboard = _userInfo.username;
				}
			}
		}
		
		private void ShowErrorMessage(string message)
		{
			var alertController = UIAlertController.Create("Errore", message, UIAlertControllerStyle.Alert);
			alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			PresentViewController(alertController, true, null);
		}
	}
}
