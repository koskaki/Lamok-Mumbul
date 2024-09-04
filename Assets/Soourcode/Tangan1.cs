using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangan1 : MonoBehaviour
{
    // Start is called before the first frame update
    float nilaiRandom;
	void Start()
    {
        nilaiRandom = Random.Range(-3.61f, -1.0f);
		transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}
