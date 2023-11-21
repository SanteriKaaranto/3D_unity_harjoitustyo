using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    [SerializeField] private Transform TeleportEnd;
    [SerializeField] private Rigidbody PlayerRB;
    

    void OnTriggerEnter(Collider other)
    {
        // Kun pelaaja osuu respawn collider objectiin, viedään pelaaja respawn alueelle.
        player.transform.position = TeleportEnd.transform.position;
        // Asetetaan pelaajan nopeus nollaan
        PlayerRB.velocity = Vector3.zero;
    }
}
