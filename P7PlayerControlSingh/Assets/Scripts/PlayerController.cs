using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'11 move the vehical forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
