// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloForm
{
	[Register ("Form1")]
	partial class Form1
	{
		[Outlet]
		AppKit.NSButton Button1 { get; set; }

		[Outlet]
		AppKit.NSTextField Lable1 { get; set; }

		[Action ("button1_click:")]
		partial void button1_click (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Lable1 != null) {
				Lable1.Dispose ();
				Lable1 = null;
			}

			if (Button1 != null) {
				Button1.Dispose ();
				Button1 = null;
			}
		}
	}
}
