using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlatformColor : MonoBehaviour
{
    public Renderer platform;

    void OnCollisionEnter(Collision other)
    {
        Ingest obj = new Ingest();

        if (obj.shrink == false)
        {
            platform.material.color = Color.white;
            platform.material.SetColor("_EmissionColor", Color.white);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        platform = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
