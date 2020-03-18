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

namespace HitAndMiss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const String kResUriDir = "pack://application:,,,/HitAndMiss;component/";

        public MainWindow()
        {
            InitializeComponent();

            resultView.Image = new BitmapImage(new Uri(kResUriDir + "images/0.png"));
            item_1.ItemImage = new BitmapImage(new Uri(kResUriDir + "images/1.png"));
            item_2.ItemImage = new BitmapImage(new Uri(kResUriDir + "images/2.png"));
            item_3.ItemImage = new BitmapImage(new Uri(kResUriDir + "images/3.png"));
            item_4.ItemImage = new BitmapImage(new Uri(kResUriDir + "images/4.png"));
            item_5.ItemImage = new BitmapImage(new Uri(kResUriDir + "images/5.png"));
            item_6.ItemImage = new BitmapImage(new Uri(kResUriDir + "images/6.png"));
            var defaultSE = new BitmapImage(new Uri(kResUriDir + "images/defaultSE.png"));

            var retImage = Process.erosion(resultView.Image, defaultSE);
            retImage.Save("D:\\TTT\\erosion.png");
        }
    }
}
