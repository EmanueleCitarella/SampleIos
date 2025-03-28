﻿// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using iOSExampleApplication.Services;
using UIKit;

namespace iOSExampleApplication
{
	public partial class KeyboardViewController : UIViewController
	{
		private UsersService _userService = new UsersService();

		public KeyboardViewController(IntPtr handle) : base(handle)
		{
		}

		public void RegisterEvents()
		{
			btn0.TouchUpInside += Btn0_Pressed;
			btn1.TouchUpInside += Btn1_Pressed;
			btn2.TouchUpInside += Btn2_Pressed;
			btn3.TouchUpInside += Btn3_Pressed;
			btn4.TouchUpInside += Btn4_Pressed;
			btn5.TouchUpInside += Btn5_Pressed;
			btn6.TouchUpInside += Btn6_Pressed;
			btn7.TouchUpInside += Btn7_Pressed;
			btn8.TouchUpInside += Btn8_Pressed;
			btn9.TouchUpInside += Btn9_Pressed;
			hashtagBtn.TouchUpInside += HashtagBtn_Pressed;
			deleteBtn.TouchUpInside += DeleteBtn_Pressed;

		}

		public void UnregisterEvents()
		{
			btn0.TouchUpInside -= Btn0_Pressed;
			btn1.TouchUpInside -= Btn1_Pressed;
			btn2.TouchUpInside -= Btn2_Pressed;
			btn3.TouchUpInside -= Btn3_Pressed;
			btn4.TouchUpInside -= Btn4_Pressed;
			btn5.TouchUpInside -= Btn5_Pressed;
			btn6.TouchUpInside -= Btn6_Pressed;
			btn7.TouchUpInside -= Btn7_Pressed;
			btn8.TouchUpInside -= Btn8_Pressed;
			btn9.TouchUpInside -= Btn9_Pressed;
			deleteBtn.TouchUpInside -= DeleteBtn_Pressed;
			hashtagBtn.TouchUpInside -= HashtagBtn_Pressed;
		}
		
		private void Btn0_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '0';
		}private void Btn1_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '1';
		}private void Btn2_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '2';
		}private void Btn3_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '3';
		}private void Btn4_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '4';
		}private void Btn5_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '5';
		}private void Btn6_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '6';
		}private void Btn7_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '7';
		}
		private void Btn8_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '8';
		}private void Btn9_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '9';
		}
		
		private void HashtagBtn_Pressed(object? sender, EventArgs e)
		{
			textField.Text += '#';
		}

		private void DeleteBtn_Pressed(object? sender, EventArgs e)
		{
			if (textField.Text.Length >0)
			{
				textField.Text = (textField?.Text)?[..^1];
			}
				
		}
		partial void enterAction(UIButton sender)
		{
			if (textField.Text.Length >= 5)
			{
				var alertController = UIAlertController.Create("Confirmed", "You will be redirected to dashboard", UIAlertControllerStyle.Alert);
				alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, action =>
				{
				PerformSegue("DashboardSegue", new NSString(_userService.GetCurrentUser()));
					
				}));
				PresentViewController(alertController, true, null);
			}
			else
			{
				ShowErrorMessage("Minimum lenght is 5 characters");			
			}
		}
		
		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "DashboardSegue")
			{
				var nextVC = segue.DestinationViewController as DashboardViewController;

				if (nextVC != null)
				{
					nextVC._usernameDashboard = _userService.GetCurrentUser();
				}
			}
		}
		
		public override void ViewWillAppear(bool animated)
		{
			btn0.Layer.CornerRadius = 5;
			btn0.Layer.BorderWidth = 1;
			btn0.Layer.BorderColor = UIColor.Black.CGColor;
			btn0.Layer.BackgroundColor = UIColor.White.CGColor;

	btn1.Layer.CornerRadius = 5;
			btn1.Layer.BorderWidth = 1;
			btn1.Layer.BorderColor = UIColor.Black.CGColor;
			btn1.Layer.BackgroundColor = UIColor.White.CGColor;
			
	btn2.Layer.CornerRadius = 5;
			btn2.Layer.BorderWidth = 1;
			btn2.Layer.BorderColor = UIColor.Black.CGColor;
			btn2.Layer.BackgroundColor = UIColor.White.CGColor;

	btn3.Layer.CornerRadius = 5;
			btn3.Layer.BorderWidth = 1;
			btn3.Layer.BorderColor = UIColor.Black.CGColor;			btn3.Layer.BackgroundColor = UIColor.White.CGColor;

	btn4.Layer.CornerRadius = 5;
			btn4.Layer.BorderWidth = 1;
			btn4.Layer.BorderColor = UIColor.Black.CGColor;			btn4.Layer.BackgroundColor = UIColor.White.CGColor;

	btn5.Layer.CornerRadius = 5;
			btn5.Layer.BorderWidth = 1;
			btn5.Layer.BorderColor = UIColor.Black.CGColor;			btn5.Layer.BackgroundColor = UIColor.White.CGColor;

	btn6.Layer.CornerRadius = 5;
			btn6.Layer.BorderWidth = 1;
			btn6.Layer.BorderColor = UIColor.Black.CGColor;			btn6.Layer.BackgroundColor = UIColor.White.CGColor;

	btn7.Layer.CornerRadius = 5;
			btn7.Layer.BorderWidth = 1;
			btn7.Layer.BorderColor = UIColor.Black.CGColor;			btn7.Layer.BackgroundColor = UIColor.White.CGColor;

	btn8.Layer.CornerRadius = 5;
			btn8.Layer.BorderWidth = 1;
			btn8.Layer.BorderColor = UIColor.Black.CGColor;			btn8.Layer.BackgroundColor = UIColor.White.CGColor;

	btn9.Layer.CornerRadius = 5;
			btn9.Layer.BorderWidth = 1;
			btn9.Layer.BorderColor = UIColor.Black.CGColor;			btn9.Layer.BackgroundColor = UIColor.White.CGColor;

	hashtagBtn.Layer.CornerRadius = 5;
			hashtagBtn.Layer.BorderWidth = 1;
			hashtagBtn.Layer.BorderColor = UIColor.Black.CGColor;				hashtagBtn.Layer.BackgroundColor = UIColor.White.CGColor;

			enterBtn.Layer.CornerRadius = 5;
			enterBtn.Layer.BorderWidth = 1;
			enterBtn.Layer.BorderColor = UIColor.Blue.CGColor;			enterBtn.Layer.BackgroundColor = UIColor.White.CGColor;

			
			deleteBtn.Layer.CornerRadius = 5;
			deleteBtn.Layer.BorderWidth = 1;
			deleteBtn.Layer.BorderColor = UIColor.Black.CGColor;			deleteBtn.Layer.BackgroundColor = UIColor.White.CGColor;
			
			RegisterEvents();
		}

		public override void ViewWillDisappear(bool animated)
		{
			UnregisterEvents();
		}
		
		private void ShowErrorMessage(string message)
		{
			var alertController = UIAlertController.Create("Errore", message, UIAlertControllerStyle.Alert);
			alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			PresentViewController(alertController, true, null);
		}
	}
}
