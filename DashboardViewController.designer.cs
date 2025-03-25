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
	[Register ("DashboardViewController")]
	partial class DashboardViewController
	{
		[Outlet]
		UIKit.UIButton keyboardBtn { get; set; }

		[Outlet]
		UIKit.UILabel username { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (keyboardBtn != null) {
				keyboardBtn.Dispose ();
				keyboardBtn = null;
			}

			if (username != null) {
				username.Dispose ();
				username = null;
			}

		}
	}
}
