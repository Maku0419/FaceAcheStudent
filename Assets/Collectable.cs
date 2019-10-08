using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioClip pickUpSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (pickUpSound)
            {
                AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
            }
            Destroy(gameObject);
        }
    }
}
