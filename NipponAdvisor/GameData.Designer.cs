﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NipponAdvisor {
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
    internal class GameData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GameData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NipponAdvisor.GameData", typeof(GameData).Assembly);
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
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;Name&quot;: &quot;Ankake Yakisoba&quot;,
        ///    &quot;BaseRating&quot;: 4,
        ///    &quot;DerivedDish&quot;: &quot;Yakisoba&quot;,
        ///    &quot;RecipeIngredient1&quot;: &quot;Tasty Fish&quot;,
        ///    &quot;RecipeIngredient2&quot;: &quot;&quot;,
        ///    &quot;MaxPrice&quot;: 70,
        ///    &quot;PriceRating&quot;: &quot;A&quot;,
        ///    &quot;MaxTaste&quot;: 150,
        ///    &quot;TasteRating&quot;: &quot;D&quot;,
        ///    &quot;MaxAppeal&quot;: 150,
        ///    &quot;AppealRating&quot;: &quot;D&quot;,
        ///    &quot;CostPerMonth&quot;: 45,
        ///    &quot;Craftable&quot;: true,
        ///    &quot;Source&quot;: &quot;&quot;
        ///  },
        ///  {
        ///    &quot;Name&quot;: &quot;BBQ Pork Ramen&quot;,
        ///    &quot;BaseRating&quot;: 6,
        ///    &quot;DerivedDish&quot;: &quot;Ramen&quot;,
        ///    &quot;RecipeIngredient1&quot;: &quot;Top-Class Pork&quot;,
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DishData {
            get {
                return ResourceManager.GetString("DishData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  { 
        ///    &quot;Name&quot;: &quot;Aged Cheese&quot;,
        ///    &quot;Rating&quot;: 4,
        ///    &quot;Health&quot;: 16,
        ///    &quot;Brain&quot;: 11,
        ///    &quot;Texture&quot;: 11,
        ///    &quot;Armoa&quot;: 5,
        ///    &quot;Appearance&quot;: 5,
        ///    &quot;Volume&quot;: 27,
        ///    &quot;Rarity&quot;: 11,
        ///    &quot;Charisma&quot;: 3
        ///  },
        ///  {
        ///    &quot;Name&quot;: &quot;Apple&quot;,
        ///    &quot;Rating&quot;: 1,
        ///    &quot;Health&quot;: 1,
        ///    &quot;Brain&quot;: -1,
        ///    &quot;Texture&quot;: 16,
        ///    &quot;Armoa&quot;: 0,
        ///    &quot;Appearance&quot;: 0,
        ///    &quot;Volume&quot;: 2,
        ///    &quot;Rarity&quot;: 3,
        ///    &quot;Charisma&quot;: 4
        ///  },
        ///  {
        ///    &quot;Name&quot;: &quot;Bamboo&quot;,
        ///    &quot;Rating&quot;: 3,
        ///    &quot;Health&quot;: 11,
        ///    &quot;Brain&quot;: 11,
        ///    &quot;Texture&quot;: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IngredientData {
            get {
                return ResourceManager.GetString("IngredientData", resourceCulture);
            }
        }
    }
}