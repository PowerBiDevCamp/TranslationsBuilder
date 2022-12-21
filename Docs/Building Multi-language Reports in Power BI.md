# Building Multi-language Reports in Power BI

Power BI provides Internationalization and localization features which
make it possible to build multi-language reports. For example, you can
design a Power BI report that renders in English for some users while
rendering in Spanish, German, Japanese or Hindi for other users. If a
company or organization has the requirement of building Power BI reports
that support multiple languages, it's not necessary to clone and
maintain a separate PBIX project file for each language. Instead, they
can increase reuse and lower report maintenance by designing and
implementing a strategy for building multi-language reports.

This article has been created to provide guidance and to teach the
skills required to build Power BI reports that support multiple
languages. You need to learn a few key concepts about how Power BI
translations work and how to automate repetitive tasks that would take
forever to complete manually. An essential part of this guidance is
based on using an external tool named [Translations
Builder](https://github.com/PowerBiDevCamp/TranslationsBuilder) that’s
been created for content creators using Power BI Desktop. Once you
understand how all the pieces fit together, you’ll be able to build
multi-language reports for Power BI using a strategy that is reliable,
predictable and scalable.

### Multi-language Report Live Demo

This article is accompanied a [**live
demo**](https://multilanguagereportdemo.azurewebsites.net/) based on a
single PBIX file solution named
[**TranslationsBuilderLiveDemo.pbix**](https://github.com/PowerBiDevCamp/TranslationsBuilder/raw/main/LiveDemo/TranslationsBuilderLiveDemo.pbix).
This live demo shows the potential of building multi-language reports
for Power BI. The report in the live demo supports English, Spanish,
French, German, Dutch, Italian, Portuguese, Greek, Russian, Japanese,
Chinese, Hindi, Hebrew and Afrikaans. You can test out the live demo and
the experience a Power BI report that support over a dozen secondary
languages by navigating the following URL.

- [**https://multilanguagereportdemo.azurewebsites.net**](https://multilanguagereportdemo.azurewebsites.net)

When you test out the live demo, experiment by clicking links in the
left navigation to reload the report using different langauges. For
example, click on the link with the caption of **German (Deutsch)**.
When you do, you will see the report load with German translations as
shown in the following screenshot.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image1.png"
style="width:5.45447in;height:2.68in"
alt="A picture containing chart Description automatically generated" />

The live demo is based on a custom web application that uses Power BI
embedding. When you click on a link in the left navigation, there is
JavaScript behind this web page that responds by explicitly reloading
the report using the language of German intead of English. You can see
that all the text-based elements for the entire report are now displayed
with their German translations instead of with the default English
translations.

### Power BI Support for Translations and Localization

The primary localization feature in Power BI used to build
multi-language reports is known as **metadata translations**. Power BI
inherited this feature from its predecessor, Analysis Services, which
introduced metadata translations to add localization support to the data
model associated with a tabular database or a multidimensional database.
In Power BI, metadata translations support has been integrated at the
dataset level.

A metadata translation represents the property for a dataset object
that's been translated for a specific language. Consider a simple
example. If your dataset contains a table with an English name of
**Products**, you can add translations for the **Caption** property of
this table object to provide alternative names for when the report is
rendered in a different language. The types of dataset objects that
support metadata translations include **Table**, **Column**,
**Measure**, **Hierarchy** and **Hierarchy** **Level**. In addition to
the **Caption** property which tracks an object's display name, dataset
objects also support adding metadata translations for two other
properties which are **Description** and **DisplayFolder**.

Power BI reports and datasets that support multiple languages can only
run in workspaces which are associated a dedicated capacity created
using Power BI Premium or the Power BI Embedded Service. That means
multi-language reports will not load correctly when launched from a
workspace in the shared capacity. If you are working in a Power BI
workspace that does not display a diamond indicating it’s a Premium
workspace, you will find that multi-language reports don’t work as
expected because there is no support for loading translations from
secondary languages.

Another critical point to understand is that the Power BI support for
metadata translations only applies to datasets. Neither Power BI Desktop
nor the Power BI Service provide any support for storing or loading
translations for text values stored as part of the report layout.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image2.png"
style="width:3.12857in;height:1.11105in" />

Think about a common scenario where you add a textbox or a button to a
Power BI report and then you type in literal text for a string value
displayed to the user. That text value is stored in the report layout
and cannot be localized. Therefore, you must avoid using textboxes and
buttons with literal text values stored in the report layout. As a
second example, page tabs in a Power BI report are also problematic
because their display names cannot be localized. Therefore, you must
design multi-language reports so that page tabs are hidden and never
displayed to the user.

### Understanding the Three Types of Translations

When it comes to localizing Power BI artifacts such as datasets and
reports, there are three different types of translations and you must be
able distinguish between them. These are the three types of translations
you should understand.

- Metadata Translations

- Report Label Translations

- Data Translations

Now, let’s examine all three types in a little more depth.

**Metadata translations** provides localized values for dataset object
properties. The object types which support metadata translation include
tables, columns, measures, hierarchies and hierarchy levels. The
following screenshot shows how metadata translations provide German
names for the measures displayed in card visuals.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image3.png"
style="width:6.6in;height:0.47588in" />

Metadata translations are also used to display column names and measure
names in tables and matrices.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image4.png"
style="width:6.98in;height:1.25963in" />

Metadata translations are the easiest to create, manage and integrate
into a Power BI report. By leveraging the machine translation features
of Translations Builder, you can add all the metadata translations you
need to build and test a Power BI report in a matter of seconds. As you
will discover, adding metadata translations to your dataset is fairly
straight-ahead and an essential first step. However, metadata
translations rarely provide a complete solution by themselves. A
complete solution will typically require going further to localize
report labels.

**Report label translations** provide localized values for text elements
on a report that are not directly associated with a dataset object.
Examples of report labels include the report title, section headings and
button captions. Here are a few examples of report label translations in
the live demo with the report title and the captions of navigation
buttons.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image5.png"
style="width:7.20667in;height:1.15413in" />

Report label translations are harder to create and manage than metadata
translations because Power BI provides no built-in feature to track or
integrate them. Translations Builder solves this problem using the
Localized Table strategy. This strategy is based on creating a hidden
table named **Localized Labels** in the dataset behind a report with
measures which can track and load translations for each report label.
You will learn more about the Localized Labels table strategy later in
this article.

**Data translations** provide translated values for text-based columns
in the underlying data itself. Think about a scenario where a Power BI
report displays product names imported from the rows of the **Products**
table in an underlying database. Data translations are used to display
product names differently for users who speak different languages. For
example, some users see products names in English while other users see
product names in secondary languages.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image6.png"
style="width:3.98823in;height:1.78667in" />

Data translations also appear in the axes of cartesian visuals and in
legends as shown in the following screenshot.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image7.png"
style="width:6.56989in;height:1.56667in" />

Data translations are harder to design and implement than the other two
types of translations. The reason it’s harder is that you must typically
redesign the underlying datasource with additional text columns for
secondary language translations. Once the underlying datasource has been
extended with extra text columns for secondary language translations,
you can then use a powerful new feature in Power BI Desktop known as
Field Parameters to design a scheme where can control the loading the
data translations for a specific language through filtering.

While every multi-language report will typically require both metadata
translations and report label translations, it is not as clear whether
they will also require data translations. Some projects to build a
multilanguage report for Power BI will require data translations while
other projects will not. This point will be revisited in more depth a
little later.

### Packaging Dataset and Report in PBIX Project Files

Now that you understand high-level concepts of building multi-language
reports with translations, it's time to discuss the multi-language
report development process. The first step here is to decide how to
package your dataset definitions and report layouts for distribution.
Let's examine two popular approaches used by content creators using
Power BI Desktop.

In the first approach, the goal is to keep things simple and convenient
by creating a single PBIX project file which contains both a report
layout and its underlying dataset definition. You can easily deploy a
reporting solution like this by importing the PBIX project file into a
Power BI workspace. If you need to update either the report layout or
the dataset definition after they have been deployed, you can perform an
upgrade operation by importing an updated version of the PBIX project
file.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image8.png"
style="width:1.96338in;height:0.85324in" />

The single PBIX file approach doesn't always provide the flexibility you
need. Imagine a scenario where one team is responsible for creating and
updating dataset definitions while other teams are responsible for
building reports. For a scenario like this, it makes sense to split out
dataset definitions and report layouts into separate PBIX project files.

To use the shared dataset approach, you create one PBIX project file
with a dataset definition and an empty report which remains unused. Once
this dataset has been deployed to the Power BI Service, report builders
can connect to it using Power BI Desktop to create report-only PBIX
files. This makes it possible for the teams building reports to build
PBIX project files with report layouts which can be deployed and updated
independently of the underlying dataset.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image9.png"
style="width:2.37794in;height:1.28333in" />

From the perspective of adding multi-language support to a Power BI
solution, it really doesn't matter which of these approaches you choose.
The techniques and disciplines used to build multi-language reports
remain the same whether you decide to build your solution using a single
PBIX project file or with a combination of PBIX project files. There are
specific tasks you need to perform at the dataset level and other tasks
you must perform when building report layouts in Power BI Desktop. The
multi-language report development process can be broken down into a few
distinct phases. Each of these phases will be examined in detail in this
article.

While the solution provided by
[**TranslationsBuilderLiveDemo.pbix**](https://github.com/PowerBiDevCamp/TranslationsBuilder/raw/main/LiveDemo/TranslationsBuilderLiveDemo.pbix)
demonstrates a single PBIX project file approach where the dataset and
report are packaged together for convenience. However, nothing changes
if you package and distribute datasets and reports using separate PBIX
files. You will use the exact same concepts and techniques to build
multi-language reports in scenarios where your solution contains
multiple PBIX files.

## Understanding How Translations Builder Works

Translations Builder is an external tool for Power BI Desktop that has
been developed using .NET 6, C# and Windows Forms. Translations Builder
does its work by reading and writing to a dataset definition that’s been
loaded into a session of the local Analysis Services engine running in
Power BI Desktop. Translations Builder uses the Tabular Object Model
(TOM) to perform read and write operations.

Translations Builder uses TOM to establish a direct connection to the
data model for a dataset definition loaded into Power BI Desktop. This
provides the most direct approach for writing custom code to automate
the process of creating and managing metadata translations within a
Power BI dataset.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image10.png"
style="width:5.20126in;height:2.00562in" />

The **TranslationsBuilder** project has been created using the [external
tools integration
support](https://docs.microsoft.com/en-us/power-bi/transform-model/desktop-external-tools)
for Power BI Desktop. Once the **TranslationsBuilder** application has
been deploy on a Windows computer, you can launch it directly from Power
BI Desktop using the **External Tools** tab in the ribbon.

You can install Translations Builder on a computer where you've already
installed Power BI Desktop using instructions in the [Translations
Builder Installation
Guide](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Docs/Installation%20Guide.md).
After installation, you should be able to launch Translations Builder
from the External Tools tab in Power BI Desktop.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image11.png"
style="width:3.86in;height:1.14848in" />

When you launch an external tool like **TranslationsBuilder**, the
application is passed startup parameters including a connection string
which can be used to establish a connection back to the dataset that's
loaded in Power BI Desktop. This allows **TranslationsBuilder** to
display dataset information and to provide commands to automate adding
metadata translations. You can read [Translations Builder Developers
Guide](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Docs/Developer%20Guide.md)
if you want to learn more about the details of working with Translations
Builder as a developer.

The key value proposition of Translations Builder is that is allows the
user to work with a two-dimensional, editable grid which abstracts aways
the details or reading and writing translation inside a dataset
definition. Users can work with the translations grid to create, view
and edit translations with an experience similar to working with an
Excel spreadsheet.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image12.png"
style="width:5.99958in;height:2.69204in"
alt="Graphical user interface, application Description automatically generated" />

### Adding Languages and Translations

When you open Translations Builder for the first time.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image13.png"
style="width:4.67317in;height:2.17692in"
alt="Graphical user interface, application Description automatically generated" />

Technically, the tools is adding a Culture object to the dataset which
is composed of a language (en) and a culture (US). However, the tool is
made so users can just thing of languages and not worry about the
differences between a language and a culture.

Sss

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image14.png"
style="width:4.42767in;height:0.74013in"
alt="Background pattern Description automatically generated" />

Sssss

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image15.png"
style="width:2.05489in;height:2.15426in"
alt="Graphical user interface Description automatically generated" />

Sssss

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image16.png"
style="width:5.14465in;height:1.18499in"
alt="A picture containing application Description automatically generated" />

Sssss

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image17.png"
style="width:4.63759in;height:1.61905in"
alt="Table Description automatically generated" />

Sssss

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image18.png"
style="width:3.8239in;height:1.22098in"
alt="Table Description automatically generated" />

Xxxxx

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image19.png"
style="width:3.19497in;height:0.947in"
alt="Graphical user interface, application, Word Description automatically generated" />

It’s easy to forget to save your changes in Power BI Desktop. Be aware
that any changes made by Translations Builder are just made to the data
model loaded in memory. None of your changes are saved back to the PBIX
project file until you save in Power BI Desktop.

Xxxx

Now it’s time to begin adding translations. As you begin to add
translations to a PBIX project, you will often follow this set of
steps:  
**(1)** make changes in Power BI Desktop, **(2)** publish the project,
**(3)** check your work in the Power BI Service, **(4)** repeat until
happy

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image20.png"
style="width:5.19816in;height:0.8239in"
alt="Graphical user interface, application Description automatically generated" />

Xxx

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image21.png"
style="width:6.48154in;height:0.81132in"
alt="A screenshot of a computer Description automatically generated" />

Xxxx

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image22.png"
style="width:5.54899in;height:1.50943in"
alt="Graphical user interface, text, application Description automatically generated" />

Try out the hands-on lab

### Generate Machine Translations using Azure Translator Service

One of the biggest challenges in building multi-language reports is
managing the language translation process. You must ensure that the
quality of translations is high and that the translated names of tables,
columns, measures and labels do not lose their meaning when translated
to another language. In most cases, acquiring quality translations will
require human translators to create or at least review translations as
part of the multi-language report development process.

While human translators are an essential part of the end-to-end process,
it can take a long time to send out translation files to a translation
team and then wait for them to come back. With all the recent industry
advances in Artificial Intelligence (AI), you also have the option to
generate machine translations using a Web API that can be called
directly from an external tool such as **TranslationsBuilder**. If you
initially generate machine translations for each secondary culture you
need to support, that will give you something to work with while waiting
for a translation team to return their high-quality human translations.

While machine translation are not always guaranteed to be high quality,
they do provide value in the multi-language report development process.
First, they can act as translation placeholders so you can begin your
testing by loading reports using secondary languages to see if there are
layout issues or unexpected line breaks. Machine translations can also
provide human translators with a better starting point as they just need
to review and correct translations instead of creating every translation
from scratch. Finally, machine translations can be used to quickly add
support for languages in scenarios where there are legal compliance
issues and organizations are facing fines or litigation for
non-compliance.

The **TranslationsBuilder** application includes support to generate
machine translations with the [Azure Translator
service](https://docs.microsoft.com/en-us/azure/cognitive-services/translator/translator-info-overview)
that is part of Azure Cognitive Services. This Web API makes it possible
to automate enumerating through dataset objects to translate dataset
object names from the default language to secondary languages. The
diagram below shows the details of executing a Translator service API
request to convert a table name from English (en) to Dutch (nl).

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image23.png"
style="width:5.77914in;height:1.21095in" />

If you'd like to test out the support in **TranslationsBuilder** for
generating machine translations, you will require an Azure subscription.
An Azure subscription is required because you must create your own
instance of the Translator service in Microsoft Azure. Once you have
created an instance of the Translator service, you must determine its
location and acquire an application key before you can successfully call
to it from the **TranslationsBuilder** application.

The Azure Translator service does not support anonymous API calls.
Instead, you must acquire an application keys which acts as a security
credential because it allows you to execute secure Web API calls to the
Translator service. When working with an instance of the Translator
service in the Azure portal, you can navigate to the **Keys and
Endpoint** page where you can view and acquire an application key.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image24.png"
style="width:6.00293in;height:1.65031in" />

On the **Keys and Endpoint** page, you can copy the application key and
then paste it into the **Configuration Options** dialog in
**TranslationsBuilder**. You will also need to copy the service
**Location** and paste that value into the **Configuration Options**
dialog as well.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image25.png"
style="width:2.6319in;height:1.28792in" />

Once you have copy-and-pasted the application key and the location for
your Translator service instance, you can save your changes in the
**Configuration Options** dialog and begin generating machine
translations.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image26.png"
style="width:3.3865in;height:1.45203in" />

The **TranslationsBuilder** project contains a class named
[**TranslatorService**](https://github.com/PowerBiDevCamp/Multilanguage-Reports/blob/main/TranslationsBuilder/Services/TranslatorService.cs)
which contains code to manage the low-level details of calling the
Translator service API to translate text values from one language to
another. The **TranslatorService** class provides the public static
method named
[**TranslateContent**](https://github.com/PowerBiDevCamp/Multilanguage-Reports/blob/main/TranslationsBuilder/Services/TranslatorService.cs#L64)
which can be called to translate text values.

The **TranslateContent** method accepts two parameters. The first
parameter is a string value containing the text to be translated. The
second parameter is used to pass the target language for translation.
The implementation of **TranslateContent** abstracts calling the
Translator server Web API and does the work to translate text value from
the default culture language to the target language. Here is an example
of calling **TranslateContent** to translate a text value from the
default culture language (e.g. English) to the language of Spanish in
the locale of Spain.

String translatedSpanishName =
TranslatorService.TranslateContent("Customers", "es-ES");

The **TranslationsBuilder** application contains a **Machine
Translations** section with a **Generate Translations** button. Note
that the **Machine Translations** section will not be visible until you
have added an application key and a location for the Azure Translation
Service in the **Configuration Options** dialog. Once you have
configured **TranslationsBuilder** with an application key and a
location for your Translator service instance, you should be able to
select a target culture with the language you want and click the
**Generate Translations** button to generate machine translation for
that language.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image27.png"
style="width:6.05271in;height:1.78285in" />

The actual implementation of **PopulateCultureWithMachineTranslations**
contains more code than is shown in this code listing. More
specifically, the actual implementation of
**PopulateCultureWithMachineTranslations** includes extra code to ensure
that metadata translation are added for any dataset object that has
non-blank property values for either its **DisplayFolder** property or
its **Description** property. Adding this extra support to localize the
property values for the **DisplayFolder** property and **Description**
property is important. This is especially true for scenarios will be
using different languages to open report in edit mode.

You now seen how the **TranslationsBuilder** application can automate
common localization tasks such as adding secondary cultures and
generating machines translations. This will allow you to reach you first
milestone of adding the first round of metadata translations so you can
begin testing them by loading a localized report with different
languages.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image28.png"
style="width:7.5in;height:2.55625in" />

Once you have added metadata translations for a secondary culture, you
can test your work by publishing the dataset and report to a workspace
in the Power BI Service. Remember that the workspace must be associated
with a Premium capacity or a Power BI Embedded capacity or metadata
translations will not load as expected. To load the metadata
translations for a specific language, you can add the **language** query
string parameter at the end of the URL for a report. For example, you
can load a report with Spanish translations by adding a **language**
query string parameter of **es** or **es-ES**.

There is one important thing to note about loading reports with the
**language** query string parameter. At the time of this writing in July
of 2021, loading a report with the **language** query string parameter
does not change the behavior of the **UserCulture** function in DAX. If
you have written measures which use the **UserCulture** function to
conditionally return different values depending on the user's language
or locale, they will not work correctly. Instead you must configure the
browser setting for user language and user locale to effectively test
measures that call **UserCulture**. Alternatively, you can test reports
using Power BI embedding where you have completed control over which
language and locale is used to load a report.

### Understanding the Localized Labels Table

When designing reports, it's a common practice to use text-based labels
for report elements such as titles, headings and button captions. You've
learned that any text value stored in a report layout cannot be
localized. If you want to localize the text-based labels which are
displayed on a Power BI report, then those labels must be defined inside
the dataset. This leads to the innovative technique of creating a
specialized table in the dataset definition for localized labels.

The idea behind the **Localized Labels** table is pretty simple.

You can localize the name of any measure inside a dataset. When you need
a text label for a report title, you can add a new measure to the
**Localized Labels** table and then give the measure a name for the
English label such as **European Sales Report**. Since the label is a
measure name, you can add metadata translations to supply a localized
version of this label for each language.

SHOW MENU to create localized labels table.

The **TranslationsBuilderLiveDemo.pbix** sample demonstrates a hidden
**Localized Labels** table to provide a set of localized labels for all
titles, headings and button captions used throughout the report.

Use them for report title. Easy to add to a Card visual or Share object
such as a Rectangle.

Now that you've seen how to create the **Localized Labels** table, it's
time to move ahead and learn how to surface the measure name for a
localized label on a Power BI report.

### Add Support for Page Navigation

As you recall, you cannot display Power BI report page tabs to the user
in a multi-language report because page tabs do not support
localization. Therefore, you must provide some other means for users to
navigate from page to page. This can be accomplished using a design
technique where you add shapes to a report which act as buttons. When
the user clicks on a shape, the shape will apply a bookmark to navigate
to another page. Let's step through the process of building a navigation
menu that supports localization using measures from the **Localized
Labels** table.

The first thing you need to do is to hide every page in the report
except for the first page which acts as the landing page.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image29.png"
style="width:6.75059in;height:0.63244in" />

Next, create a set of bookmarks. Each bookmark should be created to
navigate to a specific page. The **ProductSales.pbix** developer sample
demonstrates this technique by adding a bookmark for each page supported
by the navigation menu.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image30.png"
style="width:1.81164in;height:2.23313in"
alt="Graphical user interface, text, application Description automatically generated" />

Remember, that you cannot add a button with literal text to a
multi-language report. Instead, you configure the button to pull its
text value from a measure in the Translated Localized Labels table.

From a design perspective, the user sees the localized label with the
button caption but does not see the shape. When the user clicks on the
localized label visual, the invisible shape on top acts as a button and
responds to the user’s click action by applying a bookmark to navigate
to the target page.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image31.png"
style="width:6.1in;height:1.25163in" />

At this point, you've learned how to create the **Localized Labels**
table and add labels. You also learned how to generate the Translated
Localized Labels table and to bind the measures in that table to report
elements such as Card visuals, shapes and buttons. These are the
localization techniques you will continue to use as you create and
maintain reports that must support multiple languages

### Enable Human Workflows for Translation using Export and Import

Another important consideration when building multi-language reports
involves the human aspect of translating text values from one language
to another. While it's possible to generate the first round of metadata
translations using machine translations, it's likely you will eventually
need to integrate those friendly carbon-based life forms (i.e. people)
who play the role of translators to generate high quality translations.
Furthermore, you cannot expect that people who work as professional
translators will be able to use an advanced Power BI data modeling tool
like the Tabular Editor.

While it's theoretically possible to have human translators work on
files generated by the **Export Translations** command of the Tabular
Editor, the JSON-based format will likely be rejected by professional
translator teams due to it being a non-standard file format that is hard
to work with. Once you begin writing custom code with TOM, however, you
can generate the translation files that are sent out to a translation
team using whatever file format they require.

If you are working with a professional translation team, you might be
requires to generate translation files in a standard translation format
such as RESX files or XLIFF files. Depending on the requirements of the
translator team, you might be able to generate translations files in
easy-to-use formats such as CSV files or XLSX files. The
**TranslationsBuilder** application provides an **Export Translation
Sheet** command which demonstrates how to generate a translation sheet
for a human translator using a simple CSV format.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image32.png"
style="width:7.60715in;height:1.50649in"
alt="Graphical user interface, application Description automatically generated" />

When you click the **Export Translation Sheet** button, the
**TranslationsBuilder** application generates a CSV file for the
selected language using a naming format (e.g.
**ProductSales-Translations-German.csv**) which includes the dataset
name and the language for translation. After generating the file and
saving it to the location of **TranslationsOutboxFolderPath** the
**TranslationsBuilder** application will then open the translation sheet
in Microsoft Excel.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image33.png"
style="width:7.09418in;height:2.19345in"
alt="Graphical user interface, application, table, Excel Description automatically generated" />

Once these translation files have been generated, they can be sent out
to the translation team. Once these translations files have been edited
and returned with the high-quality human translations, you can then use
the **Import Translations** command to important these human
translations which will then effectively overwrite the machine
translations.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image34.png"
style="width:6.99117in;height:1.35714in"
alt="Graphical user interface, application Description automatically generated" />

### Embed Power BI Reports with Specific Languages and Locales

If you are developing with Power BI embedding, you can use the Power BI
JavaScript API to load reports with a specific language and locale using
the **localeSettings** parameter. The **localeSettings** parameter is an
object with a **language** property and a **formatLocale** property that
can be included as part of the **config** object that is passed in the
call to **powerbi.embed** as shown in the following code.

let config = {

type: "report",

id: reportId,

embedUrl: embedUrl,

accessToken: embedToken,

tokenType: models.TokenType.Embed,

localeSettings: { language: "de-DE", formatLocale: "de-DE" }

};

let report = powerbi.embed(reportContainer, config);

When you embed reports using an explicit value for the **formatLocale**
parameter, the **UserCulture** function will work correctly. That means
you can write and test measures that conditionally return values based
on the user's locale. This is different from the scenario in which
you’re loading reports in the Power BI Service using the **language**
query string parameter where the return value of the **UserCulture**
function does not return the expected value.

In the screenshot below, you can see a visual in the top right
displaying a text value of **de-DE**. This visual displays the value
returned by the **UserCulture** function. You can inspect this value
when loading a report into the Power BI Service or with Power BI
embedding to determine whether the **UserCulture** is returning the
language and locale you expect.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image35.png"
style="width:6.95714in;height:3.94238in"
alt="Chart, waterfall chart Description automatically generated" />

This concludes the coverage of developing an external tool with custom
code and TOM to automate the development tasks associated with creating
and maintaining metadata translations in a multi-language reporting
solution. Now it’s time to move ahead to the final section which
addresses the ***why***, ***when*** and ***how*** of implementing data
translations.

When creating a report for Power BI, it's a common practice to add
text-based labels for report elements such as titles, headings and
button captions. However, this creates an unexpected bump in the road
when building multi-language reports in Power BI Desktop. The problem is
that you cannot create labels for a report using the standard approach
where you add textboxes and buttons to the report. That's because any
text you add for a property value of a textbox or a button is stored in
the report layout and, therefore, cannot be localized.

As discussed earlier in this article, the Power BI localization features
are supported at the dataset definition level but not at the report
layout level. At first you might ask the question ***how can I localize
text-based values that are not stored inside the dataset definition?***
The answer to this question is that you cannot.

A better question to ask is ***how can I add the text-based values for
labels so they become part of the dataset definition?*** Once the
text-based values for labels become part of the dataset definition, then
they can be localized. This leads to an innovative approach of creating
the **Localized Labels** table. This design technique will be discussed
in detail in the next section of this article.

The **live demo** demonstrates how to implement localized labels in the
report title and the top navigation menu buttons. The following
screenshot shows the how button captions are translated when loaded with
five different languages.

The live demo also demonstrates how to implement data translations. With
metadata translations, you can see the names of columns and measures
change as you switch between languages. Data translations go further to
localize the product names in rows of the **Products** table. The
following screenshot shows how the **ProductSales.pbix** developer
sample provides data translations for product names as well.

## Design and Implement a Data Translations Strategy

While all multi-language reports will require metadata translations, you
cannot assume the same for data translations. Some projects will require
data translations and others will not. In order the determine whether
your project will require data translations, you'll need to think
through the use cases you plan to support with your reporting solution.
You will find that adding support for data translations can involve a
good deal of planning and effort. You might decide to only support data
translations if they are a hard requirement for your project.

Implementing data translations is quite different from implementing
metadata translations. They are different because Power BI doesn't offer
any localization features to assist you with data translations. Instead,
you must implement a data translation strategy on your own by extending
a dataset definition with fundamental building blocks such as tables,
columns, measures and filters. This article walks through one possible
solution for implementing data translations by examining how this
requirement is met in the **ProductSales.pbix** developer solution.

### Determine Whether Your Solution Requires Data Translations

To determine whether you need to implement data translations, start by
thinking about how your reporting solution will be deployed and think
about the use case for its intended audience. That leads to a key
question. **Will you have people who speak different languages looking
at the same database instance?**

Imagine a scenario where you are developing a report template for a SaaS
application with a well-known database schema. Now let's say some
customer maintain their database instance in English while others
maintain their database instances in other languages such as Spanish or
German. There is no need to implement data translations in this use case
as the data from any database instance only needs to be viewed by users
in a single language.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image36.png"
style="width:5.84793in;height:4.02857in" />

The important observation is that each customer deployment uses a single
language for its database and all its users. Metadata translations must
be implemented is this use case so you can deploy a single version of
the PBIX file across all customer deployments. However, there is no need
to implement data translations when no database instance ever needs to
be viewed in multiple languages.

Now let's examine a different use case which introduces the requirement
of data translations. This is the use case for the **ProductSales.pbix**
developers sample which involves a single database instance containing
sales performance data across several European countries. This reporting
solution has the requirement to display its report in different
languages while the data being analyzed is coming from a single database
instance.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image37.png"
style="width:6.14478in;height:1.77914in" />

Once again, the key question to ask is whether you will have people who
speak different languages looking at the same database instance. If the
answer to that question is ***NO***, then you will not be required to
implement data translations. If the answer to that question is
***YES***, then you should ask additional questions because there are
other consideration you should think through before deciding whether it
make sense to implement data translations.

When you're considering whether to implement data translations, you
should examine the text-based columns which are candidates for
translation to determine how hard will it be to translate those text
value to secondary languages. Columns with short text values for things
like product names, product categories and country names are a good
candidates for data translations because the values are short and easy
to translate. What if you have a column for product descriptions where
each row has two to three sentences of text. While you can provide
translations for product descriptions, they will require more effort to
generate high quality translations. In general, columns with longer text
values are less ideal as candidates for data translations.

You should also consider the number of distinct column values that will
require translation. You can easily translate product names in a
database that holds 100 products. You can probably translate product
names when the number gets up to 1000. However, what happens if the
number of translated values reaches 10,000 or 100,000. Your translation
team might have trouble scaling to handle that volume of language
translation by humans.

You also have to consider that your commitment to implement data
translations often requires on-going maintenance. Every time someone
adds a new record to the underlying database, you might be required to
add new data translations for it. This is very different from
implementing metadata translations where you create a finite number of
translation for database objects and your work is done. Metadata
translations don't require on-going maintenance as long as the
underlying dataset schema remains the same.

In summary, there are many factors that go into deciding whether you
should implement data translations. You must decide whether you can
afford to spend the time and effort it takes to implement data
translations properly. You might decide that implementing metadata
translations goes far enough. If your primary goal is to make your
reporting solution compliant with laws or regulations, you might that
find implementing metadata translations is all you need.

### Modify the Dataset Design to Support Data Translations

In years long before Microsoft introduced Power BI, software developers
around the world were already building multi-language applications that
support data translations. After two decades of designing and refining
various database designs, several common design patterns have emerged as
industry best practices to support data translations. Some of these
design patterns involve adding a new table column for each language
while other design patterns involve adding a new table row for each
language. Column-based approach has benefits and the guidance in this
article will focus on that approach.

The following diagram shows the use case for the **ProductSales.pbix**
developer sample. Note that this approach eliminates the need to
redesign the underlying database to support data translations. Instead,
all the ETL logic used to implemented data translations can be packaged
and maintained inside a PBIX template file.

Now it's time to examine a few queries in the **ProductSales.pbix**
developer solution so you can see how Power Query can be used to
generate the extra rows required in the row replication pattern. Let's
begin by examining the query named **Languages** which generates a table
based on the following M code.

let

OutputSchema = type table \[ LanguageTag=text, DisplayName=text,
NativeName=text, SortOrder=number \],

Languages = \#table(OutputSchema, {

{ "en-US", "English", "English", 1 },

{ "es-ES", "Spanish", "español", 2 },

{ "fr-FR", "French", "français", 3 },

{ "de-DE", "German", "Deutsch", 4 },

{ "nl-NL", "Dutch", "Nederlands", 5 }

})

in

Languages

The **Languages** query generates a table with a row for each language
which will be used in the row expansion process.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image38.png"
style="width:3.76488in;height:0.80393in" />

### Load Reports using Bookmarks to Filter Data Translations

Once you have created the Field Parameters to load \tables which use the
row replication strategy, you must then figure out how to filter table
rows so a user only sees the rows for one language at a time. In the
**ProductSales.pbix** developer sample, the two tables that require
filtering are **Products** and **Countries**. The following screenshot
shows how you can use the **Filter** pane in Power BI Desktop to set
report-level filtering on the **LanguageTag** column on both the
**Products** table and the **Countries** table so only rows with
**German** translations are displayed to the user.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image39.png"
style="width:7.1846in;height:2.4945in" />

The best way to control filtering in a Power BI report is to create a
set of bookmarks. The **ProductSales.pbix** developer sample includes a
set of bookmarks that can be used to apply the filtering required for
each of the supported languages. Now you can simply apply a bookmark to
set the data translations filtering as shown in the following
screenshot.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image40.png"
style="width:7.26455in;height:2.55714in" />

Earlier in this article, you learned that it is possible to open a
report in the Power BI Service using the **language** query string
parameter to force a report to load the metadata translations for a
specific language. Now that the report implements data translations in
addition to metadata translations, it is now necessary to pass a second
query string parameter to apply a bookmark. This query string parameter
is named **bookmarkGuid** and it makes it possible to apply a bookmark
as the report is loading before anything is displayed to the user.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image41.png"
style="width:7.21417in;height:3.19345in" />

### Setting the Language for Current User using RLS and UserCulture

If you deploy a multi-language report through the Power BI Service, your
deployment scenario might require you to use URLs with query string
parameters for **language** and **bookmarkGuid** to ensure that reports
load with the correct metadata translations and the data translations
filtering for a specific language. When you develop with Power BI
embedding you have more control because you can embed the report with a
**localeSettings** object which allows you to the specify the
**language** and the **formatLocale**.

If you are developing multi-language reports for use in a custom
application that uses Power BI embedding, you can control data
translations filtering using the Power BI features for Row Level
Security (RLS). This approach involves creating a single RLS role named
**LocalizedUser**. This RLS role applies a filter on the **Products**
table where the **LanguageTag** column is equal to the return value of
the **UserCulture** function.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image42.png"
style="width:5.02245in;height:1.65059in" />

The RLS role named **LocalizedUser** also applies a second filter on the
**Countries** table where the **LanguageTag** column is equal to the
return value of the **UserCulture** function.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image43.png"
style="width:5.02055in;height:1.57917in" />

If you are developing with App-Owns-Data embedding, you will be required
to generate embed tokens with an effective identity which includes the
RLS role named **LocalizedUser**. The following code listing
demonstrates how to generate an embed token with an effective identity
containing the **LocalizedUser** role using the Power BI .NET SDK.

<img
src="./images/BuildingMultiLanguageReportsInPowerBI/media/image44.png"
style="width:6.56809in;height:3.25059in" />

## Summary

This article has examined how to use Power BI localization features to
design and implement multi-language reports. Along the way you learned
that Power BI datasets provide support for localization while the Power
BI report designer does not. This partial support for localization in
Power BI can lead to confusion as many common Power BI Desktop report
design techniques do not support localization and must be avoided.

Becoming successful at building multi-language reports requires a deep
understanding of Power BI architecture and a thorough knowledge of which
report design techniques support localization. You 've learned how to
prepare datasets and reports for localization and how to create the
**Localized Labels** table so you can localize report labels such as
titles, headings and button captions. You also learned several different
approaches you can use to add metadata translations to a dataset
definition. After reading this article, you should now possess a deeper
understanding and the fundamental skills you need to build
multi-language reports in a reliable and testable fashion.

This article also discussed when and how to implement data translations.
You have learned that some projects will require data translations while
other will not. You must decide whether to implement data translations
on a project-by-project basis. Fortunately, you now know the right
questions to ask in order to make that decision.

The **ProductSales.pbix** developer sample demonstrates how to implement
data translations using the row replication pattern. While this design
approach will work well for some scenarios, it might have trouble
scaling in larger scenarios as the number of rows in the tables with
translated content increases due to the use of many-to-many
relationship. In the fullness of time, Power BI developers will continue
to come up with creative and innovative designs to implement an
efficient data translation strategy for these types of scenarios.

Also remember that one fine day in the future that Power BI will
introduce support for calculated columns with dynamic evaluation. That
will certainly open up opportunities for creating new designs for
implementing data translation strategies that are more performant and
less complex than using the row replication pattern which was
demonstrated in this article with the **ProductSales.pbix** developer
solution.

## Prepare Datasets and Reports for Localization

So far you've learned about essential concepts and background
information you'll need to build multi-language reports. Now, it's time
to move ahead and discuss the actual development process. We'll start by
discussing a few general topics associated with software localization.
After that, we'll move on to topics that are specific to Power BI and
designing reports in Power BI Desktop.

When it comes to localizing software, there are some universal
principals to keep in mind. The first is to plan for localization from
the start of any project. It's significantly harder to add localization
support to an existing dataset or report that was initially built
without any regard for Internationalization or localization. This is
especially true with Power BI reports because there are so many popular
design techniques that do not support localization. You might find that
much of the work for adding localization support to existing Power BI
reports involves moving backward and undoing the things that do not
support localization before you can move forward with design techniques
that do support localization.

Another important concept in localization is to plan for growth. A label
that's 400 pixels wide when displayed in English could require a much
greater width when translated into another language. If you optimize the
width of your labels for text in English, you might find that
translations in other languages introduce unexpected line breaks or get
cut off which, in turn, creates a compromised user experience.

Adding a healthy degree of padding to localized labels is the norm when
developing Internationalized software and it's essential that you test
your reports with each language you plan to support. In essence, you
need to ensure your report layouts looks the way you expect with any
language you have chosen to support.

### Avoid Report Design Techniques that Do Not Support Localization

If you have experience with Power BI Desktop, it's critical that you
learn which report design techniques to avoid when you begin building
multi-language reports. Let's begin with the obvious things which cause
problems due to a lack of localization support.

- Using textboxes or buttons with literal text

- Adding literal text for the title of a visual

- Displaying page tabs to the user

The key point here is that any literal text that gets added to the
report layout cannot be localized. Consider the case where you add a
column chart to your report. By default, a Cartesian visual such as a
column chart is assigned a dynamic value to its **Title** property which
is parsed together using the names of the columns and measures that have
been added into the data roles such of **Axis**, **Legend** and
**Values**.

There is good news here. The default **Title** property for a Cartesian
visual is dynamically parsed together in a fashion that supports
localization. As long as you supply metadata translations for the names
of columns and measures in the underlying dataset definition (e.g.
**Sales Revenue**, **Country** and **Year**), the **Title** property of
the visual will use the translations for whatever language has been used
to load the report. The following table shows how the default **Title**
property of this visual is updated for each language supported by the
**ProductSales.pbix** developer sample.

| Language        | Visual Title                         |
|-----------------|--------------------------------------|
| English (en-US) | Sales Revenue by Country and Year    |
| Spanish (es-ES) | Ingresos por ventas por país y año   |
| French (fr-FR)  | Chiffre d’affaires par pays et année |
| German (de-DE)  | Umsatz nach Land und Jahr            |
| Dutch (nl-NL)   | Omzet per land en jaar               |

Even if you don’t like the dynamically-generated visual **Title**, you
must resist the temptation to replace it with a literal text value. Any
literal text you type into the **Title** property of the visual will be
added to the report layout and cannot be localized. Therefore, you
should either leave the visual **Title** property with its default value
or hide the title so it is not displayed.
