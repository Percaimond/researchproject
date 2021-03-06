using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorMove : MonoBehaviour
{

    public GameObject belt;
    public Transform endpoint;
    public float speed = 2;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
	{
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
	}
}
