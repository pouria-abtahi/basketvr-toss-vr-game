using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopTarget : MonoBehaviour
{
    public AudioClip scoreSound; // Assign the scoring sound in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to the hoop
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            GameManager1.Instance.AddScore(1); // Add score

            // Play the scoring sound
            if (scoreSound != null)
            {
                audioSource.PlayOneShot(scoreSound);
            }

            Debug.Log("Scored!");
        }
    }
}
