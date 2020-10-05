#pragma checksum "C:\Users\KholmamadovN\source\repos\ElectOcher\Views\Tablo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ca63844f25203ac07dec2ebb5c5f82d203770a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablo_Index), @"mvc.1.0.view", @"/Views/Tablo/Index.cshtml")]
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
#line 1 "C:\Users\KholmamadovN\source\repos\ElectOcher\Views\_ViewImports.cshtml"
using ElectrOcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KholmamadovN\source\repos\ElectOcher\Views\_ViewImports.cshtml"
using ElectrOcher.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ca63844f25203ac07dec2ebb5c5f82d203770a", @"/Views/Tablo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f1cfa3a7cd8a26a29a3914955870c58a066422", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\KholmamadovN\source\repos\ElectOcher\Views\Tablo\Index.cshtml"
  
    ViewData["Title"] = "Информационное табло";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row justify-content-center mt-4"">
            <div class=""col-12 rounded-lg border border-primary mb-4 text-center"">
                <h1><b>ИНФОРМАЦИОННОЕ ТАБЛО</b></h1>
            </div>

            <div id=""CallTalonBlock"" class=""col-4 rounded-lg border border-primary mr-4 p-3 text-center"" style=""height: 300px; font-size: 30pt; background-color: #d8f4e7"">
                <b id=""callText""></b> <br><b id=""ColRow""></b>
            </div>

            <div id=""talon_list"" class=""col-7 rounded-lg border border-primary mb-2 p-2 text-center"" style=""background-color: #d8f4e7"">
                <div id=""talons"" class=""col-12 rounded-lg border border-primary mb-2 p-1 text-center"" style=""background-color: #f2e5c7""></div>
            </div>

        </div>

    </div>



    

<script src=""js/signalr/dist/browser/signalr.min.js""></script>
<script>
    const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/chat"")
        .b");
            WriteLiteral(@"uild();
    let connectionId = """";
    
    // Добавление талона в список очередей
    hubConnection.on(""AddTalon"", function (message, id) {

        var divTalons = document.querySelector(""div#talons"");
        var newDivTalons = divTalons.cloneNode(true);
        newDivTalons.id = ""talon"" + id;
        newDivTalons.appendChild(document.createTextNode(message));

        
        document.getElementById(""talon_list"").appendChild(newDivTalons);

    });

    //Вызывается талон
    hubConnection.on(""CallTalon"", function (message) {

        // Удаление элемента из списка талонов
        document.getElementById(""talon"" + message).remove();

        // создает элемент <p> для сообщения пользователя
        document.getElementById(""callText"").innerText = ""Вызывается клиент с талоном""
        let elem = document.getElementById(""ColRow"").textContent =  message;
        document.getElementById(""CallTalonBlock"").appendChild(elem);

    });

    // Количество необслуженных клинтов
    hub");
            WriteLiteral(@"Connection.on(""TalonCount"", function (message) {

        if (message == 0) {
            document.getElementById(""callText"").innerText = ""Ожидайте вызова оператора""
            document.getElementById(""ColRow"").innerText = """"
        }

    });



    hubConnection.start();

</script>

");
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
