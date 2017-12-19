using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageShow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    ///   
    public sealed partial class MainPage : Page
    {
        private int count = 0;
        DispatcherTimer _imageTimer = new DispatcherTimer();
        public MainPage()
        {
            _imageTimer.Interval = new TimeSpan(0, 0, 10);
            _imageTimer.Tick += Time_Tick;
            this.InitializeComponent();
            _imageTimer.Start();
        }

        private void Time_Tick(object sender, object e)
        {
            switch (count)
            {
                case 0:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/1.jpg"));
                    count++;                    
                    break;

                case 1:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/2.jpg"));
                    count++;
                    break;

                case 2:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/3.jpg"));
                    count++;
                    break;

                case 3:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/4.jpg"));
                    count++;
                    break;

                case 4:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/5.jpg"));
                    count++;
                    break;

                case 5:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/6.jpg"));
                    count++;
                    break;

                case 6:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/7.jpg"));
                    count++;
                    break;

                case 7:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/8.jpg"));
                    count++;
                    break;

                case 8:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/9.jpg"));
                    count++;
                    break;

                case 9:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/10.jpg"));
                    count++;
                    break;

                case 10:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/11.jpg"));
                    count++;
                    break;

                case 11:
                    testImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/azure.png"));
                    count = 0;
                    break;
            }            
        }
    }
}
