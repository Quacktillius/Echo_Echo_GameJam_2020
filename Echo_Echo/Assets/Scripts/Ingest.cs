using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using UnityEngine;

public class Ingest : MonoBehaviour
{
    public GameObject box;
    public GameObject mainLevel;
    public GameObject effects;
    public bool shrink = false;
    
    void enablePostEffects()
    {
        effects.SetActive(true);
    }

    void Start()
    {
        box.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        mainLevel.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);

        mainLevel.transform.position += new Vector3(0.0f, -1.0f, 0.0f);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            enablePostEffects();
            shrink = true;
            //Destroy(box);
        }
        if (shrink)
        {
            box.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            mainLevel.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            if (box.transform.localScale == new Vector3(0, 0, 0))
            {
                shrink = false;
                mainLevel.transform.position += new Vector3(0.0f, 1.0f, 0.0f);
            }
        }
    }
}
