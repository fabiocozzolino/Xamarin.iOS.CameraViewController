all: clean CameraViewController.framework

CameraViewController.framework:
		git clone https://github.com/matheusneder/ALCameraViewController.git
		$(MAKE) -C ALCameraViewController all
		mv ALCameraViewController/CameraViewController.framework .

clean:
	rm -Rf ALCameraViewController
	rm -Rf CameraViewController.framework

.PHONY: all
