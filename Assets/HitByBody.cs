using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByBody : MonoBehaviour
{
    private bool isHit;
    private Rigidbody myRigidbody;
    //public GameObject part;
    private Collider myCollider;
    public string body_part;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
        isHit = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(body_part) && !isHit)
        {
            isHit = true;
            Destroy(gameObject);
        }
    }
}
