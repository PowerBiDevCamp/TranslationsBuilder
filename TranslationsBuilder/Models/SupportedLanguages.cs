using System;
using System.Linq;
using System.Collections.Generic;
using TranslationsBuilder.Models;

namespace TranslationsBuilder.Models {

  class SupportedLanguages {


    static public Language Afrikaans = new Language { LanguageTag = "af-ZA", TranslationId = "af", DisplayName = "Afrikaans", NativeName = "Afrikaans", ShownOnlyOnExtendedLanguageList = false };
    static public Language Arabic = new Language { LanguageTag = "ar-001", TranslationId = "ar", DisplayName = "Arabic", NativeName = "العربية", ShownOnlyOnExtendedLanguageList = true };
    static public Language Bulgarian = new Language { LanguageTag = "bg-BG", TranslationId = "bg", DisplayName = "Bulgarian", NativeName = "български", ShownOnlyOnExtendedLanguageList = true };
    static public Language Catalan = new Language { LanguageTag = "ca-ES", TranslationId = "ca", DisplayName = "Catalan", NativeName = "Català", ShownOnlyOnExtendedLanguageList = true };
    static public Language Chinese = new Language { LanguageTag = "zh-CN", TranslationId = "zh-Hans", DisplayName = "Chinese", NativeName = "中文", ShownOnlyOnExtendedLanguageList = false };
    static public Language Croatian = new Language { LanguageTag = "hr-HR", TranslationId = "hr", DisplayName = "Croatian", NativeName = "Hrvatski", ShownOnlyOnExtendedLanguageList = true };
    static public Language Czech = new Language { LanguageTag = "cs-CZ", TranslationId = "cs", DisplayName = "Czech", NativeName = "Ceština", ShownOnlyOnExtendedLanguageList = true };
    static public Language Danish = new Language { LanguageTag = "da-DK", TranslationId = "da", DisplayName = "Danish", NativeName = "Dansk", ShownOnlyOnExtendedLanguageList = true };
    static public Language Dutch = new Language { LanguageTag = "nl-NL", TranslationId = "nl", DisplayName = "Dutch", NativeName = "Nederlands", ShownOnlyOnExtendedLanguageList = false };
    static public Language English = new Language { LanguageTag = "en-US", TranslationId = "en", DisplayName = "English", NativeName = "English", ShownOnlyOnExtendedLanguageList = false };
    static public Language Estonian = new Language { LanguageTag = "et-EE", TranslationId = "et", DisplayName = "Estonian", NativeName = "Eesti", ShownOnlyOnExtendedLanguageList = true };
    static public Language Filipino = new Language { LanguageTag = "fil-PH", TranslationId = "fil", DisplayName = "Filipino", NativeName = "Filipino", ShownOnlyOnExtendedLanguageList = true };
    static public Language Finnish = new Language { LanguageTag = "fi-FI", TranslationId = "fi", DisplayName = "Finnish", NativeName = "Suomi", ShownOnlyOnExtendedLanguageList = false };
    static public Language French = new Language { LanguageTag = "fr-FR", TranslationId = "fr", DisplayName = "French", NativeName = "Français", ShownOnlyOnExtendedLanguageList = false };
    static public Language German = new Language { LanguageTag = "de-DE", TranslationId = "de", DisplayName = "German", NativeName = "Deutsch", ShownOnlyOnExtendedLanguageList = false };
    static public Language Greek = new Language { LanguageTag = "el-GR", TranslationId = "el", DisplayName = "Greek", NativeName = "Greece", ShownOnlyOnExtendedLanguageList = false };
    static public Language Hebrew = new Language { LanguageTag = "he-IL", TranslationId = "he", DisplayName = "Hebrew", NativeName = "ישראל", ShownOnlyOnExtendedLanguageList = false };
    static public Language Hindi = new Language { LanguageTag = "hi-IN", TranslationId = "hi", DisplayName = "Hindi", NativeName = "हिन्दी", ShownOnlyOnExtendedLanguageList = false };
    static public Language Hungarian = new Language { LanguageTag = "hu-HU", TranslationId = "hu", DisplayName = "Hungarian", NativeName = "Magyar", ShownOnlyOnExtendedLanguageList = true };
    static public Language Icelandic = new Language { LanguageTag = "is-IS", TranslationId = "is", DisplayName = "Icelandic", NativeName = "Islenska", ShownOnlyOnExtendedLanguageList = true };
    static public Language Indonesian = new Language { LanguageTag = "id-ID", TranslationId = "id", DisplayName = "Indonesian", NativeName = "Indonesia", ShownOnlyOnExtendedLanguageList = true };
    static public Language Irish = new Language { LanguageTag = "ga-IE", TranslationId = "ga", DisplayName = "Irish", NativeName = "Gaeilge", ShownOnlyOnExtendedLanguageList = true };
    static public Language Italian = new Language { LanguageTag = "it-IT", TranslationId = "it", DisplayName = "Italian", NativeName = "Italiano", ShownOnlyOnExtendedLanguageList = false };
    static public Language Japanese = new Language { LanguageTag = "ja-JP", TranslationId = "ja", DisplayName = "Japanese", NativeName = "日本語 (日本)", ShownOnlyOnExtendedLanguageList = false };
    static public Language Korean = new Language { LanguageTag = "ko-KR", TranslationId = "ko", DisplayName = "Korean", NativeName = "한국어(대한민국)", ShownOnlyOnExtendedLanguageList = true };
    static public Language Latvian = new Language { LanguageTag = "lv-LV", TranslationId = "lv", DisplayName = "Latvian", NativeName = "Latviešu", ShownOnlyOnExtendedLanguageList = true };
    static public Language Napali = new Language { LanguageTag = "ne-NP", TranslationId = "ne", DisplayName = "Napali", NativeName = "Napal", ShownOnlyOnExtendedLanguageList = true };
    static public Language Norwegian = new Language { LanguageTag = "nb-NO", TranslationId = "nb", DisplayName = "Norwegian", NativeName = "Norsk", ShownOnlyOnExtendedLanguageList = false };
    static public Language Persian = new Language { LanguageTag = "fa-IR", TranslationId = "fa", DisplayName = "Persian", NativeName = "فارسی (ایران)", ShownOnlyOnExtendedLanguageList = true };
    static public Language Polish = new Language { LanguageTag = "pl-PL", TranslationId = "pl", DisplayName = "Polish", NativeName = "Polski", ShownOnlyOnExtendedLanguageList = false };
    static public Language Portuguese = new Language { LanguageTag = "pt-PT", TranslationId = "pt", DisplayName = "Portuguese", NativeName = "Português", ShownOnlyOnExtendedLanguageList = false };
    static public Language Romanian = new Language { LanguageTag = "ro-RO", TranslationId = "ro", DisplayName = "Romanian", NativeName = "Română", ShownOnlyOnExtendedLanguageList = true };
    static public Language Russian = new Language { LanguageTag = "ru-RU", TranslationId = "ru", DisplayName = "Russian", NativeName = "Pусский", ShownOnlyOnExtendedLanguageList = false };
    static public Language Serbian = new Language { LanguageTag = "sr-Latn-BA", TranslationId = "sr-Latn", DisplayName = "Serbian", NativeName = "Srpski", ShownOnlyOnExtendedLanguageList = true };
    static public Language Slovak = new Language { LanguageTag = "sk-SK", TranslationId = "sk", DisplayName = "Slovak", NativeName = "Slovenčina", ShownOnlyOnExtendedLanguageList = true };
    static public Language Slovenian = new Language { LanguageTag = "sl-SI", TranslationId = "sl", DisplayName = "Slovenian", NativeName = "Slovenščina (Slovenija)", ShownOnlyOnExtendedLanguageList = true };
    static public Language Somalian = new Language { LanguageTag = "so-SO", TranslationId = "so", DisplayName = "Somalian", NativeName = "Somalia", ShownOnlyOnExtendedLanguageList = true };
    static public Language Spanish = new Language { LanguageTag = "es-ES", TranslationId = "es", DisplayName = "Spanish", NativeName = "Español", ShownOnlyOnExtendedLanguageList = false };
    static public Language Swedish = new Language { LanguageTag = "sv-SE", TranslationId = "sv", DisplayName = "Swedish", NativeName = "Svenska", ShownOnlyOnExtendedLanguageList = false };
    static public Language Thai = new Language { LanguageTag = "th-TH", TranslationId = "th", DisplayName = "Thai", NativeName = "ไทย", ShownOnlyOnExtendedLanguageList = false };
    static public Language Turkish = new Language { LanguageTag = "tr-TR", TranslationId = "tr", DisplayName = "Turkish", NativeName = "Türkçe", ShownOnlyOnExtendedLanguageList = true };
    static public Language Ukrainian = new Language { LanguageTag = "uk-UA", TranslationId = "uk", DisplayName = "Ukrainian", NativeName = "українська", ShownOnlyOnExtendedLanguageList = false };
    static public Language Vietnamese = new Language { LanguageTag = "vi-VN", TranslationId = "vi", DisplayName = "Vietnamese", NativeName = "Tiếng Việt", ShownOnlyOnExtendedLanguageList = true };

