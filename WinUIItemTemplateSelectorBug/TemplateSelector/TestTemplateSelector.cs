using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using WinUIItemTemplateSelectorBug.ViewModel;
namespace WinUIItemTemplateSelectorBug.TemplateSelector;
public class TestTemplateSelector : DataTemplateSelector
{
    public DataTemplate? TemplateTestVM1 { get; set; }

    public DataTemplate? TemplateTestVM2 { get; set; }
    protected override DataTemplate SelectTemplateCore(object item)
    {
        return GetTemplate(item) ?? base.SelectTemplateCore(item);
    }

    protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
    {
        return GetTemplate(item) ?? base.SelectTemplateCore(item, container);
    }

    private DataTemplate? GetTemplate(object item)
    {
        return item switch
        {
            TestVM1 => TemplateTestVM1,
            TestVM2 => TemplateTestVM2,
            _ => null,
        };
    }
}
