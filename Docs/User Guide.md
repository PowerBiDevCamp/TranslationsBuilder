# Translations Builder User Guide

Translations Builder is an external tool created for Power BI Desktop
specifically to assist report authors and dataset authors with tasks
associated with creating translations and building multi-language
reports. As a user, you can install Translations Builder and use it
together with Power BI Desktop to build and test datasets and reports
that support multiple languages.

There are three types of translations that come into play when
localizing Power BI datasets and building reports that support multiple
languages. Translations Builder helps to create and manage the first two
types of translations which are **metadata translations** and **report
label translations**. Translations Builder does not provide any
assistance with implementing **data translations**. For more background
on this topic, please read [Understanding the Three Types of
Translations](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Docs/Building%20Multi-language%20Reports%20in%20Power%20BI.md#understanding-the-three-types-of-translations).

While this document has been designed to explain the features and
limitations of Translations Builder, it is recommended that you
additionally read through the [guidance
document](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Docs/Building%20Multi-language%20Reports%20in%20Power%20BI.md)
and work through the [hands-on lab
exercises](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Labs/Hands-on%20Lab%20-%20Building%20Multi-language%20Reports%20for%20Power%20BI.md).
They will provide a great compliment for the contents you’ll find here.

### Limitations

ddddd

#### Supported Languages and Cultures

Every report that loads in the Power BI Service is initialized with a
specific language and a specific locale. These

The default behavior of the Power BI Service is to load each report
using the language and regional locale specified by the user’s browser
settings. However, those settings can be overridden by adding the
**language** query string parameter to the end of the report URL.

Translations Builder supports 43 different languages. , it is important
you understand a few important limitation.

| Afrikaans \[af-ZA\] | Filipino \[fil-PH\]  | Italian \[it-IT\]    | Serbian \[sr-Latn-BA\] |
|---------------------|----------------------|----------------------|------------------------|
| Arabic \[ar-001\]   | Finnish \[fi-FI\]    | Japanese \[ja-JP\]   | Slovak \[sk-SK\]       |
| Bulgarian \[bg-BG\] | French \[fr-FR\]     | Korean \[ko-KR\]     | Slovenian \[sl-SI\]    |
| Catalan \[ca-ES\]   | German \[de-DE\]     | Latvian \[lv-LV\]    | Somalian \[so-SO\]     |
| Chinese \[zh-CN\]   | Greek \[el-GR\]      | Napali \[ne-NP\]     | Spanish \[es-ES\]      |
| Croatian \[hr-HR\]  | Hebrew \[he-IL\]     | Norwegian \[nb-NO\]  | Swedish \[sv-SE\]      |
| Czech \[cs-CZ\]     | Hindi \[hi-IN\]      | Persian \[fa-IR\]    | Thai \[th-TH\]         |
| Danish \[da-DK\]    | Hungarian \[hu-HU\]  | Polish \[pl-PL\]     | Turkish \[tr-TR\]      |
| Dutch \[nl-NL\]     | Icelandic \[is-IS\]  | Portuguese \[pt-PT\] | Ukrainian \[uk-UA\]    |
| English \[en-US\]   | Indonesian \[id-ID\] | Romanian \[ro-RO\]   | Vietnamese \[vi-VN\]   |
| Estonian \[et-EE\]  | Irish \[ga-IE\]      | Russian \[ru-RU\]    |                        |

#### Import and Export using CSV Formatted Files

ddddd

#### 

#### Translations Buread ilder Configuration Options

Inbox/Outbox to facilitate workflows associated with gathering and
integrating human translations

Adding a Key and Location for the Machine Translator Service

### Adding Metadata Translations

#### Adding Secondary Languages

Remember that calling **SaveChanges** doesn't update the PBIX project
file. After making changes to a dataset using an external tool such as
**TranslationsBuilder**, you still need to return to Power BI Desktop
and save your changes there. OK, now you’ve been told several times to
save your changes in Power BI Desktop. This is your last warning.

#### Creating and Editing Translations by Hand

Remember that calling **SaveChanges** doesn't update the PBIX project
file. After making changes to a dataset using an external tool such as
**TranslationsBuilder**, you still need to return to Power BI Desktop
and save your changes there. OK, now you’ve been told several times to
save your changes in Power BI Desktop. This is your last warning.

#### Testing Metadata Translations in the Power BI Service

#### Creating Machine Translations using the Azure Translation Service

### Adding Report Label Translations

#### Creating the Localized Labels Table

Show command to create table

Create simple label

Show behind the scenes what has been created

Delete all and add multiple labels at once

Import labels from a file

#### Generating the Translated Localized Labels Table

Show command.

Show the two tables behind the scenes.

While the Localized Labels table is hidden from report authors, the
Translated Localized Labels table is not hidden. That is what report
authors use to create translated report labels

#### Surfacing Localized Labels on a Power BI Report

Measure make life easy. Over the last two years, Power BI Desktop has
been extended

- Card visual

- Shape such as a Rectangle

- Button

### Adding Data Translations

When implementing metadata translations and report label translations,
Translations Builder can automate a large percentage of the translations
work that need to be done. Unfortunately, the same is not true for data
translations. Implementing data translations will often require
refactoring the underlying database or datasource to provide extra
columns to provide translations on a row to row basis.

#### Understanding Translations Builder Support for Data Translations
