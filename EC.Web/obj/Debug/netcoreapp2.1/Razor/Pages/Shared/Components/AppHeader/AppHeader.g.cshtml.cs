#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815964868115f76bd4034cb12da6ac9bd203dd92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Pages.Shared.Components.AppHeader.Pages_Shared_Components_AppHeader_AppHeader), @"mvc.1.0.view", @"/Pages/Shared/Components/AppHeader/AppHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/Components/AppHeader/AppHeader.cshtml", typeof(EC.Web.Pages.Shared.Components.AppHeader.Pages_Shared_Components_AppHeader_AppHeader))]
namespace EC.Web.Pages.Shared.Components.AppHeader
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\_ViewImports.cshtml"
using EC.Web;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815964868115f76bd4034cb12da6ac9bd203dd92", @"/Pages/Shared/Components/AppHeader/AppHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9393181a2de6c431c7eb358dd506c8798e13bc0c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_AppHeader_AppHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(92, 38, true);
            WriteLiteral("\r\n<header class=\"app-header navbar\">\r\n");
            EndContext();
#line 5 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
            BeginContext(171, 170, true);
            WriteLiteral("        <button class=\"navbar-toggler mobile-sidebar-toggler d-lg-none mr-auto\" type=\"button\">\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        </button>\r\n");
            EndContext();
#line 10 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(365, 184, true);
            WriteLiteral("        <button class=\"navbar-toggler mobile-sidebar-toggler d-lg-none mr-auto\" type=\"button\" hidden>\r\n            <span class=\"navbar-toggler-icon\" hidden></span>\r\n        </button>\r\n");
            EndContext();
#line 16 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
    }

#line default
#line hidden
            BeginContext(556, 43, true);
            WriteLiteral("    <a class=\"navbar-brand\" href=\"/\"></a>\r\n");
            EndContext();
#line 18 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
            BeginContext(640, 160, true);
            WriteLiteral("        <button class=\"navbar-toggler sidebar-toggler d-md-down-none\" type=\"button\">\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        </button>\r\n");
            EndContext();
#line 23 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(824, 174, true);
            WriteLiteral("        <button class=\"navbar-toggler sidebar-toggler d-md-down-none\" type=\"button\" hidden>\r\n            <span class=\"navbar-toggler-icon\" hidden></span>\r\n        </button>\r\n");
            EndContext();
#line 29 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
    }

#line default
#line hidden
            BeginContext(1005, 41, true);
            WriteLiteral("    <!-- Embed Application Menu -->\r\n    ");
            EndContext();
            BeginContext(1047, 62, false);
#line 31 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
Write(await Component.InvokeAsync("ApplicationMenus", "Application"));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 33 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(1162, 57, true);
            WriteLiteral("        <ul class=\"nav navbar-nav ml-auto\">\r\n            ");
            EndContext();
            BeginContext(1220, 38, false);
#line 36 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
       Write(await Component.InvokeAsync("UserNav"));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 165, true);
            WriteLiteral("\r\n        </ul>\r\n        <button class=\"navbar-toggler aside-menu-toggler\" type=\"button\">\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        </button>\r\n");
            EndContext();
#line 41 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1447, 75, true);
            WriteLiteral("        <ul class=\"nav navbar-nav mr-5\">\r\n            <li class=\"nav-item\">");
            EndContext();
            BeginContext(1522, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e7aa75fb4514d768ffa0d9c294a57e0", async() => {
                BeginContext(1591, 11, true);
                WriteLiteral("Register | ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1606, 40, true);
            WriteLiteral("</li>\r\n            <li class=\"nav-item\">");
            EndContext();
            BeginContext(1646, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c471e63daae84dd592f354e058e35d3b", async() => {
                BeginContext(1712, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1721, 22, true);
            WriteLiteral("</li>\r\n        </ul>\r\n");
            EndContext();
#line 48 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\AppHeader\AppHeader.cshtml"
    }

#line default
#line hidden
            BeginContext(1750, 36, true);
            WriteLiteral("    <!-- /remove:seed -->\r\n</header>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
