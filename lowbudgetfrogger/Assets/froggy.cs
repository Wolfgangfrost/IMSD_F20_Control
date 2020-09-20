using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class froggy : MonoBehaviour
   
    
    
{

    Transform myTransform;
    public float speed = 2.24f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform; 
    }

    // Update is called once per frame
    void Update()
    {
     

        if(Input.GetKey(KeyCode.W))
        {
            myTransform.position += new Vector3(0, Time.deltaTime*speed, 0);
        }

        
        
        if (Input.GetKey(KeyCode.S))
        {
            myTransform.position += new Vector3(0, -Time.deltaTime * speed, 0);
        }





    }
}
