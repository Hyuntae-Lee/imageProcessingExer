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
    /// Interaction logic for ItemView.xaml
    /// </summary>
    public partial class ItemView : UserControl
    {
        public BitmapImage ItemImage
        {
            get
            {
                return _itemImage;
            }
            set
            {
                _itemImage = value;
                image.Source = _itemImage;
            }
        }
        private BitmapImage _itemImage = null;

        public ItemView()
        {
            InitializeComponent();
        }
    }
}
