#pragma checksum "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbcdf93fec7e94bacf73aadee54780bfd252be71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Shared.Pages_Shared__CartPartial), @"mvc.1.0.view", @"/Pages/Shared/_CartPartial.cshtml")]
namespace Shop.UI.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcdf93fec7e94bacf73aadee54780bfd252be71", @"/Pages/Shared/_CartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__CartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Application.Cart.GetCart.Response>>
    {
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
        private global::Shop.UI.Pages.Shared.Pages_Shared__CartPartial.__Generated__CartViewComponentTagHelper __CartViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .space{
        margin-top: 200px;
        margin-bottom: 200px;
    }
    .btnc {
        display: inline-flex;
        align-items: center;
        justify-content: center;
        text-align: center;
        padding: .85rem 1.5rem;
        font-weight: 400;
        font-size: 2.4rem;
        line-height: 1.5;
        letter-spacing: -.01em;
        min-width: 20px;
        border-radius: 0;
        white-space: normal;
        transition: all 0.3s;
        border: none
    }
    .labelc {
        color: #666;
        font-weight: 300;
        font-size: 2.4rem;
        margin: 0 0 1.1rem;
    }
</style>


<main class=""main"" id=""cart-main"">
    <div class=""page-content"">
        <div class=""cart"">
            <div class=""container"">
                <div class=""row"">
");
#nullable restore
#line 38 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                     if (Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""page-content"">
                            <div class=""cart"">
                                <div class=""container"">
                                    <div class=""row justify-content-center"">
                                        <div class=""col-lg-11 justify-content-center"">
                                            <table class=""table table-cart table-mobile"">
                                                <thead>
                                                    <tr>
                                                        <th>??????????</th>
                                                        <th>????????</th>
                                                        <th>????????????????????</th>
                                                        <th>??????????</th>
                                                        <th></th>
                                                    </tr>
                                                </thead>

                 ");
            WriteLiteral("                               <tbody>\r\n");
#nullable restore
#line 57 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                     foreach (var product in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <tr>
                                                            <td class=""product-col"">
                                                                <div class=""product"">
                                                                    <figure class=""product-media"">
                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 2569, "\"", 2615, 2);
            WriteAttributeValue("", 2576, "Product/", 2576, 8, true);
#nullable restore
#line 63 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
WriteAttributeValue("", 2584, product.Name.Replace(" ", "-"), 2584, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 64 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                             if (!String.IsNullOrEmpty(product.PropImage))
                                                                            {
                                                                                var image_path = $"/images/productsfolder/{product.PropImage}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                <img");
            BeginWriteAttribute("src", " src=\"", 3051, "\"", 3068, 1);
#nullable restore
#line 67 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
WriteAttributeValue("", 3057, image_path, 3057, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\" />\r\n");
#nullable restore
#line 68 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                        </a>
                                                                    </figure>

                                                                    <h3 class=""product-title"">
                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 3504, "\"", 3550, 2);
            WriteAttributeValue("", 3511, "Product/", 3511, 8, true);
#nullable restore
#line 73 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
WriteAttributeValue("", 3519, product.Name.Replace(" ", "-"), 3519, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                     Write(product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 73 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  (");
#nullable restore
#line 73 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                                                                   Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</a>
                                                                    </h3><!-- End .product-title -->
                                                                </div><!-- End .product -->
                                                            </td>
                                                            <td class=""price-col"">");
#nullable restore
#line 77 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                             Write(product.RealValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ??.</td>
                                                            <td class=""quantity-col"" style=""max-width: 150px"">
                                                                <div class=""cart-product-quantity"" style=""width: 125px; max-width: 150px; text-align:center"">
                                                                    <button class=""btnc btn-outline-dark"" type=""button"" onclick=""removeOneFromCart(event)"" data-stock-id=""");
#nullable restore
#line 80 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                                                                     Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                                        -\r\n                                                                    </button>\r\n                                                                    <label class=\"labelc\"");
            BeginWriteAttribute("id", " id=\"", 4701, "\"", 4732, 2);
            WriteAttributeValue("", 4706, "stock-qty-", 4706, 10, true);
#nullable restore
#line 83 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
WriteAttributeValue("", 4716, product.StockId, 4716, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                     Write(product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                                    <button class=\"btnc btn-outline-dark\" type=\"button\" onclick=\"addOneToCart(event)\" data-stock-id=\"");
#nullable restore
#line 84 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                                                                Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                                        +
                                                                    </button>
                                                                    <div class=""column is-4 align-self-center"" hidden");
            BeginWriteAttribute("id", " id=\"", 5212, "\"", 5243, 2);
            WriteAttributeValue("", 5217, "stock-qty-", 5217, 10, true);
#nullable restore
#line 87 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
WriteAttributeValue("", 5227, product.StockId, 5227, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                                                 Write(product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                                </div><!-- End .cart-product-quantity -->
                                                            </td>
                                                            <td class=""total-col"">");
#nullable restore
#line 90 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                              Write(product.RealValue * product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??.</td>\r\n                                                            <td class=\"remove-col\"><a class=\"icon-close\" onclick=\"removeAllFromCart(event)\" data-stock-id=\"");
#nullable restore
#line 91 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                                                                                                                      Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></a></td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 93 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </tbody>
                                            </table><!-- End .table table-wishlist -->
                                        </div>
                                    </div>
                                    <div class=""row justify-content-center"">
                                        <div class=""col-lg-7"">
                                            <div class=""cart-discount"">
                                                <h3 class=""summary-total"">??????????: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbcdf93fec7e94bacf73aadee54780bfd252be7115443", async() => {
            }
            );
            __CartViewComponentTagHelper = CreateTagHelper<global::Shop.UI.Pages.Shared.Pages_Shared__CartPartial.__Generated__CartViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CartViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Small");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CartViewComponentTagHelper.view = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("view", __CartViewComponentTagHelper.view, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" ??.</h3>
                                            </div><!-- End .cart-discount -->
                                        </div><!-- End .cart-bottom -->
                                        <div class=""col-lg-4"">
                                            <a href=""Shop"" class=""btn btn-outline-dark-2""><span>?????????????????? ?? ??????????????</span><i class=""icon-refresh""></i></a>
                                            <a href=""Checkout/CustomerInformation"" class=""btn btn-outline-dark-2"">?????????????? ?? ????????????</a>
                                        </div><!-- End .cart-bottom -->



                                    </div><!-- End .col-lg-9 -->
                                    </div><!-- End .row -->
                            </div><!-- End .container -->
                        </div><!-- End .cart -->
");
#nullable restore
#line 115 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""text-center space"">
                            <div class=""container"">
                                <h1 class=""page-title"">?????????????? ??????????!</h1>
                                <a href=""Shop"" class=""btn btn-outline-dark-2""><span>?????????????????? ?? ??????????????</span><i class=""icon-refresh""></i></a>
                            </div><!-- End .container -->
                        </div><!-- End .page-header -->
");
#nullable restore
#line 124 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\_CartPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div><!-- End .container -->\r\n        </div><!-- End .cart -->\r\n    </div><!-- End .page-content -->\r\n</main><!-- End .main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Application.Cart.GetCart.Response>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cart")]
        public class __Generated__CartViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__CartViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String view { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Cart", new { view });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
