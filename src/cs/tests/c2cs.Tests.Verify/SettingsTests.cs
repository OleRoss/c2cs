// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using C2CS.GenerateCSharpCode;
using C2CS.Tests.Verify.Helpers;

namespace C2CS.Tests.Verify;

public class SettingsTests(FileSystemHelper fileSystemHelper, Tool tool) : VerifyHelpers(fileSystemHelper, tool)
{
    /// <summary>
    ///     Tests <see cref="InputUnsanitized.LibraryName" />, <see cref="InputUnsanitized.NamespaceName" />, and
    ///     <see cref="InputUnsanitized.ClassName" />.
    /// </summary>
    [Fact]
    private async Task DifferentNames()
    {
        var output = RunTool("config-generate-cs-different_names.json");

        await VerifyOutput(output);
    }

    /// <summary>
    ///     Tests <see cref="InputUnsanitized.IsEnabledAccessModifierInternal" />.
    /// </summary>
    [Fact]
    private async Task InternalTypeAccessModifiers()
    {
        var output = RunTool("config-generate-cs-internal_type_access_modifiers.json");

        await VerifyOutput(output);
    }

    /// <summary>
    ///     Tests <see cref="InputUnsanitized.HeaderCodeRegionFilePath" />.
    /// </summary>
    [Fact]
    private async Task HeaderCodeRegionFilePath()
    {
        var output = RunTool("config-generate-cs-header_code_region.json");

        await VerifyOutput(output);
    }

    /// <summary>
    ///     Tests <see cref="InputUnsanitized.FooterCodeRegionFilePath" />.
    /// </summary>
    [Fact]
    private async Task FooterCodeRegionFilePath()
    {
        var output = RunTool("config-generate-cs-footer_code_region.json");

        await VerifyOutput(output);
    }

    /// <summary>
    ///     Tests <see cref="InputUnsanitized.IsEnabledFileScopedNamespace" />.
    /// </summary>
    [Fact]
    private async Task FileScopedNamespacesDisabled()
    {
        var output = RunTool("config-generate-cs-file_scoped_namespaces.json");

        await VerifyOutput(output);
    }
}
