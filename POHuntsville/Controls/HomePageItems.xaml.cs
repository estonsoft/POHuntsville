
namespace POHuntsville.Controls
{
    public partial class HomePageItems : ContentView
    {
        public event EventHandler CategoryTapped;

        public HomePageItems()
        {
            InitializeComponent();
        }

        private void OnCategoryTapped(object sender, TappedEventArgs e)
        {
            CategoryTapped?.Invoke(this, EventArgs.Empty);
        }
    }
}
