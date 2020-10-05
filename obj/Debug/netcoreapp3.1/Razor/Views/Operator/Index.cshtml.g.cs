#pragma checksum "C:\Users\KholmamadovN\source\repos\ElectOcher\Views\Operator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84709d481aac227bc53f02e64b647b9e8a3f4fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operator_Index), @"mvc.1.0.view", @"/Views/Operator/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84709d481aac227bc53f02e64b647b9e8a3f4fdf", @"/Views/Operator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f1cfa3a7cd8a26a29a3914955870c58a066422", @"/Views/_ViewImports.cshtml")]
    public class Views_Operator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\KholmamadovN\source\repos\ElectOcher\Views\Operator\Index.cshtml"
  
    ViewData["Title"] = "Оператор";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row justify-content-center mt-4"">
            <div id=""call_talon"" class=""col-7 rounded-lg border border-primary mb-2 text-center"">
                <h1><b>ОПЕРАТОР</b></h1>
            </div>

            <div id=""served"" class=""col-7 rounded-lg border border-primary mb-2 text-center"" style=""height: 300px; font-size: 50pt;"">
                <b id=""servedText""></b><br><b id=""servedNomer""></b>
            </div>

            <div class=""row col-7"">

                <div class=""col rounded-lg border border-primary ml-2"">Клиентов: </div>
                <div class=""col rounded-lg border border-primary ml-2"">Обслужено: </div>
                <div id=""t_wait"" class=""col rounded-lg border border-primary ml-2"">Ожидают: <b id=""talonCount""></b></div>

            </div>

            <div class=""row col-7 mt-4"">
                <div class=""col text-center""><button id=""callButton"" type=""button"" class=""btn btn-primary"" style=""width: 200px"">Вызов</button>");
            WriteLiteral(@"</div>

                <div class=""col text-center""><button id=""nextButton"" type=""button"" class=""btn btn-success"" style=""width: 200px"">Обслужен</button></div>
            </div>

        </div>

    </div>    


    

        <script src=""js/signalr/dist/browser/signalr.min.js""></script>
        <script>
            const hubConnection = new signalR.HubConnectionBuilder()
                .withUrl(""/chat"")
                .build();
            let connectionId = """";
            document.getElementById(""nextButton"")
                .addEventListener(""click"", function (e) {
                    e.preventDefault();
                    document.getElementById(""nextButton"").disabled = true;

                    const data = new FormData();
                    data.append(""connectionId"", connectionId);

                    fetch(""operator/next"", {
                        method: ""POST"",
                        body: data
                    })
                        .catch(error => con");
            WriteLiteral(@"sole.error(""Error: "", error));
                });
            //Вызов талона
            document.getElementById(""callButton"")
                .addEventListener(""click"", function (e) {
                    e.preventDefault();

                    document.getElementById(""nextButton"").disabled = false;

                    document.getElementById(""servedText"").innerText = ""Вызван клиент с талоном""
                    const data = new FormData();
                    data.append(""connectionId"", connectionId);

                    fetch(""operator/call"", {
                        method: ""POST"",
                        body: data
                    })
                        .catch(error => console.error(""Error: "", error));
                });

            // получение сообщения количество необслуженных
            hubConnection.on(""TalonCount"", function (message) {

                if (message != 0) {
                    document.getElementById(""callButton"").disabled = false;
           ");
            WriteLiteral(@"     } 
                else {
                    document.getElementById(""callButton"").disabled = true;
                    
                    document.getElementById(""servedText"").innerText=""""
                    document.getElementById(""servedNomer"").innerText = """"
                }

                // меняет сообщения
                let elem = document.getElementById(""talonCount"").textContent = message;
                document.getElementById(""t_wait"").appendChild(elem);
                


            });

            // получение: Обслуживается талон
            hubConnection.on(""CallTalon"", function (message) {

                // меняет сообщения
                let elem = document.getElementById(""servedNomer"").textContent = message;
                document.getElementById(""served"").appendChild(elem);

            });


            hubConnection.start().then(() => {
                // после соединения получаем id подключения
                console.log(hubConnection.conn");
            WriteLiteral("ectionId);\r\n                connectionId = hubConnection.connectionId;\r\n            });\r\n        </script>\r\n\r\n\r\n");
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
