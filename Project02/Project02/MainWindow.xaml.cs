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
using System.Windows.Threading;

namespace Project02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage[] images;
        private int counter = 0;
        

        public MainWindow()
        {
            InitializeComponent();

            ChangeImage();        
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonInfo_Click(object sender, RoutedEventArgs e)
        {
            Win_Svedenia win_Svedenia = new Win_Svedenia();
            win_Svedenia.Show();

            this.Close();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Win_Add win_Add = new Win_Add();
            win_Add.Show();

            this.Close();
        }

        private void ChangeImage()
        {
            images = new BitmapImage[2];
            images[0] = new BitmapImage(new Uri("Assets/img_laboratoria_1.jpg", UriKind.Relative));
            images[1] = new BitmapImage(new Uri("Assets/lab_2.jpg", UriKind.Relative));
           // images[2] = new BitmapImage(new Uri("/Animations;component/Images/3.png", UriKind.Relative));
            DispatcherTimer dT = new DispatcherTimer();
            dT.Interval = new TimeSpan(0, 0, 3);
            dT.Tick += new EventHandler(dT_Tick);
            dT.Start();

        }

        void dT_Tick(object sender, EventArgs e)
        {
            img.Source = images[counter % images.Length];
            counter++;
        }

    }
}
