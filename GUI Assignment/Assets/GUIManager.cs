using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour {

    public GUISkin menuSkin;
    public GUIStyle backGround;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;

        GUI.Box(new Rect(0f * scrW, 0f * scrH, 17 * scrW, 10 * scrH), "", backGround);

        GUI.skin = menuSkin;

        GUI.Button(new Rect(0.5f * scrW, 0.5f * scrH, 4 * scrW, 1f * scrH), "");
        GUI.Button(new Rect(0.5f * scrW, 2f * scrH, 4 * scrW, 1f * scrH), "");
        GUI.Button(new Rect(0.5f * scrW, 3.5f * scrH, 4 * scrW, 1f * scrH), "");
    }
}
