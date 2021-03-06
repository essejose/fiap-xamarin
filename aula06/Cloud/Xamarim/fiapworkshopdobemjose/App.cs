﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace fiapworkshopdobemjose
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new TodoList();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
         
        public static IAuthenticate Authenticator { get; private set; }
        public static void Init(IAuthenticate authenticator) {
            Authenticator = authenticator;
        }
         

    }

    public interface IAuthenticate {
        Task<bool> Authenticate();
    }
}

