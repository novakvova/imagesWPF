using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppWorkImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var image = System.Drawing.Image.FromFile("1.jpg");
            var newImage = ImageConvert.ImageWorker.ConverImageToBitmap(image, 640, 480);
            if(newImage!=null)
            {
                newImage.Save("step.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }
    }
}
