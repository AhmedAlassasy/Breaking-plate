using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class PlateDestroyer : MonoBehaviour
{
    [SerializeField]
    GameObject destroyedPlatePrefab;
    [SerializeField]
    int desructionForce;

    Rigidbody myRB;

    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
           myRB.useGravity = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ground")){
            GameObject destroyedPlate = Instantiate(destroyedPlatePrefab, this.transform.position,Quaternion.identity);
            Rigidbody[] bodies; bodies = destroyedPlate.GetComponentsInChildren<Rigidbody>();
           for(int i = 0;i < bodies.Length; i++)
           {
                bodies[i].AddExplosionForce(desructionForce, transform.position, 5f);
           }                        
            this.gameObject.SetActive(false);
        }
    }
}
