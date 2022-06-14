using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timediff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>timediff)
        {
           GameObject newpipe =  Instantiate(pipe);
           newpipe.transform.position = new Vector3(0, Random.Range(-2, 3), 0);
           timer = 0;
           Destroy(newpipe, 8f);
        }
       
        
    }
}
