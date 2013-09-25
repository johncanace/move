using UnityEngine;
using System.Collections;
using System;

public static class TriggerException {
		public static bool Has<T>(this Enum type, T value)
		{
			try
			{
				return ((int)(object)type&(int)(object)value) == ((int)(object)value);
			}
			catch(Exception e)
			{
				return false;
			}
		}

}
