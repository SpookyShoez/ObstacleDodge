using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into this thingy many times" + hits);
        }
    }
}
