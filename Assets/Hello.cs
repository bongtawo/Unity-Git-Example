using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(new Vector3(3, 0, 0));
    }
}