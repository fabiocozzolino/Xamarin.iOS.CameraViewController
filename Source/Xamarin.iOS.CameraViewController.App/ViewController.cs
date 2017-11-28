using System;
using System.Diagnostics;
using UIKit;
using Xamarin.iOS.CameraViewController;

namespace Xamarin.iOS.CameraViewController.App
{
    public partial class ViewController : UIViewController
    {
		protected ViewController(IntPtr handle) : base(handle)
		{

		}

        partial void ChangeImageButton_TouchUpInside(UIButton sender)
        {
            //var parameters = new CroppingParameters(true, true, true, new CoreGraphics.CGSize(width: 60, height: 60));
            var cameraViewController = new CameraViewController(
                croppingEnabled: true, 
                allowResizing: true, 
                allowMoving: true, 
                allowsLibrarySave: false, 
                allowsLibraryAccess: true, 
                allowsSwapCameraOrientation: true, 
                allowVolumeButtonCapture: true,
                completion: (image, asset) => 
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
