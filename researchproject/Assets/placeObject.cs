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
        bool buildMode = false;

        if (Input.GetKey(KeyCode.B))
                buildMode = true;
        
        if(buildMode == true) { 

        var speed = 30;

        RaycastHit hit;

        if (Input.GetKey(KeyCode.Q))
            ghost.transform.Rotate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            ghost.transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Y))
            ghost.transform.Rotate(0, 90, 0);
        if (Input.GetKeyDown(KeyCode.X))
            ghost.transform.Rotate(0, -90, 0);

        //if (Input.GetKeyDown(KeyCode.C))
                //buildMode = false;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)){
            ghost.transform.position = hit.point;
            //ghost.transform.position = new Vector3(hit.point.x, hit.point.y+1, hit.point.z);
            if (Input.GetMouseButtonDown(0))
			{
                
                Instantiate(placed, new Vector3(hit.point.x, hit.point.y + 0.74f, hit.point.z), ghost.transform.rotation);
			    }
		    }
        }
    }
}
