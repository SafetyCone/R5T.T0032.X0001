using System;

using R5T.T0032;
using R5T.T0032.X0001.X002;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        [Obsolete("See R5T.Z0044.")]
        public static string csproj(this IFileExtension _)
        {
            return VisualStudioFileExtensions.csproj;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string CSharpProjectFile(this IFileExtension _)
        {
            return VisualStudioFileExtensions.CSharpProjectFile;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string sln(this IFileExtension _)
        {
            return VisualStudioFileExtensions.sln;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Sln(this IFileExtension _)
        {
            return VisualStudioFileExtensions.sln;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
