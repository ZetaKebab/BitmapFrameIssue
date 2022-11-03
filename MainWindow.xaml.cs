using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            byte[] data = File.ReadAllBytes("./Resources/cover1.jpg");
            using MemoryStream stream = new MemoryStream(data);
            BitmapFrame Frame = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            Cover.Source = Frame;
        }
    }
}