#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1102fc7e988f7aeaad50bfb435ec2d997c1e4a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Inventory.Pages.DailyInventory.Areas_Inventory_Pages_DailyInventory_DailyInventory), @"mvc.1.0.razor-page", @"/Areas/Inventory/Pages/DailyInventory/DailyInventory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Inventory/Pages/DailyInventory/DailyInventory.cshtml", typeof(EC.Web.Areas.Inventory.Pages.DailyInventory.Areas_Inventory_Pages_DailyInventory_DailyInventory), null)]
namespace EC.Web.Areas.Inventory.Pages.DailyInventory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\_ViewImports.cshtml"
using EC.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\_ViewImports.cshtml"
using EC.Web.ViewModels;

#line default
#line hidden
#line 6 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\_ViewImports.cshtml"
using EC.Web.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1102fc7e988f7aeaad50bfb435ec2d997c1e4a32", @"/Areas/Inventory/Pages/DailyInventory/DailyInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e58db206250307d8d8f3b99389fafe6301d1e2", @"/Areas/Inventory/Pages/_ViewImports.cshtml")]
    public class Areas_Inventory_Pages_DailyInventory_DailyInventory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
  
    ViewData["Title"] = "Daily Inventories";

#line default
#line hidden
            BeginContext(88, 30, true);
            WriteLiteral("\r\n<h2>Daily Inventories</h2>\r\n");
            EndContext();
            BeginContext(118, 370, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea44ebed2b844c5a6bce17752314b68", async() => {
                BeginContext(168, 57, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n");
                EndContext();
#line 11 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
             if (Model.DailyInventories.Count() > 0)
            {

#line default
#line hidden
                BeginContext(294, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(310, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f3527a7de4f4ab3978a336b91d5ee27", async() => {
                    BeginContext(383, 6, true);
                    WriteLiteral("Export");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(398, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 14 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
            }

#line default
#line hidden
                BeginContext(415, 66, true);
                WriteLiteral("        </div>\r\n        <div class=\"col-md-8\"></div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(488, 140, true);
            WriteLiteral("\r\n<table id=\"example\" class=\"table table-striped table-hover table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(629, 64, false);
#line 23 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyInventories[0].ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(693, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(768, 62, false);
#line 26 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyInventories[0].OnHand));

#line default
#line hidden
            EndContext();
            BeginContext(830, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(905, 61, false);
#line 29 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyInventories[0].Whs01));

#line default
#line hidden
            EndContext();
            BeginContext(966, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1041, 62, false);
#line 32 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyInventories[0].Whs01a));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1178, 61, false);
#line 35 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyInventories[0].Whs99));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1314, 62, false);
#line 38 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyInventories[0].Whs99a));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
         foreach (var item in Model.DailyInventories)
        {

#line default
#line hidden
            BeginContext(1505, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1566, 43, false);
#line 47 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1609, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(1696, 41, false);
#line 50 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
               Write(Html.DisplayFor(modelItem => item.OnHand));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(1824, 40, false);
#line 53 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Whs01));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(1951, 41, false);
#line 56 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Whs01a));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(2079, 40, false);
#line 59 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Whs99));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(2206, 41, false);
#line 62 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Whs99a));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 65 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
        }

#line default
#line hidden
            BeginContext(2302, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2346, 6417, true);
                WriteLiteral(@"
    <script>
        //var today = new Date();
        //var fileName = 'Inventory Report-' + today.toISOString().substring(0, 10);
        //var idioma =
        //{
        //    ""sProcessing"": ""Processing..."",
        //    ""sLengthMenu"": ""To show _MENU_ registros"",
        //    ""sZeroRecords"": ""No results found"",
        //    ""sEmptyTable"": ""No data available in this table"",
        //    ""sInfo"": ""Showing records from _START_ to _END_ of a total of _TOTAL_ records"",
        //    ""sInfoEmpty"": ""Showing records from 0 to 0 of a total of 0 records"",
        //    ""sInfoFiltered"": ""(filtering a total of _MAX_ registros)"",
        //    ""sInfoPostFix"": """",
        //    ""sSearch"": ""Search for:"",
        //    ""sUrl"": """",
        //    ""sInfoThousands"": "","",
        //    ""sLoadingRecords"": ""Loading..."",
        //    ""oPaginate"": {
        //        ""sFirst"": ""First"",
        //        ""sLast"": ""Last"",
        //        ""sNext"": ""Next"",
        //        ""sPrevious"": ""Previous""
    ");
                WriteLiteral(@"    //    },
        //    ""oAria"": {
        //        ""sSortAscending"": "": Sort as ascending"",
        //        ""sSortDescending"": "": Sort as descending order""
        //    },
        //    ""buttons"": {
        //        ""copyTitle"": 'Copied information',
        //        ""copyKeys"": 'Use your keyboard or menu to select the copy command',
        //        ""copySuccess"": {
        //            ""_"": '%d rows copied to clipboard',
        //            ""1"": '1 row copied to clipboard'
        //        },

        //        ""pageLength"": {
        //            ""_"": ""To show %d rows"",
        //            ""-1"": ""Show everything""
        //        }
        //    }
        //};
        //$(document).ready(function () {
        //    $('#example').DataTable({
        //        ""paging"": true,
        //        ""lengthChange"": true,
        //        ""searching"": true,
        //        ""ordering"": true,
        //        ""info"": true,
        //        ""autoWidth"": true,
        ");
                WriteLiteral(@"//        ""language"": idioma,
        //        ""lengthMenu"": [[5, 10, 20, -1], [5, 10, 20, ""Show everything""]],
        //        dom: 'Bfrt<""col-md-6 inline""i> <""col-md-6 inline""p>',
        //        buttons: {
        //            dom: {
        //                container: {
        //                    tag: 'div',
        //                    className: 'flexcontent'
        //                },
        //                buttonLiner: {
        //                    tag: null
        //                }
        //            },
        //            buttons: [
        //                {
        //                    extend: 'copyHtml5',
        //                    text: '<i class=""fa fa-clipboard""></i>Copy',
        //                    title: fileName,
        //                    titleAttr: 'Copy',
        //                    className: 'btn btn-app export barras',
        //                    exportOptions: {
        //                        columns: [0, 1, 2, 3, 4, 5]");
                WriteLiteral(@"
        //                    }
        //                },

        //                {
        //                    extend: 'pdfHtml5',
        //                    text: '<i class=""fa fa-file-pdf-o""></i>PDF',
        //                    title: fileName,
        //                    titleAttr: 'PDF',
        //                    className: 'btn btn-app export pdf',
        //                    exportOptions: {
        //                        columns: [0, 1, 2, 3, 4, 5]
        //                    },
        //                    customize: function (doc) {

        //                        doc.styles.title = {
        //                            color: '#4c8aa0',
        //                            fontSize: '30',
        //                            alignment: 'center'
        //                        }
        //                        doc.styles['td:nth-child(2)'] = {
        //                            width: '100px',
        //                            'max");
                WriteLiteral(@"-width': '100px'
        //                        },
        //                            doc.styles.tableHeader = {
        //                                fillColor: '#4c8aa0',
        //                                color: 'white',
        //                                alignment: 'center'
        //                            },
        //                            doc.content[1].margin = [100, 0, 100, 0]

        //                    }

        //                },

        //                {
        //                    extend: 'excelHtml5',
        //                    text: '<i class=""fa fa-file-excel-o""></i>Excel',
        //                    title: fileName,
        //                    titleAttr: 'Excel',
        //                    className: 'btn btn-app export excel',
        //                    exportOptions: {
        //                        columns: [0, 1, 2, 3, 4, 5]
        //                    },
        //                },
        //        ");
                WriteLiteral(@"        {
        //                    extend: 'csvHtml5',
        //                    text: '<i class=""fa fa-file-text-o""></i>CSV',
        //                    title: fileName,
        //                    titleAttr: 'CSV',
        //                    className: 'btn btn-app export csv',
        //                    exportOptions: {
        //                        columns: [0, 1, 2, 3, 4, 5]
        //                    }
        //                },
        //                {
        //                    extend: 'print',
        //                    text: '<i class=""fa fa-print""></i>Print',
        //                    title: fileName,
        //                    titleAttr: 'Imprimir',
        //                    className: 'btn btn-app export imprimir',
        //                    exportOptions: {
        //                        columns: [0, 1, 2, 3, 4, 5]
        //                    }
        //                },
        //                {
        //        ");
                WriteLiteral(@"            extend: 'pageLength',
        //                    titleAttr: 'Records to show',
        //                    className: 'selectTable'
        //                }
        //            ]


        //        }
        //    });
        //});
        ");
                EndContext();
                BeginContext(8764, 63, false);
#line 216 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\DailyInventory\DailyInventory.cshtml"
   Write(Html.Raw(Model.PrepareScript("example", "Inventory Report", 6)));

#line default
#line hidden
                EndContext();
                BeginContext(8827, 18, true);
                WriteLiteral(";\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DailyInventoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DailyInventoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DailyInventoryModel>)PageContext?.ViewData;
        public DailyInventoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591