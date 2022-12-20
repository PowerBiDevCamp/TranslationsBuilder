## **Lab 01: Getting Started with Translation Builder**

> **Overview**: In this lab, you will learn how to work with Power BI
Desktop and Translations Builder to build multi-language reports for
Power BI. You will start by downloading a PBIX project file named
**TB-Lab01.pbix** and opening it in Power BI Desktop. Once you have
opened **TB-Lab01.pbix,** you will launch Translations Builder and move
through the steps to add metadata translations and report label
translations. At various milestones in this lab, you will be required to
publish the **TB-Lab01.pbix** project from Power BI Desktop to the Power
BI Service so you can test how the translations you’ve added to the PBIX
project to ensure they are displayed to users when loaded using
different languages and different cultures.

> **Prerequisite 1**: To complete this lab, you will need a Power BI
workspace where you have appropriate permissions to publish PBIX project
files from Power BI Desktop to test your work. This workspace must also
be associated with a Premium capacity as indicated by the diamond image
(*see below*) displayed after the workspace name. A workspace in a
premium capacity is required because Power BI translations do not load
properly for reports in the shared capacity.

> <img src="./images/Lab01/media/image1.png" style="width:50%" />

> **Prerequisite 2**: This lab assumes you’ve already installed
Translations Builder. If you haven’t installed Translations Builder yet,
you must follow steps in the [Translations Builder Installation
Guide](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Docs/Installation%20Guide.md)
before continuing with these lab exercises.

### Exercise 1: Creating and Testing Metadata Translations
---
> In this exercise, you will begin by downloading a PBIX file with a
simple data model and a single page report. You will publish the project
to the Power BI Service to set up a workflow process to test how
translations appear to report consumers. At the end of this exercise,
you will use Translations Builder to add metadata translations for the
column names and measure names in the dataset.

1. Download the PBIX starter file named **TB-Lab01.pbix** from the following link


