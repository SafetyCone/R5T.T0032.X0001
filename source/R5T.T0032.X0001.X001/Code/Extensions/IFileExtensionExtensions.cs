using System;

using R5T.T0032;
using R5T.T0032.X0001.X001;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        public static string cs(this IFileExtension _)
        {
            return CodeFileExtensions.cs;
        }

        public static string CSharpCode(this IFileExtension _)
        {
            return CodeFileExtensions.CSharpCode;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
