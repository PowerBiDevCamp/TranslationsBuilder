pandoc -s --extract-media ./images/TranslationsBuilder "TranslationsBuilder.docx" -t gfm -o ./../ReadMe.md

(Get-Content -path ./../ReadMe.md -Raw) -replace './images/TranslationsBuilder','./Docs/images/TranslationsBuilder' | Set-Content -Path ./../ReadMe.md

pandoc -s --extract-media ./images/BuildingMultilanguageReportsInPowerBI "Building Multi-language Reports in Power BI.docx" -t gfm -o BuildingMultilanguageReportsInPowerBI.md

pandoc -s --extract-media ./images/HandsOnLab "Hands-On-Lab.docx" -t gfm -o Hands-On-Lab.md