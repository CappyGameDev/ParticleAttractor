using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ParticleAttractor : MonoBehaviour {

    //-----------------------------------
    // Created by: Callum Stirrup-Prazak
    // Contributors:
    //-----------------------------------


    //Referencing An array of particle systems to be using in programming
    [SerializeField] private ParticleSystem[] particleSystems;

    //Used for referencing target locations for particle systems
    [SerializeField] private GameObject attractorLeft;
    [SerializeField] private GameObject attractorRight;

    //References Left and Right Particle Attractors
    void Start () {

        attractorLeft = GameObject.FindGameObjectWithTag("attractorLeft");
        attractorRight = GameObject.FindGameObjectWithTag("attractorRight");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ParticleAttracting()
    {

    }
}
