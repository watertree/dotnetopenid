﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
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
    internal class OAuth2Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OAuth2Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.OAuth2.OAuth2Strings", typeof(OAuth2Strings).Assembly);
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
        ///   Looks up a localized string similar to Access token has expired and cannot be automatically refreshed..
        /// </summary>
        internal static string AccessTokenRefreshFailed {
            get {
                return ResourceManager.GetString("AccessTokenRefreshFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authorization has expired..
        /// </summary>
        internal static string AuthorizationExpired {
            get {
                return ResourceManager.GetString("AuthorizationExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected OAuth authorization response received with callback and client state that does not match an expected value..
        /// </summary>
        internal static string AuthorizationResponseUnexpectedMismatch {
            get {
                return ResourceManager.GetString("AuthorizationResponseUnexpectedMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} must be set before this operation is allowed..
        /// </summary>
        internal static string RequiredPropertyNotYetPreset {
            get {
                return ResourceManager.GetString("RequiredPropertyNotYetPreset", resourceCulture);
            }
        }
    }
}
