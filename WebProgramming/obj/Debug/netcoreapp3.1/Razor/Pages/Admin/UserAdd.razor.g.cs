#pragma checksum "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d645b6f5ef4af38f8c58f2facd95a2d61f4f7e"
// <auto-generated/>
#pragma warning disable 1591
namespace WebProgramming.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using WebProgramming.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/user/addUser")]
    public partial class UserAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UserAdd</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                 signUpModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                             HandledSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n");
#nullable restore
#line 10 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
     if (errorMessages.Count > 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "validation");
                __builder2.AddAttribute(13, "style", "display:inline");
                __builder2.AddMarkupContent(14, "\n");
#nullable restore
#line 13 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
             foreach (var item in errorMessages)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(15, "                ");
                __builder2.OpenElement(16, "p");
                __builder2.AddAttribute(17, "class", "text-danger");
                __builder2.AddContent(18, 
#nullable restore
#line 15 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                        item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n");
#nullable restore
#line 16 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n");
#nullable restore
#line 18 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(22, "\n    ");
                __builder2.AddMarkupContent(23, "<style>\n        .validation {\n            display: none;\n        }\n    </style>\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.AddMarkupContent(27, "<label class=\"form-control-label\">Username : </label><br>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                                     signUpModel.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signUpModel.UserName = __value, signUpModel.UserName))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signUpModel.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "<br>\n        ");
                __builder2.AddMarkupContent(34, "<label class=\"form-control-label\">Password : </label><br>\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                                     signUpModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signUpModel.Password = __value, signUpModel.Password))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signUpModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "<br>\n\n        ");
                __builder2.AddMarkupContent(41, "<label class=\"form-control-label\">ConfrimPassword : </label><br>\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                                     signUpModel.ConfrimPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signUpModel.ConfrimPassword = __value, signUpModel.ConfrimPassword))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signUpModel.ConfrimPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "<br>\n\n        ");
                __builder2.AddMarkupContent(48, "<label class=\"form-control-label\">Email : </label><br>\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                                     signUpModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signUpModel.Email = __value, signUpModel.Email))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signUpModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "<br>\n\n        ");
                __builder2.AddMarkupContent(55, "<label class=\"form-control-label\">TelphoneNumber : </label><br>\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                                     signUpModel.TelphoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signUpModel.TelphoneNumber = __value, signUpModel.TelphoneNumber))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signUpModel.TelphoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "<br>\n\n        ");
                __builder2.AddMarkupContent(62, "<label class=\"form-control-label\">Role : </label><br>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n\n    ");
                __Blazor.WebProgramming.Pages.Admin.UserAdd.TypeInference.CreateInputSelect_0(__builder2, 64, 65, "form-control", 66, "Please Enter", 67, 
#nullable restore
#line 47 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
                                                                       role

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => role = __value, role)), 69, () => role, 70, (__builder3) => {
                    __builder3.AddMarkupContent(71, "\n        ");
                    __builder3.AddMarkupContent(72, "<optgroup label=\"Please Enter\">\n            <option value=\"Admin\">Admin</option>\n            <option value=\"Client\">Client</option>\n        </optgroup>\n    ");
                }
                );
                __builder2.AddMarkupContent(73, "\n    <br>\n    ");
                __builder2.AddMarkupContent(74, "<button class=\"btn btn-primary\" type=\"submit\">Add User</button>\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Cumali\Desktop\WebProgramming-master\WebProgramming\Pages\Admin\UserAdd.razor"
       
    string role;
    SignUpModel signUpModel = new SignUpModel();
    List<string> errorMessages = new List<string>();
    private async Task HandledSubmit()
    {
        errorMessages.Clear();
        IdentityUser user = new IdentityUser();
        user.UserName = signUpModel.UserName;
        user.Email = signUpModel.Email;
        user.SecurityStamp = "TolgaEmirFatih";
        user.PhoneNumber = signUpModel.TelphoneNumber;

        var addedUser = await userManager.CreateAsync(user, signUpModel.Password);

        if (addedUser.Errors.Count() > 0)
        {
            foreach (var item in (await userManager.CreateAsync(user, signUpModel.Password)).Errors)
            {
                errorMessages.Add(item.Description);
            }
        };
        if (addedUser.Succeeded)
        {
            await userManager.AddToRoleAsync(user, role);
            NavManager.NavigateTo("/admin/user");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
    }
}
namespace __Blazor.WebProgramming.Pages.Admin.UserAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
