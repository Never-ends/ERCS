#pragma checksum "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc552368d35f324f8684649632dfa4e12dccca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Edit), @"mvc.1.0.view", @"/Views/Report/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/Edit.cshtml", typeof(AspNetCore.Views_Report_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc552368d35f324f8684649632dfa4e12dccca9", @"/Views/Report/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERCS.ViewModels.ReportVMs.ReportVM>
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(43, 372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bc552368d35f324f8684649632dfa4e12dccca93829", async() => {
                BeginContext(64, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(66, 196, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bc552368d35f324f8684649632dfa4e12dccca94212", async() => {
                    BeginContext(110, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(112, 40, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc552368d35f324f8684649632dfa4e12dccca94615", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#line 5 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Temprature);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(152, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(154, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc552368d35f324f8684649632dfa4e12dccca96293", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Remark);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(190, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(192, 59, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:combobox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc552368d35f324f8684649632dfa4e12dccca97967", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper);
#line 7 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.PatientID);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Items = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AllPatients);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("items", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(251, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 4 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow = ItemsPerRowEnum.Two;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("items-per-row", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(262, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(267, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc552368d35f324f8684649632dfa4e12dccca911401", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#line 9 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.ID);

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
                BeginContext(298, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(303, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bc552368d35f324f8684649632dfa4e12dccca912997", async() => {
                    BeginContext(335, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(344, 19, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc552368d35f324f8684649632dfa4e12dccca913407", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(363, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(372, 18, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc552368d35f324f8684649632dfa4e12dccca914617", async() => {
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
                    BeginContext(390, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 10 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align = AlignEnum.Right;

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
                BeginContext(404, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper);
#line 3 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Report\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERCS.ViewModels.ReportVMs.ReportVM> Html { get; private set; }
    }
}
#pragma warning restore 1591