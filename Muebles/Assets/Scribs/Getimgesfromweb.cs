using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Getimgesfromweb : MonoBehaviour {


	public string base_url = "https://stalinfernandocarrioncarchi96.000webhostapp.com";
	public string prefijo = "floor";
	public string extension = ".jpg";

	public Texture[] BaseDeTexturas;
	public RawImage img;
	public int totalimages = 5;
	int id_actual;

	void Start () {
		BaseDeTexturas = new Texture[totalimages];
		StartCoroutine (getAll ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator getAll(){

		WWW web = new WWW (base_url+"/"+prefijo+(id_actual+1)+extension);
		Debug.Log (web.url);

		yield return web;

		BaseDeTexturas [id_actual] = web.texture;

		id_actual++;

		if (id_actual < BaseDeTexturas.Length) {
			StartCoroutine (getAll ());
		} else {
			


			img.texture = BaseDeTexturas[3];
		}


	}


}
