using System;
using System.Linq;
using System.Collections.Generic;

namespace TranslationsBuilder.Models {

  class SupportedLanguages {

    static public Language English = new Language {
      LanguageTag = "en-US",
      TranslationId = "en",
      DisplayName = "English",
      NativeName = "English"
    };

    static public Language Spanish = new Language {
      LanguageTag = "es-ES",
      TranslationId = "es",
      DisplayName = "Spanish",
      NativeName = "español"
    };

    static public Language Portuguese = new Language {
      LanguageTag = "pt-PT",
      TranslationId = "pt",
      DisplayName = "Portuguese",
      NativeName = "Portuguese"
    };

    static public Language French = new Language {
      LanguageTag = "fr-FR",
      TranslationId = "fr",
      DisplayName = "French",
      NativeName = "français"
    };

    static public Language German = new Language {
      LanguageTag = "de-DE",
      TranslationId = "de",
      DisplayName = "German",
      NativeName = "Deutsch"
    };

    static public Language Dutch = new Language {
      LanguageTag = "nl-NL",
      TranslationId = "nl",
      DisplayName = "Dutch",
      NativeName = "Nederlands"
    };

    static public Language Italian = new Language {
      LanguageTag = "it-IT",
      TranslationId = "it",
      DisplayName = "Italian",
      NativeName = "Italy"
    };

    static public Language Irish = new Language {
      LanguageTag = "ga-IE",
      TranslationId = "ga",
      DisplayName = "Irish",
      NativeName = "Gaeilge"
    };

    static public Language Russian = new Language {
      LanguageTag = "ru-RU",
      TranslationId = "ru",
      DisplayName = "Russian",
      NativeName = "русский"
    };

    static public Language Hebrew = new Language {
      LanguageTag = "he-IL",
      TranslationId = "he",
      DisplayName = "Hebrew",
      NativeName = "עברית"
    };

    static public Language Hindi = new Language {
      LanguageTag = "hi-IN",
      TranslationId = "hi",
      DisplayName = "Hindi",
      NativeName = "हिन्दी"
    };

    static public Language Japanese = new Language {
      LanguageTag = "ja-JP",
      TranslationId = "ja",
      DisplayName = "Japanese",
      NativeName = "日本語"
    };

    static public Language Chinese = new Language {
      LanguageTag = "zh-CN",
      TranslationId = "zh-Hans",
      DisplayName = "Chinese",
      NativeName = "中文"
    };

    static public Language Greek = new Language {
      LanguageTag = "el-GR",
      TranslationId = "el",
      DisplayName = "Greek",
      NativeName = "Greece"
    };

    static public Language Napali = new Language {
      LanguageTag = "ne-NP",
      TranslationId = "ne",
      DisplayName = "Napali",
      NativeName = "Napal"
    };

    static public Language Romanian = new Language {
      LanguageTag = "ro-RO",
      TranslationId = "ro",
      DisplayName = "Romanian",
      NativeName = "Napal"
    };

    static public Language Somalian = new Language {
      LanguageTag = "so-SO",
      TranslationId = "so",
      DisplayName = "Somalian ",
      NativeName = "Somalia"
    };

    static public Language Swedish = new Language {
      LanguageTag = "sv-SE",
      TranslationId = "ro",
      DisplayName = "Swedish",
      NativeName = "Sweeden"
    };


    static public Language Turkish = new Language {
      LanguageTag = "tr-TR",
      TranslationId = "tr",
      DisplayName = "Turkish",
      NativeName = "Turkey"
    };

    static public Language Ukranian = new Language {
      LanguageTag = "uk-UA",
      TranslationId = "uk",
      DisplayName = "Ukranian",
      NativeName = "Ukrania"
    };

    static public Language Vietnamese = new Language {
      LanguageTag = "vi-VN",
      TranslationId = "vi",
      DisplayName = "Vietnamese",
      NativeName = "Vietnam"
    };

    static public Dictionary<string, Language> AllLangauges =
           new Dictionary<string, Language>{
             { English.LanguageTag, English },
             { Spanish.LanguageTag, Spanish },
             { Portuguese.LanguageTag, Portuguese },
             { French.LanguageTag, French },
             { German.LanguageTag, German },
             { Dutch.LanguageTag, Dutch },
             { Irish.LanguageTag, Irish},
             { Russian.LanguageTag, Russian },
             { Hebrew.LanguageTag, Hebrew },
             { Hindi.LanguageTag, Hindi },
             { Japanese.LanguageTag, Japanese },
             { Chinese.LanguageTag, Chinese },
             { Greek.LanguageTag, Greek },
             { Napali.LanguageTag, Napali },
             { Romanian .LanguageTag, Romanian },
             { Somalian.LanguageTag, Somalian },
             { Swedish.LanguageTag, Swedish },
             { Turkish .LanguageTag, Turkish },
             { Ukranian .LanguageTag, Ukranian },
             { Vietnamese.LanguageTag, Vietnamese }
    };

    static public Language GetLanguageFromFullName(string FullName) {
      return AllLangauges.First(languageEntry => languageEntry.Value.FullName == FullName).Value;
    }

  }
}
