using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class DeathPlaneController : MonoBehaviour
{
    public Transform currentCheckpoint;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            var player = collision.gameObject.GetComponent<PlayerBehaviour>();
            player.life.LoseLife();
            player.health.ResetHealth();
            if(player.life.value > 0)
            {
                Respawn(collision.gameObject);
            }
        }
    }
    public void Respawn(GameObject go)
    {
        go.transform.position = currentCheckpoint.position;
    }
}
