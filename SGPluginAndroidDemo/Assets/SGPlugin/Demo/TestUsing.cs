using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUsing : SGPluginManager
{

	void OnGUI()
	{
		int offset = 0;
		if (Button("AlertTest", offset++))
		{
			AlertTest();
		}
	}

	private bool Button(string label, int index)
	{
		float width = Screen.width * 0.7f;
		float height = Screen.height * 0.1f;

		Rect rect = new Rect(Screen.width * 0.5f - width * 0.5f, 
			height * index * 1.1f,
			width,
			height);

		return GUI.Button(rect, label);
	}
}
