using Xamarin.Forms;

namespace TranslatorApp
{
    public partial class TranslatorAppPage : ContentPage
    {
        public TranslatorAppPage()
        {
            InitializeComponent();
        }


        public void TranslateButton_OnClicked(object sender)
		{
			Translator translator = new Translator();
			
		}
    }
}
