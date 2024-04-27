using System;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    Collider _collider;
    public ParticleSystem particleSystem;

    void Start()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;

    
        if (particleSystem == null)
        {
            Debug.LogError("Particle System is not assigned to the Consumer script!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Consumable consumable = other.GetComponent<Consumable>();
        if (consumable != null && !consumable.IsFinished)
        {
            consumable.Consume();

            if (particleSystem != null)
            {
                particleSystem.Play();
            }
        }
    }
}
