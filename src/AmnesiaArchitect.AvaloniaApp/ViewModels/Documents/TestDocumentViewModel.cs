using Dock.Model.ReactiveUI.Controls;

namespace AmnesiaArchitect.AvaloniaApp.ViewModels.Documents;

public class TestDocumentViewModel : Document
{
    public string Code { get; set; } = "void OnStart() {} // Hello, Amnesia!";
}
