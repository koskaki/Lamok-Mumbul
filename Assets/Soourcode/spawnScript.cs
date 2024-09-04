using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
	float time = 0;
	float timer = 3;
	public GameObject Tangan;

    void Update()
    {
        if(time<=0)
		{
			Instantiate(Tangan, transform.position, Quaternion.identity);
			time = timer;
		}
		else
		{
			time -= Time.deltaTime;
		}
    }
}
