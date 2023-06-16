using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public SimpleTouchController stc;
    
    public float speed = 0.02f;
    
    void Update()
    {
        player.transform.position += new Vector3(stc.GetTouchPosition.x * speed, 0, 0.01f);
    }
}
