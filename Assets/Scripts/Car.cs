using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float SteerSpeed = 0.5f;
    [SerializeField] private float MoveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float SteerAmount = Input.GetAxis("Horizontal");
        float DriveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -SteerAmount * SteerSpeed);
        transform.Translate(0, DriveAmount * MoveSpeed, 0);
    }
}
