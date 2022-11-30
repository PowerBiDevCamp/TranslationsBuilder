## **Translations Builder Installation Guide**

Before installing **Translations Builder**, ensure your computer meets
the following requirements.

1.  64-bit Version of Windows 10 or Windows 11

2.  64-bit version of Power BI Desktop (November 2022 or later)

3.  .NET 6 Runtime for Desktop Applications ([download install
    files](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-6.0.8-windows-x64-installer)).

To install **Translations Builder**, begin by downloading
[**TranslationsBuilderInstall.msi**](https://github.com/PowerBiDevCamp/TranslationsBuilder/raw/main/SetupFiles/TranslationsBuilderInstaller.msi).

When you click the download link, the browser should download the MSI
file named **TranslationsBuilderInstall.msi** and place this file in the
local **Downloads** folder. The browser should eventually show that
**TranslationsBuilderInstall.msi** has been downloaded and it should
provide a context menu of actions. The following screenshot shows what
this experience looks like when using Google Chrome. Other browsers will
provide a different experience.

<img src="./images/InstallationGuide/media/image1.png"
style="width:3.92006in;height:1.5in" />

Note that the installation file named **TranslationsBuilderInstall.msi**
has not been signed using Authenticate to verify the authenticity of the
code manufacturer. We are in the process of obtaining a code-signing
certificate for Power BI Dev Camp which will make the installation
process smoother. But for now, there are some extra steps to go through
during installation because the Window operating system cannot verify
who the publisher is.

Open to context menu for **TranslationsBuilderInstall.msi** and select
**Open** to run the installation program.

<img src="./images/InstallationGuide/media/image2.png"
style="width:3.59325in;height:1.51667in" />

Because TranslationsBuilderInstall.msi is not signed with a code-signing
certificate, you will be present with the following dialog with the
title **Windows protected your PC dialog**. Click the **More info** link
to continue.

<img src="./images/InstallationGuide/media/image3.png"
style="width:3.72222in;height:2.53333in" />

The next screen display the name of the App as
**TranslationsBuilderInstall,msi** and indicate that the publisher is
unknown. Click the **Run anyway** button to begin the installation
process.

<img src="./images/InstallationGuide/media/image4.png"
style="width:2.56667in;height:1.78401in" />

When you see the **Welcome** screen of the **Translations Builder Setup
Wizard**, click **Next** to continue,

<img src="./images/InstallationGuide/media/image5.png"
style="width:2.70359in;height:2.21755in"
alt="Graphical user interface, text, application, email Description automatically generated" />

On the **Select Installation Folder** page, accept the default Folder
value and click **Next**.

. <img src="./images/InstallationGuide/media/image6.png"
style="width:3.55722in;height:2.91772in"
alt="Graphical user interface, text, application Description automatically generated" />

Do not change default **Folder** path value of **C:\Program Files\Power
BI Dev Camp\Translations Builder\\**. That’s because the installation
program copies a file named into the special folder for external tools.
adds

Xxx

<img src="./images/InstallationGuide/media/image7.png"
style="width:4.39805in;height:3.60739in"
alt="Graphical user interface, text, application, email Description automatically generated" />

Xxxx

Xxxx

<img src="./images/InstallationGuide/media/image8.png"
style="width:3.69167in;height:2.65716in" />

X

<img src="./images/InstallationGuide/media/image9.png"
style="width:3.47466in;height:2.85in" />

Open Power BI Desktop, Navigate to the **External Tools** tab.

<img src="./images/InstallationGuide/media/image10.png"
style="width:5.39167in;height:0.91658in" />

You should see

<img src="./images/InstallationGuide/media/image11.png"
style="width:3.7in;height:1.22773in" />

Xxxxx

<img src="./images/InstallationGuide/media/image12.png"
style="width:4.95in;height:2.252in" />

Your done.

Troubleshooting

Installation should create this

C:\Program Files\Power BI Dev Camp\Translations Builder

Here is what it looks like.

C:\Program Files\Power BI Dev Camp\Translations Builder

<img src="./images/InstallationGuide/media/image13.png"
style="width:5.28333in;height:2.4683in" />

The installation program copies a special file named
translationsbuilder.pbitool.json into a folder at the path of

C:\Program Files (x86)\Common Files\Microsoft Shared\Power BI
Desktop\External Tools to register Translations Builder as an external
tool which can be integrated with Power BI Desktop.

<img src="./images/InstallationGuide/media/image14.png"
style="width:5.91667in;height:1.79472in" />

There is also a file named l

<img src="./images/InstallationGuide/media/image15.png"
style="width:5.95833in;height:1.72984in" />

Upgrade

You can install a newer version just like you did the original install.
