using UnityEngine;

public class playerCollisionWithObstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Choco contra algo");
        }
    }
}
