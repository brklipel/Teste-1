using UnityEngine;
using System.Collections;

public class CodificarAtributos
{

    static readonly char[] References = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789@~`!#$%^&*()_-+=+/|[]{}';:,<>?.".ToCharArray();

    static readonly char[] Dictionary = "@8NaMzObLyPcKxQdJwReIvSfHuT6GtUhFsViErWjDqXkCpYlBoZmA453g271n9#?<%^&+/)_-+]{=|[*(>$}';:,~`!.0".ToCharArray();

    //
    public static string EncodeString(string In)
    {

        char[] Chars = In.ToCharArray();
        string Out = null;

        for (int I = 0; I < Chars.Length; I++)
        {
            int i = -1;

            foreach (char CH in References)

            {
                i++;

                if (Chars[I] == CH)
                {
                    Chars[I] = Dictionary[i];

                    i = -1;

                    break;
                }
            }

            Out += Chars[I].ToString();
        }

        return Out;
    }

    //

    public static string DecodeString(string In)
    {

        char[] Chars = In.ToCharArray();

        string Out = null;

        for (int I = 0; I < Chars.Length; I++)
        {
            int i = -1;

            foreach (char CH in Dictionary)
            {
                i++;

                if (Chars[I] == CH)
                {
                    Chars[I] = References[i];
                    i = -1;
                    break;
                }

            }

            Out += Chars[I].ToString();
        }

        return Out;
    }
}
