using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGPluginAndroid 
{
	private static readonly string sSGPAcivity = "com.supergame.party.sgplugin.MainActivity";

	private static AndroidJavaClass mActivityContext = null;

	public static void StartContext()
	{
		if( Application.platform != RuntimePlatform.Android )
			return;

		if (mActivityContext == null) 
			mActivityContext = new AndroidJavaClass(sSGPAcivity);
	}

	public static void AlertShow()
	{
		if( Application.platform != RuntimePlatform.Android )
			return;
		StartContext ();

		mActivityContext.CallStatic( "AlertShow", "這是標題", "這是內文" );
	}



}
