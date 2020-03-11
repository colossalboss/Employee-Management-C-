#pragma checksum "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf52378125f4a00c0e9006a2a0d3ec4e33be235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeeManagement.Views.Employment.Views_Employment_Details), @"mvc.1.0.view", @"/Views/Employment/Details.cshtml")]
namespace EmployeeManagement.Views.Employment
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/_ViewImports.cshtml"
using EmployeeManagement.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf52378125f4a00c0e9006a2a0d3ec4e33be235", @"/Views/Employment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f928a36a3a6805fbc3dcc6fe69db23c2feb9c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Employment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmploymentIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Employment Details\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <p><strong>Company</strong>: ");
#nullable restore
#line 8 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
                                Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <p><strong>Student</strong>: ");
#nullable restore
#line 10 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
                                Write(Model.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <p><strong>Start Date</strong>: ");
#nullable restore
#line 12 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
                                   Write(Model.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <p><strong>End Date</strong>: ");
#nullable restore
#line 14 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
                                 Write(Model.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n\r\n");
#nullable restore
#line 17 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
         if (Model.Salary != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><strong>Salary</strong>: ");
#nullable restore
#line 19 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
                                   Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n");
#nullable restore
#line 21 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><strong>Salary</strong>: Not Specified Yet</p>\r\n            <br />\r\n");
#nullable restore
#line 26 "/Users/ogbaragodwin/Desktop/code360/EmployeeManagement/EmployeeManagement/Views/Employment/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"card-footer\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf52378125f4a00c0e9006a2a0d3ec4e33be2356874", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISalary _salary { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPayment _payment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEmployment _employment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICompany _company { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEmployeeRepository _empRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProject _project { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmploymentIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591