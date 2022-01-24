using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    public GameObject objek1, objek2;
    public GameObject[] objek3d = new GameObject[2];
    public int no = 1;

    // Start is called before the first frame update
    public void Start()
    {
        objek3d[0] = objek1;
        objek3d[1] = objek2;
    }

    public GUIStyle customButton; 
    public void OnGUI()
              
    {
             
        if (GUI.Button(new Rect(1825, 820, 300, 110), "Tampilan Kata", customButton))
        {
            nextObject();
        }

        if (GUI.Button(new Rect(25, 820, 300, 110), "Tampilan Huruf", customButton))
        {
            prevObject();
        }
        
    }

    public void nextObject()
    {
        if (no < 2)
        {
            no++;
        }
    }

    public void prevObject()
    {
        if (no > 1)
        {
            no--;
        }
    }

    public void Update()
    {
        if (no == 1)
        {
            objek1.SetActive(true);
            objek2.SetActive(false);
        }
        if (no == 2)
        {
            objek1.SetActive(false);
            objek2.SetActive(true);
        }
    }
}