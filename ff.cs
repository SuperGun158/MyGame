using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ff : MonoBehaviour
{
	public Transform player;
	public NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.transform.position);
    }
      void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.tag == "Bullet"){
    Destroy(collision.gameObject);
    Destroy(gameObject);
};

}
}
