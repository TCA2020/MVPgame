using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MVPview : MonoBehaviour
{
	[SerializeField] private Text hpText;
    [SerializeField] private Text goText;
    [SerializeField] private GameObject player;

    void Update()
    {
        if (!player.active) {
            goText.transform.Translate(0, -1, 0); 
        }
    }


	public void SetHp(int hp)
    {
        hpText.text = "HP = "+hp.ToString();
    }

}
