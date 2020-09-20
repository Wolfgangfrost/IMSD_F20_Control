using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class movecar: MonoBehaviour
{
    public Transform myTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = myTransform.position + new Vector3(1f, 0, 0) * speed * Time.deltaTime;


        if(myTransform.position.x> 5)
        {
            myTransform.position += Vector3.left * 10;
        }




    }
}
