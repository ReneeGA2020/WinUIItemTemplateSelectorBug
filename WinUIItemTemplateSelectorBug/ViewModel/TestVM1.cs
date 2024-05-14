using System.Collections.ObjectModel;

namespace WinUIItemTemplateSelectorBug.ViewModel;
public class TestVM1
{
    public ObservableCollection<object> Items { get; set; } = [];
    public string Content1 => "Content1";
}
