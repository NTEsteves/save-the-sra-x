using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public string scene;
	public float time;
	float initialtime = 180f;
	public float lifeinitial;
	public GUIStyle custom;
	public static float life;
	public static float lastlife;
	// Use this for initialization
	void Start () 
	{
		time = initialtime;
		life = lifeinitial;
		lastlife = life;

	}
	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;
		Debug.Log( time + "Time");
		Debug.Log (lastlife+"lastlife");


		if (time <=0)
		{
			Application.LoadLevel(scene);
		}
		//lifeinitial = life;
	}

	void OnGUI() 
	{

	GUI.Label (new Rect (Screen.width * 0.7f, Screen.height * 0.01f, 50, 15), "Time: " + time.ToString("F0"), custom);
		GUI.Label (new Rect (Screen.width * 0.5f, Screen.height * 0.01f, 50, 15), "Life: " + life.ToString("F0"), custom);
	}		
}
