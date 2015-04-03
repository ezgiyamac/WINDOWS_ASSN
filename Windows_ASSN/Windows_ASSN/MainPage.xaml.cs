using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_ASSN
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI capture = new CameraCaptureUI();
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage(); 
            img.SetSource(filestream);

            if (img_viewer1.Source == null)
            {
                img_viewer1.Source = img;
                Txtbox2.Visibility = Visibility.Visible;
            }
            else if (img_viewer2.Source == null)
            {
                img_viewer2.Source = img;
                Txtbox3.Visibility = Visibility.Visible;

            }
            else
                img_viewer3.Source = img;


            




        }

        
       

        
        
       
    }
}
