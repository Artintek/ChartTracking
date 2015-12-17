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
using Windows.UI.Xaml.Navigation;

/** \mainpage Chart Tracker
 * 
 * \section observer_sec Observer Design Pattern
 * 
 * The RFID sensor will be configured to be a provider. Once an event occurs
 * a notice will be emited. A separate entity will serve as an observer, and
 * this will display the status of the event.
 *
 */

namespace Tracker
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

        private void ClickMe_Click(object sender, RoutedEventArgs e)
        {
            this.HelloMessage.Text = "Hello, Windows IoT Core!";
        }
    }
}
