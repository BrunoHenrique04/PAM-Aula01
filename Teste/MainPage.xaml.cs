namespace Teste
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name = "";
        

        public MainPage()
        {
            InitializeComponent();
        }

  

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnHelloClicked(object sender, EventArgs e)
        {
            name = NameInput.Text;
            GreetingLabel.Text = $"Hello, {name}";

            SemanticScreenReader.Announce(GreetingLabel.Text);

        }
    }

}
