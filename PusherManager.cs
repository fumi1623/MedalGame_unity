using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherManager : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin(Time.time);
        this.transform.position = new Vector3(sin * 2 - 9.5f, 3.8f, 0);
    }
}
