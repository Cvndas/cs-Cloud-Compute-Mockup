﻿global using static System.Console;
global using System.Diagnostics;
using CloudStates;


class ProgramClient
{
    static ProgramClient()
    {

    }
    public static void Main()
    {
#if DEBUG
        Console.WriteLine("Welcome (Debug)");
#else
        Console.WriteLine("Welcome (Release)");
#endif

        // Enables debug prints in standard output
        var myWriter = new TextWriterTraceListener(Out);
        Trace.Listeners.Add(myWriter);

        ClientInstance instance = ClientInstance.Instance;
        Debug.Assert(instance != null);
        instance?.RunClient();

        return;
    }

}