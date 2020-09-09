using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class moveright : MonoBehaviour
{
    public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(1.75f, 0, 5);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
