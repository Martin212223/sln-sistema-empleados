#pragma checksum "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c36d69e59b55eab93a662b83b98454fbada2f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Eliminar), @"mvc.1.0.view", @"/Views/Empleado/Eliminar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c36d69e59b55eab93a662b83b98454fbada2f06", @"/Views/Empleado/Eliminar.cshtml")]
    #nullable restore
    public class Views_Empleado_Eliminar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebEmpleado.Models.Empleado>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
  
    ViewData["Title"] = "Eliminar Empleado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    <h2>Administración de empleados</h2>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n    <h2>Empleado: ");
#nullable restore
#line 12 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
                           Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Legajo: ");
#nullable restore
#line 12 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
                                                   Write(Model.Legajo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>¿Desea eliminar este empleado?</p>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
     using (Html.BeginForm("Eliminar", "Empleado", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 18 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 19 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 23 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 24 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 28 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 29 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 33 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayNameFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 34 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 38 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 39 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n            <span>");
#nullable restore
#line 43 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 44 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
             Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral("                <input type=\"submit\" action=\"Eliminar\" />\r\n");
#nullable restore
#line 49 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
   Write(Html.ActionLink("Volver", "Index", "Empleado"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Alternativa\Desktop\Último curso\15 - tp individual empleados 31-1\slnSistEmpleado\SistemaWebEmpleado\Views\Empleado\Eliminar.cshtml"
                                                       

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebEmpleado.Models.Empleado> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
