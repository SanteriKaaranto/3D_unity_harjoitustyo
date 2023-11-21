using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Rigidbody PlayerRB;

    void OnTriggerEnter(Collider other)
    {
        // Kun pelaaja osuu respawn collider objectiin, viedään pelaaja respawn alueelle.
        player.transform.position = respawnPoint.transform.position;
        // Asetetaan pelaajan nopeus nollaan
        PlayerRB.velocity = Vector3.zero;
    }
}
