using UnityEngine;
using System.Collections;
using System;

public class Shoot : MonoBehaviour {
    [SerializeField]
    private GameObject bala;

    [SerializeField]
    private GameObject origenBala;

    [SerializeField]
    private float fuerza;


	// Use this for initialization
	void Start () {
 
        origenBala = new GameObject();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, origenBala.transform.position, Quaternion.identity);
            bala.GetComponent<Rigidbody>().AddForce(transform.forward * fuerza*Time.deltaTime);

        }
	}

    

    public void disparar() {

    }

}
