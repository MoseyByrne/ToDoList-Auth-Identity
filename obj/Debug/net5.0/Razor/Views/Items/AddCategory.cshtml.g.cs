#pragma checksum "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2fc4dc0427fbbd4fea29d937d3ddbdbb979d92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_AddCategory), @"mvc.1.0.view", @"/Views/Items/AddCategory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2fc4dc0427fbbd4fea29d937d3ddbdbb979d92", @"/Views/Items/AddCategory.cshtml")]
    public class Views_Items_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Add a category</h2>\n\n<h4>Add a category to this task: ");
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
                            Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
Write(Html.Label("Select category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 19 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 21 "/Users/difalcoa/Desktop/epicodus/Week-11-To-Do-List/Views/Items/AddCategory.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591