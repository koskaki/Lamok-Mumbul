using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
	float Yhand;
	public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
		Yhand = Random.Range (0.87f,-0.94f);
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.timeScale == 1) {
		transform.localPosition = new Vector3 (transform.localPosition.x-kecepatan, Yhand, 2f);
        }
    }
}
