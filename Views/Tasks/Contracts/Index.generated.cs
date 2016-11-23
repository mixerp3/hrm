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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Contracts/Index.cshtml")]
    public partial class _Views_Tasks_Contracts_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Contracts_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\Contracts\Index.cshtml"
  
    ViewBag.Title = "Employment Contracts";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"Emp" +
"loyment Contracts\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/hrm/contract-scrud" +
"-view\";\r\n    scrudFactory.viewTableName = \"hrm.contract_scrud_view\";\r\n\r\n    scru" +
"dFactory.formAPI = \"/api/forms/hrm/contracts\";\r\n    scrudFactory.formTableName =" +
" \"hrm.contracts\";\r\n\r\n    scrudFactory.excludedColumns = [\"Photo\"];\r\n\r\n    scrudF" +
"actory.allowDelete = true;\r\n    scrudFactory.allowEdit = true;\r\n\r\n    scrudFacto" +
"ry.live = \"EmployeeId\";\r\n\r\n\r\n    scrudFactory.readonlyColumns = [\"EndedOn\"];\r\n  " +
"  scrudFactory.hiddenColumns = [\"VerificationStatusId\", \"VerifiedByUserId\", \"Ver" +
"ifiedOn\", \"VerificationReason\"];\r\n\r\n    scrudFactory.keys = [\r\n        {\r\n      " +
"      property: \"EmployeeId\",\r\n            url: \'/api/forms/hrm/employees/displa" +
"y-fields\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n           " +
" textField: \"Value\"\r\n        },\r\n        {\r\n            property: \"OfficeId\",\r\n " +
"           url: \'/api/forms/core/offices/display-fields\',\r\n            data: nul" +
"l,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n" +
"        {\r\n            property: \"DepartmentId\",\r\n            url: \'/api/forms/h" +
"rm/departments/display-fields\',\r\n            data: null,\r\n            valueField" +
": \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            pro" +
"perty: \"RoleId\",\r\n            url: \'/api/forms/hrm/roles/display-fields\',\r\n     " +
"       data: null,\r\n            valueField: \"Key\",\r\n            textField: \"Valu" +
"e\"\r\n        },\r\n        {\r\n            property: \"LeaveBenefitId\",\r\n            " +
"url: \'/api/forms/hrm/leave-benefits/display-fields\',\r\n            data: null,\r\n " +
"           valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n     " +
"   {\r\n            property: \"EmploymentStatusCodeId\",\r\n            url: \'/api/fo" +
"rms/hrm/employment-status-codes/display-fields\',\r\n            data: null,\r\n     " +
"       valueField: \"Key\",\r\n            textField: \"Value\"\r\n        }\r\n    ];\r\n\r\n" +
"\r\n    $.get(\'/ScrudFactory/View.html\', function (view) {\r\n        $.get(\'/ScrudF" +
"actory/Form.html\', function (form) {\r\n            $(\"#ScrudFactoryView\").html(vi" +
"ew);\r\n            $(\"#ScrudFactoryForm\").html(form);\r\n            $.cachedScript" +
"(\"/assets/js/scrudfactory-view.js\");\r\n            $.cachedScript(\"/assets/js/scr" +
"udfactory-form.js\");\r\n        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>\r\n\r\n<script>\r\n    $(document).on(\"formready\", function () {\r\n        $(\"#v" +
"erification_status_id\").val(\"0\");\r\n    });\r\n</script>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
