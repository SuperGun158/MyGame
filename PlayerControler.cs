using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{	
	public GameObject bullet;
	GameObject bulletClone;
	Rigidbody rbClone; 
	Rigidbody rb ;
    public int hp = 10 ;
    public Text HPtext;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
    	rb.AddForce(transform.forward * moveVertical * 80f);
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f,moveHorizontal * 10f,0f);
         if(Input.GetKey("space")){
            bulletClone = Instantiate(bullet,new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            rbClone = bulletClone.GetComponent<Rigidbody>();
            rbClone.AddForce(transform.forward * 600f);
        };
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "die"){
        hp--;
        HPtext.text = "Hp: "+ hp;
    };
    if(hp == 0){
        SceneManager.LoadScene(1);
        hp = 10 ;
    };
}
}