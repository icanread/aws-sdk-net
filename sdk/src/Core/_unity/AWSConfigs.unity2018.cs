/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

namespace Amazon
{
    public static partial class AWSConfigs
    {
#if UNITY_2018_OR_NEWER
        public static void FromUnity(IClientSettings clientSettings, System.Diagnostics.TraceListener traceListener = null)
        {
            AWSConfigs.AWSRegion = clientSettings.region;
            AWSConfigs.RegionEndpoint = clientSettings.regionEndpoint;
            AWSConfigs.UseSdkCache = clientSettings.useSdkCache;
            AWSConfigs.CorrectForClockSkew = clientSettings.correctForClockSkew;

            AWSConfigs.LoggingConfig.LogTo = clientSettings.LogTo;
            AWSConfigs.LoggingConfig.LogResponses = clientSettings.LogResponses;
            AWSConfigs.LoggingConfig.LogMetrics = clientSettings.LogMetrics;
            AWSConfigs.LoggingConfig.LogResponsesSizeLimit = clientSettings.LogResponsesSizeLimit;
            AWSConfigs.LoggingConfig.LogMetricsFormat = clientSettings.LogMetricsFormat;

            if (traceListener != null)
            {
                AWSConfigs.AddTraceListener(traceListener.Name, traceListener);
            }
        }

        public interface IClientSettings
        {
            RegionEndpoint regionEndpoint { get; }

            string region { get; }
            bool useSdkCache { get; }
            bool correctForClockSkew { get; }
            string applicationName { get; }

            LoggingOptions LogTo { get; }
            ResponseLoggingOption LogResponses { get; }
            int LogResponsesSizeLimit { get; }
            bool LogMetrics { get; }
            LogMetricsFormatOption LogMetricsFormat { get; }
        }
#endif
    }
}
