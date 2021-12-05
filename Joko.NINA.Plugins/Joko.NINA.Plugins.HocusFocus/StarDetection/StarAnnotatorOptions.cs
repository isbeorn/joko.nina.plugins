﻿#region "copyright"

/*
    Copyright © 2021 - 2021 George Hilios <ghilios+NINA@googlemail.com>

    This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

#endregion "copyright"

using Joko.NINA.Plugins.HocusFocus.Interfaces;
using NINA.Core.Utility;
using NINA.Profile;
using NINA.Profile.Interfaces;
using System;
using System.Linq;
using System.Windows.Media;

namespace Joko.NINA.Plugins.HocusFocus.StarDetection {

    public class StarAnnotatorOptions : BaseINPC, IStarAnnotatorOptions {
        private readonly PluginOptionsAccessor optionsAccessor;

        public StarAnnotatorOptions(IProfileService profileService) {
            var guid = PluginOptionsAccessor.GetAssemblyGuid(typeof(StarDetectionOptions));
            if (guid == null) {
                throw new Exception($"Guid not found in assembly metadata");
            }

            this.optionsAccessor = new PluginOptionsAccessor(profileService, guid.Value);
            InitializeOptions();
        }

        private void InitializeOptions() {
            showAnnotations = optionsAccessor.GetValueBoolean("ShowAnnotations", true);
            showAllStars = optionsAccessor.GetValueBoolean("ShowAllStars", true);
            maxStars = optionsAccessor.GetValueInt32("MaxStars", 200);
            showStarBounds = optionsAccessor.GetValueBoolean("ShowStarBounds", true);
            starBoundsColor = optionsAccessor.GetValueColor("StarBoundsColor", Color.FromArgb(128, 255, 0, 0));
            showHFR = optionsAccessor.GetValueBoolean("ShowHFR", true);
            textFontFamily = new FontFamily(optionsAccessor.GetValueString("TextFontFamily", "Arial"));
            textFontSizePoints = optionsAccessor.GetValueSingle("TextFontSizePoints", 18);
            hfrColor = optionsAccessor.GetValueColor("HFRColor", Color.FromArgb(255, 255, 255, 0));
            starBoundsType = optionsAccessor.GetValueEnum<StarBoundsTypeEnum>("StarBoundsType", StarBoundsTypeEnum.Box);
            showROI = optionsAccessor.GetValueBoolean("ShowROI", true);
            roiColor = optionsAccessor.GetValueColor("ROIColor", Color.FromArgb(255, 255, 255, 0));
            showStarCenter = optionsAccessor.GetValueBoolean("ShowStarCenter", true);
            starCenterColor = optionsAccessor.GetValueColor("StarCenterColor", Color.FromArgb(128, 0, 0, 255));
            showDegenerate = optionsAccessor.GetValueBoolean("ShowDegenerate", false);
            degenerateColor = optionsAccessor.GetValueColor("DegenerateColor", Color.FromArgb(128, 0, 255, 0));
            showSaturated = optionsAccessor.GetValueBoolean("ShowSaturated", false);
            saturatedColor = optionsAccessor.GetValueColor("SaturatedColor", Color.FromArgb(128, 0, 255, 0));
            showLowSensitivity = optionsAccessor.GetValueBoolean("ShowLowSensitivity", false);
            lowSensitivityColor = optionsAccessor.GetValueColor("LowSensitivityColor", Color.FromArgb(128, 0, 255, 0));
            showNotCentered = optionsAccessor.GetValueBoolean("ShowNotCentered", false);
            notCenteredColor = optionsAccessor.GetValueColor("NotCenteredColor", Color.FromArgb(128, 0, 255, 0));
            showTooFlat = optionsAccessor.GetValueBoolean("ShowTooFlat", false);
            tooFlatColor = optionsAccessor.GetValueColor("TooFlatColor", Color.FromArgb(128, 0, 255, 0));
            showStructureMap = optionsAccessor.GetValueEnum<ShowStructureMapEnum>("ShowStructureMap", ShowStructureMapEnum.None);
            structureMapColor = optionsAccessor.GetValueColor("StructureMapColor", Color.FromArgb(128, 255, 0, 255));
        }

        public void ResetDefaults() {
            ShowAnnotations = true;
            ShowAllStars = false;
            MaxStars = 200;
            ShowStarBounds = true;
            StarBoundsColor = Color.FromArgb(128, 255, 0, 0); // Red half transparency
            ShowHFR = true;
            TextFontFamily = new FontFamily("Arial");
            TextFontSizePoints = 18;
            HFRColor = Color.FromArgb(255, 255, 255, 0); // Red
            StarBoundsType = StarBoundsTypeEnum.Box;
            ShowROI = true;
            ROIColor = Color.FromArgb(255, 255, 255, 0); // Yellow
            ShowStarCenter = true;
            StarCenterColor = Color.FromArgb(128, 0, 0, 255); // Blue half transparency
            ShowDegenerate = false;
            DegenerateColor = Color.FromArgb(128, 0, 255, 0); // Green half transparency
            ShowSaturated = false;
            SaturatedColor = Color.FromArgb(128, 0, 255, 0); // Green half transparency
            ShowLowSensitivity = false;
            LowSensitivityColor = Color.FromArgb(128, 0, 255, 0); // Green half transparency
            ShowNotCentered = false;
            NotCenteredColor = Color.FromArgb(128, 0, 255, 0); // Green half transparency
            ShowTooFlat = false;
            TooFlatColor = Color.FromArgb(128, 0, 255, 0); // Green half transparency
            ShowStructureMap = ShowStructureMapEnum.None;
            StructureMapColor = Color.FromArgb(128, 255, 0, 255); // Purple half transparency
        }

        private bool showAnnotations;

        public bool ShowAnnotations {
            get => showAnnotations;
            set {
                if (showAnnotations != value) {
                    showAnnotations = value;
                    optionsAccessor.SetValueBoolean("ShowAnnotations", showAnnotations);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showAllStars;

        public bool ShowAllStars {
            get => showAllStars;
            set {
                if (showAllStars != value) {
                    showAllStars = value;
                    optionsAccessor.SetValueBoolean("ShowAllStars", value);
                    RaisePropertyChanged();
                }
            }
        }

        private int maxStars;

        public int MaxStars {
            get => maxStars;
            set {
                if (maxStars != value) {
                    maxStars = value;
                    optionsAccessor.SetValueInt32("MaxStars", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showStarBounds;

        public bool ShowStarBounds {
            get => showStarBounds;
            set {
                if (showStarBounds != value) {
                    showStarBounds = value;
                    optionsAccessor.SetValueBoolean("ShowStarBounds", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color starBoundsColor;

        public Color StarBoundsColor {
            get => starBoundsColor;
            set {
                if (starBoundsColor != value) {
                    starBoundsColor = value;
                    optionsAccessor.SetValueColor("StarBoundsColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showHFR;

        public bool ShowHFR {
            get => showHFR;
            set {
                if (showHFR != value) {
                    showHFR = value;
                    optionsAccessor.SetValueBoolean("ShowHFR", value);
                    RaisePropertyChanged();
                }
            }
        }

        private FontFamily textFontFamily;

        public FontFamily TextFontFamily {
            get => textFontFamily;
            set {
                if (textFontFamily != value) {
                    textFontFamily = value;
                    optionsAccessor.SetValueString("TextFontFamily", value.FamilyNames.First().Value);
                    RaisePropertyChanged();
                }
            }
        }

        private float textFontSizePoints;

        public float TextFontSizePoints {
            get => textFontSizePoints;
            set {
                if (textFontSizePoints != value) {
                    textFontSizePoints = value;
                    optionsAccessor.SetValueSingle("TextFontSizePoints", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color hfrColor;

        public Color HFRColor {
            get => hfrColor;
            set {
                if (hfrColor != value) {
                    hfrColor = value;
                    optionsAccessor.SetValueColor("HFRColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private StarBoundsTypeEnum starBoundsType;

        public StarBoundsTypeEnum StarBoundsType {
            get => starBoundsType;
            set {
                if (starBoundsType != value) {
                    starBoundsType = value;
                    optionsAccessor.SetValueEnum<StarBoundsTypeEnum>("StarBoundsType", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showROI;

        public bool ShowROI {
            get => showROI;
            set {
                if (showROI != value) {
                    showROI = value;
                    optionsAccessor.SetValueBoolean("ShowROI", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color roiColor;

        public Color ROIColor {
            get => roiColor;
            set {
                if (roiColor != value) {
                    roiColor = value;
                    optionsAccessor.SetValueColor("ROIColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showStarCenter;

        public bool ShowStarCenter {
            get => showStarCenter;
            set {
                if (showStarCenter != value) {
                    showStarCenter = value;
                    optionsAccessor.SetValueBoolean("ShowStarCenter", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color starCenterColor;

        public Color StarCenterColor {
            get => starCenterColor;
            set {
                if (starCenterColor != value) {
                    starCenterColor = value;
                    optionsAccessor.SetValueColor("StarCenterColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showDegenerate;

        public bool ShowDegenerate {
            get => showDegenerate;
            set {
                if (showDegenerate != value) {
                    showDegenerate = value;
                    optionsAccessor.SetValueBoolean("ShowDegenerate", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color degenerateColor;

        public Color DegenerateColor {
            get => degenerateColor;
            set {
                if (degenerateColor != value) {
                    degenerateColor = value;
                    optionsAccessor.SetValueColor("DegenerateColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showSaturated;

        public bool ShowSaturated {
            get => showSaturated;
            set {
                if (showSaturated != value) {
                    showSaturated = value;
                    optionsAccessor.SetValueBoolean("ShowSaturated", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color saturatedColor;

        public Color SaturatedColor {
            get => saturatedColor;
            set {
                if (saturatedColor != value) {
                    saturatedColor = value;
                    optionsAccessor.SetValueColor("SaturatedColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showLowSensitivity;

        public bool ShowLowSensitivity {
            get => showLowSensitivity;
            set {
                if (showLowSensitivity != value) {
                    showLowSensitivity = value;
                    optionsAccessor.SetValueBoolean("ShowLowSensitivity", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color lowSensitivityColor;

        public Color LowSensitivityColor {
            get => lowSensitivityColor;
            set {
                if (lowSensitivityColor != value) {
                    lowSensitivityColor = value;
                    optionsAccessor.SetValueColor("LowSensitivityColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showNotCentered;

        public bool ShowNotCentered {
            get => showNotCentered;
            set {
                if (showNotCentered != value) {
                    showNotCentered = value;
                    optionsAccessor.SetValueBoolean("ShowNotCentered", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color notCenteredColor;

        public Color NotCenteredColor {
            get => notCenteredColor;
            set {
                if (notCenteredColor != value) {
                    notCenteredColor = value;
                    optionsAccessor.SetValueColor("NotCenteredColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private bool showTooFlat;

        public bool ShowTooFlat {
            get => showTooFlat;
            set {
                if (showTooFlat != value) {
                    showTooFlat = value;
                    optionsAccessor.SetValueBoolean("ShowTooFlat", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color tooFlatColor;

        public Color TooFlatColor {
            get => tooFlatColor;
            set {
                if (tooFlatColor != value) {
                    tooFlatColor = value;
                    optionsAccessor.SetValueColor("TooFlatColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        private ShowStructureMapEnum showStructureMap;

        public ShowStructureMapEnum ShowStructureMap {
            get => showStructureMap;
            set {
                if (showStructureMap != value) {
                    showStructureMap = value;
                    optionsAccessor.SetValueEnum<ShowStructureMapEnum>("ShowStructureMap", value);
                    RaisePropertyChanged();
                }
            }
        }

        private Color structureMapColor;

        public Color StructureMapColor {
            get => structureMapColor;
            set {
                if (structureMapColor != value) {
                    structureMapColor = value;
                    optionsAccessor.SetValueColor("StructureMapColor", value);
                    RaisePropertyChanged();
                }
            }
        }

        public IStarDetectionOptions DetectorOptions {
            get => HocusFocusPlugin.StarDetectionOptions;
            set => throw new NotImplementedException();
        }
    }
}