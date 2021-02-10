using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMapa : MonoBehaviour {


    int numeroBack = 15;
        // Use this for initialization
        void Start () {
  
        }
    
    
    // Update is called once per frame
        void Update () { 
        transform.position += new Vector3(-3 * Time.deltaTime, 0, 0);
        }

    void OnTriggerEnter2D(Collider2D outro) {

        if(outro.transform.tag == "backmover") {
            float larguraBack = GetComponent<BoxCollider2D>().size.x;

            Vector3 posicao = GetComponent<BoxCollider2D>().transform.position;

            posicao.x += larguraBack * numeroBack;

            GetComponent<BoxCollider2D>().transform.position = posicao;
        }

    }

            
  }

