// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AudioAnalysisMode.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AudioAnalysisModeConverter))]
    public struct AudioAnalysisMode : System.IEquatable<AudioAnalysisMode>
    {
        private AudioAnalysisMode(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Performs all operations included in the Basic mode, additionally
        /// performing language detection and speaker diarization.
        /// </summary>
        public static readonly AudioAnalysisMode Standard = "Standard";

        /// <summary>
        /// This mode performs speech-to-text transcription and generation of a
        /// VTT subtitle/caption file. The output of this mode includes an
        /// Insights JSON file including only the keywords, transcription,and
        /// timing information. Automatic language detection and speaker
        /// diarization are not included in this mode.
        /// </summary>
        public static readonly AudioAnalysisMode Basic = "Basic";


        /// <summary>
        /// Underlying value of enum AudioAnalysisMode
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AudioAnalysisMode
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AudioAnalysisMode
        /// </summary>
        public bool Equals(AudioAnalysisMode e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AudioAnalysisMode
        /// </summary>
        public static implicit operator AudioAnalysisMode(string value)
        {
            return new AudioAnalysisMode(value);
        }

        /// <summary>
        /// Implicit operator to convert AudioAnalysisMode to string
        /// </summary>
        public static implicit operator string(AudioAnalysisMode e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AudioAnalysisMode
        /// </summary>
        public static bool operator == (AudioAnalysisMode e1, AudioAnalysisMode e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AudioAnalysisMode
        /// </summary>
        public static bool operator != (AudioAnalysisMode e1, AudioAnalysisMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AudioAnalysisMode
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AudioAnalysisMode && Equals((AudioAnalysisMode)obj);
        }

        /// <summary>
        /// Returns for hashCode AudioAnalysisMode
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
