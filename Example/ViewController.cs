using System;
using System.Diagnostics;
using UIKit;
using Xamarin.iOS.CameraViewController;

namespace CameraViewControllerExample
{
    public partial class ViewController : UIViewController
    {
		protected ViewController(IntPtr handle) : base(handle)
		{

		}

        partial void ChangeImageButton_TouchUpInside(UIButton sender)
        {
            var cameraViewController = new CameraViewController(true, true,
	            (image, asset) => 
	            {
                    if (image != null)
                    {
                        ImageView.Image = image;
                    }

	                DismissViewController(true, null);   
	            });

            PresentViewController(cameraViewController, true, null);
        }
    }
}
