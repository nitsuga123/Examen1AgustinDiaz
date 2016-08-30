using UnityEngine;
using System.Collections;

public class enemigo : MonoBehaviour {

   [SerializeField]
   private int vida;

    [SerializeField]
    private int daño;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (vida <= 0) {
            Destroy(this.gameObject);
        }
   
	}

    public void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "bala") {
            vida -= daño;
            Destroy(collision.gameObject);
        }

    }
}
