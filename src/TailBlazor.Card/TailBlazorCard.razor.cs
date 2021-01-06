using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;


namespace TailBlazor.Card
{
    public partial class TailBlazorCard
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Class { get; set; }
        private string _baseClass = "bg-white overflow-hidden shadow-md rounded-md ";
        
        private bool _hasSectionContent { get; set; } = false;

        public void HasSectionContent() {
            _hasSectionContent = true;
            StateHasChanged();
        }
    }
}
