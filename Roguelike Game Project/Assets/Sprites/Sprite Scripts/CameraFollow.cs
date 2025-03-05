using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player sprite
    public float FollowSpeed = 2f; // Adjust for smoothness
    public float yOffset=1f; // Optional offset

    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x,target.position.y+yOffset,-10f);
        transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
    }
}
