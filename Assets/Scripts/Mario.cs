using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            
        }else(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
             
        }
    }
}
