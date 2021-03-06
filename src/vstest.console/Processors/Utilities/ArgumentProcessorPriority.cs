// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.CommandLine.Processors
{
    /// <summary>
    /// Defines the priority of argument processors.
    /// </summary>
    internal enum ArgumentProcessorPriority
    {
        /// <summary>
        /// Maximum priority for a processor.
        /// </summary>
        Maximum = 0,

        /// <summary>
        /// Priority of the Help Content argument processor.
        /// </summary>
        Help = Maximum,

        /// <summary>
        /// Priority of UseVsixArgumentProcessor.
        /// The priority of useVsix processor is more than the logger because logger’s initialization 
        /// loads the extensions which are incomplete if vsix processor is enabled
        /// </summary>
        VsixExtensions = 1,

        /// <summary>
        /// Priority of TestAdapterPathArgumentProcessor.
        /// The priority of TestAdapterPath processor is more than the logger because logger’s initialization 
        /// loads the extensions which are incomplete if custom test adapter is enabled
        /// </summary>
        TestAdapterPath = 1,

        /// <summary>
        /// Priority of processors related to Run Settings.
        /// </summary>
        RunSettings = 3,

        /// <summary>
        /// Priority of processors that needs to update runsettings.
        /// </summary>
        AutoUpdateRunSettings = 5,

        /// <summary>
        /// Priority of processors related to CLI Run Settings.
        /// </summary>
        CLIRunSettings = 6,

        /// <summary>
        /// Priority of processors related to logging.
        /// </summary>
        Logging = 10,

        /// <summary>
        /// Priority of the StartLogging processor.
        /// </summary>
        StartLogging = 11,

        /// <summary>
        /// Priority of the Diag processor.
        /// </summary>
        Diag = 12,

        /// <summary>
        /// Priority of a ParentProcessId processor.
        /// </summary>
        ParentProcessId = 45,

        /// <summary>
        /// Priority of a typical processor.
        /// </summary>
        Normal = 50,

        /// <summary>
        /// Minimum priority for a processor.
        /// </summary>
        Minimum = 100
    }
}
