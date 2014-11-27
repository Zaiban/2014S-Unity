using UnityEngine;
using System.Collections;

public class color_script : MonoBehaviour {

	private int toggle = 0;
	private float countdown = 0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		countdown -= Time.deltaTime;
		if (countdown <= 0.0f) {
			countdown = 3.0f;
						if (toggle < 3)
								toggle++;
						else
								toggle = 0;

						if (toggle == 0)
								gameObject.renderer.material.color = Color.red;
						else if (toggle == 1)
								gameObject.renderer.material.color = Color.blue;
						else if (toggle == 2)
								gameObject.renderer.material.color = Color.green;
				}
	}


}
