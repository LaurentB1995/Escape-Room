using UnityEngine;

public class ObjectPuller : MonoBehaviour
{

    public float pullRadius = 2;
    public float pullForce = 1;

    public void FixedUpdate()
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, pullRadius))
        {
            // calculate direction from target to me
            Vector3 forceDirection = transform.position - collider.transform.position;
            if (collider.gameObject.tag == "Key")
            {
                // apply force on target towards me
                collider.GetComponent<Rigidbody>().AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);
                //Debug.Log("Found a key and moving it to me");
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FixedUpdate();
    }
}
