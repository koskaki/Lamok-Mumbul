using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
	float time = 0;
	float timer = 2;
	public GameObject Tangan1;

    void Update()
    {
        if(time<=0)
		{
			Instantiate(Tangan1, transform.position, Quaternion.identity);
			time = timer;
		}
		else
		{
			time -= Time.deltaTime;
		}
    }
}
