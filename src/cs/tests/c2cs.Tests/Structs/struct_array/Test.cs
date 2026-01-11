// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using C2CS.Tests.Common.Extensions;

namespace C2CS.Tests.Structs.struct_array;

public class Test : WriteCSharpCodeTest
{
    private const string StructName = "struct_array";

    [Fact]
    public void Function()
    {
        var ast = GetCSharpAbstractSyntaxTree(
            $"src/c/tests/structs/{StructName}");

        FfiFunctionExists(ast);
    }

    private static void FfiFunctionExists(CSharpTestAbstractSyntaxTree ast)
    {
        var function = ast.GetStructs(StructName);
        function.Name.Should().Be("a");
    }
}
