using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviour
{

    public GameObject playerPrefab;
    public Transform spawnPoint;

    void Start()
    {
        Vector3 position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
    }

}
