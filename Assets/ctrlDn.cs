using UnityEngine;
using UnityEngine.UI;

public class ctrlDn : MonoBehaviour
{
    [SerializeField] private Button bDn;
    [SerializeField] private GameObject pl;
    [SerializeField] private float speed = 0.5f;

    Vector3 dir = new Vector3();

    void Start()
    {
        bDn.onClick.AddListener(() => GoDn());
    }

    public void GoDn()
    {
        if (pl.transform.position.y > -4.0f)
        {
            dir.y -= speed;
            pl.transform.position += dir;
            dir.y += speed;
        }
    }

}
