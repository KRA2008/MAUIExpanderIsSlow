namespace ExampleApp
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClickedComplex(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpanderPageComplex());
        }

        private async void Button_OnClickedSimple(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpanderPageSimple());
        }
    }

}
