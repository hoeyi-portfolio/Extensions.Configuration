﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hoeyi.Extensions.Configuration.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionString {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionString() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hoeyi.Extensions.Configuration.Resources.ExceptionString", typeof(ExceptionString).Assembly);
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
        ///   Looks up a localized string similar to {0}-bit key size is invalid for this provider. .
        /// </summary>
        internal static string Aes_InvalidSize {
            get {
                return ResourceManager.GetString("Aes.InvalidSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key container has not been set..
        /// </summary>
        internal static string EncryptionProvider_KeyContainerNotSet {
            get {
                return ResourceManager.GetString("EncryptionProvider.KeyContainerNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration provider has no encryption key..
        /// </summary>
        internal static string EncryptionProvider_KeyNotSet {
            get {
                return ResourceManager.GetString("EncryptionProvider.KeyNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to rotate asymmetric and symmetric keys..
        /// </summary>
        internal static string EncryptionProvider_RotateKeyFailed {
            get {
                return ResourceManager.GetString("EncryptionProvider.RotateKeyFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The container &apos;{0}&apos; could not be saved to provider &apos;{1}&apos;..
        /// </summary>
        internal static string KeyStore_CreateKeyFailed {
            get {
                return ResourceManager.GetString("KeyStore.CreateKeyFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not decrypt value..
        /// </summary>
        internal static string KeyStore_DecryptionFailed {
            get {
                return ResourceManager.GetString("KeyStore.DecryptionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The container &apos;{0}&apos; could not be deleted..
        /// </summary>
        internal static string KeyStore_DeleteKeyFailed {
            get {
                return ResourceManager.GetString("KeyStore.DeleteKeyFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not encrypt value..
        /// </summary>
        internal static string KeyStore_EncryptionFailed {
            get {
                return ResourceManager.GetString("KeyStore.EncryptionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not supported for this operation..
        /// </summary>
        internal static string KeyStore_PlatformNotSupported {
            get {
                return ResourceManager.GetString("KeyStore.PlatformNotSupported", resourceCulture);
            }
        }
    }
}
