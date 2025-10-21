using UnityEngine;

public class movement : MonoBehaviour
    
{
    [SerializeField, Range(0.005f, 25)] float speed;
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode right = KeyCode.D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            print("Åk upp");
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            print("Åk ner fy fan");
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            print("Åk höger fy fan");
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            print("turn left");
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
    }
}
