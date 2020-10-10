using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingest : MonoBehaviour
{
    public GameObject box;
    public GameObject effects;
    private bool shrink = false;
    
    void enablePostEffects()
    {
        effects.SetActive(true);
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
            if (box.transform.localScale == new Vector3(0, 0, 0))
            {
                shrink = false;
            }
        }
    }
}
