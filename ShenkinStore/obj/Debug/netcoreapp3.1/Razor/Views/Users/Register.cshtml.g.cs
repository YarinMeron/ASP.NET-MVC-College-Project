#pragma checksum "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5dc880a7bad1d541d8729a7c51f41ed716d998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Register), @"mvc.1.0.view", @"/Views/Users/Register.cshtml")]
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
#line 1 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5dc880a7bad1d541d8729a7c51f41ed716d998", @"/Views/Users/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShenkinStore.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<fieldset>\r\n    <legend>\r\n        User Registartion\r\n    </legend>\r\n");
#nullable restore
#line 10 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
     using (Html.BeginForm("Register", "Users", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 15 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.LabelFor(model => Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 18 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.TextBoxFor(model => Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n\r\n        </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserName, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 31 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.LabelFor(model => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 34 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.TextBoxFor(model => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n\r\n        </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 47 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.LabelFor(model => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 50 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.PasswordFor(model => Model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n\r\n        </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 63 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.LabelFor(model => Model.ConfirmedPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 66 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.PasswordFor(model => Model.ConfirmedPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n\r\n        </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.ConfirmedPassword, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 79 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.LabelFor(model => Model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 82 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.TextBoxFor(model => Model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n        </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 89 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </td>
    </tr>
    <tr>
        <td>

        <td>
            <table>
                <tr>
                    <td>
                        <input type=""submit"" value=""Register"" />
                    </td>
                    <td>
                        <input type=""reset"" value=""Reset"" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
          
            ");
#nullable restore
#line 111 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"
       Write(Html.ValidationMessage("Error", null, new { @class = "alert alert-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 116 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Register.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</fieldset>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShenkinStore.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
