using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Determine el player
    public GameObject player;

    // Offset de la c�mara
    private Vector3 offset = new Vector3(40, 0, 0);


    // Update is called once per frame
    void Update()
    {
        // Posiciona la c�mara siguiendo la posici�n del player respecto al offset
        transform.position = player.transform.position + offset;
    }
}
