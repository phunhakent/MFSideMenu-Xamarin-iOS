using System;
using UIKit;

namespace MFSideMenuBinding.Sample
{
	public partial class ContentViewController : UIViewController
	{
		public ContentViewController() : base("ContentViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib. 
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem("Menu", UIBarButtonItemStyle.Bordered, (sender, e) =>
			{
				this.MenuContainerViewController().ToggleLeftSideMenuCompletion(null);
			});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

