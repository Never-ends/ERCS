#pragma checksum "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25ae2f604c5018540eba39ffccc562d9ed2ee499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Delete), @"mvc.1.0.view", @"/Views/Patient/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/Delete.cshtml", typeof(AspNetCore.Views_Patient_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ae2f604c5018540eba39ffccc562d9ed2ee499", @"/Views/Patient/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERCS.ViewModels.PatientVMs.PatientVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "删除", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(45, 635, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ae2f604c5018540eba39ffccc562d9ed2ee4994137", async() => {
                BeginContext(66, 2, true);
                WriteLiteral("\n\t");
                EndContext();
                BeginContext(68, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:quote", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ae2f604c5018540eba39ffccc562d9ed2ee4994519", async() => {
                    BeginContext(78, 11, true);
                    WriteLiteral("确定要删除这条数据么：");
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
                BeginContext(100, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(102, 385, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ae2f604c5018540eba39ffccc562d9ed2ee4995767", async() => {
                    BeginContext(146, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(148, 41, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee4996170", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 6 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.PatientName);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(189, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(191, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee4997852", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 7 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.IdNumber);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(229, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(231, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee4999531", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 8 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Gender);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(267, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(269, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49911208", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 9 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Status);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(305, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(307, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49912886", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 10 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Birthday);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(345, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(347, 43, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49914567", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 11 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Location.Name);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(390, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(392, 43, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49916253", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 12 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Hospital.Name);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(435, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(437, 37, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49917939", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#line 13 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.PhotoId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(474, 4, true);
                    WriteLiteral("\r\n\r\n");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 5 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
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
                BeginContext(487, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(492, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49920886", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#line 16 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
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
                BeginContext(523, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(528, 141, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ae2f604c5018540eba39ffccc562d9ed2ee49922486", async() => {
                    BeginContext(561, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(570, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49922896", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
#line 18 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Theme =  ButtonThemeEnum.Warm;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("theme", __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Theme, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(628, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(637, 18, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ae2f604c5018540eba39ffccc562d9ed2ee49924762", async() => {
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
                    BeginContext(655, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#line 17 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
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
                BeginContext(669, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper);
#line 3 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Patient\Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERCS.ViewModels.PatientVMs.PatientVM> Html { get; private set; }
    }
}
#pragma warning restore 1591