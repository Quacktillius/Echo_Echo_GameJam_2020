using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public GameObject playerSprite;
    public GameObject mainLevel;

    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        mainCamera.SetActive(true);
        playerSprite.SetActive(true);
        mainLevel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCamera.activeInHierarchy == false)
        {
            player.SetActive(true);
            playerSprite.SetActive(false);
            mainLevel.SetActive(true);
        }
    }
}
