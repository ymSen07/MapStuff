using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 teleportLoction;
    public Transform Player;

    public void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Player = player.transform;
    }

    public void TeleportLoc()
    {
        Player.gameObject.transform.position = teleportLoction;
        Player.GetComponent<CharacterController>().enabled = true;
        Debug.Log("Teleported");
    }

}