    static public Dictionary<string, Language> AllLangauges =
           new Dictionary<string, Language>{
                        { Afrikaans.LanguageTag, Afrikaans },
             { Arabic.LanguageTag, Arabic },
             { Bulgarian.LanguageTag, Bulgarian },
             { Catalan.LanguageTag, Catalan },
             { Chinese.LanguageTag, Chinese },
             { Croatian.LanguageTag, Croatian },
             { Czech.LanguageTag, Czech },
             { Danish.LanguageTag, Danish },
             { Dutch.LanguageTag, Dutch },
             { English.LanguageTag, English },
             { Estonian.LanguageTag, Estonian },
             { Filipino.LanguageTag, Filipino },
             { Finnish.LanguageTag, Finnish },
             { French.LanguageTag, French },
             { German.LanguageTag, German },
             { Greek.LanguageTag, Greek },
             { Hebrew.LanguageTag, Hebrew },
             { Hindi.LanguageTag, Hindi },
             { Hungarian.LanguageTag, Hungarian },
             { Icelandic.LanguageTag, Icelandic },
             { Indonesian.LanguageTag, Indonesian },
             { Irish.LanguageTag, Irish },
             { Italian.LanguageTag, Italian },
             { Japanese.LanguageTag, Japanese },
             { Korean.LanguageTag, Korean },
             { Latvian.LanguageTag, Latvian },
             { Napali.LanguageTag, Napali },
             { Norwegian.LanguageTag, Norwegian },
             { Persian.LanguageTag, Persian },
             { Polish.LanguageTag, Polish },
             { Portuguese.LanguageTag, Portuguese },
             { Romanian.LanguageTag, Romanian },
             { Russian.LanguageTag, Russian },
             { Serbian.LanguageTag, Serbian },
             { Slovak.LanguageTag, Slovak },
             { Slovenian.LanguageTag, Slovenian },
             { Somalian.LanguageTag, Somalian },
             { Spanish.LanguageTag, Spanish },
             { Swedish.LanguageTag, Swedish },
             { Thai.LanguageTag, Thai },
             { Turkish.LanguageTag, Turkish },
             { Ukrainian.LanguageTag, Ukrainian },
             { Vietnamese.LanguageTag, Vietnamese }

    };


    static public Dictionary<string, Language> GetCommonLangauges() {

      var commonLanguages = new Dictionary<string, Language>();

      foreach (var language in AllLangauges) {
        if (!language.Value.ShownOnlyOnExtendedLanguageList)
          commonLanguages.Add(language.Key, language.Value);
      }

      return commonLanguages;

    }

    static public Language GetLanguageFromFullName(string FullName) {
      return AllLangauges.First(languageEntry => languageEntry.Value.FullName == FullName).Value;
    }

  }
}
