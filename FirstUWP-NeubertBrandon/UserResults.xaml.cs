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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FirstUWP_NeubertBrandon
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserResults : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            CustWindow CustWindow1 = (CustWindow)e.Parameter;

            theirDate.Text = Convert.ToString(CustWindow1.CurrentDate);
            theirWidth.Text = Convert.ToString(CustWindow1.width);
            theirHeight.Text = Convert.ToString(CustWindow1.height);
            theirColor.Text = Convert.ToString(CustWindow1.ColorSelection);
            their_Quantity.Text = Convert.ToString(CustWindow1.quantity);
            theirWoodLength.Text = Convert.ToString(CustWindow1.woodLength);
            theirGlassArea.Text = Convert.ToString(CustWindow1.glassArea);
        }

        public UserResults()
        {
            this.InitializeComponent();
        }
    }
}