using UnityEngine;
using System.Collections;

public class destruirbala : MonoBehaviour {


    public void OnColisionEnter()
    {
        
       Destroy(this.gameObject);

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    
}
