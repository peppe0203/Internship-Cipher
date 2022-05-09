#pragma checksum "C:\Github\Internship-Cipher\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38e8ade997cdf41e748211aa2cdf01f3b1c80323"
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
#line 1 "C:\Github\Internship-Cipher\Views\_ViewImports.cshtml"
using Internship_Cipher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Github\Internship-Cipher\Views\_ViewImports.cshtml"
using Internship_Cipher.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38e8ade997cdf41e748211aa2cdf01f3b1c80323", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ffc882e4646410f64108f5f24edd519f4d1927", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Github\Internship-Cipher\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>
        Test different functions via the buttons.
        </br>
        One button does't work properly but that is the intention. This can clarify the difference in monitoring.
    </p>
");
            WriteLiteral(@"    <button type=""button"" class=""btn btn-primary"" onclick=""testRequest(1)"">Correct API request</button>
    <button type=""button"" class=""btn btn-primary"" onclick=""testRequest(10293029)"">False API request</button>
    </br>
    <hr style=""width: 60%; margin-top: 30px"">
    <div class=""form-group row d-flex justify-content-center"">
        <input class=""form-control"" type=""url"" id=""webName"" name=""webName"" placeholder=""URL: https://example.com"" pattern=""https://.*"" style=""width: 25%"">
        <button type=""button"" class=""btn btn-primary ml-2"" onclick=""goToWebsite()"">Go to webpage</button>
        <div class=""custom-control custom-switch mt-2 ml-2"">
            <input type=""checkbox"" class=""custom-control-input"" id=""customSwitch1"" onclick=""switchState()"" value=""True"" checked>
            <label class=""custom-control-label"" for=""customSwitch1"">new tab</label>
        </div>
    <div>
</div>

<script>
    function switchState(){
        let customSwitch1 = document.getElementById(""customSwitch1"")
 ");
            WriteLiteral(@"       if (customSwitch1.value == ""True"") { 
            customSwitch1.value = ""False""
        } 
        else {
            customSwitch1.value = ""True""
        };
    };
    // API fetch request.
    function testRequest(number) {
            fetch('https://jsonplaceholder.typicode.com/todos/' + number)
                .then(function (response) {
                    if (!response.ok) {
                        alert(""[!] ERROR: \n"" + ""\nCode: "" + response.status);
                        console.log(""[!] ERROR occurred in request: "" + response.status);
                        throw Error(response.statusText);
                    }
                    return response.json();
                })
                .then(function (myJson) {
                    console.log(myJson);
                    alert(""The API data received: \n"" + ""\nID: "" + myJson.id + ""\nTitle: "" + myJson.title + ""\nCompleted: "" + myJson.completed);
                })
                .catch(function (error) {
         ");
            WriteLiteral(@"           console.log(""[V] ERROR caught"");
                });
    };
    // Used to go to an website
    function goToWebsite() {
        let webNameValue = document.getElementById(""webName"").value
        let checkBox = document.getElementById(""customSwitch1"").value
        if (webNameValue != '' && webNameValue.startsWith(""https://"") && webNameValue.includes(""."")) {
            if (checkBox == ""True"") {
                window.open(webNameValue, ""_blank"");
            }
            else{
                window.location.href = webNameValue;
            };
            console.log(""Going to: "" + webNameValue)
        }
        else {
            console.log(""[!] ERROR, need to use a valide URL"")
        };
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
