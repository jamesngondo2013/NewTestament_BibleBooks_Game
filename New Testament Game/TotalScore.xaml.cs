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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace New_Testament_Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TotalScore : Page
    {
        int myScore;

        public TotalScore()
        {
            this.InitializeComponent();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void playAgain_Click(object sender, RoutedEventArgs e)
        {
            myScore = 0;
           // Frame.GoBack();
            this.Frame.Navigate(typeof(MainPage));
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            Result s = (Result)e.Parameter;
            txScore.Text = " " + s.totalScore;

            myScore = Int32.Parse(txScore.Text);

           

            
            myScore = 0;

        }

    }
}
