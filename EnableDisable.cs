using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject cube;

    public void OnEnable()
    {
        cube.SetActive(true);
    }
    public void OnDisable()
    {
        cube.SetActive(false);
    }
    
}
