using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
