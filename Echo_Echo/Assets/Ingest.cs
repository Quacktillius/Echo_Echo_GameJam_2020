using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingest : MonoBehaviour
{
    public GameObject box;
    public GameObject effects;
    
    void enablePostEffects()
    {
        effects.SetActive(true);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            enablePostEffects();
            Destroy(box);
        }
    }
}
