#nullable enable
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Metadata;
using Avalonia.Styling;

namespace Avalonia.Controls;

public class DataGridRowTemplate : ITemplate<DataGridRow?>
{
    [Content]
    [TemplateContent]
    public object? Content { get; set; }

    public DataGridRow? Build() => (DataGridRow?)TemplateContent.Load(Content)?.Result;

    object? ITemplate.Build()
    {
        return Build();
    }
}
