#pragma checksum "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49dc558fbce1d928e7438c884689321b7f2808d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlCenter_BatchDelete), @"mvc.1.0.view", @"/Views/ControlCenter/BatchDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ControlCenter/BatchDelete.cshtml", typeof(AspNetCore.Views_ControlCenter_BatchDelete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49dc558fbce1d928e7438c884689321b7f2808d", @"/Views/ControlCenter/BatchDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlCenter_BatchDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERCS.ViewModels.ControlCenterVMs.ControlCenterBatchVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden-panel", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "删除", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.QuoteTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_QuoteTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.DataTableTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(62, 348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49dc558fbce1d928e7438c884689321b7f2808d4586", async() => {
                BeginContext(83, 2, true);
                WriteLiteral("\n\t");
                EndContext();
                BeginContext(85, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:quote", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49dc558fbce1d928e7438c884689321b7f2808d4968", async() => {
                    BeginContext(95, 11, true);
                    WriteLiteral("确定要删除以下数据么：");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_QuoteTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.QuoteTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_QuoteTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(117, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(122, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a49dc558fbce1d928e7438c884689321b7f2808d6217", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#line 5 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ids);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(147, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(152, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a49dc558fbce1d928e7438c884689321b7f2808d7820", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DataTableTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ListVM);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.UseLocalData = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("use-local-data", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.UseLocalData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Height = 300;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.HiddenCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("hidden-checkbox", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.HiddenCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(253, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(258, 141, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49dc558fbce1d928e7438c884689321b7f2808d10830", async() => {
                    BeginContext(291, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(300, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a49dc558fbce1d928e7438c884689321b7f2808d11240", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
#line 8 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Theme =  ButtonThemeEnum.Warm;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("theme", __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Theme, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Text = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(358, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(367, 18, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a49dc558fbce1d928e7438c884689321b7f2808d13116", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(385, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 7 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align =  AlignEnum.Right;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("align", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(399, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper);
#line 3 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\ControlCenter\BatchDelete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERCS.ViewModels.ControlCenterVMs.ControlCenterBatchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
