using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        Debug.Log("rotating");
        if(this.transform.rotation.y >= 360)
        {
            this.transform.Rotate(0f, 0f, 0f);
            Debug.Log("reset");
        }
        
    }
}
