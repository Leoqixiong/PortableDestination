using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Behavior : MonoBehaviour {
    [SerializeField]
    Color field_function_color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        // Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "building")
        {
            other.GetComponent<Building_Behavior>().ChangeColor(field_function_color);
        }
    }
}
