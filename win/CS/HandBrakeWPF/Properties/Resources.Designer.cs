﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandBrakeWPF.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HandBrakeWPF.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright (C) 2003-2013 The HandBrake Team
        ///
        ///This program is free software; you can redistribute it and/or
        ///modify it under the terms of the GNU General Public License
        ///as published by the Free Software Foundation; either version 2
        ///of the License, or (at your option) any later version.
        ///
        ///This program is distributed in the hope that it will be useful,
        ///but WITHOUT ANY WARRANTY; without even the implied warranty of
        ///MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        ///GNU General Public License f [rest of string was truncated]&quot;;.
        /// </summary>
        public static string About_GPL {
            get {
                return ResourceManager.GetString("About_GPL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can optionally store a maximum resolution for encodes that use this preset. There are 3 modes:
        ///
        ///None:  There is no maximum resolution for encodes using this preset. They will always use the source resolution minus any cropping that may be applied.
        ///
        ///Custom: You can optionally set a Maximum width and height. When doing this an encode will be less than or equal to these values.
        ///
        ///Source Maximum:  Similar to custom, but the resolution of your current source is used as the Max width and Height values in [rest of string was truncated]&quot;;.
        /// </summary>
        public static string AddPreset_PictureSizeMode {
            get {
                return ResourceManager.GetString("AddPreset_PictureSizeMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to x264 has a variety of algorithms to decide when to use B-frames and how many to use.
        ///
        ///Fast mode takes roughly the same amount of time no matter how many B-frames you specify.  However, while fast, its decisions are often suboptimal.
        ///
        ///Optimal mode gets slower as the maximum number of B-Frames increases, but makes much more accurate decisions, especially when used with B-pyramid..
        /// </summary>
        public static string Advanced_AdaptiveBFramesToolTip {
            get {
                return ResourceManager.GetString("Advanced_AdaptiveBFramesToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H.264 allows for two different prediction modes, spatial and temporal, in B-frames.
        ///
        ///Spatial, the default, is almost always better, but temporal is sometimes useful too.
        ///
        ///x264 can, at the cost of a small amount of speed (and accordingly for a small compression gain), adaptively select which is better for each particular frame..
        /// </summary>
        public static string Advanced_AdaptiveDirectModeToolTip {
            get {
                return ResourceManager.GetString("Advanced_AdaptiveDirectModeToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adaptive quantization controls how the encoder distributes bits across the frame.
        ///Higher values take more bits away from edges and complex areas to improve areas with finer detail..
        /// </summary>
        public static string Advanced_AdaptiveQuantizationStrengthToolTip {
            get {
                return ResourceManager.GetString("Advanced_AdaptiveQuantizationStrengthToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mode decision picks from a variety of options to make its decision: this option chooses what options those are.  
        ///Fewer partitions to check means faster encoding, at the cost of worse decisions, since the best option might have been one that was turned off..
        /// </summary>
        public static string Advanced_AnalysisToolTip {
            get {
                return ResourceManager.GetString("Advanced_AnalysisToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sane values are ~2-5.  
        ///This specifies the maximum number of sequential B-frames that the encoder can use. 
        /// Large numbers generally won&apos;t help significantly unless Adaptive B-frames is set to Optimal.  
        ///Cel-animated source material and B-pyramid also significantly increase the usefulness of larger values. 
        ///Baseline profile, as required for iPods and similar devices, requires B-frames to be set to 0 (off)..
        /// </summary>
        public static string Advanced_BFramesToolTip {
            get {
                return ResourceManager.GetString("Advanced_BFramesToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to After the encoder has done its work, it has a bunch of data that needs to be compressed losslessly, similar to ZIP or RAR. H.264 provides two options for this: CAVLC and CABAC.  CABAC decodes a lot slower but compresses significantly better (10-30%), especially at lower bitrates. If you&apos;re looking to minimize CPU requirements for video playback, disable this option. Baseline profile, as required for iPods and similar devices, requires CABAC to be disabled..
        /// </summary>
        public static string Advanced_CabacToolTip {
            get {
                return ResourceManager.GetString("Advanced_CabacToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H.264 has a built-in deblocking filter that smooths out blocking artifacts after decoding each frame.  This not only improves visual quality, but also helps compression significantly. 
        ///The deblocking filter takes a lot of CPU power, so if you&apos;re looking to minimize CPU requirements for video playback, disable it.
        ///
        ///The deblocking filter has two adjustable parameters, &quot;strength&quot; and &quot;threshold&quot;. 
        ///The former controls how strong (or weak) the deblocker is, while the latter controls how many (or few)  edges  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Advanced_DeblockingToolTip {
            get {
                return ResourceManager.GetString("Advanced_DeblockingToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The 8x8 transform is the single most useful feature of x264 in terms of compression-per-speed.  
        ///It improves compression by at least 5% at a very small speed cost and may provide an unusually high visual quality benefit compared to its compression gain.  
        ///However, it requires High Profile, which many devices may not support..
        /// </summary>
        public static string Advanced_EightByEightDctToolTip {
            get {
                return ResourceManager.GetString("Advanced_EightByEightDctToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The options passed to the x264 encoder. 
        ///The above controls are only a subset of useful x264 parameters. 
        ///This box allows you to add or modify additional or current parameters as desired. .
        /// </summary>
        public static string Advanced_EncoderOptions {
            get {
                return ResourceManager.GetString("Advanced_EncoderOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controls the motion estimation method. Motion estimation is how the encoder estimates how each block of pixels in a frame has moved.  
        ///A better motion search method improves compression at the cost of speed.
        ///
        ///Diamond: performs an extremely fast and simple search using a diamond pattern.
        ///
        ///Hexagon: performs a somewhat more effective but slightly slower search using a hexagon pattern.
        ///
        ///Uneven Multi-Hex: performs a very wide search using a variety of patterns, more accurately capturing complex motion.
        ///        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Advanced_MotionEstimationMethodToolTip {
            get {
                return ResourceManager.GetString("Advanced_MotionEstimationMethodToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is the distance x264 searches from its best guess at the motion of a block in order to try to find its actual motion.  
        ///
        ///The default is fine for most content, but extremely high motion video, especially at HD resolutions, may benefit from higher ranges, albeit at a high speed cost..
        /// </summary>
        public static string Advanced_MotionEstimationRangeToolTip {
            get {
                return ResourceManager.GetString("Advanced_MotionEstimationRangeToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to x264 normally zeroes out nearly-empty data blocks to save bits to be better used for some other purpose in the video.  
        ///However, this can sometimes have slight negative effects on retention of subtle grain and dither.  
        ///Don&apos;t touch this unless you&apos;re having banding issues or other such cases where you are having trouble keeping fine noise..
        /// </summary>
        public static string Advanced_NoDctDecimateToolTip {
            get {
                return ResourceManager.GetString("Advanced_NoDctDecimateToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The x264 Preset / Tune / Profile and Level options are currently in use on the Video Tab. 
        ///
        ///To enable this tab, check the &quot;Use Advanced Tab instead&quot; option on the Video Tab.
        ///
        ///If you do not use this tab, it can be hidden from: Tools Menu &gt; Options &gt; Advanced..
        /// </summary>
        public static string Advanced_NotInUse {
            get {
                return ResourceManager.GetString("Advanced_NotInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Psychovisual Rate Distortion means x264 tries to retain detail, for better quality to the human eye, 
        ///as opposed to trying to maximize quality the way a computer understands it, through signal-to-noise ratios that have trouble telling apart fine detail and noise..
        /// </summary>
        public static string Advanced_PsychovisualRateDistortionToolTip {
            get {
                return ResourceManager.GetString("Advanced_PsychovisualRateDistortionToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Psychovisual Trellis tries to retain more sharpness and detail, but can cause artifacting.
        ///It is considered experimental, which is why it&apos;s off by default. Good values are 0.1 to 0.2..
        /// </summary>
        public static string Advanced_PsychovisualTrellisToolTip {
            get {
                return ResourceManager.GetString("Advanced_PsychovisualTrellisToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B-pyramid improves compression by creating a pyramidal structure (hence the name) of B-frames, allowing B-frames to 
        ///reference each other to improve compression.  
        ///
        ///Requires Max B-frames greater than 1; optimal adaptive B-frames is strongly recommended for full compression benefit..
        /// </summary>
        public static string Advanced_PyramidalBFramesToolTip {
            get {
                return ResourceManager.GetString("Advanced_PyramidalBFramesToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sane values are ~1-6.
        ///
        ///The more you add, the better the compression, but the slower the encode.
        ///
        ///Cel animation tends to benefit from more reference frames a lot more than film content.
        ///
        ///Note that many hardware devices have limitations on the number of supported reference frames, so if you&apos;re encoding for a handheld or standalone player, don&apos;t touch this unless you&apos;re absolutely sure you know what you&apos;re doing!.
        /// </summary>
        public static string Advanced_ReferenceFramesToolTip {
            get {
                return ResourceManager.GetString("Advanced_ReferenceFramesToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This setting controls both subpixel-precision motion estimation and mode decision methods.
        ///
        ///Subpixel motion estimation is used for refining motion estimates beyond mere pixel accuracy, improving compression.
        ///
        ///Mode decision is the method used to choose how to encode each block of the frame: a very important decision.
        ///
        ///SAD is the fastest method, followed by SATD, RD, RD refinement, and the slowest, QPRD.
        ///6 or higher is strongly recommended: Psy-RD, a very powerful psy optimization that helps retain det [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Advanced_SubpixelMotionEstimationToolTip {
            get {
                return ResourceManager.GetString("Advanced_SubpixelMotionEstimationToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trellis fine-tunes the rounding of transform coefficients to squeeze out 3-5% more compression at the cost of some speed. 
        ///&quot;Always&quot; uses trellis not only during the main encoding process, but also during analysis, which improves compression even more, albeit at great speed cost. 
        ///
        ///Trellis costs more speed at higher bitrates..
        /// </summary>
        public static string Advanced_TrellisToolTip {
            get {
                return ResourceManager.GetString("Advanced_TrellisToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performs extra analysis to decide upon weighting parameters for each frame.  
        ///This improves overall compression slightly and improves the quality of fades greatly. 
        ///Baseline profile, as required for iPods and similar devices, requires weighted P-frame prediction to be disabled.  
        ///Note that some devices and players, even those that support Main Profile, 
        ///may have problems with Weighted P-frame prediction: the Apple TV is completely incompatible with it, for example..
        /// </summary>
        public static string Advanced_WeightPToolTip {
            get {
                return ResourceManager.GetString("Advanced_WeightPToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap logo64 {
            get {
                object obj = ResourceManager.GetObject("logo64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: You do not have automatic file naming turned on. Please enable this in options..
        /// </summary>
        public static string QueueSelection_AutoNameWarning {
            get {
                return ResourceManager.GetString("QueueSelection_AutoNameWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: You do not currently have automatic audio and subtitle track selection setup. You can setup the default track selection behaviour in options..
        /// </summary>
        public static string QueueSelection_AutoTrackSelectionWarning {
            get {
                return ResourceManager.GetString("QueueSelection_AutoTrackSelectionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: RF 0 is Lossless!.
        /// </summary>
        public static string Video_LosslessWarning {
            get {
                return ResourceManager.GetString("Video_LosslessWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value of 0 means lossless and will result in a file size that is larger than the original source, 
        ///unless the source was also lossless. 
        ///
        ///x264&apos;s scale is logarithmic and lower values correspond to higher quality. 
        ///
        ///So small increases in value will result in progressively larger increases in the resulting file size. 
        ///
        ///Suggested values are: 18 to 20 for Standard Definition and 20 to 23 for High Definition..
        /// </summary>
        public static string Video_LosslessWarningTooltip {
            get {
                return ResourceManager.GetString("Video_LosslessWarningTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the desired quality factor. The encoder targets a certain quality. 
        ///The scale used by each video encoder is different.
        ///
        ///x264&apos;s scale is logarithmic and lower values correspond to higher quality. 
        ///So small increases in value will result in progressively larger increases in the resulting file size. 
        ///A value of 0 means lossless and will result in a file size that is larger than the original source, 
        ///unless the source was also lossless. 
        ///Suggested values are: 18 to 20 for Standard Definition and 20 t [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Video_QualitySlider {
            get {
                return ResourceManager.GetString("Video_QualitySlider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The full x264 list of parameters: 
        ///{0}.
        /// </summary>
        public static string Video_x264ExtraArgs {
            get {
                return ResourceManager.GetString("Video_x264ExtraArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reduce decoder CPU usage.
        ///
        ///Set this if your device is struggling to play the output. (i.e. dropped frames).
        /// </summary>
        public static string Video_x264FastDecode {
            get {
                return ResourceManager.GetString("Video_x264FastDecode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets and ensures compliance with the specified H.264 Levels. This will override all other settings..
        /// </summary>
        public static string Video_x264Level {
            get {
                return ResourceManager.GetString("Video_x264Level", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjusts x264 settings to trade off compression efficiency against encoding speed.
        ///
        ///This establishes your default x264 settings. Tunes, profiles, levels and advanced options string will be applied to this.
        ///
        ///You should generally set this option to the slowest you can bear since slower settings will result in better quality or smaller files..
        /// </summary>
        public static string Video_x264Preset {
            get {
                return ResourceManager.GetString("Video_x264Preset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Limit the H.264 profile of the output stream. This will override all other settings..
        /// </summary>
        public static string Video_x264Profile {
            get {
                return ResourceManager.GetString("Video_x264Profile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tune settings to optimise for common scenarios
        ///
        ///This can improve efficiency for particular source characteristics or set of characteristics of the output file.
        ///
        ///Changes will be applied after the preset but before all other parameters..
        /// </summary>
        public static string Video_x264Tune {
            get {
                return ResourceManager.GetString("Video_x264Tune", resourceCulture);
            }
        }
    }
}
