#pragma checksum "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ceedab6d854157cb086de9e45ce504a6d696894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ceedab6d854157cb086de9e45ce504a6d696894", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb195832d57fd319cc59a703a57088508d9f1732", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все автомобили</h1>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
Write(Model.CurrCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 4 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
       
        foreach (var car in Model.AllCars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4\">\r\n            <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src =\"", 214, "\"", 229, 1);
#nullable restore
#line 8 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
WriteAttributeValue("", 221, car.img, 221, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 230, "\"", 245, 1);
#nullable restore
#line 8 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
WriteAttributeValue("", 236, car.name, 236, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <h2>");
#nullable restore
#line 9 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
           Write(car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 10 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
          Write(car.shortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Цена: ");
#nullable restore
#line 11 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
                Write(car.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p><a class=\"btn btn-warning\" href = \"#\">Подробнее</a></p>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\User\source\repos\WebApplication7\WebApplication7\Views\Cars\List.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
