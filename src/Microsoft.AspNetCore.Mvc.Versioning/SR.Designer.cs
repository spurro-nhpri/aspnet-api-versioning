﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.Mvc {
    using System;
    using System.Reflection;


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
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.Mvc.SR", typeof(SR).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Multiple actions matched. The following actions matched route data and had all constraints satisfied:{0}{0}{1}.
        /// </summary>
        internal static string ActionSelector_AmbiguousActions {
            get {
                return ResourceManager.GetString("ActionSelector_AmbiguousActions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified API group version &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string ApiVersionBadGroupVersion {
            get {
                return ResourceManager.GetString("ApiVersionBadGroupVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified API version status &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string ApiVersionBadStatus {
            get {
                return ResourceManager.GetString("ApiVersionBadStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified API version is invalid..
        /// </summary>
        internal static string ApiVersionInvalidFormat {
            get {
                return ResourceManager.GetString("ApiVersionInvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format &apos;{0}&apos; is invalid or not supported..
        /// </summary>
        internal static string ApiVersionInvalidFormatCode {
            get {
                return ResourceManager.GetString("ApiVersionInvalidFormatCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested API version &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ApiVersionNotSupported {
            get {
                return ResourceManager.GetString("ApiVersionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An API version is required, but was not specified..
        /// </summary>
        internal static string ApiVersionUnspecified {
            get {
                return ResourceManager.GetString("ApiVersionUnspecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression &apos;{0}&apos; must refer to a controller action method..
        /// </summary>
        internal static string InvalidActionMethodExpression {
            get {
                return ResourceManager.GetString("InvalidActionMethodExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following API versions were requested: {0}. At most, only a single API version may be specified. Please update the intended API version and retry the request..
        /// </summary>
        internal static string MultipleDifferentApiVersionsRequested {
            get {
                return ResourceManager.GetString("MultipleDifferentApiVersionsRequested", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP resource that matches the request URI &apos;{0}&apos; does not support the API version &apos;{1}&apos;..
        /// </summary>
        internal static string VersionedResourceNotSupported {
            get {
                return ResourceManager.GetString("VersionedResourceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one IApiVersionReader must be specified..
        /// </summary>
        internal static string ZeroApiVersionReaders {
            get {
                return ResourceManager.GetString("ZeroApiVersionReaders", resourceCulture);
            }
        }
    }
}
