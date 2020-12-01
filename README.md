# Statiq_TestProfileSite
Blog/Profile site to test the "Statiq" Static Site Generator (similar to my Hugo version)

This is similar to my test of the Hugo Statis Site Generatot.
Again, is is an experiment in building and hosting an ultra-cheap website. The goal is to get it as close to free as possible, while using a solid development tool chain. I'll try keep this readme up to date with the latest tooling details.



## Current Technologies and Tool Chains

Hosting Stack: JAM Stack

- Using github.com to host static pages, built with a static site generator.

- Netlify.com to provide a astatic IP address

- [Todo] LetsEncrypt to provide https encryption certificate



Static page/site Generation:

- Statiq



Source Control:

- Git on Github.com (https://github.com/kohlmann0/Statiq_TestProfileSite.git)



Build pipeline

- Windows 10 - Visual Studio Code - dotNet run

- Github - Source Control checkin

- Netlify monitors Github, and kicks of a continuous integration build and host



Editor/IDE:

- Windows 10 - Visual Studio Code (but could easily be done with Notepad++ or Sublime)



Summary of findings:
Statiq is different than Hugo in that, Hugo is a stand-alone program, while Statiq is a Nuget package (.dlls) within your solution. In Satatiq, you add content to an "Input" folder, do a commandline "dotnet run" for the whole project, and it generates the output as part of the running program. 

In a way, I guess they are kind of the same thing, the running program generates the static content. The difference being that Statiq's DLL's live within the project itself, and the Hugo engine is installed completely seperate from the project being worked on.

There are advantages to both approaches, but I think one of the biggest, is that Statiq's version-control is built in (whatever you include in the project is what get built). You could even have multiple versions running in parallel. Where as, an update to your Hugo installation changes everything, and could potentially break the build. Secondarily, you can guarantee everyone on your team has the same version of Statiq "installed"... because there is no install. It a DLL that sits within your Source Control.

Additionally, for some reason I find debugging Statiq a bit more intuitive than Hugo. Hugo was pretty easy to work with, but whenever I made a mistake, it was tougher to debug when the build broke. I work in the .NET world on a daily basis, so debugging withing visual studio code and writing in C#/Razor was much more familiar to me than GO/Hugo. Less context switching and more productivity. At least it was for me.