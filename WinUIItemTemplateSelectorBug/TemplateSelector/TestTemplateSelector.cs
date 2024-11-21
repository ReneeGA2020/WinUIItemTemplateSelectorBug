using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using WinUIItemTemplateSelectorBug.ViewModel;
namespace WinUIItemTemplateSelectorBug.TemplateSelector;
public class TestTemplateSelector : DataTemplateSelector
{
    public DataTemplate? TemplateTestVM1 { get; set; }

    public DataTemplate? TemplateTestVM2 { get; set; }

    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
    {
        return GetTemplate(item, container) ?? base.SelectTemplateCore(item, container);
    }

    private DataTemplate? GetTemplate(object item, DependencyObject container)
    {
        var template = item switch
        {
            TestVM1 => TemplateTestVM1,
            TestVM2 => TemplateTestVM2,
            _ => null,
        };
        if(container is TreeViewItem element)
        {
            if (item is TestVM1 a)
            {
                element.ItemsSource = a.Items;
            }
            else if (item is TestVM2 b)
            {
                element.ItemsSource = b.Items;
            }
        }
        return template;
    }
}
