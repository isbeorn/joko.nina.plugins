﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joko.NINA.Plugins.JokoFocus.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateSettings {
            get {
                return ((bool)(this["UpdateSettings"]));
            }
            set {
                this["UpdateSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HotpixelFiltering {
            get {
                return ((bool)(this["HotpixelFiltering"]));
            }
            set {
                this["HotpixelFiltering"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int NoiseReductionRadius {
            get {
                return ((int)(this["NoiseReductionRadius"]));
            }
            set {
                this["NoiseReductionRadius"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public double NoiseClippingMultiplier {
            get {
                return ((double)(this["NoiseClippingMultiplier"]));
            }
            set {
                this["NoiseClippingMultiplier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int StructureLayers {
            get {
                return ((int)(this["StructureLayers"]));
            }
            set {
                this["StructureLayers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1")]
        public double BrightnessSensitivity {
            get {
                return ((double)(this["BrightnessSensitivity"]));
            }
            set {
                this["BrightnessSensitivity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.85")]
        public double StarPeakResponse {
            get {
                return ((double)(this["StarPeakResponse"]));
            }
            set {
                this["StarPeakResponse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double MaxDistortion {
            get {
                return ((double)(this["MaxDistortion"]));
            }
            set {
                this["MaxDistortion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double BarycenterStretchMultiplier {
            get {
                return ((double)(this["BarycenterStretchMultiplier"]));
            }
            set {
                this["BarycenterStretchMultiplier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int StarBackgroundBoxExpansion {
            get {
                return ((int)(this["StarBackgroundBoxExpansion"]));
            }
            set {
                this["StarBackgroundBoxExpansion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int MinStarBoundingBoxSize {
            get {
                return ((int)(this["MinStarBoundingBoxSize"]));
            }
            set {
                this["MinStarBoundingBoxSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.5")]
        public double MinHFR {
            get {
                return ((double)(this["MinHFR"]));
            }
            set {
                this["MinHFR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int MaxStars {
            get {
                return ((int)(this["MaxStars"]));
            }
            set {
                this["MaxStars"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowStarBounds {
            get {
                return ((bool)(this["ShowStarBounds"]));
            }
            set {
                this["ShowStarBounds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#80FF0000")]
        public global::System.Windows.Media.Color StarBoundsColor {
            get {
                return ((global::System.Windows.Media.Color)(this["StarBoundsColor"]));
            }
            set {
                this["StarBoundsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowHFR {
            get {
                return ((bool)(this["ShowHFR"]));
            }
            set {
                this["ShowHFR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFF00")]
        public global::System.Windows.Media.Color HFRColor {
            get {
                return ((global::System.Windows.Media.Color)(this["HFRColor"]));
            }
            set {
                this["HFRColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial")]
        public global::System.Windows.Media.FontFamily TextFontFamily {
            get {
                return ((global::System.Windows.Media.FontFamily)(this["TextFontFamily"]));
            }
            set {
                this["TextFontFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("18")]
        public float TextFontSizePoints {
            get {
                return ((float)(this["TextFontSizePoints"]));
            }
            set {
                this["TextFontSizePoints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowAllStars {
            get {
                return ((bool)(this["ShowAllStars"]));
            }
            set {
                this["ShowAllStars"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Box")]
        public string StarBoundsType {
            get {
                return ((string)(this["StarBoundsType"]));
            }
            set {
                this["StarBoundsType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowROI {
            get {
                return ((bool)(this["ShowROI"]));
            }
            set {
                this["ShowROI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFF00")]
        public global::System.Windows.Media.Color ROIColor {
            get {
                return ((global::System.Windows.Media.Color)(this["ROIColor"]));
            }
            set {
                this["ROIColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int StructureDilationSize {
            get {
                return ((int)(this["StructureDilationSize"]));
            }
            set {
                this["StructureDilationSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int StructureDilationCount {
            get {
                return ((int)(this["StructureDilationCount"]));
            }
            set {
                this["StructureDilationCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowStarCenter {
            get {
                return ((bool)(this["ShowStarCenter"]));
            }
            set {
                this["ShowStarCenter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#800000FF")]
        public global::System.Windows.Media.Color StarCenterColor {
            get {
                return ((global::System.Windows.Media.Color)(this["StarCenterColor"]));
            }
            set {
                this["StarCenterColor"] = value;
            }
        }
    }
}
