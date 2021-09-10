﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------

namespace Microsoft.Oryx.BuildScriptGenerator.DotNetCore
{
    /// <summary>
    /// Build script template for DotNetCore in Bash.
    /// </summary>
    public class DotNetCoreBashBuildSnippetProperties
    {
        public string CustomRunBuildCommand { get; set; }

        public string ProjectFile { get; set; }

        public string Configuration { get; set; }
    }
}