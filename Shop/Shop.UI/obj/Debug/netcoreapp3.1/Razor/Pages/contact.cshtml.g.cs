#pragma checksum "D:\OnlineShop\Shop\Shop.UI\Pages\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfefc3be77d4a7bb1d335ad5a27c7c9714a9326d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Pages_contact), @"mvc.1.0.razor-page", @"/Pages/contact.cshtml")]
namespace Shop.UI.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfefc3be77d4a7bb1d335ad5a27c7c9714a9326d", @"/Pages/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e0c920645c7bc6af12b05eaabdc8fb9fc041bf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\OnlineShop\Shop\Shop.UI\Pages\contact.cshtml"
  
    ViewData["Title"] = "Контакты";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfefc3be77d4a7bb1d335ad5a27c7c9714a9326d4611", async() => {
                WriteLiteral(@"
    <div class=""page-wrapper"">
        <main class=""main"">
            <nav aria-label=""breadcrumb"" class=""breadcrumb-nav border-0 mb-0"">
                <div class=""container"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfefc3be77d4a7bb1d335ad5a27c7c9714a9326d5161", async() => {
                    WriteLiteral("Главная");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Контакты
                        <li />
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->
            <div class=""container"">
                <div class=""page-header page-header-big text-center"" style=""background-image: url('/images/index/iPhone12.jpg')"">
                    <h1 class=""page-title text-white"">Свяжитесь с нами<span class=""text-white"">Мы сможем Вам помочь</span></h1>
                </div><!-- End .page-header -->
            </div><!-- End .container -->

            <div class=""page-content pb-0"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-6 mb-2 mb-lg-0"">
                            <h2 class=""title mb-1"">Контактная информация</h2><!-- End .title mb-2 -->
                            <p class=""mb-3"">Поддержка работает круглосуточно, Вы можете позвон");
                WriteLiteral(@"ить в любое время или прийти к нам в офис, чтобы задать интрересующие Вас вопросы. Проatccионально подготовленный персонал сможет ответить на Ваши вопросы</p>
                            <div class=""row"">
                                <div class=""col-sm-7"">
                                    <div class=""contact-info"">
                                        <h3>Офис</h3>

                                        <ul class=""contact-list"">
                                            <li>
                                                <i class=""icon-map-marker""></i>
                                                ул. Красная 19Б, Минск, Беларусь
                                            </li>
                                            <li>
                                                <i class=""icon-phone""></i>
                                                <a href=""tel:#"">+375 29 122 18 55</a>
                                            </li>
                                            <");
                WriteLiteral(@"li>
                                                <i class=""icon-envelope""></i>
                                                <a href=""mailto:#"">ulyaa.071@gmail.com</a>
                                            </li>
                                        </ul><!-- End .contact-list -->
                                    </div><!-- End .contact-info -->
                                </div><!-- End .col-sm-7 -->

                                <div class=""col-sm-5"">
                                    <div class=""contact-info"">
                                        <h3>Офис</h3>

                                        <ul class=""contact-list"">
                                            <li>
                                                <i class=""icon-clock-o""></i>
                                                <span class=""text-dark"">Понедельник - Суббота</span> <br>8.00 - 17.00
                                            </li>
                                            <li>");
                WriteLiteral(@"
                                                <i class=""icon-calendar""></i>
                                                <span class=""text-dark"">Воскресенье</span> <br> Выходной
                                            </li>
                                        </ul><!-- End .contact-list -->
                                    </div><!-- End .contact-info -->
                                </div><!-- End .col-sm-5 -->
                            </div><!-- End .row -->
                        </div><!-- End .col-lg-6 -->
                        <div class=""col-lg-6"">
                            <h2 class=""title mb-1"">Остались вопросы?</h2><!-- End .title mb-2 -->
                            <p class=""mb-2"">Напишите нам, и мы сможм на них ответить!</p>

                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfefc3be77d4a7bb1d335ad5a27c7c9714a9326d10438", async() => {
                    WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <label for=""cname"" class=""sr-only"">Имя</label>
                                        <input type=""text"" class=""form-control"" id=""cname"" placeholder=""Имя"" required>
                                    </div><!-- End .col-sm-6 -->

                                    <div class=""col-sm-6"">
                                        <label for=""cemail"" class=""sr-only"">Эл. адрес</label>
                                        <input type=""email"" class=""form-control"" id=""cemail"" placeholder=""Эл. адрес"" required>
                                    </div><!-- End .col-sm-6 -->
                                </div><!-- End .row -->

                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <label for=""cphone"" class=""sr-only"">Телефон</label>
                       ");
                    WriteLiteral(@"                 <input type=""tel"" class=""form-control"" id=""cphone"" placeholder=""Телефон"">
                                    </div><!-- End .col-sm-6 -->

                                    <div class=""col-sm-6"">
                                        <label for=""csubject"" class=""sr-only"">Тема</label>
                                        <input type=""text"" class=""form-control"" id=""csubject"" placeholder=""Тема"">
                                    </div><!-- End .col-sm-6 -->
                                </div><!-- End .row -->

                                <label for=""cmessage"" class=""sr-only"">Сообщение</label>
                                <textarea class=""form-control"" cols=""30"" rows=""4"" id=""cmessage"" required placeholder=""Сообщение""></textarea>

                                <button type=""submit"" class=""btn btn-outline-primary-2 btn-minwidth-sm"">
                                    <span>ОТПРАВИТЬ</span>
                                    <i class=""icon-long-arrow-right""></i>");
                    WriteLiteral("\r\n                                </button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<!-- End .contact-form -->
                        </div><!-- End .col-lg-6 -->
                    </div><!-- End .row -->

                    <hr class=""mt-4 mb-5"">

                    <div class=""stores mb-4 mb-lg-5"">
                        <h2 class=""title text-center mb-3"">Наши магазины</h2><!-- End .title text-center mb-2 -->

                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""store"">
                                    <div class=""row"">
                                        <div class=""col-sm-5 col-xl-6"">
                                            <figure class=""store-media mb-2 mb-lg-0"">
                                                <img src=""/images/stores/img-1.jpg"" alt=""image"">
                                            </figure><!-- End .store-media -->
                                        </div><!-- End .col-xl-6 -->
                                        <div class=""col-sm-7 col-x");
                WriteLiteral(@"l-6"">
                                            <div class=""store-content"">
                                                <h3 class=""store-title"">Торговый центр ""Галерея Минск""</h3><!-- End .store-title -->
                                                <address>88 Pine St, New York, NY 10005, USA</address>
                                                <div><a href=""tel:#"">+1 987-876-6543</a></div>

                                                <h4 class=""store-subtitle"">Store Hours:</h4><!-- End .store-subtitle -->
                                                <div>Monday - Saturday 11am to 7pm</div>
                                                <div>Sunday 11am to 6pm</div>

                                                <a href=""#"" class=""btn btn-link"" target=""_blank""><span>View Map</span><i class=""icon-long-arrow-right""></i></a>
                                            </div><!-- End .store-content -->
                                        </div><!-- End .col-xl-6 -->
     ");
                WriteLiteral(@"                               </div><!-- End .row -->
                                </div><!-- End .store -->
                            </div><!-- End .col-lg-6 -->

                            <div class=""col-lg-6"">
                                <div class=""store"">
                                    <div class=""row"">
                                        <div class=""col-sm-5 col-xl-6"">
                                            <figure class=""store-media mb-2 mb-lg-0"">
                                                <img src=""/images/stores/img-2.jpg"" alt=""image"">
                                            </figure><!-- End .store-media -->
                                        </div><!-- End .col-xl-6 -->

                                        <div class=""col-sm-7 col-xl-6"">
                                            <div class=""store-content"">
                                                <h3 class=""store-title"">One New York Plaza</h3><!-- End .store-title -->
           ");
                WriteLiteral(@"                                     <address>88 Pine St, New York, NY 10005, USA</address>
                                                <div><a href=""tel:#"">+1 987-876-6543</a></div>

                                                <h4 class=""store-subtitle"">Store Hours:</h4><!-- End .store-subtitle -->
                                                <div>Monday - Friday 9am to 8pm</div>
                                                <div>Saturday - 9am to 2pm</div>
                                                <div>Sunday - Closed</div>

                                                <a href=""#"" class=""btn btn-link"" target=""_blank""><span>View Map</span><i class=""icon-long-arrow-right""></i></a>
                                            </div><!-- End .store-content -->
                                        </div><!-- End .col-xl-6 -->
                                    </div><!-- End .row -->
                                </div><!-- End .store -->
                            </div>");
                WriteLiteral(@"<!-- End .col-lg-6 -->
                        </div><!-- End .row -->
                    </div><!-- End .stores -->
                </div><!-- End .container -->
                <div id=""map""></div><!-- End #map -->
            </div><!-- End .page-content -->
        </main><!-- End .main -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""http://maps.googleapis.com/maps/api/js?key=AIzaSyDc3LRykbLB-y8MuomRUIY0qH5S6xgBLX4&callback=initMap&v=weekly""></script>
<script>
    function initMap() {
        map = new google.maps.Map(document.getElementById(""map""), {
            center: { lat: 53.91670832181059, lng: 27.579408012387013 },
            zoom: 8,
        });
    }
</script>
</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.UI.Pages.contactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.contactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.contactModel>)PageContext?.ViewData;
        public Shop.UI.Pages.contactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
