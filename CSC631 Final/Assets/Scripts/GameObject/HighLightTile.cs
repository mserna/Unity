using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLightTile : MonoBehaviour {

    ParticleSystem hitParticles;
    // Use this for initialization
    void Start () {
        hitParticles = GetComponentInChildren<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {    
        hitParticles.Play();
    }

    void OnCollisionExit(Collision collision)
    {
        hitParticles.Stop();
    }
}
