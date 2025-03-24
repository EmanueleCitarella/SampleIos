// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOSExampleApplication
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UITextField passwordField { get; set; }

		[Outlet]
		UIKit.UITextField usernameField { get; set; }

		[Action ("LoginAction:")]
		partial void LoginAction (UIKit.UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (usernameField != null) {
				usernameField.Dispose ();
				usernameField = null;
			}

			if (passwordField != null) {
				passwordField.Dispose ();
				passwordField = null;
			}

		}
	}
}
