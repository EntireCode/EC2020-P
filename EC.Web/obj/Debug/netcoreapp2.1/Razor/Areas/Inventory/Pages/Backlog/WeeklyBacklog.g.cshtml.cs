#pragma checksum "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff30ee0c8528f9530d506fa29d09c22c0405b34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.Web.Areas.Inventory.Pages.Backlog.Areas_Inventory_Pages_Backlog_WeeklyBacklog), @"mvc.1.0.razor-page", @"/Areas/Inventory/Pages/Backlog/WeeklyBacklog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Inventory/Pages/Backlog/WeeklyBacklog.cshtml", typeof(EC.Web.Areas.Inventory.Pages.Backlog.Areas_Inventory_Pages_Backlog_WeeklyBacklog), null)]
namespace EC.Web.Areas.Inventory.Pages.Backlog
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff30ee0c8528f9530d506fa29d09c22c0405b34", @"/Areas/Inventory/Pages/Backlog/WeeklyBacklog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e58db206250307d8d8f3b99389fafe6301d1e2", @"/Areas/Inventory/Pages/_ViewImports.cshtml")]
    public class Areas_Inventory_Pages_Backlog_WeeklyBacklog : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 26, true);
            WriteLiteral("<h2>Weekly Backlogs</h2>\r\n");
            EndContext();
            BeginContext(441, 156, true);
            WriteLiteral("<table id=\"example\" class=\"table table-striped table-hover table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(598, 61, false);
#line 21 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].OrdDate));

#line default
#line hidden
            EndContext();
            BeginContext(659, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(734, 62, false);
#line 24 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].SONumber));

#line default
#line hidden
            EndContext();
            BeginContext(796, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(870, 62, false);
#line 27 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].ShipDate));

#line default
#line hidden
            EndContext();
            BeginContext(932, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1006, 59, false);
#line 30 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Sales));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1139, 65, false);
#line 33 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].InsideSales));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1278, 57, false);
#line 36 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Rep));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1410, 61, false);
#line 39 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].RepComm));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1545, 62, false);
#line 42 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Customer));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1681, 66, false);
#line 45 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].CustPONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1822, 56, false);
#line 48 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Ln));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1952, 65, false);
#line 51 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].ModelNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(2092, 61, false);
#line 54 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].OpenQty));

#line default
#line hidden
            EndContext();
            BeginContext(2153, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(2228, 59, false);
#line 57 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(2362, 61, false);
#line 60 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].OpenAmt));

#line default
#line hidden
            EndContext();
            BeginContext(2423, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(2497, 59, false);
#line 63 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
           Write(Html.DisplayNameFor(model => model.Weeklybacklogs[0].Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 68 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
         foreach (var item in Model.Weeklybacklogs)
        {

#line default
#line hidden
            BeginContext(2683, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2744, 42, false);
#line 72 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrdDate));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(2872, 43, false);
#line 75 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.SONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(3001, 43, false);
#line 78 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShipDate));

#line default
#line hidden
            EndContext();
            BeginContext(3044, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(3130, 40, false);
#line 81 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sales));

#line default
#line hidden
            EndContext();
            BeginContext(3170, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(3256, 46, false);
#line 84 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.InsideSales));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(3388, 38, false);
#line 87 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rep));

#line default
#line hidden
            EndContext();
            BeginContext(3426, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(3513, 42, false);
#line 90 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.RepComm));

#line default
#line hidden
            EndContext();
            BeginContext(3555, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(3641, 43, false);
#line 93 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(3684, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(3770, 47, false);
#line 96 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustPONumber));

#line default
#line hidden
            EndContext();
            BeginContext(3817, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(3904, 37, false);
#line 99 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ln));

#line default
#line hidden
            EndContext();
            BeginContext(3941, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(4027, 46, false);
#line 102 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModelNumber));

#line default
#line hidden
            EndContext();
            BeginContext(4073, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(4160, 42, false);
#line 105 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.OpenQty));

#line default
#line hidden
            EndContext();
            BeginContext(4202, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(4289, 40, false);
#line 108 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(4329, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(4416, 42, false);
#line 111 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.OpenAmt));

#line default
#line hidden
            EndContext();
            BeginContext(4458, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(4544, 40, false);
#line 114 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
               Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(4584, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 117 "D:\Projects\PoC\EC2020-P\EC.Web\Areas\Inventory\Pages\Backlog\WeeklyBacklog.cshtml"
        }

#line default
#line hidden
            BeginContext(4639, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4681, 6252, true);
                WriteLiteral(@"
    <script>
        var idioma =
        {
            ""sProcessing"": ""Processing..."",
            ""sLengthMenu"": ""To show _MENU_ registros"",
            ""sZeroRecords"": ""No results found"",
            ""sEmptyTable"": ""No data available in this table"",
            ""sInfo"": ""Showing records from _START_ to _END_ of a total of _TOTAL_ records"",
            ""sInfoEmpty"": ""Showing records from 0 to 0 of a total of 0 records"",
            ""sInfoFiltered"": ""(filtering a total of _MAX_ registros)"",
            ""sInfoPostFix"": """",
            ""sSearch"": ""Search for:"",
            ""sUrl"": """",
            ""sInfoThousands"": "","",
            ""sLoadingRecords"": ""Loading..."",
            ""oPaginate"": {
                ""sFirst"": ""First"",
                ""sLast"": ""Last"",
                ""sNext"": ""Next"",
                ""sPrevious"": ""Previous""
            },
            ""oAria"": {
                ""sSortAscending"": "": Sort as ascending"",
                ""sSortDescending"": "": Sort as descending order""
");
                WriteLiteral(@"            },
            ""buttons"": {
                ""copyTitle"": 'Copied information',
                ""copyKeys"": 'Use your keyboard or menu to select the copy command',
                ""copySuccess"": {
                    ""_"": '%d rows copied to clipboard',
                    ""1"": '1 row copied to clipboard'
                },

                ""pageLength"": {
                    ""_"": ""To show %d rows"",
                    ""-1"": ""Show everything""
                }
            }
        };
        $(document).ready(function () {
            $('#example').DataTable({
                ""paging"": true,
                ""lengthChange"": true,
                ""searching"": true,
                ""ordering"": true,
                ""info"": true,
                ""autoWidth"": true,
                ""language"": idioma,
                ""lengthMenu"": [[5, 10, 20, -1], [5, 10, 20, ""Show everything""]],
                dom: 'Bfrt<""col-md-6 inline""i> <""col-md-6 inline""p>',
                buttons: {
 ");
                WriteLiteral(@"                   dom: {
                        container: {
                            tag: 'div',
                            className: 'flexcontent'
                        },
                        buttonLiner: {
                            tag: null
                        }
                    },
                    buttons: [
                        {
                            extend: 'copyHtml5',
                            text: '<i class=""fa fa-clipboard""></i>Copy',
                            title: 'Copy table title',
                            titleAttr: 'Copy',
                            className: 'btn btn-app export barras',
                            exportOptions: {
                                columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]
                            }
                        },

                        {
                            extend: 'pdfHtml5',
                            text: '<i class=""fa fa-file-pdf-o""></i>PDF',
");
                WriteLiteral(@"                            title: 'Table title in pdf',
                            titleAttr: 'PDF',
                            className: 'btn btn-app export pdf',
                            exportOptions: {
                                columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]
                            },
                            customize: function (doc) {

                                doc.styles.title = {
                                    color: '#4c8aa0',
                                    fontSize: '30',
                                    alignment: 'center'
                                }
                                doc.styles['td:nth-child(2)'] = {
                                    width: '100px',
                                    'max-width': '100px'
                                },
                                    doc.styles.tableHeader = {
                                        fillColor: '#4c8aa0',
                            ");
                WriteLiteral(@"            color: 'white',
                                        alignment: 'center'
                                    },
                                    doc.content[1].margin = [100, 0, 100, 0]

                            }

                        },

                        {
                            extend: 'excelHtml5',
                            text: '<i class=""fa fa-file-excel-o""></i>Excel',
                            title: 'Weekly Backlog',
                            titleAttr: 'Excel',
                            className: 'btn btn-app export excel',
                            exportOptions: {
                                columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]
                            },
                        },
                        {
                            extend: 'csvHtml5',
                            text: '<i class=""fa fa-file-text-o""></i>CSV',
                            title: 'Table title in CSV',
                ");
                WriteLiteral(@"            titleAttr: 'CSV',
                            className: 'btn btn-app export csv',
                            exportOptions: {
                                columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]
                            }
                        },
                        {
                            extend: 'print',
                            text: '<i class=""fa fa-print""></i>Print',
                            title: 'Title of table in print',
                            titleAttr: 'Imprimir',
                            className: 'btn btn-app export imprimir',
                            exportOptions: {
                                columns: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]
                            }
                        },
                        {
                            extend: 'pageLength',
                            titleAttr: 'Records to show',
                            className: 'selectTable'
          ");
                WriteLiteral("              }\r\n                    ]\r\n\r\n\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeeklyBacklogModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeeklyBacklogModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeeklyBacklogModel>)PageContext?.ViewData;
        public WeeklyBacklogModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591