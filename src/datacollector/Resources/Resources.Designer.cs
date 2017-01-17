﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.TestPlatform.DataCollector.Resources {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.TestPlatform.DataCollector.Resources.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to An error occurred while retrieving the attributes for the diagnostic data adapter of type &apos;{0}&apos;..
        /// </summary>
        internal static string AttributeRetrievalError {
            get {
                return ResourceManager.GetString("AttributeRetrievalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Diagnostic data adapter type URI cannot be null or empty. The type URI for the diagnostic data adapter of type &apos;{0}&apos; is null or empty..
        /// </summary>
        internal static string DataCollector_TypeIsNull {
            get {
                return ResourceManager.GetString("DataCollector_TypeIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find diagnostic data adapter &apos;{0}&apos;.  Make sure diagnostic data adapter is installed and try again..
        /// </summary>
        internal static string DataCollectorAssemblyNotFound {
            get {
                return ResourceManager.GetString("DataCollectorAssemblyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The diagnostic data adapter &apos;{0}&apos;  threw an exception during type loading, construction, or initialization: {1}..
        /// </summary>
        internal static string DataCollectorInitializationError {
            get {
                return ResourceManager.GetString("DataCollectorInitializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find diagnostic data adapter of type &apos;{0}&apos; and Uri &apos;{1}&apos;.
        /// </summary>
        internal static string DataCollectorNotFound {
            get {
                return ResourceManager.GetString("DataCollectorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required diagnostic data adapter attribute &apos;{0}&apos; is missing for the diagnostic data adapter of type &apos;{1}&apos;..
        /// </summary>
        internal static string DataCollectorRequiredAttributeMissing {
            get {
                return ResourceManager.GetString("DataCollectorRequiredAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get type for diagnostic data adapter &apos;{0}&apos;. Error: {1}..
        /// </summary>
        internal static string DataCollectorTypeNotFound {
            get {
                return ResourceManager.GetString("DataCollectorTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid URI format. The URI &apos;{0}&apos; provided for the diagnostic data adapter of type &apos;{1}&apos; is not a valid URI..
        /// </summary>
        internal static string DataCollectorTypeUriFormatInvalid {
            get {
                return ResourceManager.GetString("DataCollectorTypeUriFormatInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending message of Message Type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string DataCollectorUnsupportedMessageType {
            get {
                return ResourceManager.GetString("DataCollectorUnsupportedMessageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are multiple configurations that have diagnostic data adapter  type &apos;{0}&apos; or Uri &apos;{1}&apos;. Duplicate configurations will be ignored in the test run..
        /// </summary>
        internal static string IgnoredDuplicateConfiguration {
            get {
                return ResourceManager.GetString("IgnoredDuplicateConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Diagnostic data adapter caught an exception of type &apos;{0}&apos;: &apos;{1}&apos;. More details: {2}..
        /// </summary>
        internal static string ReportDataCollectorException {
            get {
                return ResourceManager.GetString("ReportDataCollectorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types deriving from the data collection context cannot be used for sending data and messages.  The DataCollectionContext used for sending data and messages must come from one of the events raised to the data collector..
        /// </summary>
        internal static string WrongDataCollectionContextType {
            get {
                return ResourceManager.GetString("WrongDataCollectionContextType", resourceCulture);
            }
        }
    }
}
