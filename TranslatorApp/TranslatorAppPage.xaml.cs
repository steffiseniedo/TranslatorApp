using System;
using Xamarin.Forms;

namespace TranslatorApp
{
    public partial class TranslatorAppPage : ContentPage
    {
        public TranslatorAppPage()
        {
            InitializeComponent();
        }


        async void TranslateButton_Clicked(object sender, EventArgs e)
		{
            Translator translator = new Translator();
			var result = translator.Translate(Input.Text, "en");
			//change the result text to the translated text
            Result.Text = result;
			
		}
    }
}
