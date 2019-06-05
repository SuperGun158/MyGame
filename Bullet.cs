using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
	static int sc = 0 ;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "die"){
    Destroy(collision.gameObject);
    Destroy(gameObject);
    sc++;
    ScoreText.text = "Score: "+ sc;
};
	if(sc == 5){
        SceneManager.LoadScene(0);
        sc = 0 ;
    };
  }
}
