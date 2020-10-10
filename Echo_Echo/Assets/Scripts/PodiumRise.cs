using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PodiumRise : MonoBehaviour
{
    public GameObject podium;
    public Vector3 finalPosition = new Vector3(0, 1, 0);
    public float speed = 0.6f;
    public bool rise = false;

    IEnumerator OnTriggerEnter(Collider collider)
    {
        yield return new WaitForSeconds(1);
        rise = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rise)
            podium.transform.position = Vector3.Lerp(podium.transform.position, finalPosition, speed * Time.deltaTime);
    }
}
