using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AmnesiaArchitect.AvaloniaApp.Views.Documents
{
    public partial class TestDocumentView : UserControl
    {
        public TestDocumentView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
