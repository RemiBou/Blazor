// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "MyAttr", "abc");
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment<System.String>)((item) => (builder2) => {
                builder2.AddContent(3, "\n    Some text");
                builder2.OpenElement(4, "some-child");
                builder2.AddAttribute(5, "a", "1");
                builder2.AddContent(6, item.ToLowerInvariant());
                builder2.CloseElement();
                builder2.AddContent(7, "\n  ");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
