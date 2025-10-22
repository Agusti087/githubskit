using UnityEngine;
using UnityEngine.UIElements;

public class CreateBullet : MonoBehaviour
{
    [SerializeField] KeyCode Shoot = KeyCode.Return;
    [SerializeField] Transform rightPoint, leftPoint;
    public GameObject Bullet;
    [SerializeField, Range(0.005f, 25)] float speed;
    [SerializeField] float Cooldown;
    float Cooldowntime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bullet.transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;


        if (Input.GetKeyDown(Shoot) && Cooldowntime <= 0)
        {
            print("Jag skjuter dig");
            Instantiate(Bullet,rightPoint.position, Quaternion.identity);
            Instantiate(Bullet,leftPoint.position, Quaternion.identity);
            Cooldowntime += Cooldown;

            
        }
        if (Cooldowntime > 0)
        {
            Cooldowntime -= Time.deltaTime;
        }
    }
    
}
