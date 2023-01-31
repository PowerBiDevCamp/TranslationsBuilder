# User Guide for Translations Builder

This document provides information you need to become productive with
Translations Builder.

### Getting Started

When it comes to localizing Power BI artifacts such as datasets and
reports, there are three different types of translations.

- Metadata Translations

- Report Label Translations

- Data Translations

Translations Builder assists with the first two types which are metadata
translations and report label translations. It is recommended that you
read xxx. It will be helpful if you work through lab

### Limitations

ddddd

#### Supported Languages and Cultures

The get the most out of Translations Builder, it is important you
understand a few important limitation.

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
