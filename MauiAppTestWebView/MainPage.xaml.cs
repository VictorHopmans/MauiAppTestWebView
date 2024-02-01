namespace MauiAppTestWebView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            webView.Source = "https://mijn.overheid.nl";

        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            // and then inject the javascript
            // For Dutch govermentsites the result is always NULL on iOS (on Android the javascript is executed, and results in a string)
            var result = await webView.EvaluateJavaScriptAsync("document.documentElement.innerHTML");
            
            // in Android we get here the results of the executed javascript, but in iOS it is a NULL value ???
            resultjavascript.Text = result;

        }
    }

}
