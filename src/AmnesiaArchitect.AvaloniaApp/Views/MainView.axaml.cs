using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AmnesiaArchitect.AvaloniaApp.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
