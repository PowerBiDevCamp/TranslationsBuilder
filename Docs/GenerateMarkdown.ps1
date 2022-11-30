pandoc -s --extract-media ./images/TranslationsBuilder "ReadMe.docx" -t gfm -o ./../ReadMe.md

(Get-Content -path ./../ReadMe.md -Raw) -replace './images/TranslationsBuilder','./Docs/images/TranslationsBuilder' | Set-Content -Path ./../ReadMe.md

pandoc -s --extract-media ./images/UnderstandingTranslationsInPowerBI "Understanding Translations in Power BI.docx" -t gfm -o "Understanding Translations in Power BI.md"

pandoc -s --extract-media ./images/HandsOnLabExercises "Hands-On Lab Exercises.docx" -t gfm -o "Hands-On Lab Exercises.md"

pandoc -s --extract-media ./images/UserGuide "User Guide.docx" -t gfm -o "User Guide.md"

pandoc -s --extract-media ./images/DeveloperGuide "Developer Guide.docx" -t gfm -o "Developer Guide.md"
