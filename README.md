# Introdução ao dotnet core

1 - Para instalar do framework é necessário entrar no site: 

https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.201-windows-x64-installer
--------------------------------------------  -------------------  ----------  ----------------------
2 - Após instalar faça o teste via CMD: "dotnet --version

5.0.201
--------------------------------------------  -------------------  ----------  ----------------------
3 - Para saber quais são os templates disponíveis, é só digitar:

dotnet new

Templates                                     Short Name           Language    Tags
--------------------------------------------  -------------------  ----------  ----------------------
Console Application                           console              [C#],F#,VB  Common/Console
Class library                                 classlib             [C#],F#,VB  Common/Library
WPF Application                               wpf                  [C#],VB     Common/WPF
WPF Class library                             wpflib               [C#],VB     Common/WPF
WPF Custom Control Library                    wpfcustomcontrollib  [C#],VB     Common/WPF
WPF User Control Library                      wpfusercontrollib    [C#],VB     Common/WPF
Windows Forms App                             winforms             [C#],VB     Common/WinForms
Windows Forms Control Library                 winformscontrollib   [C#],VB     Common/WinForms
Windows Forms Class Library                   winformslib          [C#],VB     Common/WinForms
Worker Service                                worker               [C#],F#     Common/Worker/Web
Unit Test Project                             mstest               [C#],F#,VB  Test/MSTest
NUnit 3 Test Project                          nunit                [C#],F#,VB  Test/NUnit
NUnit 3 Test Item                             nunit-test           [C#],F#,VB  Test/NUnit
xUnit Test Project                            xunit                [C#],F#,VB  Test/xUnit
Razor Component                               razorcomponent       [C#]        Web/ASP.NET
Razor Page                                    page                 [C#]        Web/ASP.NET
MVC ViewImports                               viewimports          [C#]        Web/ASP.NET
MVC ViewStart                                 viewstart            [C#]        Web/ASP.NET
Blazor Server App                             blazorserver         [C#]        Web/Blazor
Blazor WebAssembly App                        blazorwasm           [C#]        Web/Blazor/WebAssembly
ASP.NET Core Empty                            web                  [C#],F#     Web/Empty
ASP.NET Core Web App (Model-View-Controller)  mvc                  [C#],F#     Web/MVC
ASP.NET Core Web App                          webapp               [C#]        Web/MVC/Razor Pages
ASP.NET Core with Angular                     angular              [C#]        Web/MVC/SPA
ASP.NET Core with React.js                    react                [C#]        Web/MVC/SPA
ASP.NET Core with React.js and Redux          reactredux           [C#]        Web/MVC/SPA
Razor Class Library                           razorclasslib        [C#]        Web/Razor/Library
ASP.NET Core Web API                          webapi               [C#],F#     Web/WebAPI
ASP.NET Core gRPC Service                     grpc                 [C#]        Web/gRPC
dotnet gitignore file                         gitignore                        Config
global.json file                              globaljson                       Config
NuGet Config                                  nugetconfig                      Config
Dotnet local tool manifest file               tool-manifest                    Config
Web Config                                    webconfig                        Config
Solution File                                 sln                              Solution
Protocol Buffer File                          proto                            Web/gRPC

4 - Em nosso primeiro projeto criamo um projeto console application:

dotnet new console
--------------------------------------------  -------------------  ----------  ----------------------
5 - Pronto o projeto Console Application foi criado. 
--------------------------------------------  -------------------  ----------  ----------------------
6 - Para a execução deste projeto está sendo utilizado com Visual Studio Code, que pode ser baixado através da seguinte URL:

https://code.visualstudio.com/
--------------------------------------------  -------------------  ----------  ----------------------
7 - Foram instalados os seguintes plugins:

- C#
- C# Extensions




