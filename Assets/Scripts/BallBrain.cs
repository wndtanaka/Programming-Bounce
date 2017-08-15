using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBrain : MonoBehaviour
{
    Rigidbody rigid;
    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "bounce")
        {
            print("Hello");
            rigid.velocity = ((transform.position - collision.contacts[0].point) * 50);
        }
    }
}
