using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Vector3 movementDirection = new Vector3 (0,0,0);
    public float speedBullet = 10.0f;
    public float damage = 100.0f;

    void Start()
    {
        Debug.Log("Se crea una bala del cañon");
    }

    void Update()
    {
        shoot(movementDirection, speedBullet);
    }

    private void shoot(Vector3 direction, float speed){
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
