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
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
   RenderFragment<Person> template = 

#line default
#line hidden
            (builder2) => {
                builder2.OpenElement(0, "div");
                builder2.AddContent(1, context.Name);
                builder2.CloseElement();
            }
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                              ; 

#line default
#line hidden
            builder.OpenComponent<Test.MyComponent>(2);
            builder.AddAttribute(3, "PersonTemplate", new Microsoft.AspNetCore.Blazor.RenderFragment<Test.Person>(template));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
