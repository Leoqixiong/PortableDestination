using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Behavior : MonoBehaviour
{
    public Color original_color;
    public Color target_color;
    Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        original_color = rend.material.color;
        target_color = rend.material.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (rend.material.color != target_color)
        {
            rend.material.color = Color.Lerp(rend.material.color, target_color, 0.03f);
        }
	}

    public void ChangeColor(Color col)
    {
        // rend.material.color = col;
        target_color = col;
    }

    void OnTriggerExit(Collider col)
    {
        // rend.material.color = original_color;
        target_color = original_color;
    }
}
