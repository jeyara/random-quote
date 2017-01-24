using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RandomQuote
{
    public partial class Quote : ContentPage
    {
        private string[] _quotes = {
            "After all is said and done, more is said than done",
            "Persuasion is often more effectual than force",
            "United we stand, divided we fall",
            "When I was born, I was so surprised I didn't talk for a year and a half",
            "If you're not failing every now and again, it's a sign you're not doing anything very innovative",
            "I'm not afraid to die.  I just don't want to be there when it happens",
            "Time is nature's way of keeping everything from happening at once"
        };

        public Quote()
        {
            InitializeComponent();

            this.Padding = new Thickness(20, 20, 20, 20);
            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    this.Padding = new Thickness(20, 40, 20, 20);
                    break;
                case TargetPlatform.Android:
                    this.Padding = new Thickness(20, 30, 20, 20);
                    break;
                case TargetPlatform.WinPhone:
                case TargetPlatform.Windows:
                    this.Padding = new Thickness(20, 40, 20, 20);
                    break;
                case TargetPlatform.Other:
                default:
                    break;
            }

            btnNext_Click(null, null);
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            var x = new Random();
            int nextIndex = x.Next(0, _quotes.Length - 1);

            lblQuote.Text = _quotes[nextIndex];
        }
    }
}
