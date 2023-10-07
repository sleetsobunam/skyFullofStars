using Unity.VisualScripting;
using UnityEngine;

public class CameraInput : MonoBehaviour
{
    [SerializeField] public float horizontalSpeed = 2.0f;
    [SerializeField] public float verticalSpeed = 2.0f;
    private float yaw;
    private float pitch;
    [SerializeField] Component POV;

    void Start()
    {
        POV.transform.position = new Vector3(0, 2000, -3000);
    }
    void Update()
    {
        float x = POV.transform.position.x;
        float y = POV.transform.position.y;
        float z = POV.transform.position.z;

        
        
        if (Input.GetKey("w"))
        {
            POV.transform.Translate(0,0,horizontalSpeed);
        }
        if (Input.GetKey("s"))
        {
            POV.transform.Translate(0,0,-1 * horizontalSpeed);
        }
        if (Input.GetKey("d"))
        {
            POV.transform.Translate(horizontalSpeed,0,0);
        }
        if (Input.GetKey("a"))
        {
            POV.transform.Translate(-1 * horizontalSpeed,0,0);
        }
        if (Input.GetKey("up"))
        {
            POV.transform.Translate(0,verticalSpeed,0);
        }

        if (Input.GetKey("down"))
        {
            POV.transform.Translate(0,-1 * verticalSpeed,0);
        }

        if (Input.GetKey("left cmd"))
        {
            yaw += 10f * Input.GetAxis("Mouse X");
            pitch -= 10f * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}