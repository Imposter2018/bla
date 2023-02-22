using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    [Header("VARIABLES")]
    [SerializeField] private float speed = 3f;
    [SerializeField] private float sensitivity = 1f;
    void Update()
    {
        if (Input.GetButton("Horizontal")) Move(transform.right, "Horizontal");
        if (Input.GetButton("Vertical")) Move(transform.forward, "Vertical");
        Rotate();
    }
    private void Move(Vector3 dir, string titleDir)
    {
        dir = dir * Input.GetAxis(titleDir);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime * speed);
    }
    private void Rotate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        mainCam.transform.Rotate(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);
    }
}
