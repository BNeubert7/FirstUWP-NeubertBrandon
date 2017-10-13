using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FirstUWP_NeubertBrandon
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ColorInput.ItemsSource = Enum.GetValues(typeof(Color));
        }

        public enum Color
        {
            Black,
            Brown,
            Blue
        }

        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                double width, height, woodLength, glassArea;
                int quantity;
                Color ColorSelection;
                DateTime CurrentDate;
                
                width = double.Parse(WidthInput.Text);
                height = double.Parse(HeightInput.Text);
                woodLength = 2 * (width + height) * 3.25;
                glassArea = 2 * (width * height);
                quantity = Convert.ToInt32(QuantityInput.Value);
                ColorSelection = (Color)this.ColorInput.SelectedItem;
                CurrentDate = DateTime.Now.Date;

                CustWindow CustWindow = new CustWindow(width, height, woodLength, glassArea, quantity, ColorSelection, CurrentDate);

                this.Frame.Navigate(typeof(UserResults), CustWindow);
            }
            catch (Exception)
            {
                ContentDialog InputError = new ContentDialog()
                {
                    Title = "Input Error",
                    Content = "One of your inputs is incorrect. Please try again.",
                    CloseButtonText = "Ok"
                };
                await InputError.ShowAsync();
            }
        }

        private async void WidthInput_KeyUpAsync(object sender, KeyRoutedEventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(WidthInput.Text);

                if (input > 5.0 || input < 0.5)
                {
                    ContentDialog WidthIssue = new ContentDialog()
                    {
                        Title = "Width Issue",
                        Content = "The Width must be between 0.5 and 5",
                        CloseButtonText = "Ok"
                    };
                    await WidthIssue.ShowAsync();
                    
                    WidthInput.Text = "";
                }
            }
            catch (Exception)
            {
                ContentDialog TypeIssue = new ContentDialog()
                {
                    Title = "Input Issue",
                    Content = "The entry must be numeric.",
                    CloseButtonText = "Ok"
                };
                await TypeIssue.ShowAsync();
                WidthInput.Text = "";
            }
        }

        private async void HeightInput_KeyUpAsync(object sender, KeyRoutedEventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(HeightInput.Text);

                if (input > 5.0 || input < 0.5)
                {
                    ContentDialog HeightIssue = new ContentDialog()
                    {
                        Title = "Height Issue",
                        Content = "The Height must be between 0.75 and 3",
                        CloseButtonText = "Ok"
                    };
                    await HeightIssue.ShowAsync();

                    WidthInput.Text = "";
                }
            }
            catch (Exception)
            {
                ContentDialog TypeIssue = new ContentDialog()
                {
                    Title = "Input Issue",
                    Content = "The entry must be numeric.",
                    CloseButtonText = "Ok"
                };
                await TypeIssue.ShowAsync();
                HeightInput.Text = "";
            }
        }
    }
}