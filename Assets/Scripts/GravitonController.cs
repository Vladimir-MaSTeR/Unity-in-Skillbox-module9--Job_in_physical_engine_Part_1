using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitonController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 onePosition;
    [SerializeField] private Vector3 twoPosition;

    private Vector3 targetPoint;


    // Start is called before the first frame update
    void Start()
    {
        targetPoint = onePosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);

        if (transform.position == targetPoint)
        {
            if (targetPoint == onePosition)
            {
                targetPoint = twoPosition;

            } else
            {
                targetPoint = onePosition;
            }

        }
    }


    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = false;    
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = true;
    }



}
