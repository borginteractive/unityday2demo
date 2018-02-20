using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {

    public List<GameObject> cubes = new List<GameObject>();
    public float speed;

	// Use this for initialization
	void Start () {
        cubes[0].transform.position = new Vector3(10, 0, 0);


        InvokeRepeating("moveCube5", 1, 0.5f);

        StartCoroutine(moveCube6());
        
      
        
    }

    IEnumerator moveCube6()
    {
        print("Hello 1");
        yield return new WaitForSeconds(1f);
        
        
        iTween.MoveTo(cubes[7], new Vector3(10, -14, 0), 2);

        iTween.ScaleTo(cubes[7], new Vector3(3, 3, 3), 2);

        print("Hello 2");

        for (int i = 0; i < 3; i++)
        {
            print("Hello 3");
            yield return new WaitForSeconds(0.5f);

        }
        print("Hello 4");

        yield return null;
    }

    void moveCube5()
    {
        Vector3 newpos = new Vector3(cubes[5].transform.position.x + 0.1f,
          cubes[5].transform.position.y, cubes[5].transform.position.z);
        cubes[5].transform.position = newpos;
    }
	// Update is called once per frame
	void Update () {

        if (Time.time < 1)
            return;


        // CUBE 1
        Vector3 newpos = new Vector3(cubes[1].transform.position.x + 0.1f, 
            cubes[1].transform.position.y, cubes[1].transform.position.z);
        cubes[1].transform.position = newpos;

        //CUBE 2

        cubes[2].transform.position = Vector3.MoveTowards(cubes[2].transform.position, new Vector3(10, -4, 0), speed * Time.deltaTime);

        // CUBE 3
        cubes[3].transform.position = Vector3.Lerp(cubes[3].transform.position, new Vector3(10, -6, 0), 0.1f);


       

    }
    void FixedUpdate()
    {
        // CUBE 4
        cubes[4].GetComponent<Rigidbody>().AddForce(15, 0, 0);

    }
}
