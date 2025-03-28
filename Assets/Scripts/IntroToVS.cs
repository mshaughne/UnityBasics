using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroToVS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Destroy(this.gameObject);
            MeshRenderer example = GetComponent<MeshRenderer>();
            Debug.Log(example);
        }
    }
}
