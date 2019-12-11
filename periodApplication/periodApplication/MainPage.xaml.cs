using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace periodApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {

        }

        //button 
        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            //calculate timespan
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date + TimeSpan.FromDays(1);

            //convert timespan to String
            String newT = timeSpan.Days.ToString();

            //Add day to the start date
            DateTime dt = startDatePicker.Date;
            DateTime newDate = dt.AddDays(28);
            //convert to string
            String result = newDate.ToShortDateString();

            //Ovulation day calculation
            DateTime nd = startDatePicker.Date;
            DateTime nDate = nd.AddDays(15);

            //convert to String
            String ovulation = nDate.ToShortDateString();

            //Output day in period and date of period for next month
            resultLabel.Text = newT + " day(s) in Period\n" + "On  " + result + "  (m/d/y) might be your next period start date\n" +
                ovulation + "  is your Ovulation Day ";
        }
        
    }
}
