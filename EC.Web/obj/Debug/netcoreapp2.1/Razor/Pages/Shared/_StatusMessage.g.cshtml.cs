#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "326c45203357a36105898c84e296a540889e4168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Pages.Shared.Pages_Shared__StatusMessage), @"mvc.1.0.view", @"/Pages/Shared/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_StatusMessage.cshtml", typeof(EC.Web.Pages.Shared.Pages_Shared__StatusMessage))]
namespace EC.Web.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\_ViewImports.cshtml"
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
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"326c45203357a36105898c84e296a540889e4168", @"/Pages/Shared/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9393181a2de6c431c7eb358dd506c8798e13bc0c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
  
    var type = (string)TempData["_alert.type"];
    var title = (string)TempData["_alert.title"];
    var body = (string)TempData["_alert.body"];

#line default
#line hidden
            BeginContext(191, 31, true);
            WriteLiteral("<div class=\"alert-container\">\r\n");
            EndContext();
#line 8 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
     if (!string.IsNullOrEmpty(type))
    {

#line default
#line hidden
            BeginContext(268, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 280, "\"", 323, 4);
            WriteAttributeValue("", 288, "alert", 288, 5, true);
            WriteAttributeValue(" ", 293, "alert-", 294, 7, true);
#line 10 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
WriteAttributeValue("", 300, type, 300, 5, false);

#line default
#line hidden
            WriteAttributeValue(" ", 305, "alert-dismissible", 306, 18, true);
            EndWriteAttribute();
            BeginContext(324, 174, true);
            WriteLiteral(" role=\"alert\">\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n            <strong>");
            EndContext();
            BeginContext(499, 5, false);
#line 12 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
               Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(504, 10, true);
            WriteLiteral("</strong> ");
            EndContext();
            BeginContext(515, 4, false);
#line 12 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
                               Write(body);

#line default
#line hidden
            EndContext();
            BeginContext(519, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 14 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\_StatusMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(544, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591