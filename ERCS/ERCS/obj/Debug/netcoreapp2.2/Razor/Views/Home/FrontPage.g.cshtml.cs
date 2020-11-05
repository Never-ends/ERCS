#pragma checksum "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a1387d35f7bb2f8b962ec9f4f8cf3ad81c1389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FrontPage), @"mvc.1.0.view", @"/Views/Home/FrontPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FrontPage.cshtml", typeof(AspNetCore.Views_Home_FrontPage))]
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
#line 2 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a1387d35f7bb2f8b962ec9f4f8cf3ad81c1389", @"/Views/Home/FrontPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FrontPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalkingTec.Mvvm.Core.BaseVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 8063, true);
            WriteLiteral(@"
<div class=""layui-row layui-col-space15"" id=""frontpage"">
  <div class=""layui-col-md8"">
    <div class=""layui-row layui-col-space15"">
      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">快捷方式</div>
          <div class=""layui-card-body"">

            <div class=""layui-carousel layadmin-carousel layadmin-shortcut"">
              <div carousel-item>
                <ul class=""layui-row layui-col-space10"">
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkUser/Index"">
                      <i class=""layui-icon layui-icon-username""></i>
                      <cite>用户</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkRole/Index"">
                      <i class=""layui-icon layui-icon-tabs""></i>
                      <cite>角色</cite>
                    </a>
                  </li>
                  <li class=""layui-col-x");
            WriteLiteral(@"s3"">
                    <a lay-href=""_Admin/FrameworkMenu/Index"">
                      <i class=""layui-icon layui-icon-app""></i>
                      <cite>菜单</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/FrameworkGroup/Index"">
                      <i class=""layui-icon layui-icon-user""></i>
                      <cite>用户组</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/DataPrivilege/Index"">
                      <i class=""layui-icon layui-icon-auz""></i>
                      <cite>数据权限</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a lay-href=""_Admin/ActionLog/Index"">
                      <i class=""layui-icon layui-icon-console""></i>
                      <cite>日志</cite>
                    </a>
                  </li>
                  <li class");
            WriteLiteral(@"=""layui-col-xs3"">
                    <a href=""/_codegen/index"" target=""_blank"">
                      <i class=""layui-icon layui-icon-template-1""></i>
                      <cite>代码生成</cite>
                    </a>
                  </li>
                  <li class=""layui-col-xs3"">
                    <a href=""https://wtmdoc.walkingtec.cn"" target=""_blank"">
                      <i class=""layui-icon layui-icon-read""></i>
                      <cite>文档</cite>
                    </a>
                  </li>
                </ul>

              </div>
            </div>

          </div>
        </div>
      </div>
      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">WTM开源</div>
          <div class=""layui-card-body"">

            <div class=""layui-carousel layadmin-carousel layadmin-backlog"">
              <div carousel-item>
                <ul class=""layui-row layui-col-space10"">
                  <li class=""layui-col-xs6"">
                    <a href=");
            WriteLiteral(@"""https://github.com/dotnetcore/WTM/stargazers"" class=""layadmin-backlog-body""
                       target=""_blank"">
                      <h3>Star</h3>
                      <p><cite id=""githubstar""></cite></p>
                    </a>
                  </li>
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.com/dotnetcore/WTM/network/members"" class=""layadmin-backlog-body""
                       target=""_blank"">
                      <h3>Fork</h3>
                      <p><cite id=""githubfork""></cite></p>
                    </a>
                  </li>
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.com/dotnetcore/WTM/watchers"" class=""layadmin-backlog-body""
                       target=""_blank"">
                      <h3>Watch</h3>
                      <p><cite id=""githubwatch""></cite></p>
                    </a>
                  </li>
                  <li class=""layui-col-xs6"">
                    <a href=""https://github.c");
            WriteLiteral(@"om/dotnetcore/WTM/issues"" class=""layadmin-backlog-body"" target=""_blank"">
                      <h3>Issue</h3>
                      <p><cite id=""githubissue""></cite></p>
                    </a>
                  </li>
                </ul>
                <ul class=""layui-row layui-col-space10"">
                  <li class=""layui-col-xs12"">
                    <span style=""font-size:16px;line-height:50px;"">WTM是纯开源免费框架，如果喜欢，来GitHub赏个星~~</span>

                    <p style=""text-align:center"">
                      <a href=""https://github.com/dotnetcore/wtm"" target=""_blank""
                         style=""background-color:#eee;background-image:linear-gradient(to bottom, #fcfcfc 0, #eee 100%);background-repeat:no-repeat;border:1px solid #d5d5d5;color:#333;padding:3px 10px 3px 8px;font-size:16px;line-height:22px"">
                        <span width=""20""
                              style=""width:20px;height:20px;font-size:16px;line-height:22px;box-sizing:border-box; background-size:100% 100%; background-image:");
            WriteLiteral(@"url('data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4PSIwcHgiIHk9IjBweCIgd2lkdGg9IjQwcHgiIGhlaWdodD0iNDBweCIgdmlld0JveD0iMTIgMTIgNDAgNDAiIGVuYWJsZS1iYWNrZ3JvdW5kPSJuZXcgMTIgMTIgNDAgNDAiIHhtbDpzcGFjZT0icHJlc2VydmUiPjxwYXRoIGZpbGw9IiMzMzMzMzMiIGQ9Ik0zMiAxMy40Yy0xMC41IDAtMTkgOC41LTE5IDE5YzAgOC40IDUuNSAxNS41IDEzIDE4YzEgMC4yIDEuMy0wLjQgMS4zLTAuOWMwLTAuNSAwLTEuNyAwLTMuMiBjLTUuMyAxLjEtNi40LTIuNi02LjQtMi42QzIwIDQxLjYgMTguOCA0MSAxOC44IDQxYy0xLjctMS4yIDAuMS0xLjEgMC4xLTEuMWMxLjkgMC4xIDIuOSAyIDIuOSAyYzEuNyAyLjkgNC41IDIuMSA1LjUgMS42IGMwLjItMS4yIDAuNy0yLjEgMS4yLTIuNmMtNC4yLTAuNS04LjctMi4xLTguNy05LjRjMC0yLjEgMC43LTMuNyAyLTUuMWMtMC4yLTAuNS0wLjgtMi40IDAuMi01YzAgMCAxLjYtMC41IDUuMiAyIGMxLjUtMC40IDMuMS0wLjcgNC44LTAuN2MxLjYgMCAzLjMgMC4yIDQuNyAwLjdjMy42LTIuNCA1LjItMiA1LjItMmMxIDIuNiAwLjQgNC42IDAuMiA1YzEuMiAxLjMgMiAzIDIgNS4xYzAgNy4zLTQuNSA4LjktOC43IDkuNCBjMC43IDAuNiAxLjMgMS43IDEuMyAzLjVjMCAyLjYgMCA0LjYgMCA1L");
            WriteLiteral(@"jJjMCAwLjUgMC40IDEuMSAxLjMgMC45YzcuNS0yLjYgMTMtOS43IDEzLTE4LjFDNTEgMjEuOSA0Mi41IDEzLjQgMzIgMTMuNHoiLz48L3N2Zz4=')"">&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <span>Stars <cite id=""githubstars""></cite></span>
                      </a>
                    </p>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">控制器</div>
          <div class=""layui-carousel layadmin-carousel layadmin-dataview"">
            <div carousel-item>
              <div id=""chart_Controller"" style="" height:300px;"">
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""layui-col-md6"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">其他</div>
          <div class=""layui-carousel layadmin-carousel layadmin-dataview"">
            <div carousel-item>
              <div i");
            WriteLiteral(@"d=""chart_Other"" style="" height:300px;"">
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""layui-col-md12"">
        <div class=""layui-card"">
          <div class=""layui-card-header"">模拟数据</div>
          <div class=""layui-card-body"">

            <div class=""layui-carousel layadmin-carousel layadmin-dataview"" data-anim=""fade""
                 lay-filter=""LAY-index-dataview"">
              <div carousel-item id=""LAY-index-dataview"">
                <div><i class=""layui-icon layui-icon-loading1 layadmin-loading""></i></div>
                <div></div>
                <div></div>
              </div>
            </div>

          </div>
        </div>
      </div>
    </div>
  </div>

  <div class=""layui-col-md4"">
    <div class=""layui-card"">
      <div class=""layui-card-header"">版本信息</div>
      <div class=""layui-card-body layui-text"">
");
            EndContext();
#line 173 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
         if (Model.ConfigInfo.IsQuickDebug == true)
        {

#line default
#line hidden
            BeginContext(8184, 486, true);
            WriteLiteral(@"          <p>你正在使用<font color=""Red"">调试模式</font>，在调试模式下，框架会：</p>
          <p><span class=""layui-badge layui-bg-cyan"">1</span>&nbsp;反射所有controller下的Index方法作为左侧菜单</p>
          <p><span class=""layui-badge layui-bg-cyan"">2</span>&nbsp;登陆时自动添加用户名和密码</p>
          <p><span class=""layui-badge layui-bg-cyan"">3</span>&nbsp;跳过权限验证</p>
          <p>
            修改appsettings文件中的IsQuickDebug可关闭调试模式，<a href=""http://wtmdoc.walkingtec.cn/#/QuickStart/FAQ"" target=""_blank"">详见文档</a>
          </p>
");
            EndContext();
#line 182 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(8703, 458, true);
            WriteLiteral(@"          <p>你正在使用普通模式，普通模式是项目发布后应该使用的模式，框架会：</p>
          <p><span class=""layui-badge layui-bg-cyan"">1</span>&nbsp;从数据库读取菜单和权限配置</p>
          <p><span class=""layui-badge layui-bg-cyan"">2</span>&nbsp;验证所有访问地址的权限</p>
          <p><span class=""layui-badge layui-bg-cyan"">3</span>&nbsp;不再输出各类调试信息</p>
          <p>
            修改appsettings文件中的IsQuickDebug可开启调试模式，<a href=""http://wtmdoc.walkingtec.cn/#/QuickStart/FAQ"" target=""_blank"">详见文档</a>
          </p>
");
            EndContext();
#line 192 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
        }

#line default
#line hidden
            BeginContext(9171, 3569, true);
            WriteLiteral(@"      </div>
    </div>

    <div class=""layui-card"">
      <div class=""layui-card-header"">框架特点</div>
      <div class=""layui-card-body layadmin-takerates"">
        <ul>
          <li><i class=""layui-icon layui-icon-ok""></i>一键生成WTM项目</li>
          <li><i class=""layui-icon layui-icon-ok""></i>一键生成增删改查，导入导出，批量操作代码</li>
          <li><i class=""layui-icon layui-icon-ok""></i>支持一对多，多对多关联模型的识别和代码生成</li>
          <li><i class=""layui-icon layui-icon-ok""></i>支持分离和不分离两种模式</li>
          <li><i class=""layui-icon layui-icon-ok""></i>支持sqlserver，mysql，pgsql三种数据库</li>
          <li><i class=""layui-icon layui-icon-ok""></i>封装了Layui，AntD，Element的大部分控件，编写前台更加简便</li>
          <li><i class=""layui-icon layui-icon-ok""></i>提供了很多基类，封装了绝大部分后台常用操作</li>
          <li><i class=""layui-icon layui-icon-ok""></i>提供了用户，角色，用户组，菜单，日志等常用模块</li>
          <li><i class=""layui-icon layui-icon-ok""></i>支持数据权限的开发和配置</li>
          <li><i class=""layui-icon layui-icon-ok""></i>支持读写分离和数据库分库</li>
        </ul>
      </div>
    </div>

    <div class=""layui");
            WriteLiteral(@"-card"">
      <div class=""layui-card-header"">
        作者的话
        <i class=""layui-icon layui-icon-tips"" lay-tips=""从善如登"" lay-offset=""5""></i>
      </div>
      <div class=""layui-card-body layui-text layadmin-text"">
        <p>
          WTM框架，全称WalkingTec
          MVVM（不是“我特么”的拼音首字母），WTM是一个快速开发框架，有多快？至少目前dotnetcore的开源项目中，我还没有见到更接地气，开发速度更快的框架。WTM的设计理念就是最大程度的加快开发速度，降低开发成本。
        </p>
        <p>
          国内Java一家独大原因很多，有BAT的示范效应，也有微软自己战略的失误。好在微软这两年终于想明白了， dotnet
          core的横空出世和收购github都是非常正确的方向。当然要想达到java一样的生态还有很长的路要走，那我就贡献一点绵薄之力吧。
        </p>
        <p>
          WTM开源以来，受到了越来越多开发者的喜爱，WTM必将以更加成熟稳定的姿态回报各位的喜爱。特别鸣谢贤心（<a href=""http://www.layui.com/""
                                                                 target=""_blank"">layui.com</a>），授权WTM开发的项目可以免费使用其收费版的LayuiAdmin。提高自己，造福他人，吾道不孤！
        </p>
        <p>
          —— 框架开源地址：<a href=""https://github.com/dotnetcore/WTM"" target=""_blank"">https://github.com/dotnetcore/WTM</a>
        </p>
        <p>—— 框架在线文档：<a href=""https://wtmdoc.walkingtec.cn"" ");
            WriteLiteral(@"target=""_blank"">https://wtmdoc.walkingtec.cn</a></p>
        <p>—— 框架QQ交流群：694148336</p>
      </div>
    </div>
  </div>

</div>
<script>
  $(""#frontpage"").parent().css(""background-color"", ""#eee"");
  $.get(""/Home/GetGithubInfo"", function (r) {
    $(""#githubstar"").html(r.stargazers_count);
    $(""#githubstars"").html(r.stargazers_count);
    $(""#githubfork"").html(r.forks_count);
    $(""#githubwatch"").html(r.subscribers_count);
    $(""#githubissue"").html(r.open_issues_count);
  });

  //区块轮播切换
  layui.use(['admin', 'carousel'], function () {
    var $ = layui.$
      , admin = layui.admin
      , carousel = layui.carousel
      , element = layui.element
      , device = layui.device();

    //轮播切换
    $('.layadmin-carousel').each(function () {
      var othis = $(this);
      carousel.render({
        elem: this
        , width: '100%'
        , arrow: 'none'
        , interval: othis.data('interval')
        , autoplay: othis.data('autoplay') === true
        , trigger: (device.ios || device.android) ? 'click");
            WriteLiteral(@"' : 'hover'
        , anim: othis.data('anim')
      });
    });

    element.render('progress');

  });

  //数据概览
  layui.use(['admin', 'carousel', 'echarts'], function () {
    var $ = layui.$
      , admin = layui.admin
      , carousel = layui.carousel
      , echarts = layui.echarts;

      var control = echarts.init(document.getElementById('chart_Controller'), 'default');
      var controlOption = {
        title: { text: '控制器' },
        tooltip: {},
         legend: {
          data: ");
            EndContext();
            BeginContext(12741, 68, false);
#line 290 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
           Write(Html.Raw(JsonConvert.SerializeObject(ViewData["controller.legend"])));

#line default
#line hidden
            EndContext();
            BeginContext(12809, 104, true);
            WriteLiteral("\n        },\n       xAxis: {},\n        yAxis: {\n          data: [\'控制器\', \'动作\']\n        },\n        series: ");
            EndContext();
            BeginContext(12914, 68, false);
#line 296 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
           Write(Html.Raw(JsonConvert.SerializeObject(ViewData["controller.series"])));

#line default
#line hidden
            EndContext();
            BeginContext(12982, 340, true);
            WriteLiteral(@"
      };
      control.setOption(controlOption);

      var other = echarts.init(document.getElementById('chart_Other'), 'default');
      var otherOption = {
        title: { text: '其他' },
        tooltip: {},
        xAxis: {},
        yAxis: {
          data: ['模型', 'Dll文件', '数据权限', '连接字符串', 'App Settings']
        },
        series: ");
            EndContext();
            BeginContext(13323, 63, false);
#line 308 "D:\桌面备份\大三下\.net大作业\病毒防疫管理系统源码及毕设文档\病毒防疫系统\ERCS\Views\Home\FrontPage.cshtml"
           Write(Html.Raw(JsonConvert.SerializeObject(ViewData["other.series"])));

#line default
#line hidden
            EndContext();
            BeginContext(13386, 3961, true);
            WriteLiteral(@"
      };
      other.setOption(otherOption);

    var echartsApp = [], options = [
      //今日流量趋势
      {
        title: {
          text: '今日流量趋势',
          x: 'center',
          textStyle: {
            fontSize: 14
          }
        },
        tooltip: {
          trigger: 'axis'
        },
        legend: {
          data: ['', '']
        },
        xAxis: [{
          type: 'category',
          boundaryGap: false,
          data: ['06:00', '06:30', '07:00', '07:30', '08:00', '08:30', '09:00', '09:30', '10:00', '11:30', '12:00', '12:30', '13:00', '13:30', '14:00', '14:30', '15:00', '15:30', '16:00', '16:30', '17:00', '17:30', '18:00', '18:30', '19:00', '19:30', '20:00', '20:30', '21:00', '21:30', '22:00', '22:30', '23:00', '23:30']
        }],
        yAxis: [{
          type: 'value'
        }],
        series: [{
          name: 'PV',
          type: 'line',
          smooth: true,
          itemStyle: { normal: { areaStyle: { type: 'default' } } },
          data: [111, 222, 333, 444, 555, 666, ");
            WriteLiteral(@"3333, 33333, 55555, 66666, 33333, 3333, 6666, 11888, 26666, 38888, 56666, 42222, 39999, 28888, 17777, 9666, 6555, 5555, 3333, 2222, 3111, 6999, 5888, 2777, 1666, 999, 888, 777]
        }, {
          name: 'UV',
          type: 'line',
          smooth: true,
          itemStyle: { normal: { areaStyle: { type: 'default' } } },
          data: [11, 22, 33, 44, 55, 66, 333, 3333, 5555, 12666, 3333, 333, 666, 1188, 2666, 3888, 6666, 4222, 3999, 2888, 1777, 966, 655, 555, 333, 222, 311, 699, 588, 277, 166, 99, 88, 77]
        }]
      },

      //访客浏览器分布
      {
        title: {
          text: '访客浏览器分布',
          x: 'center',
          textStyle: {
            fontSize: 14
          }
        },
        tooltip: {
          trigger: 'item',
          formatter: ""{a} <br/>{b} : {c} ({d}%)""
        },
        legend: {
          orient: 'vertical',
          x: 'left',
          data: ['Chrome', 'Firefox', 'IE 8.0', 'Safari', '其它浏览器']
        },
        series: [{
          name: '访问来源',
          type: 'pie',
  ");
            WriteLiteral(@"        radius: '55%',
          center: ['50%', '50%'],
          data: [
            { value: 9052, name: 'Chrome' },
            { value: 1610, name: 'Firefox' },
            { value: 3200, name: 'IE 8.0' },
            { value: 535, name: 'Safari' },
            { value: 1700, name: '其它浏览器' }
          ]
        }]
      },

      //新增的用户量
      {
        title: {
          text: '最近一周新增的用户量',
          x: 'center',
          textStyle: {
            fontSize: 14
          }
        },
        tooltip: { //提示框
          trigger: 'axis',
          formatter: ""{b}<br>新增用户：{c}""
        },
        xAxis: [{ //X轴
          type: 'category',
          data: ['11-07', '11-08', '11-09', '11-10', '11-11', '11-12', '11-13']
        }],
        yAxis: [{  //Y轴
          type: 'value'
        }],
        series: [{ //内容
          type: 'line',
          data: [200, 300, 400, 610, 150, 270, 380],
        }]
      }
    ]
      , elemDataView = $('#LAY-index-dataview').children('div')
      , renderDataView = function ");
            WriteLiteral(@"(index) {
        echartsApp[index] = echarts.init(elemDataView[index], layui.echartsTheme);
        echartsApp[index].setOption(options[index]);
        //window.onresize = echartsApp[index].resize;
        admin.resize(function () {
          echartsApp[index].resize();
          control.resize();
          other.resize();
        });
      };


    //没找到DOM，终止执行
    if (!elemDataView[0]) return;

    renderDataView(0);

    //监听数据概览轮播
    var carouselIndex = 0;
    carousel.on('change(LAY-index-dataview)', function (obj) {
      renderDataView(carouselIndex = obj.index);
    });

    //监听侧边伸缩
    layui.admin.on('side', function () {
      setTimeout(function () {
        renderDataView(carouselIndex);
      }, 300);
    });

    //监听路由
    layui.admin.on('hash(tab)', function () {
      layui.router().path.join('') || renderDataView(carouselIndex);
    });
  });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalkingTec.Mvvm.Core.BaseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
