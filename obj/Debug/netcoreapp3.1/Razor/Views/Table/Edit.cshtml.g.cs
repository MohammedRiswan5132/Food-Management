#pragma checksum "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3345fb92b3b33ed3cd0ff371ae72567fc496288a524c979cc3aa7305b5b06514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Edit), @"mvc.1.0.view", @"/Views/Table/Edit.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\_ViewImports.cshtml"
using FoodmanagementSystem

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\_ViewImports.cshtml"
using FoodmanagementSystem.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3345fb92b3b33ed3cd0ff371ae72567fc496288a524c979cc3aa7305b5b06514", @"/Views/Table/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ebef90da74e3932a897098052abddd2c639f9423a9573835e333d7b8c16956e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Table_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tables>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
   ViewBag.Title = "Edit Table"; 

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h2>Edit Table</h2>\n\n");
#nullable restore
#line 7 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 9 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
 Html.HiddenFor(model => model.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                <div class=\"form-group\">\n                    ");
            Write(
#nullable restore
#line 12 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
                     Html.LabelFor(model => model.Number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    ");
            Write(
#nullable restore
#line 13 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
                     Html.DisplayFor(model => model.Number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </div>\n");
            WriteLiteral("                                <div class=\"form-group\">\n                                    ");
            Write(
#nullable restore
#line 17 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
                                     Html.LabelFor(model => model.Status)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                                    ");
            Write(
#nullable restore
#line 18 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
                                     Html.EditorFor(model => model.Status, new { htmlAttributes = new { @class = "form-control" } })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                                </div>\n");
            WriteLiteral("                                                <button type=\"submit\" class=\"btn btn-primary\">Save</button>");
#nullable restore
#line 21 "C:\Users\moham\Downloads\Foodmanagement\FoodmanagementSystem\FoodmanagementSystem\FoodmanagementSystem\Views\Table\Edit.cshtml"
                                                                                                           }

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tables> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
