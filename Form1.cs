using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();           

            ImageList list = new ImageList();
            list.Images.Add(SystemIcons.Application.ToBitmap());

            //ImageSize set as 20
            /*list.ImageSize = new Size(20, 20)*/;

            //Image size set as 40
            list.ImageSize = new Size(40, 40);

            this.Style.TitleBar.CaptionImage = list.Images[0];
            this.Style.TitleBar.CaptionImageLocation = new Point(40, 4);
        }
    }
}
