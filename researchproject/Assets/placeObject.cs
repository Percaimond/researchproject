using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeObject : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ghost;
    public GameObject placed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)){
            ghost.transform.position = hit.point;
			if (Input.GetMouseButtonDown(0))
			{
                Instantiate(placed, ghost.transform.position, ghost.transform.rotation);
			}
		}
    }
}
