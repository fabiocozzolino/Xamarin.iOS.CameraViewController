using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.iOS.CameraViewController
{
    // Below definitions exists to avoid this bug: https://bugzilla.xamarin.com/show_bug.cgi?id=56962 (Xamarin.iOS binding - Attempting to JIT compile method 'Class:.ctor ()' while running in aot-only mode.)
    // This types should never be referenced.
    internal class FakeCameraView : CameraView
    {
        FakeCameraView() : base()
        {

        }
    }

    internal class FakeCameraViewController : CameraViewController
    {
        FakeCameraViewController() : base()
        {

        }
    }

    internal class FakeConfirmViewController : ConfirmViewController
    {
        FakeConfirmViewController() : base()
        {

        }
    }

    internal class FakePhotoLibraryViewController : PhotoLibraryViewController
    {
        FakePhotoLibraryViewController() : base()
        {

        }
    }
}
