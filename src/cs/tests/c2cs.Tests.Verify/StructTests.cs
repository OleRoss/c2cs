// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using C2CS.GenerateCSharpCode;
using C2CS.Tests.Verify.Helpers;
using Microsoft.Extensions.Logging;

namespace C2CS.Tests.Verify;

public sealed class StructTests(FileSystemHelper fileSystemHelper, Tool tool, ILogger<VerifyHelpers> logger)
    : VerifyHelpers(fileSystemHelper, tool, logger)
{
    [Fact]
    public async Task StructArray()
    {
        var output = RunTool("structs/struct_array", "config-generate-cs-struct_array.json");

        await VerifyOutput(output);
    }
}
