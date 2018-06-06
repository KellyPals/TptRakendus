﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace TptRakendus
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Oplilasele : ContentPage
	{
		public Oplilasele ()
		{
			InitializeComponent ();
            Analytics.TrackEvent("Õpilasele");
        }
	}
}