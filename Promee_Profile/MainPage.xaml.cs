﻿namespace Promee_Profile
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }
        
        
        private void OnButtonClicked(object sender, EventArgs e)
        {  
             await Navigation.PushAsync(new EditProfilePage());
        }

        
    }
}
