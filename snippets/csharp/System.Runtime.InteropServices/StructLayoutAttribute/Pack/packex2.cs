﻿// <Snippet3>
using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
struct ExampleStruct2
{
    public byte b1;
    public byte b2;
    public int i3;
}

public class Example2
{
    public unsafe static void Main()
    {
        ExampleStruct2 ex = new();
        byte* addr = (byte*)&ex;
        Console.WriteLine("Size:      {0}", sizeof(ExampleStruct2));
        Console.WriteLine("b1 Offset: {0}", &ex.b1 - addr);
        Console.WriteLine("b2 Offset: {0}", &ex.b2 - addr);
        Console.WriteLine("i3 Offset: {0}", (byte*)&ex.i3 - addr);
    }
}
// The example displays the following output:
//       Size:      6
//       b1 Offset: 0
//       b2 Offset: 1
//       i3 Offset: 2
// </Snippet3>
