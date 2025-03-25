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
	[Register ("KeyboardViewController")]
	partial class KeyboardViewController
	{
		[Outlet]
		UIKit.UIButton btn0 { get; set; }

		[Outlet]
		UIKit.UIButton btn1 { get; set; }

		[Outlet]
		UIKit.UIButton btn2 { get; set; }

		[Outlet]
		UIKit.UIButton btn3 { get; set; }

		[Outlet]
		UIKit.UIButton btn4 { get; set; }

		[Outlet]
		UIKit.UIButton btn5 { get; set; }

		[Outlet]
		UIKit.UIButton btn6 { get; set; }

		[Outlet]
		UIKit.UIButton btn7 { get; set; }

		[Outlet]
		UIKit.UIButton btn8 { get; set; }

		[Outlet]
		UIKit.UIButton btn9 { get; set; }

		[Outlet]
		UIKit.UIButton deleteBtn { get; set; }

		[Outlet]
		UIKit.UIButton enterBtn { get; set; }

		[Outlet]
		UIKit.UIButton hashtagBtn { get; set; }

		[Outlet]
		UIKit.UIStackView keyboardView { get; set; }

		[Outlet]
		UIKit.UITextField textField { get; set; }

		[Action ("enterAction:")]
		partial void enterAction (UIKit.UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (deleteBtn != null) {
				deleteBtn.Dispose ();
				deleteBtn = null;
			}

			if (btn0 != null) {
				btn0.Dispose ();
				btn0 = null;
			}

			if (btn1 != null) {
				btn1.Dispose ();
				btn1 = null;
			}

			if (btn2 != null) {
				btn2.Dispose ();
				btn2 = null;
			}

			if (btn3 != null) {
				btn3.Dispose ();
				btn3 = null;
			}

			if (btn4 != null) {
				btn4.Dispose ();
				btn4 = null;
			}

			if (btn5 != null) {
				btn5.Dispose ();
				btn5 = null;
			}

			if (btn6 != null) {
				btn6.Dispose ();
				btn6 = null;
			}

			if (btn7 != null) {
				btn7.Dispose ();
				btn7 = null;
			}

			if (btn8 != null) {
				btn8.Dispose ();
				btn8 = null;
			}

			if (btn9 != null) {
				btn9.Dispose ();
				btn9 = null;
			}

			if (enterBtn != null) {
				enterBtn.Dispose ();
				enterBtn = null;
			}

			if (hashtagBtn != null) {
				hashtagBtn.Dispose ();
				hashtagBtn = null;
			}

			if (keyboardView != null) {
				keyboardView.Dispose ();
				keyboardView = null;
			}

			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}

		}
	}
}
