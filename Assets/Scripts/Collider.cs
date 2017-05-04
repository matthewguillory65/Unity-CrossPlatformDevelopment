using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Color origionalColor;
    Material parentMaterial;
    public GameObject gridGameObject;

    private void Start()
    {
        parentMaterial = GetComponentInParent<MeshRenderer>().materials[0];
        origionalColor = parentMaterial.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            parentMaterial.color = Random.ColorHSV();
        }
    }
	
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            parentMaterial.color = origionalColor;
        }
    }
}
