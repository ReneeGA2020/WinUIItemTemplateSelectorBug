using Microsoft.UI.Xaml;

using System.Collections.ObjectModel;

using WinUIItemTemplateSelectorBug.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIItemTemplateSelectorBug;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public ObservableCollection<object> CollectionViewModel { get; } = [];
    public MainWindow()
    {
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                CollectionViewModel.Add(new TestVM1());
            }
            else
            {
                CollectionViewModel.Add(new TestVM2());
            }
        }
        InitializeComponent();
    }
}
