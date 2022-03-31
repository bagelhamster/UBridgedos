using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCar : MonoBehaviour
{
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire5"))
        {
            Door.transform.position = new Vector2(0, 200000000000);
        }
    }
}
