# Xamarin.iOS.CameraViewController

[ALCameraViewController](https://github.com/AlexLittlejohn/ALCameraViewController) bindings for Xamarin.iOS.

Xamarin.iOS.CameraViewController is a Xamarin.iOS binding to ALCameraViewController:
> A camera view controller with custom image picker and image cropping. Written in Swift.
>
> ![camera](https://cloud.githubusercontent.com/assets/932822/8455694/c61de812-2006-11e5-85c0-a57e3d980561.jpg)
> ![cropper](https://cloud.githubusercontent.com/assets/932822/8455697/c627ac44-2006-11e5-82be-7f96e73d9b1f.jpg)
> ![library](https://cloud.githubusercontent.com/assets/932822/8455695/c620ebb6-2006-11e5-9c61-75a81870c9de.jpg)
> ![permissions](https://cloud.githubusercontent.com/assets/932822/8455696/c62157fe-2006-11e5-958f-849cabf541ca.jpg)
>
> ### Features
> 
> - Front facing and rear facing camera support
> - Simple and clean look
> - Custom image picker with permission checking
> - Image cropping (square only)
> - Flash light support
>
> @AlexLittlejohn

### Installation

Install [Xamarin.iOS.CameraViewController](https://www.nuget.org/packages/Xamarin.iOS.CameraViewController/) NuGet package.

In the Info.plist
```xml
<plist version="1.0">
  <dict>
    ... add this entries to dict element
    <key>NSCameraUsageDescription</key>
    <string>A custom message (will be shown to the user when iOS ask him for permission to access camera).</string>
    <key>NSPhotoLibraryUsageDescription</key>
    <string>A custom message (will be shown to the user when iOS ask him for permission to access photo library).</string>
    ...
  </dict>
</plist>    
```

### Usage

To use this component couldn't be simpler.
Add `using Xamarin.iOS.CameraViewController;` to the top of you controller file.

In the ViewController

```cs
var cameraViewController = new CameraViewController(true, true,
  (image, asset) => 
  {
    // Do something with your image here.
    // If cropping is enabled this image will be the cropped version
    
    DismissViewController(true, null);   
  });

PresentViewController(cameraViewController, true, null);
```

### Contribute

#### Build

First step is to build ALCameraViewController: On a mac with regular development tools for iOS plus Xamarin development (I used Xcode 8.3 and VS for Mac 7), just run `make` at the project's directory. It will clone ALCameraViewController from github (more specifically from this fork: https://github.com/matheusneder/ALCameraViewController) and invoke project's make in order to build the framework.

Second step is to build the solution on Visual Studio. I built from VS 15.2 (2017).

To create a NuGet package: build the solution in Release mode and then, at project's directory, execute: `NuGet pack Xamarin.iOS.CameraViewController.csproj -Prop Configuration=Release`.
