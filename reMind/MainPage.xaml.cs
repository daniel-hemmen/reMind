namespace reMind
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = (count % 5, count % 3) switch
            {
                (0, 0) => "FizzBuzz",
                (0, not 0) => "Buzz",
                (not 0, 0) => "Fizz",
                _ => count.ToString()
            };

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
