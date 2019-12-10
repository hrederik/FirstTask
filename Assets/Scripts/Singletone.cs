using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singletone<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	public static T instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindObjectOfType<T>();

				if (_instance == null)
				{
					Debug.LogError("Can't find " + typeof(T) + "!");
				}
			}

			return _instance;
		}
	}	
}
