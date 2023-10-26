using System;

using AppKit;
using Foundation;

namespace RecapDemo1
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}
		private void ViewController_Load(object sender, EventArgs e)
		{
			NSButton button = new NSButton();
            View.AddSubview(NSButton);
        }

		}
	}

