﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apprefine.MattermostBots.SkypeBot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Langs {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Langs() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Apprefine.MattermostBots.SkypeBot.Resources.Langs", typeof(Langs).Assembly);
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
        ///   Looks up a localized string similar to Click here to start a meeting.
        /// </summary>
        internal static string ClickHereToStartMeeting {
            get {
                return ResourceManager.GetString("ClickHereToStartMeeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You already saved this id. This is shared between channels, you should do this only once..
        /// </summary>
        internal static string IdAlreadySaved {
            get {
                return ResourceManager.GetString("IdAlreadySaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Skype id has been saved. Thanks. :+1:.
        /// </summary>
        internal static string IdSaved {
            get {
                return ResourceManager.GetString("IdSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - `/skype join GROUP` - assignes you to a group. Not case sensitive..
        /// </summary>
        internal static string JoinGroupUsage {
            get {
                return ResourceManager.GetString("JoinGroupUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - `/skype leave GROUP` - removes you from a Skype group.
        /// </summary>
        internal static string LeaveGroupUsage {
            get {
                return ResourceManager.GetString("LeaveGroupUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either you are the only one with Skype ID set up correctly or nobody has it. Encourage everybody to run `/skype id SKYPE_ID`..
        /// </summary>
        internal static string NoSidsInChannel {
            get {
                return ResourceManager.GetString("NoSidsInChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: /skype id {YOUR_SKYPE_SID}.
        /// </summary>
        internal static string SaveIdUsage {
            get {
                return ResourceManager.GetString("SaveIdUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following commands are available ([TEXT] denotes optional parameters):
        ///- `/skype id YOUR_ID`  - saves your skype id. Usually this looks like an email.
        ///- `/skype meeting [GROUP]` - opens a Skype group conversation window with memebers of your channel. If GROUP is supplied the members are also filtered by Skype group (see commands belowe).
        ///- `/skype join GROUP` - assignes you to a group. Not case sensitive.
        ///- `/skype leave GROUP` - removes you from a Skype group.
        /// </summary>
        internal static string SkypeCommandUsage {
            get {
                return ResourceManager.GetString("SkypeCommandUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some users from your channel don&apos;t have Skype ID set up correctly. Encourage them to run: .
        /// </summary>
        internal static string SomeUsersDontHaveSids {
            get {
                return ResourceManager.GetString("SomeUsersDontHaveSids", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} has joined Skype group &quot;{1}&quot;..
        /// </summary>
        internal static string UserJoinedGroup {
            get {
                return ResourceManager.GetString("UserJoinedGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} has left Skype group &quot;{1}&quot;/.
        /// </summary>
        internal static string UserLeftGroup {
            get {
                return ResourceManager.GetString("UserLeftGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        internal static string Warning {
            get {
                return ResourceManager.GetString("Warning", resourceCulture);
            }
        }
    }
}
