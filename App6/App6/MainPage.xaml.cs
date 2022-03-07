using CustomCalendarControl.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            var calendarPage = new CalendarPage(DateTime.Now, null);
            calendarPage.SelectedDateCommand = new Command<DateTime>((item) =>
            {
                //Perform operation on selected Date
            });
            await PopupNavigation.Instance.PushAsync(calendarPage);
        }
    }
}
