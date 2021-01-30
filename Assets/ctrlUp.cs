using UnityEngine;
using UnityEngine.UI;

public class ctrlUp : MonoBehaviour
{
    [SerializeField] private Button bUp;
    [SerializeField] private GameObject pl;
    [SerializeField] private float speed = 0.5f;

    Vector3 dir = new Vector3();

    void Start()
    {
        bUp.onClick.AddListener(() => GoUp());
    }

    public void GoUp()
    {
        if (pl.transform.position.y < 6.0f) {         
            dir.y += speed;
            pl.transform.position += dir;
            dir.y -= speed;
        }   
    }
  
}
