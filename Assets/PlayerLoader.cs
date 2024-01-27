using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public GameObject pos;
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("walid");
        Debug.Log(player + " Player has not been Found");
        player.transform.position = pos.transform.position;
        Debug.Log(player.transform.position + " " + pos.transform.rotation);
    }
}
