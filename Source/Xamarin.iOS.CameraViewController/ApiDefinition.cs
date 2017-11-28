using System;
using AVFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Photos;
using UIKit;

namespace Xamarin.iOS.CameraViewController
{
    // @interface CameraView : UIView
    [BaseType(typeof(UIView), Name = "_TtC20CameraViewController10CameraView")]
    interface CameraView
    {
        // @property (nonatomic) AVCaptureDevicePosition currentPosition;
        [Export("currentPosition", ArgumentSemantic.Assign)]
        AVCaptureDevicePosition CurrentPosition { get; set; }

        // -(void)startSession;
        [Export("startSession")]
        void StartSession();

        // -(void)stopSession;
        [Export("stopSession")]
        void StopSession();

        // -(void)layoutSubviews;
        [Override]
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)configureFocus;
        [Export("configureFocus")]
        void ConfigureFocus();

        // -(void)capturePhotoWithCompletion:(void (^ _Nonnull)(UIImage * _Nullable))completion;
        [Export("capturePhotoWithCompletion:")]
        void CapturePhotoWithCompletion(Action<UIImage> completion);

        // -(BOOL)focusCameraToPoint:(CGPoint)toPoint __attribute__((warn_unused_result));
        [Export("focusCameraToPoint:")]
        bool FocusCameraToPoint(CGPoint toPoint);

        // -(void)cycleFlash;
        [Export("cycleFlash")]
        void CycleFlash();

        // -(void)swapCameraInput;
        [Export("swapCameraInput")]
        void SwapCameraInput();

        // -(void)rotatePreview;
        [Export("rotatePreview")]
        void RotatePreview();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface CameraViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC20CameraViewController20CameraViewController")]
    interface CameraViewController
    {
        // @property (copy, nonatomic) void (^ _Nullable)(UIImage * _Nullable, PHAsset * _Nullable) onCompletion;
        [NullAllowed, Export("onCompletion", ArgumentSemantic.Copy)]
        Action<UIImage, PHAsset> OnCompletion { get; set; }

        // -(instancetype _Nonnull)initWithCroppingEnabled:(BOOL)croppingEnabled allowResizing:(BOOL)allowResizing allowMoving:(BOOL)allowMoving allowsLibrarySave:(BOOL)allowsLibrarySave allowsLibraryAccess:(BOOL)allowsLibraryAccess allowsSwapCameraOrientation:(BOOL)allowsSwapCameraOrientation allowVolumeButtonCapture:(BOOL)allowVolumeButtonCapture completion:(void (^ _Nonnull)(UIImage * _Nullable, PHAsset * _Nullable))completion __attribute__((objc_designated_initializer));
        [Export("initWithCroppingEnabled:allowResizing:allowMoving:allowsLibrarySave:allowsLibraryAccess:allowsSwapCameraOrientation:allowVolumeButtonCapture:completion:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool croppingEnabled, bool allowResizing, bool allowMoving, bool allowsLibrarySave, bool allowsLibraryAccess, bool allowsSwapCameraOrientation, bool allowVolumeButtonCapture, Action<UIImage, PHAsset> completion);

        // @property (readonly, nonatomic) BOOL prefersStatusBarHidden;
        [Override]
        [Export("prefersStatusBarHidden")]
        bool PrefersStatusBarHidden();

        // @property (readonly, nonatomic) UIStatusBarAnimation preferredStatusBarUpdateAnimation;
        [Override]
        [Export("preferredStatusBarUpdateAnimation")]
        UIStatusBarAnimation PreferredStatusBarUpdateAnimation { get; }

        // -(void)loadView;
        [Override]
        [Export("loadView")]
        void LoadView();

        // -(void)updateViewConstraints;
        [Override]
        [Export("updateViewConstraints")]
        void UpdateViewConstraints();

        // -(void)viewDidLoad;
        [Override]
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Override]
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)viewDidAppear:(BOOL)animated;
        [Override]
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(void)viewWillDisappear:(BOOL)animated;
        [Override]
        [Export("viewWillDisappear:")]
        void ViewWillDisappear(bool animated);
    }

