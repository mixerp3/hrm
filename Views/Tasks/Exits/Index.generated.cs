﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    using DevTrends.MvcDonutCaching;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.HRM;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Exits/Index.cshtml")]
    public partial class _Views_Tasks_Exits_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Exits_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\Exits\Index.cshtml"
  
    ViewBag.Title = "Exits";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"E" +
"xits\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/hrm/exit-scrud-view\";\r\n    scru" +
"dFactory.viewTableName = \"hrm.exit_scrud_view\";\r\n\r\n    scrudFactory.formAPI = \"/" +
"api/forms/hrm/exits\";\r\n    scrudFactory.formTableName = \"hrm.exits\";\r\n\r\n    scru" +
"dFactory.excludedColumns = [\"AuditUserId\", \"AuditTs\"];\r\n    scrudFactory.hiddenC" +
"olumns = [\"VerificationStatusId\", \"VerifiedByUserId\", \"VerifiedOn\", \"Verificatio" +
"nReason\"];\r\n    scrudFactory.excludedColumns = [\"Photo\"];\r\n\r\n    scrudFactory.al" +
"lowDelete = true;\r\n    scrudFactory.allowEdit = true;\r\n\r\n    scrudFactory.live =" +
" \"EmployeeId\";\r\n\r\n    scrudFactory.layout = [\r\n            {\r\n            tab: \"" +
"\",\r\n            fields: [\r\n                [\"ExitId\"],\r\n                [\"Employ" +
"eeId\", \"Reason\"],\r\n                [\"ChangeStatusTo\", \"ExitTypeId\"],\r\n          " +
"      [\"ForwardTo\", \"ServiceEndDate\"],\r\n                [\"Details\"],\r\n          " +
"      [\"ExitInterviewDetails\"]\r\n            ]\r\n        }\r\n    ];\r\n\r\n    scrudFac" +
"tory.keys = [\r\n        {\r\n            property: \"EmployeeId\",\r\n            url: " +
"\'/api/views/hrm/employee-view/display-fields\',\r\n            data: null,\r\n       " +
"     valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n" +
"            property: \"ExitTypeId\",\r\n            url: \'/api/forms/hrm/exit-types" +
"/display-fields\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n    " +
"        textField: \"Value\"\r\n        },\r\n        {\r\n            property: \"Change" +
"StatusTo\",\r\n            url: \'/api/forms/hrm/employment-statuses/display-fields\'" +
",\r\n            data: null,\r\n            valueField: \"Key\",\r\n            textFiel" +
"d: \"Value\"\r\n        },\r\n        {\r\n            property: \"ForwardTo\",\r\n         " +
"   url: \'/api/views/hrm/employee-view/display-fields\',\r\n            data: null,\r" +
"\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        }\r\n    " +
"];\r\n    $.get(\'/ScrudFactory/View.html\', function (view) {\r\n        $.get(\'/Scru" +
"dFactory/Form.html\', function (form) {\r\n            $(\"#ScrudFactoryView\").html(" +
"view);\r\n            $(\"#ScrudFactoryForm\").html(form);\r\n            $.cachedScri" +
"pt(\"/assets/js/scrudfactory-view.js\");\r\n            $.cachedScript(\"/assets/js/s" +
"crudfactory-form.js\");\r\n        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>\r\n\r\n<script>\r\n    $(document).on(\"formready\", function() {\r\n        $(\"#ve" +
"rification_status_id\").val(\"0\");\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591
