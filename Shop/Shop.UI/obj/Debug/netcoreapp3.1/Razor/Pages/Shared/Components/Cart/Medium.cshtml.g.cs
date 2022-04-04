#pragma checksum "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8beaad863cb6c1987d9e0b5554e2b800eb85856a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Shared.Components.Cart.Pages_Shared_Components_Cart_Medium), @"mvc.1.0.view", @"/Pages/Shared/Components/Cart/Medium.cshtml")]
namespace Shop.UI.Pages.Shared.Components.Cart
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8beaad863cb6c1987d9e0b5554e2b800eb85856a", @"/Pages/Shared/Components/Cart/Medium.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Cart_Medium : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Application.Cart.GetCart.Response>>
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
        private global::Shop.UI.Pages.Shared.Components.Cart.Pages_Shared_Components_Cart_Medium.__Generated__CartViewComponentTagHelper __CartViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown cart-dropdown\" id=\"cart-med\">\r\n    <a class=\"dropdown-toggle\" role=\"button\" ");
            WriteLiteral(" aria-haspopup=\"true\" aria-expanded=\"false\" data-display=\"static\" href=\"/Cart\">\r\n        <div class=\"icon\">\r\n            <i class=\"icon-shopping-cart\"></i>\r\n");
#nullable restore
#line 9 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"cart-count\" style=\"margin-left: 2.2rem !important; margin-top: -1.9rem !important; \">");
#nullable restore
#line 11 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                                                                                                             Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 12 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </a>\r\n\r\n");
#nullable restore
#line 16 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-menu dropdown-menu-right\">\r\n            <div class=\"dropdown-cart-products\">\r\n\r\n\r\n");
#nullable restore
#line 22 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product\">\r\n                    <div class=\"product-cart-details\">\r\n                        <h4 class=\"product-title\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1019, 2);
            WriteAttributeValue("", 980, "Product/", 980, 8, true);
#nullable restore
#line 27 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
WriteAttributeValue("", 988, product.Name.Replace(" ", "-"), 988, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                                                                         Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h4>\r\n\r\n                        <span class=\"cart-product-info\">\r\n                            <span class=\"cart-product-qty\"");
            BeginWriteAttribute("id", " id=\"", 1189, "\"", 1220, 2);
            WriteAttributeValue("", 1194, "stock-qty-", 1194, 10, true);
#nullable restore
#line 31 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
WriteAttributeValue("", 1204, product.StockId, 1204, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                                                                                      Write(product.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            x ");
#nullable restore
#line 32 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                         Write(product.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div><!-- End .product-cart-details -->\r\n\r\n                    <figure class=\"product-image-container\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1474, "\"", 1520, 2);
            WriteAttributeValue("", 1481, "Product/", 1481, 8, true);
#nullable restore
#line 37 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
WriteAttributeValue("", 1489, product.Name.Replace(" ", "-"), 1489, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\">\r\n");
#nullable restore
#line 38 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                             if (!String.IsNullOrEmpty(product.PropImage))
                            {
                                var image_path = $"/images/productsfolder/{product.PropImage}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1786, "\"", 1803, 1);
#nullable restore
#line 41 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
WriteAttributeValue("", 1792, image_path, 1792, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\" />\r\n");
#nullable restore
#line 42 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </a>\r\n                    </figure>\r\n                    <a class=\"btn-remove icon-close\" onclick=\"removeAllFromCart(event)\" data-stock-id=\"");
#nullable restore
#line 45 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                                                                                                  Write(product.StockId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></a>\r\n                </div><!-- End .product -->\r\n");
#nullable restore
#line 47 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div><!-- End .cart-product -->\r\n\r\n            <div class=\"dropdown-cart-total\">\r\n                <span>Всего</span>\r\n\r\n                <span class=\"cart-total-price\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8beaad863cb6c1987d9e0b5554e2b800eb85856a9714", async() => {
            }
            );
            __CartViewComponentTagHelper = CreateTagHelper<global::Shop.UI.Pages.Shared.Components.Cart.Pages_Shared_Components_Cart_Medium.__Generated__CartViewComponentTagHelper>();
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
            WriteLiteral(@" р.</span>
            </div><!-- End .dropdown-cart-total -->

            <div class=""dropdown-cart-action"">
                <a href=""/Cart"" class=""btn btn-primary"">В корзину</a>
                <a href=""/Checkout/CustomerInformation"" class=""btn btn-outline-primary-2""><span>Оплата</span><i class=""icon-long-arrow-right""></i></a>
            </div><!-- End .dropdown-cart-total -->

        </div><!-- End .dropdown-menu -->
");
#nullable restore
#line 63 "D:\OnlineShop\Shop\Shop.UI\Pages\Shared\Components\Cart\Medium.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<script>

    var removeOneFromCart = function (e) {
        var stockId = e.target.dataset.stockId;
        removeFromCart(stockId, 1);
    }

    var removeAllFromCart = function (e) {
        var stockId = e.target.dataset.stockId;
        var id = ""stock-qty-"" + stockId;
        var el = document.getElementById(id);
        var qty = parseInt(el.textContent);
        removeFromCart(stockId, qty);
    }

    var removeFromCart = function (stockId, qty) {
        axios.post(""/Cart/Remove/"" + stockId + '/' + qty)
            .then(res => {
                updateCart();
            }).catch(err => {
                alert(err.error);
            })
    }

    var updateCart = function () {
        axios.get('/Cart/GetCartComponent')
            .then(res => {
                var html = res.data;
                var el = document.getElementById('cart-nav');

                el.outerHTML = html;
            });
        axios.get('/Cart/GetCartMedium')
            .the");
            WriteLiteral(@"n(res => {
                var html = res.data;
                var el = document.getElementById('cart-med');

                el.outerHTML = html;
            });
        axios.get('/Cart/GetCartMain')
            .then(res => {
                var html = res.data;
                var el = document.getElementById('cart-main');

                el.outerHTML = html;
            })

    }

</script>");
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
