# Xamarin.iOS.CameraViewController

ALCameraViewController bindings for Xamarin.iOS.

Xamarin.iOS.CameraViewController is a Xamarin.iOS binding to [ALCameraViewController](https://github.com/AlexLittlejohn/ALCameraViewController):
> A camera view controller with custom image picker and image cropping. Written in Swift.
> @AlexLittlejohn

## Install

Just install [Xamarin.iOS.CameraViewController](https://www.nuget.org/packages/Xamarin.iOS.CameraViewController/) NuGet package.

## Contribute

### Build

First step is to build [ALCameraViewController](https://github.com/AlexLittlejohn/ALCameraViewController): On a mac with regular development tools for iOS plus Xamarin development, just run `make` at the project's directory. It'll clone [ALCameraViewController](https://github.com/AlexLittlejohn/ALCameraViewController) from github and build the framework.

Second step is to build on Visual Studio. I'm using VS 15.2 (2017).

If you want to create a NuGet package: build the solution in Release mode and then, at project's directory, execute: `NuGet pack Xamarin.iOS.CameraViewController.csproj -Prop Configuration=Release`.
