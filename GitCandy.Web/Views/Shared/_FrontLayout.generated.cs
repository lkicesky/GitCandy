﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GitCandy;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using GitCandy.Web;
    using GitCandy.Web.App_GlobalResources;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_FrontLayout.cshtml")]
    public partial class _Views_Shared__FrontLayout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__FrontLayout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_FrontLayout.cshtml"
  
    var token = GitCandy.Security.Token.Current;
    var cfg = NewLife.Common.SysConfig.Current;
    var title = ViewBag.Title + "";
    if (title != "" && !title.EndsWith(" - ")) { title += " - "; }
    title += cfg.DisplayName;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteAttribute("lang", Tuple.Create(" lang=\"", 301), Tuple.Create("\"", 321)
            
            #line 9 "..\..\Views\Shared\_FrontLayout.cshtml"
, Tuple.Create(Tuple.Create("", 308), Tuple.Create<System.Object, System.Int32>(ViewBag.Lang
            
            #line default
            #line hidden
, 308), false)
);

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 13 "..\..\Views\Shared\_FrontLayout.cshtml"
      Write(title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 494), Tuple.Create("\"", 524)
, Tuple.Create(Tuple.Create("", 501), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap.css")
, 501), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 556), Tuple.Create("\"", 593)
, Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch.css")
, 563), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 625), Tuple.Create("\"", 655)
, Tuple.Create(Tuple.Create("", 632), Tuple.Create<System.Object, System.Int32>(Href("~/Content/highlight.css")
, 632), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 687), Tuple.Create("\"", 712)
, Tuple.Create(Tuple.Create("", 694), Tuple.Create<System.Object, System.Int32>(Href("~/Content/site.css")
, 694), false)
);

WriteLiteral(" />\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"navbar navbar-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"navbar-toggle\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".navbar-responsive-collapse\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                </button>\r\n                <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1250), Tuple.Create("\"", 1259)
, Tuple.Create(Tuple.Create("", 1257), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 1257), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Views\Shared\_FrontLayout.cshtml"
                                             Write(cfg.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("<sub>");

            
            #line 29 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                  Write(cfg.Name);

            
            #line default
            #line hidden
WriteLiteral("</sub></a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"navbar-collapse collapse navbar-responsive-collapse\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n                    <li>");

            
            #line 33 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.ActionLink(SR.Shared_Repositories, "Index", "Repository"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 34 "..\..\Views\Shared\_FrontLayout.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Shared\_FrontLayout.cshtml"
                     if (token != null && token.IsAdmin)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Users, "Index", "Account"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Teams, "Index", "Team"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Settings, "Edit", "Setting"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 39 "..\..\Views\Shared\_FrontLayout.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <li>");

            
            #line 40 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.ActionLink(SR.Shared_About, "About", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-right\"");

WriteLiteral(">\r\n");

            
            #line 43 "..\..\Views\Shared\_FrontLayout.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Shared\_FrontLayout.cshtml"
                     if (token == null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Register, "Create", "Account"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Login, "Login", "Account", new { ReturnUrl = ViewContext.HttpContext.Request.Url.PathAndQuery }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 47 "..\..\Views\Shared\_FrontLayout.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(token.Nickname, "Detail", "Account", new { name = token.Username }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Logout, "Logout", "Account", new { ReturnUrl = ViewContext.HttpContext.Request.Url.PathAndQuery }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 52 "..\..\Views\Shared\_FrontLayout.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div" +
"");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 59 "..\..\Views\Shared\_FrontLayout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"container footer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-divider\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-right btn-group dropup\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                      Write(ViewBag.Language);

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span></a>\r\n                <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                    <li>");

            
            #line 68 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.CultureActionLink("zh-cn"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 69 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.CultureActionLink("en-us"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 70 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.CultureActionLink("fr-fr"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral("><p");

WriteLiteral(" class=\"muted\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3596), Tuple.Create("\"", 3629)
            
            #line 73 "..\..\Views\Shared\_FrontLayout.cshtml"
, Tuple.Create(Tuple.Create("", 3604), Tuple.Create<System.Object, System.Int32>(Profiler.Current.Elapsed
            
            #line default
            #line hidden
, 3604), false)
);

WriteLiteral(">&copy; 2002-");

            
            #line 73 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                                             Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 73 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                                                                Write(cfg.Company);

            
            #line default
            #line hidden
WriteLiteral("</p></div>\r\n        </div>\r\n    </div>\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3727), Tuple.Create("\"", 3758)
, Tuple.Create(Tuple.Create("", 3733), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/jquery-2.0.3.js")
, 3733), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3782), Tuple.Create("\"", 3810)
, Tuple.Create(Tuple.Create("", 3788), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap.js")
, 3788), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3834), Tuple.Create("\"", 3869)
, Tuple.Create(Tuple.Create("", 3840), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap-switch.js")
, 3840), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3893), Tuple.Create("\"", 3932)
, Tuple.Create(Tuple.Create("", 3899), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap3-typeahead.js")
, 3899), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3956), Tuple.Create("\"", 3989)
, Tuple.Create(Tuple.Create("", 3962), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/highlight.pack.js")
, 3962), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4013), Tuple.Create("\"", 4038)
, Tuple.Create(Tuple.Create("", 4019), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/marked.js")
, 4019), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4062), Tuple.Create("\"", 4087)
, Tuple.Create(Tuple.Create("", 4068), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/common.js")
, 4068), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 84 "..\..\Views\Shared\_FrontLayout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
