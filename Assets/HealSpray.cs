using UnityEngine;

public class HealingSprayVR : MonoBehaviour
{
    public ParticleSystem sprayEffect;
    public ParticleSystem bloodEffect;

    private bool isSpraying = false;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isSpraying = true;
            sprayEffect.Play();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            isSpraying = false;
            sprayEffect.Stop();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (isSpraying && other.CompareTag("Blood"))
        {
            var bloodParticles = other.GetComponent<ParticleSystem>();
            if (bloodParticles != null)
            {
                bloodParticles.Stop();
            }
        }
    }
}