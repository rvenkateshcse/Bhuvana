#pragma checksum "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9320a11160060fe36d57c5beaaaf8dce62feae35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\_ViewImports.cshtml"
using LoginForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\_ViewImports.cshtml"
using LoginForm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9320a11160060fe36d57c5beaaaf8dce62feae35", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cb94b32e36379263577bbad0052c3300de2053", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginForm.Models.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml"
  

    ViewBag.Title = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script language=""javascript"">

    function display() {

        if ($(""#txtusername"").attr(""value"") == """") {

            alert(""Please Enter your UserName."");

            return false;

        } else if ($(""#txtuserpassword"").attr(""value"") == """") {

            alert(""Please enter UserPassword."");

            return false;

        }

        alert(""Login Successfully"");

        return true;

    }

</script>

<h3>Simple Web API Login Form </h3>

");
#nullable restore
#line 37 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home"))

{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table width=\"40%\" cellpadding=\"1\" cellspacing=\"5\">\r\n\r\n        <tr>\r\n\r\n            <td colspan=\"2\" style=\"color:#f00;font-size:larger\">");
#nullable restore
#line 45 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml"
                                                           Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n\r\n            <td align=\"right\">User Name :</td>\r\n\r\n            <td>");
#nullable restore
#line 53 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.UserName, new { @style = "width:200px", @id = "txtusername" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n            <td align=\"right\">User Password :</td>\r\n\r\n            <td>");
#nullable restore
#line 60 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml"
           Write(Html.PasswordFor(m => m.UserPassword, new { @style = "width:200px", @id = "txtuserpassword" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n        <tr>\r\n\r\n            <td colspan=\"2\">\r\n\r\n                <input type=\"submit\" value=\"Login\" title=\"login\" onclick=\" display();\" />\r\n\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n");
#nullable restore
#line 75 "C:\Users\rvenk\Source\Repos\Bhuvana\LoginForm\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginForm.Models.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
