#pragma checksum "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b09a113c7348447d8185911db90003ce5a162529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b09a113c7348447d8185911db90003ce5a162529", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n\n");
            EndContext();
            BeginContext(24, 482, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b09a113c7348447d8185911db90003ce5a1625293228", async() => {
                BeginContext(30, 35, true);
                WriteLiteral("\n  <meta charset=\"utf-8\">\n  <title>");
                EndContext();
                BeginContext(66, 17, false);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Shared\_Layout.cshtml"
    Write(ViewData["title"]);

#line default
#line hidden
                EndContext();
                BeginContext(83, 416, true);
                WriteLiteral(@"</title>
  <meta name=""renderer"" content=""webkit"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
  <meta name=""viewport""
    content=""width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=0"">
  <link rel=""stylesheet"" href=""/layui/css/layui.css"" media=""all"">
  <link rel=""stylesheet"" href=""/sitecss/wtm.css"">
  <link rel=""stylesheet"" href=""/font/iconfont.css"">
");
                EndContext();
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
            EndContext();
            BeginContext(506, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(508, 539, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b09a113c7348447d8185911db90003ce5a1625295225", async() => {
                BeginContext(514, 164, true);
                WriteLiteral("\n  <div id=\"LAY_app\"></div>\n  <script src=\"/jquery.min.js\"></script>\n  <script src=\"/jquery.cookie.js\"></script>\n  <script src=\"/layui/layui.js\"></script>\n  <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 678, "\"", 732, 2);
                WriteAttributeValue("", 684, "/_js/framework_layui.js?time=", 684, 29, true);
#line 21 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 713, DateTime.Now.Ticks, 713, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(733, 89, true);
                WriteLiteral("></script>\n  <script>\n    var DONOTUSE_IGNOREHASH = false;\n    var DONOTUSE_COOKIEPRE = \'");
                EndContext();
                BeginContext(823, 30, false);
#line 24 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Shared\_Layout.cshtml"
                         Write(ViewData["DONOTUSE_COOKIEPRE"]);

#line default
#line hidden
                EndContext();
                BeginContext(853, 34, true);
                WriteLiteral("\';\n    var DONOTUSE_WINDOWGUID = \'");
                EndContext();
                BeginContext(888, 42, false);
#line 25 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Shared\_Layout.cshtml"
                          Write(Guid.NewGuid().ToString().Replace("-", ""));

#line default
#line hidden
                EndContext();
                BeginContext(930, 96, true);
                WriteLiteral("\';\n    layui.config({\n      base: \'/layuiadmin/\'\n      , version: \'1.2.1\'\n    });\n  </script>\n  ");
                EndContext();
                BeginContext(1027, 12, false);
#line 31 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1039, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(1047, 10, true);
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
