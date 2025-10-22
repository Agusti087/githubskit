using Unity.VisualScripting;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField, Range(0.005f, 25)] float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;

        if (transform.position.y > 13  || transform.position.y < -13)
        {
            Destroy(gameObject);
        }
    }
}
