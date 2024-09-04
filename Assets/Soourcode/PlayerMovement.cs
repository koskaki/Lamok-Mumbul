using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody2D Rb;
	public float jumpForce;
	float score;
	
	public Text scoreTxt;
	
	void Start()
	{
		Rb = GetComponent<Rigidbody2D>();
	}
	
	void Update()
	{
		scoreTxt.text = "" + score;
		if(Input.GetMouseButtonDown(0))
		{
			Rb.velocity = Vector2.up * jumpForce;
}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag=="point")
		{
			score++;
		}
		if(collision.gameObject.tag =="Tangan")
		{
			Destroy(gameObject);
		}
	}
}
