using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.gameObject.SetActive(false);
        }
    }
}
