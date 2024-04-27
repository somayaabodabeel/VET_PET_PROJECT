using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spray : MonoBehaviour
{
    public ParticleSystem sprayParticles;

    void Start()
    {
        // Make sure to assign the particle system in the Unity editor
        if (sprayParticles == null)
        {
            Debug.LogError("Please assign the particle system in the Unity editor");
        }
    }

    // Function to start spraying particles
    public void StartSpraying()
    {
        if (sprayParticles != null)
        {
            sprayParticles.Play();
        }
    }

    // Function to stop spraying particles
    public void StopSpraying()
    {
        if (sprayParticles != null)
        {
            sprayParticles.Stop();
        }
    }
}
