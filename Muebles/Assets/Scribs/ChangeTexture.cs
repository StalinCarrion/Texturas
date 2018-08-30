using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour {

 
    public Material material1;
    bool flag = true;
	// Use this for initialization
	public void CambiarTextura () {
        if (GameObject.FindGameObjectWithTag("suelo"))
        {
            GameObject suelo = GameObject.FindGameObjectWithTag("suelo");
            //suelo.transform.GetComponent<MeshRenderer>().material.SetTexture("_MainTex",textura1);
            suelo.transform.GetComponent<MeshRenderer>().material = material1;
           Debug.Log("lo encontro");

        }
        else
        {
            Debug.Log("NOOOO");
        }
		
	}
	

}