    // @interface ConfirmViewController : UIViewController <UIScrollViewDelegate>
    [BaseType(typeof(UIViewController), Name = "_TtC20CameraViewController21ConfirmViewController")]
    interface ConfirmViewController : IUIScrollViewDelegate
    {
        // @property (copy, nonatomic) void (^ _Nullable)(UIImage * _Nullable, PHAsset * _Nullable) onComplete;
        [NullAllowed, Export("onComplete", ArgumentSemantic.Copy)]
        Action<UIImage, PHAsset> OnComplete { get; set; }

        // -(instancetype _Nonnull)initWithAsset:(PHAsset * _Nonnull)asset allowsCropping:(BOOL)allowsCropping __attribute__((objc_designated_initializer));
        [Export("initWithAsset:allowsCropping:")]
        [DesignatedInitializer]
        IntPtr Constructor(PHAsset asset, bool allowsCropping);

        // @property (readonly, nonatomic) BOOL prefersStatusBarHidden;
        [Override]
        [Export("prefersStatusBarHidden")]
        bool PrefersStatusBarHidden();

        // @property (readonly, nonatomic) UIStatusBarAnimation preferredStatusBarUpdateAnimation;
        [Override]
        [Export("preferredStatusBarUpdateAnimation")]
        UIStatusBarAnimation PreferredStatusBarUpdateAnimation { get; }

        // -(void)viewDidLoad;
        [Override]
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillLayoutSubviews;
        [Override]
        [Export("viewWillLayoutSubviews")]
        void ViewWillLayoutSubviews();

        // -(UIView * _Nullable)viewForZoomingInScrollView:(UIScrollView * _Nonnull)scrollView __attribute__((warn_unused_result));
        [Export("viewForZoomingInScrollView:")]
        [return: NullAllowed]
        UIView ViewForZoomingInScrollView(UIScrollView scrollView);

        // -(void)scrollViewDidZoom:(UIScrollView * _Nonnull)scrollView;
        [Export("scrollViewDidZoom:")]
        void ScrollViewDidZoom(UIScrollView scrollView);
    }

    // @interface PhotoLibraryViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC20CameraViewController26PhotoLibraryViewController")]
    interface PhotoLibraryViewController
    {
        // @property (copy, nonatomic) void (^ _Nullable)(PHAsset * _Nullable) onSelectionComplete;
        [NullAllowed, Export("onSelectionComplete", ArgumentSemantic.Copy)]
        Action<PHAsset> OnSelectionComplete { get; set; }

        // -(void)viewDidLoad;
        [Override]
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillLayoutSubviews;
        [Override]
        [Export("viewWillLayoutSubviews")]
        void ViewWillLayoutSubviews();

        // @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
        [Override]
        [Export("preferredStatusBarStyle")]
        UIStatusBarStyle PreferredStatusBarStyle();

        // -(void)present:(UIViewController * _Nonnull)inViewController animated:(BOOL)animated;
        [Export("present:animated:")]
        void Present(UIViewController inViewController, bool animated);

        // -(void)dismissLibrary;
        [Export("dismissLibrary")]
        void DismissLibrary();

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);
    }

    //[Xamarin.]
    //interface CroppingParameters {

    //    // @property (nonatomic) AVCaptureDevicePosition currentPosition;
    //    [Export("isEnabled", ArgumentSemantic.Copy)]
    //    bool IsEnabled { get; set; }

    //    // @property (nonatomic) AVCaptureDevicePosition currentPosition;
    //    [Export("allowResizing", ArgumentSemantic.Copy)]
    //    bool AllowResizing { get; set; }

    //    // @property (nonatomic) AVCaptureDevicePosition currentPosition;
    //    [Export("allowMoving", ArgumentSemantic.Copy)]
    //    bool AllowMoving { get; set; }

    //    // @property (nonatomic) AVCaptureDevicePosition currentPosition;
    //    [Export("minimumSize", ArgumentSemantic.Copy)]
    //    CGSize MinimumSize { get; set; }

    //    // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
    //    [Export("initWithIsEnable:allowResizing:allowMoving:minimumSize:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor(bool isEnabled, bool allowResizing, bool allowMoving, CGSize minimumSize);
    //}
}

