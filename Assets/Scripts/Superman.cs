using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Vector3[] points;

    private Vector3 targetPoint;
    private int curentPoint = 0;
    private bool start;
    private Rigidbody body;

    void Start()
    {
        targetPoint = points[curentPoint];
        body = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {

        if (start)
        {

            // transform.LookAt(targetPoint);

            //  transform.Rotate(transform.position.x, targetPoint.y, 90);
            // transform.Rotate(0, 90, 0);
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);
            //  rigidBody.AddForce(-speed, 0, 0);

            if (transform.position == targetPoint)
            {
                curentPoint++;
                if (curentPoint >= points.Length)
                {
                    curentPoint = points.Length - 1;
                    start = false;
                }
                targetPoint = points[curentPoint];

            }

        } else
        {
            body.isKinematic = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        float x = Random.Range(-10, 0);
        float y = Random.Range(3, 15);
        float z = Random.Range(1, 10);

        collision.rigidbody.AddForce(x, y, z, ForceMode.Impulse);
    }

    public void OnStartSuperman()
    {
        start = true;
    }
}
