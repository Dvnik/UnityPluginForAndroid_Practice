using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGPluginManager : MonoBehaviour
{

	#region Unity Function
	void Start () { StartContext(); }
	#endregion


	public void StartContext()
	{
		#if UNITY_ANDROID
		SGPluginAndroid.StartContext ();
		#endif
	}

	public void AlertTest()
	{
		#if UNITY_ANDROID
		SGPluginAndroid.AlertShow();
		#endif
	}




}
