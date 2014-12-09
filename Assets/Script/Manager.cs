using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public string scene;
	public float time;
	float initialtime = 180f;
	public GUIStyle custom;
	public float life;

	// Use this for initialization
	void Start () 
	{
		time = initialtime;
		life = 5;
	}
	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;
		Debug.Log( time + "Time");

		if (time <=0)
		{
			Application.LoadLevel(scene);
		}
	}

	void OnGUI() 
	{

	GUI.Label (new Rect (Screen.width * 0.7f, Screen.height * 0.01f, 50, 15), "Time: " + time.ToString("F0"), custom);
	
	}		
}
