using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorTrigger : MonoBehaviour
{
    public GameObject trapdoor;
    public ParticleSystem trapdoorDust;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        //turns on physics for the trap door
        Destroy(trapdoor);
        trapdoorDust.Play();
    }
}
