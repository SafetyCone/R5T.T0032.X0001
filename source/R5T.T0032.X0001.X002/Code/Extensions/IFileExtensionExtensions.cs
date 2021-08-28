using System;

using R5T.T0032;
using R5T.T0032.X0001.X002;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        public static string csproj(this IFileExtension _)
        {
            return VisualStudioFileExtensions.csproj;
        }

        public static string CSharpProjectFile(this IFileExtension _)
        {
            return VisualStudioFileExtensions.CSharpProjectFile;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
