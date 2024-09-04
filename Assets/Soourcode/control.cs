using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
	public float berat, tinggiloncat;
	public GameObject Lamuk, instruction, handcopy, Rumah, skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	void OnMouseDown(){
		if(Time.timeScale == 1) {
			GameObject.Find ("suara wing").GetComponent<AudioSource> ().Play();
			Rumah.SetActive (true);
			handcopy.SetActive (true);
			instruction.SetActive (false);
			skor.SetActive (true);
			Lamuk.GetComponent<Rigidbody2D> ().gravityScale =  berat;
			Lamuk.GetComponent<Rigidbody2D> ().velocity = new Vector2(Lamuk.GetComponent<Rigidbody2D> ().velocity.x, tinggiloncat);
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		} 
    }
}
