﻿namespace Exercism.GenericTypes
{
    public class TracksOnTracksOnTracksGeneric
    {
        public static List<string> NewList() => new List<string>();
        public static List<string> GetExistingLanguages() => new List<string>() { "C#", "Clojure", "Elm" };
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages) => languages.Count;
        public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);
        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0)
                return false;
            if (languages[0] == "C#" ||
                languages[1] == "C#" && languages.Count == 2 ||
                languages[1] == "C#" && languages.Count == 3)
                return true;
            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages) =>
            languages.Distinct().Count() == languages.Count() ? true : false;
    }
}
