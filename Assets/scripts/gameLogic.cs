using UnityEngine;
using UnityEngine.UI;


public class gameLogic : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mine;
    [SerializeField] private float mSpeed = 15.0f;
    [SerializeField] private MVPview view;
    [SerializeField] private GameObject player;
    

    private MVPmodel subm = new MVPmodel();        
    private Vector3 minePos = new Vector3(8, 1, 0);   

    void Start()
    {
       
    }

    
    void FixedUpdate()
    {
        mine.velocity = Vector2.left * mSpeed;

        if (mine.transform.position.x < -10) //regenerate mine
        {
            minePos = new Vector3(8, Random.Range(-4,6), 0);
            mine.transform.position = minePos;
        }

        if (subm.hp.Value <= 0)  //gameover
        {
            player.SetActive(false);            
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Player collided with " + other.name);        
        subm.HpDmg(25);
        view.SetHp(subm.hp.Value);
    }
}