> [https://github.com/PowerBiDevCamp/TranslationsBuilder/raw/main/Labs/StarterFiles/TB-Lab01.pbix](https://github.com/PowerBiDevCamp/TranslationsBuilder/raw/main/Labs/StarterFiles/TB-Lab01.pbix)


2.  Create a new folder on your local hard drive for these lab exercises
    in a location such as **C:\DevCampLabs\\**.

<img src="./images/Lab01/media/image2.png"
style="width:3.42767in;height:1.25421in" />

3.  Copy **TB-Lab01.pbix** into the lab folder and then open it in Power
    BI Desktop to examine the report inside.

<img src="./images/Lab01/media/image3.png"
style="width:4.28128in;height:2.39831in"
alt="Graphical user interface, application, table Description automatically generated" />

4.  While in **Report view**, examine the **Fields** list to see the
    non-hidtables, columns and measure that are not hidden.

<img src="./images/Lab01/media/image4.png"
style="width:1.4211in;height:1.77987in" />

5.  Now, navigate to **Model view** so you can see the entire data model
    including the columns hidden from **Report view**.

<img src="./images/Lab01/media/image5.png"
style="width:3.65079in;height:2.39214in" />

6.  Navigate to **Data view** and examine the rows of the **Products**
    table.

<img src="./images/Lab01/media/image6.png"
style="width:3.98413in;height:2.40207in" />

> Now you are going to publish the **TB-Lab01.pbix** project to a workspace in the Power BI Service.

7.  Navigate to the **Home** tab and then click the **Publish** button.

<img src="./images/Lab01/media/image7.png"
style="width:5.61275in;height:1.11111in" />

8.  When prompted by the **Publish to Power BI** dialog, choose your
    test workspace and then click **Select**.

<img src="./images/Lab01/media/image8.png"
style="width:2.86537in;height:1.57233in" />

9.  Once you see **Success!**, click **Open ‘TB-Lab01.pbx’ in Power BI**
    to view the report in the Power BI Service.

<img src="./images/Lab01/media/image9.png"
style="width:2.83648in;height:1.69537in" />

10. The report named **TB-Lab01** should appear like the report shown in
    the screenshot below.

<img src="./images/Lab01/media/image10.png"
style="width:5.23747in;height:2.88679in" />

Now it’s time to begin adding translations. As you begin to add
translations to a PBIX project, you will often follow this set of
steps:  
**(1)** make changes in Power BI Desktop, **(2)** publish the project,
**(3)** check your work in the Power BI Service, **(4)** repeat until
happy

11. Return to Power BI Desktop, navigate to the **External Tools** tab
    and launch **Translations Builder**.

<img src="./images/Lab01/media/image11.png"
style="width:5.20002in;height:1.38298in" />

12. Translations Builder should start and load the data model for
    **TB-Lab01.pbix** as shown in the following screenshot.

<img src="./images/Lab01/media/image12.png"
style="width:4.67317in;height:2.17692in"
alt="Graphical user interface, application Description automatically generated" />

13. The **Dataset properties** section provides details about the
    dataset connection and the PBIX project file.

<img src="./images/Lab01/media/image13.png"
style="width:1.95598in;height:1.12304in" />

14. The translation grid at the bottom of the page displays one row for
    each non-hidden dataset object in the data model.

<img src="./images/Lab01/media/image14.png"
style="width:3.04403in;height:1.18999in" />

Tables, columns and measures that are hidden from report view in the
data model are not displayed. You don’t need to translate them.

15. Click the **Add Language** button to add your first secondary
    language.

<img src="./images/Lab01/media/image15.png"
style="width:4.42767in;height:0.74013in" />

16. Select **Spanish \[es-ES\]** and click **Add Language**.

<img src="./images/Lab01/media/image16.png"
style="width:2.05489in;height:2.15426in" />

17. You should now see that **Spanish \[es-ES\]** appears as the first
    language in the **Secondary Languages** list.

<img src="./images/Lab01/media/image17.png"
style="width:5.14465in;height:1.18499in" />

18. You will also notice that a new column has been added for Spanish
    translations.

<img src="./images/Lab01/media/image18.png"
style="width:4.63759in;height:1.61905in" />

19. In the row with the **Products** table, click on the cell for the
    **Spanish** column. It should turn blue when selected.

<img src="./images/Lab01/media/image19.png"
style="width:4.50937in;height:0.90476in" />

20. Type **Hello World**. You should see that you can just start typing
    in the selected cell to add or edit a translation.

<img src="./images/Lab01/media/image20.png"
style="width:4.48425in;height:0.88889in" />

21. Press the **ENTER** key to save your changes. Note that pressing
    **ENTER** will move the selection to the cell below.

<img src="./images/Lab01/media/image21.png"
style="width:4.48403in;height:0.85984in" />

22. Now, type more text and press **ENTER** repeatedly to experiment
    quickly adding text to all cells in the Spanish column.

<img src="./images/Lab01/media/image22.png"
style="width:4.58197in;height:1.42138in" />

The point of the last few steps has been for you to become comfortable
with the translation editing experience. You can see the grid provides
an editing experience similar to working with Excel. You can even use
the **{F2}** key to move a cell with content into edit mode.

23. Now edit the translations in the Spanish column with better
    translated values. Use the following translations.

24. For the **Products** table, enter the Spanish translation of
    **Productos**.

25. For the **Product** column, enter the Spanish translation of
    **Producto**

26. For the **Image** column, enter the Spanish translation of
    **Imagen**.

27. For the **Sales** table, enter the Spanish translation of
    **Ventas**.

28. For the **Sales Revenue** measure, enter the Spanish translation of
    **Ingresos Por Ventas**.

29. For the **Units Sold** measure, enter the Spanish translation of
    **Unidades Vendidas**.

30. When you are done with your edits, the Spanish translations should
    match the following screenshot.

<img src="./images/Lab01/media/image23.png"
style="width:3.8239in;height:1.22098in" />

31. Return to the **TB-Lab01.pbix** project in Power BI Desktop and save
    your work by clicking the **Save** button.

<img src="./images/Lab01/media/image24.png"
style="width:3.19497in;height:0.947in" />

It’s easy to forget to save your changes in Power BI Desktop. Be aware
that any changes made by Translations Builder are just made to the data
model loaded in memory. None of your changes are saved back to the PBIX
project file until you save in Power BI Desktop.

32. Publish the **TB-Lab01.pbix** project to push the changes to the
    project’s translations to the Power BI Service.

<img src="./images/Lab01/media/image25.png"
style="width:5.19816in;height:0.8239in" />

33. When prompted by the **Replace this dataset?** Dialog, click the
    **Replace** button to continue.

<img src="./images/Lab01/media/image26.png"
style="width:2.17282in;height:1.41509in" />

34. Once you see **Success!**, click **Open ‘TB-Lab01.pbx’ in Power BI**
    to view the report in the Power BI Service.

<img src="./images/Lab01/media/image27.png"
style="width:2.11831in;height:1.3231in"
alt="Graphical user interface, text, application, email Description automatically generated" />

35. The report should load with its default behavior showing all text in
    English at first.

<img src="./images/Lab01/media/image28.png"
style="width:4.3122in;height:2.71669in"
alt="Table Description automatically generated" />

36. Inspect the table visual column headers which displays the names of
    columns and measures in English.

<img src="./images/Lab01/media/image29.png"
style="width:4.36478in;height:1.3105in" />

Now, it’s time to test your translations. You will accomplish this by
using the **language** query string parameter to load the report.

Click the browser address bar and add the following **language**
parameter to the end of the report URL.

/?language=es-ES

37. Press **ENTER.** You should see the **language** query string
    parameter accepted by the browser as it reloads the report.

<img src="./images/Lab01/media/image30.png"
style="width:6.48154in;height:0.81132in" />

When the report reloads, you should see the UI experience for the Power
BI Service UI switch from English to Spanish.

38. Verify the column and measure names in columns headings are
    displayed with the Spanish translations you added.

<img src="./images/Lab01/media/image31.png"
style="width:5.54899in;height:1.50943in" />

You have now successfully added the metadata translations to display
this report in both English and Spanish. Leave Power BI Desktop and
Translations Builder open as you will continue using them in your next
exercise.

### Exercise 2: Generating Machine Translations

In this lab you will configure Translations Builder’s support to
automatically generate machine translations using the Azure Translator
Service. While machine translations might not prove good enough to use
in all production scenarios, they do provide a great first step in
generating translations for testing and getting something into
production sooner.

To complete this lab you will require a **Key** and **Location** which
provide access to the **Azure Translator Service**. If you do not have a
Azure subscription and you cannot obtain your own Key, you can use the
following Key and Location up through February 28, 2023.

Key: **a75b371ce1fc402ca84a05732cfcff27**

Location: **eastus2**

1.  Return to Translations Builder and drop down the **Dataset
    Connection** menu.

<img src="./images/Lab01/media/image32.png"
style="width:3.25397in;height:1.03885in" />

39. Select the **Configure Settings…** menu command to display the
    **Configuration Options** dialog.

<img src="./images/Lab01/media/image33.png"
style="width:4.00833in;height:1.60606in" />

40. In the **Configuration Options** dialog, enter the **Key** and
    **Location** for the Azure Translator Service.

<img src="./images/Lab01/media/image34.png"
style="width:4.05319in;height:1.90012in" />

41. Once you have added the **Key** and **Location**, click **Save
    Changes**.

<img src="./images/Lab01/media/image35.png"
style="width:4.62372in;height:1.74468in" />

42. After you have configured the **Key** and **Location** for the Azure
    Translator Service, new controls will appear on the main page.

<img src="./images/Lab01/media/image36.png"
style="width:4.92453in;height:1.35122in" />

Now that you have added support for generating machine translations,
it’s time to put that automatic translation support to work!

43. Click the **Add Language** button to add your second secondary
    language.

<img src="./images/Lab01/media/image37.png"
style="width:5.38365in;height:1.2069in" />

You can hold down the **CTRL** key in the **Add Language** dialog while
selecting languages to enable multiple selection

44. Hold down the **CTRL**, and select **French**, **German** and
    **Italian**. And then click **Add Language**.

<img src="./images/Lab01/media/image38.png"
style="width:2.07505in;height:2.1761in" />

45. You should now see the three new languages appear in the **Secondary
    Languages** list.

46. You will also notice that new columns have been added to the
    translation grid for each new language.

<img src="./images/Lab01/media/image39.png"
style="width:5.45121in;height:2.42175in"
alt="Graphical user interface, application, table Description automatically generated" />

47. In the **Machine Translations – Single Language** section, select
    **French \[fr-FR\]** from the drop down menu.

<img src="./images/Lab01/media/image40.png"
style="width:5.5865in;height:1.2327in" />

48. Once you have selected **French \[fr-FR\]**, click **Generate
    Translations** to create French translations for all rows in the
    grid.

<img src="./images/Lab01/media/image41.png"
style="width:5.42692in;height:1.25786in" />

49. As the code runs to interact with the Azure Translator Service, the
    **Generating machine translation** dialog shows the progress.

<img src="./images/Lab01/media/image42.png"
style="width:6.05708in;height:2.71069in" />

50. Once this dialog closes, you should see all cells the French column
    has been filled with machine-generated translations.

<img src="./images/Lab01/media/image43.png"
style="width:6.44779in;height:2.86164in" />

51. Click the **Fill All Empty Translation** button in the **Machine
    Translations - All Languages** section.

<img src="./images/Lab01/media/image44.png"
style="width:6.4717in;height:1.40645in" />

52. You should see that the empty cells for all languages have now been
    populated with machine-generated translations.

<img src="./images/Lab01/media/image45.png"
style="width:6.22811in;height:2.74037in"
alt="Graphical user interface Description automatically generated" />

Now, it’s time once again to test your work in the Power BI Service,

53. Return to the **TB-Lab01.pbix** project in Power BI Desktop and save
    your work by clicking the **Save** button.

<img src="./images/Lab01/media/image24.png"
style="width:3.19497in;height:0.947in"
alt="Graphical user interface, application, Word Description automatically generated" />

Don’t forget to save your work! Did we mention it’s easy to forget to
save in Power BI Desktop and to lose your work.

54. Publish the **TB-Lab01.pbix** project to push your changes to the
    project’s translations to the Power BI Service.

<img src="./images/Lab01/media/image25.png"
style="width:5.19816in;height:0.8239in"
alt="Graphical user interface, application Description automatically generated" />

55. When prompted by the **Replace this dataset?** Dialog, click the
    **Replace** button to continue.

<img src="./images/Lab01/media/image26.png"
style="width:1.79787in;height:1.1709in"
alt="Graphical user interface, text, application, email Description automatically generated" />

56. Once you see **Success!**, click **Open ‘TB-Lab01.pbx’ in Power BI**
    to view the report in the Power BI Service.

<img src="./images/Lab01/media/image27.png"
style="width:2.1611in;height:1.34982in"
alt="Graphical user interface, text, application, email Description automatically generated" />

57. The report should load as normal showing all text in English at
    first.

<img src="./images/Lab01/media/image28.png"
style="width:4.61579in;height:2.90795in"
alt="Table Description automatically generated" />

Now, it’s time to test your French, German & Italian translations using
the **language** query string parameter to load the report.

58. Click the browser address bar and add the **language** parameter
    value of **fr-FR** for French to the end of the report URL.

/?language=fr-FR

59. When the report reloads, you should see the UI experience for the
    Power BI Service UI switch from English to French.

<img src="./images/Lab01/media/image46.png"
style="width:5.37121in;height:0.96133in" />

60. Verify the column and measure names in columns headings of the table
    visual are displayed with French translations.

<img src="./images/Lab01/media/image47.png"
style="width:5.76195in;height:1.63522in" />

Now that you have tested the French translations, it’s time to test the
two other new languages.

61. Click the browser address bar and add the **language** parameter
    value of **de-DE** for German to the end of the report URL.

/?language=de-DE

62. When the report reloads, you should see the UI experience for the
    Power BI Service UI switch to German.

<img src="./images/Lab01/media/image48.png"
style="width:5.68939in;height:1.00565in" />

63. Verify the column and measure names in columns headings are
    displayed with the German translations.

<img src="./images/Lab01/media/image49.png"
style="width:4.84326in;height:1.36508in" />

64. Click the browser address bar and add the **language** parameter of
    **it-IT** for Italian to the end of the report URL.

/?language=it-IT

65. When the report reloads, you should see the UI experience for the
    Power BI Service UI switch to Italian.

<img src="./images/Lab01/media/image50.png"
style="width:5.39683in;height:0.86563in" />

66. Verify the column and measure names in columns headings are
    displayed with the Italian translations.

<img src="./images/Lab01/media/image51.png"
style="width:4.90566in;height:1.2959in" />

You have now successfully added the metadata translations to display
this report in five different languages. Throughout these lab exercises,
you will continue to test all five languages in the browser as you add
additional translation support.

67. As a final step in this exercise, add a browser bookmark for each
    language with a **language** parameter at the end.

<img src="./images/Lab01/media/image52.png"
style="width:4.89308in;height:1.15046in" />

Creating a browser bookmark for each language might take a minute or two
to set up at first. However, it will save lots of time in the long run
as you continue to test the translations for this report in the lab work
that remains ahead.

### Exercise 3: Creating and Testing Report Label Translations

In this exercise, you will work through the process of adding report
label translations. You will add translations for the report title which
is **Product Sales Report** and for the title of the table visual which
is **Product List by Sales Revenue**. This will give you experience
working with the localized labels table strategy that Translations
Builder uses to quickly and easily implement report label translations.

1.  Return to the **TB-Lab01.pbix** project in Power BI Desktop and move
    to **Report view**.

<!-- -->

68. The text **Product Sales Report** is displayed with a rectangle
    shape object.

69. The text **Product Sales List by Sales Revenue** is displayed using
    the **Title** property of the table visual.

<img src="./images/Lab01/media/image53.png"
style="width:4.3245in;height:1.63492in" />

70. Now, move back to Translations Builder and drop down the **Generate
    Translated Tables** menu.

71. Select the **Create Localized Labels Table** to create the
    **Localized Labels Table**.

<img src="./images/Lab01/media/image54.png"
style="width:4.36671in;height:1.69841in" />

72. When you create the **Localized Labels** table, you will be prompted
    with the following dialog. Click **<u>N</u>o** to continue.

<img src="./images/Lab01/media/image55.png"
style="width:2.54873in;height:1.19564in"
alt="Graphical user interface, application Description automatically generated" />

If you click **<u>Y</u>es**, Translations Builder will launch a browser
and navigate to [this web
page](https://github.com/PowerBiDevCamp/TranslationsBuilder/blob/main/Docs/Building%20Multi-language%20Reports%20in%20Power%20BI.md#understanding-the-localized-labels-table)
which explains the localized labels strategy.

73. Once Translations Builder has created the **Localized Labels**
    table, it will also add three sample report labels.

<img src="./images/Lab01/media/image56.png"
style="width:5.94813in;height:1.31746in" />

Over the next few steps, you will delete these three sample report
labels and replace them by adding two of your own.

74. Drop down the **Generate Translated Tables** menu and select click
    **Add Labels to the Localized Labels Table**.

<img src="./images/Lab01/media/image57.png"
style="width:3.16079in;height:1.1761in" />

Note you can also execute the **Add Labels to the Localized Labels
Table** command using the shortcut key of **Ctrl+A**.

75. In the **Add Localized Labels** dialog, click the **Advanced Mode**
    checkbox.

<img src="./images/Lab01/media/image58.png"
style="width:3.43246in;height:1.11321in" />

76. Once the dialog is in **Advanced Mode**, click the **Delete All
    Labels** button to remove the sample report labels.

<img src="./images/Lab01/media/image59.png"
style="width:2.70501in;height:1.67925in" />

77. In the **Labels** textbox, type the report label **Product Sales
    Report**.

78. Enter a line break and then type in the second label **Product List
    by Sales Revenue**.

79. Click the **Add Labels** button to add the two new labels to your
    project.

<img src="./images/Lab01/media/image60.png"
style="width:2.8671in;height:1.77987in" />

80. You should now see two new rows have been added to the translations
    gird with the two new report labels.

<img src="./images/Lab01/media/image61.png"
style="width:6.39188in;height:1.16981in" />

81. Click the **Fill All Empty Translations** button to create all the
    translations for both report labels.

<img src="./images/Lab01/media/image62.png"
style="width:3.74214in;height:1.57277in" />

82. At this point, the translations grid should be completely filled
    with machine-generated translations.

<img src="./images/Lab01/media/image63.png"
style="width:6.81761in;height:0.99676in" />

There is one critical step you must complete after modifying report
labels in the **Localized Labels** table. More specifically, you must
execute **Generate Translated Localized Labels Table** to create the
measures that will be used to surface report labels on a report.

83. Drop down the **Generate Translated Tables** menu and select click
    **Generate Translated Localized Labels Table**.

<img src="./images/Lab01/media/image64.png"
style="width:3.06918in;height:1.08398in" />

Note you can also execute the **Generate Translated Localized Labels
Table** command using the shortcut key of **Ctrl+L**.

84. Return to Power BI Desktop and navigate to **Report view**.

85. Locate the **Translated Localized Labels** table in the **Fields**
    list.

<img src="./images/Lab01/media/image65.png"
style="width:4.15873in;height:1.32327in" />

86. Select the measure named **Product Sales Report Label** and examine
    the DAX expression behind this measure.

<img src="./images/Lab01/media/image66.png"
style="width:3.60641in;height:1.38994in" />

The measures in the **Translated Localized Labels** table are what you
use to display report labels on a Power BI report.

87. Select the measure named **Product List by Sales Revenue Label** and
    examine its DAX expression.

<img src="./images/Lab01/media/image67.png"
style="width:3.65079in;height:1.32639in" />

Now that you have created the measures for translation in the
**Translated Localized Labels** table, it’s time to use them in the
report.

88. In the report layout, select the large yellow rectangle shape that
    displays the report title **Product Sales Report**.

89. With the rectangle shaped selected, move to the **Format** pane and
    locate the **Text** section inside the **Style** selection.

<img src="./images/Lab01/media/image68.png"
style="width:4.65409in;height:1.93277in" />

90. Expand the **Text** section to see the **Text** property is
    configured with the literal string value of **Product Sales
    Report**.

<img src="./images/Lab01/media/image69.png"
style="width:3.38365in;height:1.08839in" />

Literal string values in a report layout cannot be localized. Therefore,
you will replace this literal string with a measure with translations.

91. Click on the ***fx*** button to the right of the textbox to replace
    the literal string value.

<img src="./images/Lab01/media/image70.png"
style="width:2.82584in;height:0.98742in" />

92. In the **Text – Style** dialog, select **Field value** as the
    **Format style**.

93. Drop down the select control with the caption of **What field should
    we base this on?**

<img src="./images/Lab01/media/image71.png"
style="width:2.40252in;height:1.21196in" />

94. Select the **Product Sales Report Label** measure from the
    **Translated Localized Labels** table.

<img src="./images/Lab01/media/image72.png"
style="width:2.54088in;height:1.82252in" />

Now that you have configured the report title to support translations,
you will do the same for the title of the table visual.

95. Select the table visual that display the product list.

96. With the table visual selected, move to the **Format** pane and
    click the **General** tab.

97. Locate the **Title** section and the **Text** property inside with
    the literal text value of **Product List by Sales Revenue**.

<img src="./images/Lab01/media/image73.png"
style="width:4.04403in;height:1.37525in" />

98. Click on the ***fx*** button to the right of the textbox to replace
    the literal string value.

<img src="./images/Lab01/media/image74.png"
style="width:1.34831in;height:1.34591in" />

99. In the **Text – Style** dialog, select **Field value** as the
    **Format style**.

100. Drop down the select menu with the caption of **What field should
     we base this on?**

101. Select the **Product List by Sales Revenue Label** measure from the
     **Translated Localized Labels** table.

<img src="./images/Lab01/media/image75.png"
style="width:3.18868in;height:1.98132in" />

Now, it’s time once again to test your work in the Power BI Service,

102. Save your work by clicking the **Save** button.

<img src="./images/Lab01/media/image24.png"
style="width:3.48089in;height:1.03175in"
alt="Graphical user interface, application, Word Description automatically generated" />

Don’t forget to save your work! Did we mention it’s easy to forget and
to lose your work.

103. Publish the **TB-Lab01.pbix** project to push your changes to the
     project’s translations to the Power BI Service.

<img src="./images/Lab01/media/image25.png"
style="width:5.31636in;height:0.84127in"
alt="Graphical user interface, application Description automatically generated" />

104. When prompted by the **Replace this dataset?** Dialog, click the
     **Replace** button to continue.

105. Once you see **Success!**, click **Open ‘TB-Lab01.pbx’ in Power
     BI** to view the report in the Power BI Service.

106. The report should load as normal showing all text in English at
     first.

107. Use the bookmark created earlier to load the report in Spanish.
     Verify the report labels show Spanish translations.

<img src="./images/Lab01/media/image76.png"
style="width:3.91in;height:1.66in" />

108. Use the bookmark created earlier to load the report in French.
     Verify the report labels show French translations.

<img src="./images/Lab01/media/image77.png"
style="width:3.66in;height:1.58in" />

109. Use the bookmark created earlier to load the report in German.
     Verify the report labels show German translations.

<img src="./images/Lab01/media/image78.png"
style="width:3.7in;height:1.6in" />

110. Use the bookmark created earlier to load the report in Italian.
     Verify the report labels show Italian Translations.

<img src="./images/Lab01/media/image79.png"
style="width:4.3in;height:1.79in" />

You have now implemented report label translations using the
Translations Builder localized label strategy. You should be able to see
that this will add a significant level of productivity to your future
efforts to build Power BI reports that support multiple languages.

### Exercise 4: Creating a Workflow Process To Gather & Integrate Human Translations

Up to this point, you have done the work required to get the report and
its underlying dataset into a structure to support translations for
secondary languages. You were able to complete this work in a quick and
efficient manner using Translations Builder together with
machine-generated translations. However. It’s import to acknowledge that
machine-generated translations alone will not be adequate for many
production scenarios. You will need a way to integrate other people
acting as translators into a human workflow process.

In this lab exercise, you will with the Translations Builder features to
export and import translations using a CSV file format. This will
provide a quick way to generate translations sheets that can be sent to
human translators. As you will see, translators can make their edits to
a translation sheets using Microsoft Excel. Once you’ve received an
updated translation sheet back from a translator, Translation Builder
provides an import operation to integrate those updated translations
back into the dataset for the current project.

**Prerequisite**: To complete this exercise, you will need Microsoft
Excel installed on the same PC running Translations Builder.

1.  Launch Windows Explorer and navigate to the folder where you copied
    the project file **TB-Lab01.pbix**.

<img src="./images/Lab01/media/image80.png"
style="width:2.56604in;height:0.9212in" />

111. Create two new folders inside the lab folder named **Outbox** and
     **Inbox**.

<img src="./images/Lab01/media/image81.png"
style="width:2.54088in;height:1.13751in" />

Next, you need to configure settings in Translations Builder so that
these folders are used as targets for export and import operations.

112. Return to Translations Builder and drop down the **Dataset
     Connection** menu.

113. Click **Configure Settings…** to display the **Configuration
     Options** dialog.

<img src="./images/Lab01/media/image82.png"
style="width:2.43649in;height:1.1761in" />

114. By default, folder paths for the **Outbox** and **Inbox** are
     configured to target the current user’s **Documents** folder.

<img src="./images/Lab01/media/image83.png"
style="width:3.39in;height:1.33in" />

Why does **Outbox** come before **Inbox**? That’s because you generally
work with the **Outbox** first when you export translation sheets that
you will send to translators. Once you get updated translations sheets
back from translators, you add them to the **Inbox** for import.

115. Click the **set** button to update the setting for **Translations
     Outbox Folder Path**.

<img src="./images/Lab01/media/image84.png"
style="width:3.27in;height:1.28in" />

116. Select the **Outbox** folder you created earlier in this exercise.

<img src="./images/Lab01/media/image85.png"
style="width:2.84277in;height:1.59321in" />

117. Click the **set** button for **Translations Inbox Folder Path** and
     select the **Inbox** folder you created earlier

<img src="./images/Lab01/media/image86.png"
style="width:3.46in;height:1.39in" />

118. Click **Save Changes**.

<img src="./images/Lab01/media/image87.png"
style="width:3.41in;height:1.37in" />

Now that you have configured the folder paths for the Outbox and Inbox,
it’s time to begin exporting translation sheets.

119. Examine what’s inside the Export/Import Translations section.

<img src="./images/Lab01/media/image88.png"
style="width:4.87302in;height:1.41879in" />

Let’s start by creating a translation sheet for a single language.

120. Drop down the selection menu under the **Export Translations
     Sheet** button and select **German \[de-DE\]**.

<img src="./images/Lab01/media/image89.png"
style="width:2.89512in;height:1.06289in" />

121. After selecting **German \[de-DE\]**, click the **Export
     Translations Sheet** button.

<img src="./images/Lab01/media/image90.png"
style="width:2.84906in;height:1.02737in" />

Translations Builder should create a translation sheet named
**TB-Lab01-Translations-German.csv** and open this CSV file in Excel

122. Examine the contents of **TB-Lab01-Translations-German.csv**.

<img src="./images/Lab01/media/image91.png"
style="width:2.66332in;height:1.75472in"
alt="Graphical user interface, application, table, Excel Description automatically generated" />

Over the next two steps you will use a trick in Excel to widen the
columns so ou can see all their contents.

123. Click on the top left corner where the row headers and the column
     headers meet. This should select all columns and rows.

<img src="./images/Lab01/media/image92.png"
style="width:2.7421in;height:1.41509in" />

124. Double-click on the column heading divider between the column
     headers showing **A** and **B**.

<img src="./images/Lab01/media/image93.png"
style="width:2.4151in;height:1.24849in" />

125. You should now be able to see all the text from each column.

<img src="./images/Lab01/media/image94.png"
style="width:4.22642in;height:1.18786in" />

This translation sheet is what you will send to translators. They can
then use Excel to review the machine translations and make changes
wherever they are required.

126. Close **TB-Lab01-Translations-German.csv** and return to
     Translation Builder.

127. Click the **Export All Translations** button to export a master
     translation sheet with the translations for all languages.

<img src="./images/Lab01/media/image95.png"
style="width:2.45283in;height:1.42953in" />

Translations Builder creates a translation sheet named
**TB-Lab01-Translations-Master.csv** and opens this CSV file in Excel

128. When **TB-Lab01-Translations-Master.csv** open in Microsoft Excel,
     you cannot see the contents of all columns at first.

<img src="./images/Lab01/media/image96.png"
style="width:3.98113in;height:1.59983in" />

129. Use the Excel trick you learned earlier to expand all columns so
     you can see the entire contents of all cells.

<img src="./images/Lab01/media/image97.png"
style="width:6.95291in;height:0.96226in" />

Now that you have learned to export translations sheets, it’s time to
examine how to manage translation sheet files.

130. In Windows Explorer, navigate to the **Outbox** folder. You should
     see the two files you generated using export operations.

<img src="./images/Lab01/media/image98.png"
style="width:5.91195in;height:1.68623in" />

131. Return to Translations Builder and uncheck the checkbox with the
     caption **Open Export in Excel**.

<img src="./images/Lab01/media/image99.png"
style="width:2.69811in;height:1.56947in" />

All three export commands use this checkbox to decide whether to open a
translation sheet in Excel after it’s generated. In some cases, it’s
handy to have the translation sheet open in Excel. In other scenarios
like the one ahead, it’s unnecessary and distracting.

132. Click the **Export All Translation Sheets** button.

<img src="./images/Lab01/media/image100.png"
style="width:2.67296in;height:1.61641in" />

The **Export All Translation Sheets** command generates the complete set
of translation sheets to be sent to translators.

133. Return to the **Outbox** folder in Windows Explorer.

134. You should see that a sperate translation sheet has been generated
     for each secondary language.

<img src="./images/Lab01/media/image101.png"
style="width:4.26192in;height:1.8421in"
alt="Graphical user interface, text, application, email Description automatically generated" />

Now that you have experienced how to export translation sheets, you will
now learn how to import translation sheets.

135. In the **Outbox** folder in Windows Explorer, select
     **TB-Lab01-Translations-Master.csv** and
     **TB-Lab01-Translations-Spanish.csv**.

<img src="./images/Lab01/media/image102.png"
style="width:3.86419in;height:1.67019in"
alt="Graphical user interface, text, application, email Description automatically generated" />

136. Copy the two selected translation sheet files to the Windows
     clipboard.

137. Navigate from the **Outbox** folder to the **Inbox** folder.

138. Paste the two translation sheet files from the Windows clipboard
     into the **Inbox** folder.

<img src="./images/Lab01/media/image103.png"
style="width:4.42538in;height:1.91275in"
alt="Graphical user interface, text, application, email Description automatically generated" />

139. Open the translation sheet named
     **Inbox\TB-Lab01-Translations-Spanish.csv** in Microsoft Excel.

<img src="./images/Lab01/media/image104.png"
style="width:4.95306in;height:1.7619in" />

The job of the translator is to review all translations in the fifth
column and to make updates where appropriate. From the perspective of
the translator, the top row with column headers and the first four
columns should be treated as read-only values.

140. Enter new values for each of the Spanish translations in the fifth
     column.

<img src="./images/Lab01/media/image105.png"
style="width:5.18424in;height:1.22222in" />

Don’t worry whether the values you are valid translations. You just need
to add any text so you can test the import process.

141. Save your changes to **TB-Lab01-Translations-Spanish.csv** and then
     close the file in Microsoft Excel.

142. Return to Translations Builder and click the **Import
     Translations** button.

<img src="./images/Lab01/media/image106.png"
style="width:2.25397in;height:1.31779in" />

Remember to close translation sheet files in Microsoft Excel before
importing them with Translations Builder to prevent errors.

143. In the **Open** file dialog, select
     **TB-Lab01-Translations-Spanish.csv** and click **Open**.

<img src="./images/Lab01/media/image107.png"
style="width:3.06918in;height:1.48451in" />

144. You should see that your updates to the Spanish translation sheet
     now appear in the translation grid.

<img src="./images/Lab01/media/image108.png"
style="width:5.02516in;height:1.28573in" />

Now that you have seen how to how to import translations from an updated
translations sheet with a single language, it’s time to move ahead and
import translations from all languages at once by importing the master
translation sheet.

145. click the **Import Translations** button.

<img src="./images/Lab01/media/image106.png"
style="width:2.26415in;height:1.32375in" />

146. In the **Open** file dialog, select
     **TB-Lab01-Translations-Master.csv** and click **Open**.

<img src="./images/Lab01/media/image109.png"
style="width:3.95598in;height:1.46488in" />

147. You should see that the original, machine-generated Spanish
     translations now appear in the translation grid.

<img src="./images/Lab01/media/image110.png"
style="width:5.04762in;height:1.15588in" />

You can see that the master translation sheet can also serve as a great
way to backup and restore your translations work. To make this point,
you are now going to delete the column for French. Deleting a column
like this will delete all translations for that language. As you will
see, Translations Builder will automatically add the column back if it
finds the column when importing a translation sheet.

148. Right-click on the **French \[fr-FR\]** column header and click
     **Delete Secondary Language**.

<img src="./images/Lab01/media/image111.png"
style="width:5.15723in;height:0.93094in" />

149. When prompted by the **Confirm Delete Secondary Language
     Operation** dialog, click **OK** to continue.

<img src="./images/Lab01/media/image112.png"
style="width:2.84986in;height:1.17149in"
alt="Graphical user interface, application Description automatically generated" />

150. You should see that the column for French has been removed from the
     translations grid.

<img src="./images/Lab01/media/image113.png"
style="width:6.4127in;height:1.10314in" />

151. click the **Import Translations** button.

152. In the **Open** file dialog, select
     **TB-Lab01-Translations-Master.csv** and click **Open**.

153. After the import operation competes, the **French \[fr-FR\]**
     column should reappear as the last column on the right.

<img src="./images/Lab01/media/image114.png"
style="width:5.26083in;height:1.94969in" />

Congratulations. You have now completed this lab.
