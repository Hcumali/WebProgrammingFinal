#pragma checksum "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\_NewsLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae306d3d7da1aa62f4f4d1972a9f303d4df3f0ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebProgramming.Pages.Pages__NewsLayout), @"mvc.1.0.view", @"/Pages/_NewsLayout.cshtml")]
namespace WebProgramming.Pages
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
#line 2 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\_ViewImports.cshtml"
using WebProgramming.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae306d3d7da1aa62f4f4d1972a9f303d4df3f0ec", @"/Pages/_NewsLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5e31b69fc0a6da61eb03bb6dfa1fca34de60ea", @"/Pages/_ViewImports.cshtml")]
    public class Pages__NewsLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/material-dashboard.css?v=2.1.2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae306d3d7da1aa62f4f4d1972a9f303d4df3f0ec4412", async() => {
                WriteLiteral(@"
    <title>Hello, world!</title>
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"" />
    <!--     Fonts and icons     -->
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css"">
    <!-- Material Kit CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae306d3d7da1aa62f4f4d1972a9f303d4df3f0ec5260", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae306d3d7da1aa62f4f4d1972a9f303d4df3f0ec7140", async() => {
                WriteLiteral(@"
    <div class=""wrapper "">
        <div class=""sidebar"" data-color=""purple"" data-background-color=""white"">
            <div class=""logo"">
                <a class=""simple-text logo-mini"">
                    TEF
                </a>
            </div>
            <div class=""sidebar-wrapper"">
                <ul class=""nav"">
                    <li class=""nav-item active  "">
                        <a class=""nav-link"" href=""/admin/news"">
                            <i class=""material-icons"">dashboard</i>
                            <p>Dashboard</p>
                        </a>
                    </li>
                    <li class=""nav-item active  "">
                        <a class=""nav-link"" href=""/admin/user"">
                            <i class=""material-icons"">dashboard</i>
                            <p>User Process</p>
                        </a>
                    </li>
                    <li class=""nav-item active  "">
                        <a class=""nav-link"" href=""/account/logout"">
        ");
                WriteLiteral(@"                    <i class=""material-icons"">dashboard</i>
                            <p>Log Out</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""main-panel"">

            <nav class=""navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top "">
                <div class=""container-fluid"">
                    <div class=""navbar-wrapper"">
                        <a class=""navbar-brand"" href=""javascript:;"">Dashboard</a>
                    </div>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
     ");
                WriteLiteral(@"               </button>
                    <div class=""collapse navbar-collapse justify-content-end"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""javascript:;"">
                                    <i class=""material-icons"">notifications</i> Notifications
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <div class=""content"">
                <div class=""container-fluid"">
                   ");
#nullable restore
#line 75 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\_NewsLayout.cshtml"
              Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <footer class=""footer"">
                <div class=""container-fluid"">
                    <div class=""copyright float-right"">
                        &copy;
                        <script>document.write(new Date().getFullYear())</script>, made with <i class=""material-icons"">favorite</i> by
                        <a href=""https://www.github.com/Hcumali"" target=""_blank""> HUSEYIN</a>
                    </div>
                   
                </div>
            </footer>
        </div>
    </div>
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
            WriteLiteral("\n\n</html>");
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
