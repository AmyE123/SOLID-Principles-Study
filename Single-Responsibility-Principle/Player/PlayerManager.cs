using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerMovement[] players;
    


    // Start is called before the first frame update
    void Start()
    {
        players[0].isActive = true;
        players[1].isActive = false;

        players[0].playerPos = new Vector3(-15, 1, 0.5f);
        players[1].playerPos = new Vector3(-15, -1, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
