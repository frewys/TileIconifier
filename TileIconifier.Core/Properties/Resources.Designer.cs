﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TileIconifier.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TileIconifier.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;--------------------------------------------------------------------------------
        ///&apos;--- AUTOGENERATED BY TILEICONIFIER - DO NOT MANUALLY EDIT ---
        ///&apos;--------------------------------------------------------------------------------
        ///
        ///&apos;Custom Shortcut Type = &quot;{4}&quot;
        ///&apos;Shortcut Name = &quot;{0}&quot;
        ///&apos;Shortcut Path = &quot;{1}&quot;
        ///
        ///Dim targetPath, targetArguments
        ///
        ///targetPath = &quot;{2}&quot;
        ///targetArguments = &quot;{3}&quot;
        ///
        ///Set WshShell = WScript.CreateObject(&quot;WScript.Shell&quot;)
        ///WshShell.CurrentDirectory = &quot;{6}&quot;
        ///WshShell.Run targetPath &amp; &quot;  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CustomShortcutVbsTemplate {
            get {
                return ResourceManager.GetString("CustomShortcutVbsTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon explorer_ICO_MYCOMPUTER {
            get {
                object obj = ResourceManager.GetObject("explorer_ICO_MYCOMPUTER", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Google_Chrome_icon {
            get {
                object obj = ResourceManager.GetObject("Google_Chrome_icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon SteamIco {
            get {
                object obj = ResourceManager.GetObject("SteamIco", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [InternetShortcut]
        ///URL={0}.
        /// </summary>
        internal static string UrlFileTemplate {
            get {
                return ResourceManager.GetString("UrlFileTemplate", resourceCulture);
            }
        }
    }
}
