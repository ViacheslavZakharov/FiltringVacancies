#pragma checksum "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed5125b2a4ac45bcacffc0247bedae0d7583be0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\_ViewImports.cshtml"
using FiltringVacancies;

#line default
#line hidden
#line 2 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\_ViewImports.cshtml"
using FiltringVacancies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed5125b2a4ac45bcacffc0247bedae0d7583be0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f534ceb8e252013f31d2da7b0da7d067a15a0026", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vacancy>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
 foreach (var vacancy in Model)
{

#line default
#line hidden
            BeginContext(107, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(116, 12, false);
#line 9 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
   Write(vacancy.Name);

#line default
#line hidden
            EndContext();
            BeginContext(128, 36, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n    <p>Зарплата: ");
            EndContext();
            BeginContext(165, 25, false);
#line 11 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
            Write(vacancy.Salary.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(190, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
     if (vacancy.Address != null)
    {
        

#line default
#line hidden
#line 14 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
         if (vacancy.Address.City != null)
        {

#line default
#line hidden
            BeginContext(293, 22, true);
            WriteLiteral("            <p>Город: ");
            EndContext();
            BeginContext(316, 20, false);
#line 16 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
                 Write(vacancy.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(336, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 17 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
             if(vacancy.Address.Street != null)
            {

#line default
#line hidden
            BeginContext(406, 22, true);
            WriteLiteral("            <p>Улица: ");
            EndContext();
            BeginContext(429, 22, false);
#line 19 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
                 Write(vacancy.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(451, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
                 if(vacancy.Address.Building != null)
                {

#line default
#line hidden
            BeginContext(531, 58, true);
            WriteLiteral("                    <p>дом. vacancy.Address.Building</p>\r\n");
            EndContext();
#line 23 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 23 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#line 24 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(634, 10, true);
            WriteLiteral("       <p>");
            EndContext();
            BeginContext(645, 27, false);
#line 26 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
     Write(vacancy.Address.Description);

#line default
#line hidden
            EndContext();
            BeginContext(672, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 27 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#line 30 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
     if (vacancy.KeySkills.Count() != 0)
    {

#line default
#line hidden
            BeginContext(738, 47, true);
            WriteLiteral("        <p>Ключевые навыки:</p>\r\n        <ul>\r\n");
            EndContext();
#line 34 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
             foreach (var skill in vacancy.KeySkills)
            {

#line default
#line hidden
            BeginContext(855, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(876, 16, false);
#line 36 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
               Write(skill.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(892, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 37 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(914, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 39 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#line 39 "C:\Users\v_zah\OneDrive\Desktop\учеба\1магистратура\аксенов\проектный практикум\WT\FiltringVacancies\FiltringVacancies\Views\Home\Index.cshtml"
     

}

#line default
#line hidden
            BeginContext(941, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vacancy>> Html { get; private set; }
    }
}
#pragma warning restore 1591