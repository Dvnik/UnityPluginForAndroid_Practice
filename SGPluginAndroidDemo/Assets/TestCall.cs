using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCall : MonoBehaviour
{
	private void OnGUI()
	{
		Rect rect = new Rect( 0.0f, 0.0f, 200.0f, 100.0f );
		if ( GUI.Button(rect, "呼叫 Android") )
		{
			#if UNITY_ANDROID && !UNITY_EDITOR

			using ( AndroidJavaClass unity = new AndroidJavaClass("com.supergame.party.sgplugin.MainActivity") )
			{
			unity.CallStatic( "AlertShow", "這是標題", "這是內文" );
			}

			#endif
		}
	}
}
