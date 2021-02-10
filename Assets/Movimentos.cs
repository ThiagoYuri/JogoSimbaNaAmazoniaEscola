using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentos : MonoBehaviour {



    public Rigidbody2D perso;

    public float pulo;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetKeyDown(KeyCode.Space)) {

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, pulo);

        }
      //      Rigidbody2D.AddForce(Vector2.Up * 200);
       // }


	}



}
