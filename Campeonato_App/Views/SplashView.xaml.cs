﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashView : ContentPage
    {
        public SplashView()
        {
            InitializeComponent();

            Navegacao();


        }

        private async void Navegacao()
        {
            await Task.Delay(3000);

            App.Current.MainPage = new NavigationPage(new LoginView());
        }
    }
}
