using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomController : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] private GameObject stopGameObject;
    [SerializeField] private Vector3 positionGameObject;


    private float curentTime;
    private bool boomStart;


    // Start is called before the first frame update
    void Start()
    {
        boomStart = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (boomStart)
        {
            collision.rigidbody.AddForce(0, power, 0, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (boomStart)
        {
            collision.rigidbody.AddForce(0.5f, power, 0.5f, ForceMode.Impulse);
        }
    }


    public void startBoom()
    {
        boomStart = true;

        stopGameObject.SetActive(false);
    }
}
