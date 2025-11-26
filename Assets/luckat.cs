using UnityEngine;

public class luckat : MonoBehaviour
{
    GameObject farfar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        farfar = FindObjectOfType<PlayerMovement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = farfar.transform.position - transform.position;
        float angel = Vector2.SignedAngle(new Vector2(0, 1), v);
        transform.rotation = Quaternion.Euler(0, 0, angel);
    }
}
