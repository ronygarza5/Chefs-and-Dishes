#pragma checksum "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c57276df055d28d99c5af6941f1fbe3ca73f451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/_ViewImports.cshtml"
using ChefsDishes;

#line default
#line hidden
#line 1 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c57276df055d28d99c5af6941f1fbe3ca73f451", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddDishes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 6, true);
            WriteLiteral("\n\n<h2>");
            EndContext();
            BeginContext(51, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c57276df055d28d99c5af6941f1fbe3ca73f4514018", async() => {
                BeginContext(95, 5, true);
                WriteLiteral("Chefs");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(104, 15, true);
            WriteLiteral(" | Dishes</h2>\n");
            EndContext();
            BeginContext(119, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c57276df055d28d99c5af6941f1fbe3ca73f4515580", async() => {
                BeginContext(167, 10, true);
                WriteLiteral("Add a Dish");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 285, true);
            WriteLiteral(@"
<h3>Yum, look at our tasty dishes!</h3>
<table>
    <thead>
        <tr class=""table table-hover"">
            <th>Name</th>
            <th>Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
         foreach(var d in @Model)
        {

#line default
#line hidden
            BeginContext(510, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(548, 6, false);
#line 22 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(554, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(581, 17, false);
#line 23 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(d.Maker.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(598, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(600, 16, false);
#line 23 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
                                  Write(d.Maker.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(616, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(643, 11, false);
#line 24 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(d.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(654, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(681, 10, false);
#line 25 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(d.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(691, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(718, 13, false);
#line 26 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"
               Write(d.Description);

#line default
#line hidden
            EndContext();
            BeginContext(731, 37, true);
            WriteLiteral("</td>\n            \n            </tr>\n");
            EndContext();
#line 29 "/Users/rony/Documents/C#_Stack/MVC_C#/ChefsDishes/Views/Home/Dishes.cshtml"

        }

#line default
#line hidden
            BeginContext(779, 21, true);
            WriteLiteral("    </tbody>\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
