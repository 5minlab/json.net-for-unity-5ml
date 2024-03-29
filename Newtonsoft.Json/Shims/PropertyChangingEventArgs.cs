#if !UNITY_WINRT || UNITY_EDITOR || (UNITY_WP8 &&  !UNITY_WP_8_1)
using System;
using Fiveminlab.Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
    [Preserve]
    public class PropertyChangingEventArgs : EventArgs
	{
		public PropertyChangingEventArgs(string propertyName)
		{
			PropertyName = propertyName;
		}

		public virtual string PropertyName { get; set; }
	}
}

#endif