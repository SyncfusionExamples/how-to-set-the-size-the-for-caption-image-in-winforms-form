# How to set the size the for caption image in WinForms Form(SfForm)?

## About the sample
This example illustrates how to set the size the for caption image in WinForms Form(SfForm)

By default, SfForm does not provide the direct support for set the Caption Image Size in TitleBarControl in SfForm. You can achieve this by customizing the Image by using ImageList then added into CaptionImage.

```C#
   ImageList list = new ImageList();
   list.Images.Add(SystemIcons.Application.ToBitmap());
   list.ImageSize = new Size(30, 30);
            
   this.Style.TitleBar.CaptionImage = list.Images[0];
   this.Style.TitleBar.CaptionImageLocation = new Point(40, 4);
```
## Requirements to run the demo
Visual Studio 2015 and above versions

