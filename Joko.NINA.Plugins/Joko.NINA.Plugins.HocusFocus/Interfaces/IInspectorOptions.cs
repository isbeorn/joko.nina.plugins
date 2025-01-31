﻿#region "copyright"

/*
    Copyright © 2021 - 2021 George Hilios <ghilios+NINA@googlemail.com>

    This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

#endregion "copyright"

using NINA.Joko.Plugins.HocusFocus.Converters;
using System.ComponentModel;

namespace NINA.Joko.Plugins.HocusFocus.Interfaces {

    [TypeConverter(typeof(EnumStaticDescriptionConverter))]
    public enum InterpolationAlgoEnum {

        [Description("Hierarchical")]
        Hierarchical,

        [Description("Thin Plate Spline")]
        ThinPlateSpline,

        [Description("Multi Quadric")]
        MultiQuadric,

        [Description("Bi-Harmonic")]
        BiHarmonic
    }

    [TypeConverter(typeof(EnumStaticDescriptionConverter))]
    public enum InterpolationAmountEnum {

        [Description("Small")]
        Small,

        [Description("Medium")]
        Medium,

        [Description("Large")]
        Large
    }

    public interface IInspectorOptions : INotifyPropertyChanged {
        int StepCount { get; set; }
        int StepSize { get; set; }
        int FramesPerPoint { get; set; }
        int TimeoutSeconds { get; set; }
        int NumRegionsWide { get; set; }
        double SimpleExposureSeconds { get; set; }
        double DetailedAnalysisExposureSeconds { get; set; }
        bool LoopingExposureAnalysisEnabled { get; set; }
        double MicronsPerFocuserStep { get; set; }
        bool EccentricityColorMapEnabled { get; set; }
        bool MouseOnChartsEnabled { get; set; }
        bool SensorCurveModelEnabled { get; set; }
        bool ShowSensorModel { get; set; }
        double SensorROI { get; set; }
        double CornersROI { get; set; }
        bool InterpolationEnabled { get; }
        InterpolationAlgoEnum InterpolationAlgo { get; set; }
        InterpolationAmountEnum InterpolationAmount { get; set; }
        bool FixedSensorCenter { get; set; }
        bool RenderingEnabled { get; set; }
    }
}