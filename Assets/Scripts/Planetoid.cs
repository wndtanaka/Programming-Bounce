using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetoid : MonoBehaviour
{
    Rigidbody rigid;
    Transform sun;
    GameObject[] gravity;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        sun = GameObject.Find("Sun").transform;
        gravity = GameObject.FindGameObjectsWithTag("gravity");
        // rigid.velocity = (Vector3.right + Vector3.forward) * 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        for (int i = 0; i < gravity.Length; i++)
        {
            rigid.AddForce(((gravity[i].transform.position - transform.position) * 20 / (Vector3.Distance(transform.position, gravity[i].transform.position) * 10))*gravity[i].transform.localScale.x);
        }
    }
}
