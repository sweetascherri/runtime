// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Runtime.InteropServices;
using System;

internal class NullableTest
{
    private static bool BoxUnboxToNQ<T>(T o)
    {
        return Helper.Compare((int)(object)o, Helper.Create(default(int)));
    }

    private static bool BoxUnboxToQ<T>(T o)
    {
        return Helper.Compare((int?)(object)o, Helper.Create(default(int)));
    }

    private static int Main()
    {
        int? s = Helper.Create(default(int));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}

