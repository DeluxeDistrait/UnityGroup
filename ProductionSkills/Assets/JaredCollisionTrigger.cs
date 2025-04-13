using UnityEngine;

public class JaredCollisionTrigger : MonoBehaviour
{
    public AudioSource collisionSound;

    void Start()
    {
        collisionSound.GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        collisionSound.Play();
    }
}
