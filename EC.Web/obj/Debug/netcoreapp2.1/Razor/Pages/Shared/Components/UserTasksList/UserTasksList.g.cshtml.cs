#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\UserTasksList\UserTasksList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf9a0d64a21bb777648c6e08eaa004c41347471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Pages.Shared.Components.UserTasksList.Pages_Shared_Components_UserTasksList_UserTasksList), @"mvc.1.0.view", @"/Pages/Shared/Components/UserTasksList/UserTasksList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/Components/UserTasksList/UserTasksList.cshtml", typeof(EC.Web.Pages.Shared.Components.UserTasksList.Pages_Shared_Components_UserTasksList_UserTasksList))]
namespace EC.Web.Pages.Shared.Components.UserTasksList
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
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\UserTasksList\UserTasksList.cshtml"
using EC.Web.ViewModels.Base;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf9a0d64a21bb777648c6e08eaa004c41347471", @"/Pages/Shared/Components/UserTasksList/UserTasksList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9393181a2de6c431c7eb358dd506c8798e13bc0c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_UserTasksList_UserTasksList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserTaskViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 421, true);
            WriteLiteral(@"<li class=""nav-item dropdown d-md-down-none"">
    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
        <i class=""icon-list""></i>
        <span class=""badge badge-pill badge-warning"">15</span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right dropdown-menu-lg"">
        <div class=""dropdown-header text-center"">
            <strong>You have ");
            EndContext();
            BeginContext(497, 13, false);
#line 12 "D:\Projects\PoC\EC2020-P\EC.Web\Pages\Shared\Components\UserTasksList\UserTasksList.cshtml"
                        Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(510, 41, true);
            WriteLiteral(" pending tasks</strong>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1190, 2567, true);
            WriteLiteral(@"        <a class=""dropdown-item"" href=""#"">
            <div class=""small mb-1"">
                Upgrade NPM &amp; Bower
                <span class=""float-right"">
                    <strong>0%</strong>
                </span>
            </div>
            <span class=""progress progress-xs"">
                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 0%"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </span>
        </a>
        <a class=""dropdown-item"" href=""#"">
            <div class=""small mb-1"">
                ReactJS Version
                <span class=""float-right"">
                    <strong>25%</strong>
                </span>
            </div>
            <span class=""progress progress-xs"">
                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </span>
        </a>
        <a class=""dropdown-item"" href=""#"">
       ");
            WriteLiteral(@"     <div class=""small mb-1"">
                VueJS Version
                <span class=""float-right"">
                    <strong>50%</strong>
                </span>
            </div>
            <span class=""progress progress-xs"">
                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </span>
        </a>
        <a class=""dropdown-item"" href=""#"">
            <div class=""small mb-1"">
                Add new layouts
                <span class=""float-right"">
                    <strong>75%</strong>
                </span>
            </div>
            <span class=""progress progress-xs"">
                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </span>
        </a>
        <a class=""dropdown-item"" href=""#"">
            <div class=""small mb-1"">
                Angular 2 ");
            WriteLiteral(@"Cli Version
                <span class=""float-right"">
                    <strong>100%</strong>
                </span>
            </div>
            <span class=""progress progress-xs"">
                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </span>
        </a>
        <a class=""dropdown-item text-center"" href=""#"">
            <strong>View all tasks</strong>
        </a>
    </div>
</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserTaskViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
