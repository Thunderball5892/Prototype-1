using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -9);
    private Vector3 driverOffset = new Vector3(0, 3, 3);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = player.transform.position + driverOffset;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
