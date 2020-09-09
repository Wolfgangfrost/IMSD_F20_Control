using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class moverightsmoothcont : MonoBehaviour
{
    public Transform myTransform;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //myTransform.position = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = myTransform.position + new Vector3(0, 0,1f)*speed*Time.deltaTime;
        
    }
}
