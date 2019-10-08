using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnYoYoTimer : MonoBehaviour
{
    public GameObject yoyo;
    public float MovementForce = 600f;
    float fireRate;
    float nextFire;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 0.1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckTimetoFire();
    }

    void CheckTimetoFire()
    {
        if (Time.time > nextFire)
        {
            GameObject clone = Instantiate(yoyo, transform.position, Quaternion.identity) as GameObject;
            nextFire = Time.time + fireRate;
            rb = clone.GetComponent<Rigidbody>();
            transform.Rotate(new Vector3(Time.deltaTime * 0,10,0));
            rb.AddForce(MovementForce, 0, 0, ForceMode.Impulse);
            Destroy(clone, 3f);
        }
    }
}
