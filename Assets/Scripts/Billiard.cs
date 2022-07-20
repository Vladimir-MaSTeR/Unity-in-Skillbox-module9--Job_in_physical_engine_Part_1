using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billiard : MonoBehaviour
{

    [SerializeField] private float power;

    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void pushBitoc()
    {
        rigidBody.AddForce(-(power), 0, 0);
    }
}
