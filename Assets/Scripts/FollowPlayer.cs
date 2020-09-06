using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform playerTransform;
    public Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
