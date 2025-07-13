using UnityEngine;
using TMPro;

public class FinishTrigger : MonoBehaviour
{
    public ParticleSystem confettiEffect;  
    public GameObject winTextUI;      
    public AudioSource winAudioSource;    


    void Start()
    {
        winAudioSource = GetComponent<AudioSource>();

        if (winTextUI != null)
            winTextUI.SetActive(false); // Forces it hidden at runtime
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            
            if (confettiEffect != null)
            {
                confettiEffect.transform.position = other.transform.position + Vector3.up * 1.5f;
                confettiEffect.Play();
            }

            
            if (winTextUI != null)
                winTextUI.SetActive(true);

            
            if (winAudioSource != null && !winAudioSource.isPlaying)
                winAudioSource.Play();

            Debug.Log("🎉 Finish line reached!");
        }
    }
}