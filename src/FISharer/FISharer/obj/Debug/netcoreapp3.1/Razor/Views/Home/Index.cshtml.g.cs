#pragma checksum "C:\Users\Александр\Desktop\Repsitories\FISharer\src\FISharer\FISharer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Александр\Desktop\Repsitories\FISharer\src\FISharer\FISharer\Views\_ViewImports.cshtml"
using FISharer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\Desktop\Repsitories\FISharer\src\FISharer\FISharer\Views\_ViewImports.cshtml"
using FISharer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75445604a935fb282de1a5a05b49bc568d035d06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FilesShare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link menu__item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("share-btn btn btn_large btn_blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("share-btn btn btn_large btn_purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Александр\Desktop\Repsitories\FISharer\src\FISharer\FISharer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"up-btn\"><a><img src=\"/Img/up-icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 97, "\"", 103, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
<div class=""nav-btns"">
    <div href=""#"" class=""nav__btn nav__btn_active""></div>
    <div href=""#"" class=""nav__btn""></div>
    <div href=""#"" class=""nav__btn""></div>
    <div href=""#"" class=""nav__btn""></div>
</div>

<div class=""preloader"">
    <div class=""preloader__content"">
        <h1 class=""preloader__text title title_light""> Loading </h1>
    </div>
</div>
<header class=""header"">
    <div class=""container"">
        <div class=""burger"">
            <div class=""burger-line""></div>
            <div class=""burger-line""></div>
            <div class=""burger-line""></div>
        </div>
    </div>
</header>

<main id=""main"">
    <div class=""menu"">
        <div class=""menu__body"">
            <div class=""b-menu menu-part"">
                <h1 class=""menu-part__title title title_dark"">Services</h1>
                <hr>
                <ul>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee36826", async() => {
                WriteLiteral("Share Files");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee38304", async() => {
                WriteLiteral("Download File");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li><a href=""#"" class=""link menu__item"">Files Storage</a></li>
                </ul>
            </div>
            <div class=""b-menu menu-part"">
                <h1 class=""menu-part__title title title_dark"">Account</h1>
                <hr>
                <ul>
                    <li><a href=""#"" class=""link menu__item"">Sign In</a></li>
                    <li><a href=""#"" class=""link menu__item"">Register</a></li>
                    <li><a href=""#"" class=""link menu__item"">Info</a></li>
                </ul>
            </div>
            <div class=""b-menu menu-part"">
                <h1 class=""menu-part__title title title_dark"">Other</h1>
                <hr>
                <ul>
                    <li><a href=""#"" class=""link menu__item"">About Site</a></li>
                    <li><a href=""//github.com/Sparrow1488/FISharer"" class=""link menu__item"">Open Source</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""start-c");
            WriteLiteral(@"ontainer main__item"">
        <div class=""container"">
            <div class=""start-container__content"">
                <div class=""b-title"">
                    <div class=""b-subtitle"">
                        <h3 class=""subtitle subtitle_light""> Good day </h3>
                    </div>
                    <h1 class=""title title_light"">
                        Easy to <br>
                        Start Sharing
                    </h1>
                </div>
                <div class=""b-buttons"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee311395", async() => {
                WriteLiteral(" <img class=\"btn__icon\" src=\"/Img/share-icon-1.png\" alt=\"Share-icon\"> Share Quickly ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee312944", async() => {
                WriteLiteral(" <img class=\"btn__icon\" src=\"/Img/download-icon-1.png\" alt=\"Downlaod-icon\"> Fast Download ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""about-site-container main__item"">
        <div class=""container"">
            <div class=""about-site-container__content"">
                <div class=""b-description"">
                    <h3 class=""subtitle subtitle_light"">Page</h3>
                    <h1 class=""title title_light title_large site-description_title"">
                        About <br> services
                    </h1>
                </div>
                <div class=""b-services-cards"">
                    <div class=""service-card"">
                        <div class=""service-card__title"">
                            <h3 class=""title title_light title_small service__title"">Share Files</h3>
                        </div>
                        <hr>
                        <div class=""service-card__description"">
                            <div class=""service-card__description_row"">
                                <img class=""service__ico");
            WriteLiteral(@"n"" src=""/Img/share-icon-2.png"" alt=""Service-icon"">
                                <p class=""text service__description"">Send files to your friends and family fast and free!</p>
                            </div>
                        </div>
                        <div class=""service-card__link"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b878c9cb0ecd8dae4b1cdfb5f9b704c09f1ee315899", async() => {
                WriteLiteral("Try it!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""service-card"">
                        <div class=""service-card__title"">
                            <h3 class=""title title_light title_small service__title"">Data Storage</h3>
                        </div>
                        <hr>
                        <div class=""service-card__description"">
                            <div class=""service-card__description_row"">
                                <img class=""service__icon"" src=""/Img/storage-icon-1.png"" alt=""Service-icon"">
                                <p class=""text service__description"">Store data in persistent secure storage</p>
                            </div>
                        </div>
                        <div class=""service-card__link"">
                            <a class=""btn"">Store for free!</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
   ");
            WriteLiteral(@" <div class=""subscriptions-container main__item"">
        <div class=""container"">
            <div class=""subscriptions-container__content"">
                <div class=""subscriptions__title"">
                    <h3 class=""subtitle"">Hey,</h3>
                    <h1 class=""title title_large"">Join us</h1>
                </div>
                <div class=""subscriptions-cards"">
                    <div class=""subscription-card"">
                        <div class=""subscription__title"">
                            <h1 class=""title title_small"">
                                Just Free
                            </h1>
                        </div>
                        <hr>
                        <div class=""subscription__description"">
                            <p class=""text text_small"">You'll Get:</p>
                            <ul class=""sub-possibility-list"">
                                <li class=""possibility-list__item text text_small"">Restrict Use <span class=""text text_small ");
            WriteLiteral(@"text_blue"">Share Service</span></li>
                            </ul>
                        </div>
                        <div class=""subscription__link"">
                            <a class=""btn subscription__btn"">Aviable Now ✅</a>
                        </div>
                    </div>
                </div>

                <div class=""subscriptions-cards"">
                    <div class=""subscription-card"">
                        <div class=""subscription__title"">
                            <h1 class=""title title_small"">
                                Create an account
                            </h1>
                        </div>
                        <hr>
                        <div class=""subscription__description"">
                            <p class=""text text_small"">You'll Get:</p>
                            <ul class=""sub-possibility-list"">
                                <li class=""possibility-list__item text text_small"">Restrict Use <span class=""text text_small");
            WriteLiteral(@" text_blue"">Share Service</span></li>
                                <li class=""possibility-list__item text text_small"">Restrict Use <span class=""text text_small text_purple"">Files Storage</span></li>
                            </ul>
                        </div>
                        <div class=""subscription__link"">
                            <a class=""btn subscription__btn"">Login/Register</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<footer class=""footer main__item"">
    <div class=""container"">
        <div class=""footer__body"">
            <h1 class=""title"">Our Contacts</h1>
        </div>
    </div>
</footer>
    ");
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
