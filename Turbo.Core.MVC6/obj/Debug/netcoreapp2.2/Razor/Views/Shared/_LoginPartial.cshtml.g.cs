#pragma checksum "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b5ecd31f1b4a1b4113dfb2a71923ba243aee8f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginPartial))]
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
#line 1 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\_ViewImports.cshtml"
using Ruanmou.Core.MVC6;

#line default
#line hidden
#line 2 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\_ViewImports.cshtml"
using Ruanmou.Core.MVC6.Models;

#line default
#line hidden
#line 1 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
using Ruanmou.Core.Utility;

#line default
#line hidden
#line 2 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5ecd31f1b4a1b4113dfb2a71923ba243aee8f2", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2899260da9039fd305a34e10838e8b20a7fc5dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Fourth/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Fourth/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
 if (base.Context.Session != null && !string.IsNullOrEmpty(base.Context.Session.GetString("CurrentUser")))
{
    string user = base.Context.Session.GetString("CurrentUser");
    CurrentUser currentUser = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentUser>(user);
    using (Html.BeginForm("Logout", "Fourth", FormMethod.Post, new { id = "logoutForm", @class = "navbar-right" }))
    {
        

#line default
#line hidden
            BeginContext(474, 23, false);
#line 10 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(501, 84, true);
            WriteLiteral("        <ul class=\"nav navbar-nav navbar-right\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(586, 140, false);
#line 14 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
           Write(Html.ActionLink("你好 Session" + currentUser.Name + "!", "Index", "Home", routeValues: null, htmlAttributes: new { title = currentUser.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(726, 133, true);
            WriteLiteral("\r\n            </li>\r\n            <li><a href=\"javascript:document.getElementById(\'logoutForm\').submit()\">注销</a></li>\r\n        </ul>\r\n");
            EndContext();
#line 18 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
    }
}
else if (base.Context.User?.Identity?.IsAuthenticated ?? false)
{

#line default
#line hidden
            BeginContext(937, 72, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li>\r\n            ");
            EndContext();
            BeginContext(1010, 169, false);
#line 24 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("你好 Cookie" + base.Context.User.Identity.Name + "!", "Index", "Home", routeValues: null, htmlAttributes: new { title = base.Context.User.Identity.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 29, true);
            WriteLiteral("\r\n        </li>\r\n        <li>");
            EndContext();
            BeginContext(1208, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b5ecd31f1b4a1b4113dfb2a71923ba243aee8f26752", async() => {
                BeginContext(1234, 2, true);
                WriteLiteral("注销");
                EndContext();
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
            EndContext();
            BeginContext(1240, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 28 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1270, 72, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li>\r\n            ");
            EndContext();
            BeginContext(1342, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b5ecd31f1b4a1b4113dfb2a71923ba243aee8f28377", async() => {
                BeginContext(1367, 4, true);
                WriteLiteral(" 登录 ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1375, 28, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
            EndContext();
#line 36 "E:\Ruanmou.Richard.Core.Project\Ruanmou.Core.MVC6\Views\Shared\_LoginPartial.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
