pandoc -s --extract-media ./images/TranslationsBuilder "ReadMe.docx" -t gfm -o ./../ReadMe.md

(Get-Content -path ./../ReadMe.md -Raw) -replace './images/TranslationsBuilder','./Docs/images/TranslationsBuilder' | Set-Content -Path ./../ReadMe.md

pandoc -s --extract-media ./images/UnderstandingTranslationsInPowerBI "Understanding Translations in Power BI.docx" -t gfm -o "Understanding Translations in Power BI.md"

pandoc -s --extract-media ./images/HandsOnLab "Hands-On Lab.docx" -t gfm -o "Hands-On Lab.md"

pandoc -s --extract-media ./images/Install "Install.docx" -t gfm -o "Install.md"