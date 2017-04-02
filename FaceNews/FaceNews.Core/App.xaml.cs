﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Xamarin.Forms;

namespace FaceNews.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();MainPage = new NavigationPage();
			MainPage.Navigation.PushAsync(new UI.NewsFeedView());
			MainPage.Navigation.PushAsync(new UI.SourceSelectionView());
			MainPage.Navigation.PushAsync(new UI.DevView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
