using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public List<GameObject> cubes = new List<GameObject>();
    Vector3 cube2destination;
    Vector3 cube4origin;
    // Use this for initialization
    void Start () {
         cube2destination = new Vector3(0, 4, 0);
        cube4origin = cubes[4].transform.position;
        
	}

    // Update is called once per frame
    void Update() {
        if (Time.time < 1)
            return;

        //time.deltatime
        //CUBE 0
        Vector3 newpos = new Vector3(cubes[0].transform.position.x + 0.1f, cubes[0].transform.position.y, cubes[0].transform.position.z);
        cubes[0].transform.position = newpos;

        // CUBE 1
        cubes[1].transform.position = Vector3.MoveTowards(cubes[1].transform.position, new Vector3(0, 6, 0), 0.1f);


        // CUBE 2



        // CUBE 3
        cubes[3].transform.position = Vector3.Lerp(cubes[3].transform.position, new Vector3(0, 2, 0), 0.1f);

        // CUBE 4


        // CUBE 5

        cubes[5].GetComponent<Rigidbody>().AddForce(10, 0, 0);




    }

     void FixedUpdate()
    {
        
    }
}
