using UnityEngine;
using System;
using Object = UnityEngine.Object;

/// <summary>
/// Advanced console logger. Taken from: https://www.youtube.com/watch?v=lRqR4YF8iQs
/// You can click the message in the console to highlight the object the message came from.
/// </summary>

public static class ConsoleLogger
{
    public static void Log(this Object myObj, params object[] msg)
    {
        DoLog(Debug.Log, "", myObj, msg);
    }

    public static void LogError(this Object myObj, params object[] msg)
    {
        DoLog(Debug.LogError, "<!>".Color("red"), myObj, msg);
    }

    public static void LogWarning(this Object myObj, params object[] msg)
    {
        DoLog(Debug.LogWarning, "??".Color("yellow"), myObj, msg);
    }

    public static void LogSuccess(this Object myObj, params object[] msg)
    {
        DoLog(Debug.Log, "?".Color("green"), myObj, msg);
    }

    public static string Color(this string myStr, string color)
    {
        return $"<color={color}>{myStr}</color>";
    }

    private static void DoLog(Action<string, Object> LogFunction, string prefix, Object myObj, params object[] msg)
    {
#if UNITY_EDITOR // Don't log in the build
        string name = (myObj ? myObj.name : "NullObject").Color("lightblue");
        LogFunction($"{prefix}[{name}]: {String.Join("; ", msg)}\n ", myObj);
        //                      ^ name of the object                  ^ allows for highlighting the sender object on console message click
#endif
    }
}