using UnityEngine;
using System.Collections;

public class Enemy: MonoBehaviour 
{
	
	public float VelX;
	public float VelY;
	public float VelZ;
	
	void Start () 
	{
		//VelX = -0.02f;
		//VelY = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		transform.position += new Vector3(VelX,VelY, VelZ);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
		case "WallVisible":

			VelX = 0.10f;
			VelY = -0.07f;
			Debug.Log ("Bateu");

		break;
		}
		switch(other.gameObject.tag)
		{
		case "Wall2Visible":
			
			VelX = -0.10f;
			VelY = 0.02f;
			Debug.Log ("Bateu");
			
			break;
		}
		switch (other.gameObject.tag) 
		{
		case "Teto":

			VelX = 0f;
			VelY = -0.05f;

			break;
		}

		switch (other.gameObject.tag) 
		{
		case "Chao":
			VelX = 0.05f ;
		VelY = 0.1f;

			break;
		}
	}


}

