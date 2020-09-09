using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class moverightrandom : MonoBehaviour
{
    public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += new Vector3(0, 0, Random.Range(0.01f,.1f));
    }
}
