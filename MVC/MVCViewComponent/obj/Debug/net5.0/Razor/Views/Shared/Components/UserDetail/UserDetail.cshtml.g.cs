#pragma checksum "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "03597b28b9e5a5a19b0d8ccdd4d3d4342e825ef73d3fa7ae433e5da8e6c9df94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserDetail_UserDetail), @"mvc.1.0.view", @"/Views/Shared/Components/UserDetail/UserDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Practice\.Net\MVC\MVCViewComponent\Views\_ViewImports.cshtml"
using MVCViewComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Practice\.Net\MVC\MVCViewComponent\Views\_ViewImports.cshtml"
using MVCViewComponent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"03597b28b9e5a5a19b0d8ccdd4d3d4342e825ef73d3fa7ae433e5da8e6c9df94", @"/Views/Shared/Components/UserDetail/UserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d838c44696cb74f5d3ad3af95bcdea6051ae7fa2b07713ee785aad7040f94980", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UserDetail_UserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCViewComponent.Models.ViewModels.UserDetailViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>اطلاعات کاربر</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "E:\Practice\.Net\MVC\MVCViewComponent\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCViewComponent.Models.ViewModels.UserDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
