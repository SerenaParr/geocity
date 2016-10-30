using UnityEngine;
using System.Collections;

public class SimpleTrigerableFunctions : MonoBehaviour {

	public GameObject activatableComponent;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource> ();
	}

	public void turnOnGO(){
//		activatableComponent.SetActive (true);
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
		audio.Play ();

	}

	public void turnOffGO(){
//		activatableComponent.SetActive (false);
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Pause();

	}

}
