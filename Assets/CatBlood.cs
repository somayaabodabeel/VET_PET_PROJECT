using UnityEngine;

public class CatBlood : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    public ParticleSystem bloodEffect;

    private bool isBleeding = true; // Assuming blood starts bleeding initially

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void Heal()
    {
        if (isBleeding)
        {
            StopBleedingEffect();
            isBleeding = false;
        }

        // Implement the logic to heal the cat's blood and increase health
        // For example, you can increase the currentHealth variable or call a separate healing method

        // After healing logic, check if the health has reached the maximum
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            // Implement any logic when the cat's blood is fully healed
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0f)
        {
            currentHealth = 0f;
            // Implement any logic when the cat's blood reaches zero health
        }

        if (!isBleeding)
        {
            StartBleedingEffect();
            isBleeding = true;
        }
    }

    public void StopBleeding()
    {
        if (isBleeding)
        {
            StopBleedingEffect();
            isBleeding = false;
        }
    }

    private void StartBleedingEffect()
    {
        if (bloodEffect != null)
        {
            bloodEffect.Play();
        }
    }

    private void StopBleedingEffect()
    {
        if (bloodEffect != null)
        {
            bloodEffect.Stop();
        }
    }
}
