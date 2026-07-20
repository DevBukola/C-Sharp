using System;

void CultureAwareComparison()
{
    /*
            Culture-aware comparison means comparing text according to the rules of a particular language or culture.
            For example, the way letters are compared can differ between languages. A comparison that makes sense in English may not work exactly the same way in Turkish, German, or other languages. In C#, this matters when comparing strings.

            Example:
            Suppose we compare:

            ```text
            "hello"
            "HELLO"
            ```
            A normal comparison may say they are different because lowercase `h` and uppercase `H` are different characters. But a culture-aware, case-insensitive comparison can say:
            - These words are considered the same in this language.

            Culture-aware comparison is useful when comparing human language, such as:

            - Names.
            - Words.
            - Sentences.
            - User-entered text.

            For example, when checking whether a user typed "yes", "Yes", or "YES".

            The important idea is:
            - Culture-aware comparison follows the language rules of a culture, rather than simply comparing the raw character values. This is different from comparing technical data such as:

            - File names.
            - Usernames.
            - IDs.
            - Passwords.
            - Machine-generated codes.

            For those, you usually want a strict comparison that does not depend on language or culture.

            So, simply:
            - Culture-aware comparison = “Compare these strings the way people in a particular language/culture would normally understand them.”*
    */

    string word1 = "hello";
    string word2 = "HELLO";

    bool result;
    result = string.Equals(
        word1,
        word2,
        StringComparison.CurrentCultureIgnoreCase
    );
    Console.WriteLine(result);
}

CultureAwareComparison();