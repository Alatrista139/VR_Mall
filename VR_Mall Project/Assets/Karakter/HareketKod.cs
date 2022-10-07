using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKod : MonoBehaviour
{
    public bool isFlat = true;
    private Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }

        rbody.AddForce(tilt);
    }
}
