#if !UNITY_WINRT || UNITY_EDITOR || (UNITY_WP8 &&  !UNITY_WP_8_1)
using System;
using Fiveminlab.Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
    [Preserve]
    public delegate void PropertyChangingEventHandler(Object sender, PropertyChangingEventArgs e);

}

#endif