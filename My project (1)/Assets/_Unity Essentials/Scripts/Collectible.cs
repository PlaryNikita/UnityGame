using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float floatHeight = 0.1f;
    public float rotateSpeedZ = 0.1f;
    public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Mathf.Sin(Time.time * floatSpeed) * floatHeight * Time.deltaTime, 0);
        transform.Rotate(0, 0, rotateSpeedZ);
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            //Destroy the collectible
            Destroy(gameObject);

            //Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        
    }

}
