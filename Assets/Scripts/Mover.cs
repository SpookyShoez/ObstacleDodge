using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float turnSpeed = 100f;

    public ParticleSystem CarGas;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
        // Play exhaust when pressing W or UpArrow
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (!CarGas.isPlaying)
                CarGas.Play();
        }
        else
        {
            if (CarGas.isPlaying)
                CarGas.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd!");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * moveAmount);

        transform.Rotate(Vector3.up, turnAmount);

    }

}
