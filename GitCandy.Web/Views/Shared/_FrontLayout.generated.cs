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
    
    #line 2 "..\..\Views\Shared\_FrontLayout.cshtml"
    using GitCandy.Extensions;
    
    #line default
    #line hidden
    using GitCandy.Models;
    using GitCandy.Web;
    using GitCandy.Web.App_GlobalResources;
    using NewLife;
    using NewLife.Cube;
    
    #line 1 "..\..\Views\Shared\_FrontLayout.cshtml"
    using NewLife.Model;
    
    #line default
    #line hidden
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
            
            #line 3 "..\..\Views\Shared\_FrontLayout.cshtml"
  
    var token = User.Identity as IManageUser;
    var cfg = NewLife.Common.SysConfig.Current;
    var title = ViewBag.Title + "";
    if (title != "" && !title.EndsWith(" - ")) { title += " - "; }
    title += cfg.DisplayName;
    var title2 = ViewBag.Title2 as String;
    if (!title2.IsNullOrEmpty()) { title += " - " + title2; }

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteAttribute("lang", Tuple.Create(" lang=\"", 457), Tuple.Create("\"", 477)
            
            #line 13 "..\..\Views\Shared\_FrontLayout.cshtml"
, Tuple.Create(Tuple.Create("", 464), Tuple.Create<System.Object, System.Int32>(ViewBag.Lang
            
            #line default
            #line hidden
, 464), false)
);

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 17 "..\..\Views\Shared\_FrontLayout.cshtml"
      Write(title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 650), Tuple.Create("\"", 680)
, Tuple.Create(Tuple.Create("", 657), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap.css")
, 657), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 712), Tuple.Create("\"", 749)
, Tuple.Create(Tuple.Create("", 719), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch.css")
, 719), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 781), Tuple.Create("\"", 811)
, Tuple.Create(Tuple.Create("", 788), Tuple.Create<System.Object, System.Int32>(Href("~/Content/highlight.css")
, 788), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 843), Tuple.Create("\"", 868)
, Tuple.Create(Tuple.Create("", 850), Tuple.Create<System.Object, System.Int32>(Href("~/Content/site.css")
, 850), false)
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

WriteAttribute("href", Tuple.Create(" href=\"", 1406), Tuple.Create("\"", 1415)
, Tuple.Create(Tuple.Create("", 1413), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 1413), false)
);

WriteLiteral(">");

            
            #line 33 "..\..\Views\Shared\_FrontLayout.cshtml"
                                             Write(cfg.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("<sub>");

            
            #line 33 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                  Write(cfg.Name);

            
            #line default
            #line hidden
WriteLiteral("</sub></a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"navbar-collapse collapse navbar-responsive-collapse\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n                    <li>");

            
            #line 37 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.ActionLink(SR.Shared_Repositories, "Index", "Repository"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 38 "..\..\Views\Shared\_FrontLayout.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Shared\_FrontLayout.cshtml"
                     if (token != null)
                    {
                        if (token.IsAdmin())
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Shared\_FrontLayout.cshtml"
                                    Write(Html.ActionLink(SR.Shared_Users, "Index", "Account"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                            <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Shared\_FrontLayout.cshtml"
                                    Write(Html.ActionLink(SR.Shared_Teams, "Index", "Team"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                            <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Shared\_FrontLayout.cshtml"
                                    Write(Html.ActionLink(SR.Shared_Settings, "Edit", "Setting"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 45 "..\..\Views\Shared\_FrontLayout.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink("创建项目", "Create", "Repository"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 47 "..\..\Views\Shared\_FrontLayout.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <li>");

            
            #line 48 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.ActionLink(SR.Shared_About, "About", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-right\"");

WriteLiteral(">\r\n");

            
            #line 51 "..\..\Views\Shared\_FrontLayout.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\_FrontLayout.cshtml"
                     if (token == null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Register, "Create", "Account"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Login, "Login", "Account", new { ReturnUrl = ViewContext.HttpContext.Request.Url.PathAndQuery }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 55 "..\..\Views\Shared\_FrontLayout.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(token.NickName, "Detail", "Account", new { name = token.Name }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

WriteLiteral("                        <li");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Shared\_FrontLayout.cshtml"
                                Write(Html.ActionLink(SR.Shared_Logout, "Logout", "Account", new { ReturnUrl = ViewContext.HttpContext.Request.Url.PathAndQuery }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 60 "..\..\Views\Shared\_FrontLayout.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div" +
"");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 67 "..\..\Views\Shared\_FrontLayout.cshtml"
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

            
            #line 74 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                      Write(ViewBag.Language);

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span></a>\r\n                <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                    <li>");

            
            #line 76 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.CultureActionLink("zh-cn"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 77 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.CultureActionLink("en-us"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 78 "..\..\Views\Shared\_FrontLayout.cshtml"
                   Write(Html.CultureActionLink("fr-fr"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral("><p");

WriteLiteral(" class=\"muted\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3935), Tuple.Create("\"", 3968)
            
            #line 81 "..\..\Views\Shared\_FrontLayout.cshtml"
, Tuple.Create(Tuple.Create("", 3943), Tuple.Create<System.Object, System.Int32>(Profiler.Current.Elapsed
            
            #line default
            #line hidden
, 3943), false)
);

WriteLiteral(">&copy; 2002-");

            
            #line 81 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                                             Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 81 "..\..\Views\Shared\_FrontLayout.cshtml"
                                                                                                                Write(cfg.Company);

            
            #line default
            #line hidden
WriteLiteral("</p></div>\r\n        </div>\r\n    </div>\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4066), Tuple.Create("\"", 4097)
, Tuple.Create(Tuple.Create("", 4072), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/jquery-2.0.3.js")
, 4072), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4121), Tuple.Create("\"", 4149)
, Tuple.Create(Tuple.Create("", 4127), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap.js")
, 4127), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4173), Tuple.Create("\"", 4208)
, Tuple.Create(Tuple.Create("", 4179), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap-switch.js")
, 4179), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4232), Tuple.Create("\"", 4271)
, Tuple.Create(Tuple.Create("", 4238), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap3-typeahead.js")
, 4238), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4295), Tuple.Create("\"", 4328)
, Tuple.Create(Tuple.Create("", 4301), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/highlight.pack.js")
, 4301), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4352), Tuple.Create("\"", 4377)
, Tuple.Create(Tuple.Create("", 4358), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/marked.js")
, 4358), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 4401), Tuple.Create("\"", 4426)
, Tuple.Create(Tuple.Create("", 4407), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/common.js")
, 4407), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 92 "..\..\Views\Shared\_FrontLayout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
