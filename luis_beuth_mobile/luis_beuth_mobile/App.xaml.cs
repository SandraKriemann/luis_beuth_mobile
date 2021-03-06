﻿using luis_beuth_mobile.ViewModels;
using luis_beuth_mobile.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace luis_beuth_mobile
{
    //public static class ViewModelLocator
    //{
    //    static StudentProfileViewModel studentsVM;
    //    public static StudentProfileViewModel StudentProfileViewModel
    //        => studentsVM ?? (studentsVM = new StudentProfileViewModel());

    //}
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("studentId"))
            {
                var studentId = Application.Current.Properties["studentId"] as string;
            } 

            MainPage =  new luis_beuth_mobile.Views.MainPage();
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
