using UnityEngine;
using TMPro;

public class FinishTrigger : MonoBehaviour
{
    public ParticleSystem confettiEffect;  // Drag your confetti particle system here
    public GameObject winTextUI;      // Drag your TextMeshProUGUI object here

    void Start()
    {
        if (winTextUI != null)
            winTextUI.SetActive(false); // Forces it hidden at runtime
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player has the tag "Player"
        {
            // Move the confetti to player's position + burst upward
            confettiEffect.transform.position = other.transform.position + Vector3.up * 1.5f;
            confettiEffect.Play();

            // Show the win text
            winTextUI.SetActive(true);
            {

            }

            Debug.Log("🎉 Finish line reached!");
        }
    }
}