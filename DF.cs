using System;
using System.Collections.Generic;
using System.Text;

namespace Maddie_Script
{
    /// <summary>Discord Text Formatting</summary>
    public static class DF // Discord_Formater
    {
        public static class Color
        {
            public static string Red(string Text) => "“`excel" + Text + "“`";
        }

        //#region Color Test

        //public static string CSS(string Text) => "```css" + Environment.NewLine + Text + Environment.NewLine + "```";
        //public static string Red(string Text) => "-" + Text;
        //public static string Orange(string Text) => "[" + Text + "]";
        //public static string Light_Green(string Text) => '"' + Text + '"';
        //public static string Blue(string Text) => '.' + Text;

        public static string Italic(string Text) => "*" + Text + "*";

        public static string Bold(string Text) => "**" + Text + "**";

        public static string Strikethough(string Text) => "~~" + Text + "~~";

        public static string Underline(string Text) => "__" + Text + "__";

        public static string Hidden(string Text) => "||" + Text + "||";

        public static string Non_Embed_URL(string Text) => "<" + Text + ">";

        //-----------------------------------------------------------------------------------------------------------------

        public static string Block_Quote(string Text) => "> " + Text;

        public static string Block_Quote_Muti(string Text) => ">>> " + Text;

        public static string Block_Code_Delim { get => "```"; }

        public static string Block_Code(string Text) => "`" + Text + "`";

        public static string Block_Code_Muti(string Text) => Block_Code_Delim + Text + Block_Code_Delim;

        //-----------------------------------------------------------------------------------------------------------------

        public static string Bold_Italic(string Text) => Bold(Italic(Text));

        public static string Bold_Underline(string Text) => Bold(Underline(Text));

        //-----------------------------------------------------------------------------------------------------------------

        public static string Empty_Line { get => "alt+0173"; }
        public static string Tab { get => "   "; }
        public static string NewLine { get => Environment.NewLine; }
    }
}
