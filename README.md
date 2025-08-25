# How to set the size for caption image in title bar of WinForms Form

## About the sample
This example illustrates how to set the size for caption image in title bar of [WinForms Form](https://www.syncfusion.com/winforms-ui-controls/form) (SfForm)

By default, `SfForm` does not provide the direct support for set the Caption Image Size in [TitleBarControl](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.Controls.Styles.FormVisualStyle.html#Syncfusion_WinForms_Controls_Styles_FormVisualStyle_TitleBar) in `SfForm`. You can achieve this by customizing the Image by using `ImageList` then added into [CaptionImage](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.Controls.Styles.TitleBarStyleInfo.html#Syncfusion_WinForms_Controls_Styles_TitleBarStyleInfo_CaptionImage).

```C#
   ImageList list = new ImageList();
   list.Images.Add(SystemIcons.Application.ToBitmap());
   list.ImageSize = new Size(30, 30);
   this.Style.TitleBar.CaptionImage = list.Images[0];
   this.Style.TitleBar.CaptionImageLocation = new Point(40, 4);
```
## Requirements to run the demo
Visual Studio 2015 and above versions