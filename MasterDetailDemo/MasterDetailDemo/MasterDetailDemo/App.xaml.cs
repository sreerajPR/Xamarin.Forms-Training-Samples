﻿using System;
using Xamarin.Forms;
using MasterDetailDemo.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MasterDetailDemo
{
  public partial class App : Application
  {

    public App()
    {
      InitializeComponent();

     
      //MainPage = new MainPage();
      //MainPage = new HomePage();
      MainPage = new CarouselPageSample();
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
