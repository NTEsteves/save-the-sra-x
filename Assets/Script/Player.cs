﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Transform trans;
	public string scene;
	public string scene1;
	//public static float life;
	public string custom;

	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform>();
		//life = 5f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Manager.life==0)
		{
			Application.LoadLevel(scene1);
		}
	
		Debug.Log(move());
	}


	private string move(){
		if(Input.GetKey(KeyCode.DownArrow)){
			trans.Translate(new Vector3(-0,-0.05f, 0));
			return "DOWN";
		}else if(Input.GetKey(KeyCode.UpArrow)){
			trans.Translate(new Vector3(0f, 0.05f, 0));
			return "UP";
		}else if(Input.GetKey(KeyCode.LeftArrow)){
			trans.Translate(new Vector3(-0.05f, 0, 0));
			return "LEFT";
		}else if(Input.GetKey(KeyCode.RightArrow)){
			trans.Translate(new Vector3(0.05f, -0, 0));
			return "RIGHT";
		}else{
			return "IDLE";
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
		case "Seta":

			Application.LoadLevel(scene);
			Manager.lastlife++;
			

			Debug.Log ("Bateu");
			
			break;
		}

		switch(other.gameObject.tag)
		{
		case "Enemy":
			

			Manager.life --;

			Debug.Log(Manager.life);

			
			break;
		}


	}



	}


