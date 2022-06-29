using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;
using AvaloniaEdit.Indentation.CSharp;

namespace AmnesiaArchitect.AvaloniaApp.Views.Documents
{
    public partial class TestDocumentView : UserControl
    {
        private readonly TextEditor _textEditor;

        public TestDocumentView()
        {
            InitializeComponent();
            _textEditor = this.FindControl<TextEditor>("textCode");
            _textEditor.ShowLineNumbers = true;
            _textEditor.TextArea.IndentationStrategy = new CSharpIndentationStrategy();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
