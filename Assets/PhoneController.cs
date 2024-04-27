using UnityEngine;

public class PhoneController : MonoBehaviour
{
    public AudioClip ringSound;
    public AudioClip pickupSound;

    private AudioSource audioSource;
    private bool isRinging = false;
    private bool isPickedUp = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!isRinging)
            {
                StartRinging();
            }
            else
            {
                StopRinging();
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isPickedUp)
            {
                PickUpPhone();
            }
            else
            {
                StopPickup();
            }
        }
    }

    private void StartRinging()
    {
        // Play the ringing sound
        audioSource.clip = ringSound;
        audioSource.loop = true;
        audioSource.Play();

        isRinging = true;
    }

    private void StopRinging()
    {
        // Stop the ringing sound
        audioSource.Stop();

        isRinging = false;
    }

    private void PickUpPhone()
    {
        // Play the pickup sound
        audioSource.clip = pickupSound;
        audioSource.loop = false;
        audioSource.Play();

        isPickedUp = true;
    }

    private void StopPickup()
    {
        // Stop the pickup sound
        audioSource.Stop();

        isPickedUp = false;
    }
}