#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3d8d226f7b5ea0f9233b51955e47e2f6799aa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Admin.Pages.ApplicationRoles.Areas_Admin_Pages_ApplicationRoles_Index), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/ApplicationRoles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/ApplicationRoles/Index.cshtml", typeof(EC.Web.Areas.Admin.Pages.ApplicationRoles.Areas_Admin_Pages_ApplicationRoles_Index), null)]
namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels;

#line default
#line hidden
#line 5 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3d8d226f7b5ea0f9233b51955e47e2f6799aa8", @"/Areas/Admin/Pages/ApplicationRoles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8362ecfa30045c25d108ad16c073e5146b6e706d", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_ApplicationRoles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Admin\Pages\ApplicationRoles\Index.cshtml"
  
    Response.Redirect("/Admin/ApplicationRoles/ApplicationRolesIndex");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
