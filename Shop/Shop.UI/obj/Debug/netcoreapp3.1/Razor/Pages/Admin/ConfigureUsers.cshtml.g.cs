#pragma checksum "D:\OnlineShop\Shop\Shop.UI\Pages\Admin\ConfigureUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7a7494e1ce1e7554c2d602534f74bd2cb761e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Admin.Pages_Admin_ConfigureUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/ConfigureUsers.cshtml")]
namespace Shop.UI.Pages.Admin
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
#line 1 "D:\OnlineShop\Shop\Shop.UI\Pages\_ViewImports.cshtml"
using Shop.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OnlineShop\Shop\Shop.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7a7494e1ce1e7554c2d602534f74bd2cb761e6", @"/Pages/Admin/ConfigureUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_ConfigureUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/users.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\OnlineShop\Shop\Shop.UI\Pages\Admin\ConfigureUsers.cshtml"
  
    ViewData["Title"] = "????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7a7494e1ce1e7554c2d602534f74bd2cb761e64050", async() => {
                WriteLiteral(@"
    <style>
        .customInput2 {
            width: 200px;
            display: block;
            height: calc(2.25rem + 2px);
            padding: 0.375rem 0.75rem;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid #ced4da;
            border-radius: 0.25rem;
            box-shadow: inset 0 0 0 transparent;
            transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
            margin-top: 15px;
            margin-bottom: 15px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>???????????????????? ??????????????????</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""/Admin/AdminMain"">??????????????</a></li>
                    <li class=""breadcrumb-item active"">???????????????????? ??????????????????</li>
                </ol>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div v-if=""!editing"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            ?????? ???????????????? ??????????, ?????????????? ???????????? ?? ????????????????????. ???????????????? ????????????????.
                        </div>
                        <!-- /.ca");
            WriteLiteral("rd-header -->\r\n                        <div class=\"card-body\">\r\n                            <button class=\"btn btn-success\" style=\"margin-bottom: 10px; color: #000; background-color: #c39ed4; border-color: #c39ed4;\" href=\"/ConfigureUsers\" ");
            WriteLiteral(@"@click=""newAccount"" >???????????????? ??????????????</button>
                            <table id=""example7"" class=""table table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th class=""align"">ID</th>
                                        <th class=""align"">??????????</th>
                                        <th class=""align"">???????????? (????????)</th>
                                        <th class=""align""><i class=""fa fa-times""></i></th>
                                    </tr>
                                </thead>
                                <tbody>

                                    <tr v-for=""(user, index) in users"">

                                        <td class=""align"">{{user.id}}</td>
                                        <td class=""price-col align"">{{user.userName}}</td>
                                        <td class=""price-col align"">{{user.passwordHash}}</td>

                         ");
            WriteLiteral("               <td class=\"align\"><i class=\"fa fa-times\" ");
            WriteLiteral(@"@click=""deleteUser(user.id, index)""></i></td>
                                    </tr>

                                </tbody>                      
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div v-else style=""text-align: -webkit-center "">
            <div class=""login-box"">
                <!-- /.login-logo -->
                <div class=""card card-outline card-success"">
                    <div class=""card-header text-center"">
                        <a href=""/Admin/ConfigureUsers"" class=""h1""><b>?????????? ??????????????</b></a>
                    </div>
                    <div class=""card-body"">
                        <p class=""login-box-msg"">?????????????? ???????????? ?????? ?????????? ?? ?????????? ??????????????</p>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7a7494e1ce1e7554c2d602534f74bd2cb761e69105", async() => {
                WriteLiteral(@"
                            <div class=""input-group mb-3"">
                                <input type=""text"" v-model=""username"" class=""form-control"" placeholder=""??????????"">
                                <div class=""input-group-append"">
                                    <div class=""input-group-text"">
                                        <span class=""fas fa-user-circle""></span>
                                    </div>
                                </div>
                            </div>
                            <div class=""input-group mb-3"">
                                <input type=""password"" v-model=""password"" class=""form-control"" placeholder=""????????????"">
                                <div class=""input-group-append"">
                                    <div class=""input-group-text"">
                                        <span class=""fas fa-lock""></span>
                                    </div>
                                </div>
                            </div>
      ");
                WriteLiteral(@"                      <div class=""row"" style=""justify-content:center"">

                                    <div class=""icheck-primary"">
                                        <input type=""checkbox"" id=""remember"" v-model=""isAdmin"">
                                        <label for=""remember"">
                                            ??????????????????????????
                                        </label>
                                    </div>
                              
                               
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        <div class=\"social-auth-links text-center mt-2 mb-3\">\r\n                            <button type=\"submit\" ");
            WriteLiteral("@click=\"createUser(); cancel()\" class=\"btn btn-block btn-success\">\r\n                                 ??????????????\r\n                            </button>\r\n                            <button ");
            WriteLiteral(@"@click=""cancel()"" class=""btn btn-block btn-danger"">
                                 ????????????
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</section>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
    <script src=""/plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
    <script src=""/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
    <script src=""/plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
    <script src=""/plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>
    <script src=""/plugins/jszip/jszip.min.js""></script>
    <script src=""/plugins/pdfmake/pdfmake.min.js""></script>
    <script src=""/plugins/pdfmake/vfs_fonts.js""></script>
    <script src=""/plugins/datatables-buttons/js/buttons.html5.min.js""></script>
    <script src=""/plugins/datatables-buttons/js/buttons.print.min.js""></script>
    <script src=""/plugins/datatables-buttons/js/buttons.colVis.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7a7494e1ce1e7554c2d602534f74bd2cb761e613755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        window.onload = function () {
            $(function () {
                $(""#example7"").on(""draw.dt"", function () {
                    $(this).find("".dataTables_empty"").parents('tbody').empty();
                }).DataTable({
                    filter: true,
                    paging: false,
                    lengthChange: false,
                    searching: false,
                    ordering: true,
                    info: false,
                    autoWidth: false,
                    responsive: true,
                    statesave: true,
                    dom: '<""top""flp>rt<""bottom""i><""clear"">',
                    language: {
                        url: '//cdn.datatables.net/plug-ins/1.11.4/i18n/ru.json',

                    }
                });
            });
        }
        toastr.options = {
            ""closeButton"": false,
            ""debug"": false,
            ""newestOnTop"": false,
            ""progressBar"": true,
            ""po");
                WriteLiteral(@"sitionClass"": ""toast-bottom-right"",
            ""preventDuplicates"": false,
            ""showDuration"": ""300"",
            ""hideDuration"": ""1000"",
            ""timeOut"": ""5000"",
            ""extendedTimeOut"": ""1000"",
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.UI.Pages.Admin.ConfigureUsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.Admin.ConfigureUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.Admin.ConfigureUsersModel>)PageContext?.ViewData;
        public Shop.UI.Pages.Admin.ConfigureUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
