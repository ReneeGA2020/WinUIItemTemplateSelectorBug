using System.Collections.ObjectModel;

namespace WinUIItemTemplateSelectorBug.ViewModel;
public class TestVM2
{
    public ObservableCollection<object> Items { get; set; } = [];
    public string Content2 => "Content2";
}
