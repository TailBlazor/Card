using Microsoft.AspNetCore.Components;

namespace TailBlazor.Card;

public partial class TailBlazorCard
{
    private const string BaseClass = "bg-white overflow-hidden shadow-md rounded-md";
    private bool _hasSectionContent;

    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public string? Class { get; set; }

    internal string ContainerClass => Class ?? $"{BaseClass} {(_hasSectionContent ? "divide-y divide-gray-200" : "p-4")}";

    internal void NotifySectionContent()
    {
        if (_hasSectionContent)
        {
            return;
        }

        _hasSectionContent = true;
        _ = InvokeAsync(StateHasChanged);
    }
}
