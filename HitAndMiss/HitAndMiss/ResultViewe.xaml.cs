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
    /// Interaction logic for ResultViewe.xaml
    /// </summary>
    public partial class ResultViewe : UserControl
    {
        public BitmapImage Image
        {
            set
            {
                _image = value;
                image.Source = _image;
            }
            get
            {
                return _image;
            }
        }
        private BitmapImage _image;

        public ResultViewe()
        {
            InitializeComponent();
        }
    }
}
