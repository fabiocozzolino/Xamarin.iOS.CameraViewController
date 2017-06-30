# Xamarin.iOS.CameraViewController
ALCameraViewController bindings for Xamarin.iOS

## Build

Run `make` at the project's directory, it'll clone ALCameraViewController from github and build the ALCameraViewController framework (this must be done in a mac).

## Create a NuGet package

Build the solution on Release mode and then, at project's directory execute: 
`NuGet pack Xamarin.iOS.CameraViewController.csproj -Prop Configuration=Release`
