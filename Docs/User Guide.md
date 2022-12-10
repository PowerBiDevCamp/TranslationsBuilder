# User Guide for Translations Builder

This document provides information you need to become productive with
Translations Builder.

### Getting Started

When it comes to localizing Power BI artifacts such as datasets and
reports, there are three different types of translations.

- Metadata Translations

- Report Label Translations

- Data Translations

**Metadata translations** provides localized values for dataset objects.
The object types which support metadata translation include tables,
columns, measures, hierarchies and hierarchy levels. Metadata
translations are the easiest to create, managed and integrate into a
Power BI report experience. By using the machine translation features of
Translations Builder, you can add all the metadata translations you need
to test a Power BI report in a matter of minutes.

**Report label translations** provide localized values for text-based
elements on a report that are not directly associated with a dataset
object. Examples of report labels include the report title, section
heading and button captions. Report label translations are harder to
create and manage than metadata translations because Power BI provides
no direct feature to integrate them. Translations Builder solves this
problem by creating a hidden table in the data model named Localized
Labels and it adds a hidden measure to track the translations for each
report label that requires localization.

**Data translations** provide translated values for text-based columns
from the rows of data shown in a report. Data translations are harder to
design and implement as the underlying datasource must be designed with
additional columns for each language that needs to be supported. Once
the underlying datasource has been extended with extra translation
columns, you can use the new feature in Power BI Desktop named Field
Parameters to design a scheme that allows a report to provide a
mechanism where filtering can be used to load the data translations for
a specific language.

#### Translations Builder Configuration Options

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
