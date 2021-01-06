using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;


namespace TailBlazor.Card
{
    public partial class TailBlazorCardSection
    {
        [CascadingParameter] public TailBlazorCard Card { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Class { get; set; } = "p-4";

        protected override void OnInitialized() => Card.HasSectionContent();
    }
}
