using System;

namespace Plugin.org.arbweb.xam.ui
{
    /// <summary>
    /// Cross org.arbweb.xam.ui
    /// </summary>
    public static class Crossorg.arbweb.xam.ui
    {
        static Lazy<Iorg.arbweb.xam.ui> implementation = new Lazy<Iorg.arbweb.xam.ui>(() => Createorg.arbweb.xam.ui(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Gets if the plugin is supported on the current platform.
    /// </summary>
    public static bool IsSupported => implementation.Value == null ? false : true;

    /// <summary>
    /// Current plugin implementation to use
    /// </summary>
    public static Iorg.arbweb.xam.ui Current
    {
        get
        {
            Iorg.arbweb.xam.ui ret = implementation.Value;
            if (ret == null)
            {
                throw NotImplementedInReferenceAssembly();
            }
            return ret;
        }
    }

    static Iorg.arbweb.xam.ui Createorg.arbweb.xam.ui()
    {
#if NETSTANDARD1_0 || NETSTANDARD2_0
            return null;
#else
#pragma warning disable IDE0022 // Use expression body for methods
        return new org.arbweb.xam.uiImplementation();
#pragma warning restore IDE0022 // Use expression body for methods
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly() =>
        new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

}
}
