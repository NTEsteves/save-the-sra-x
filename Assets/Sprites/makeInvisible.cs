using UnityEngine;
using System.Collections;

public class makeInvisible : MonoBehaviour 
{
	SpriteRenderer renderer;

	void Start ()
	{
		renderer = GetComponent<SpriteRenderer>();

		renderer.enabled = false;
	}

}
