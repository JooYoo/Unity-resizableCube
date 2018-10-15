using UnityEngine;

public class CamerController : MonoBehaviour
{
    public float speed;

    public bool ActiveForward;
    public bool ActiveBack;
    public bool ActiveLeft;
    public bool ActiveRight;
    public bool ActiveUp;
    public bool ActiveDown;

    void Update()
    {
        if (Input.GetKey(KeyCode.D) && ActiveRight) // right: D
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A) && ActiveLeft) // left: A
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.W) && ActiveForward) // forward: W
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S) && ActiveBack) // back: S
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.E) && ActiveUp) // up: E
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Q) && ActiveDown) // down: Q
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}