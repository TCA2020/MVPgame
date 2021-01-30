using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MVPview : MonoBehaviour
{
	[SerializeField] private Text hpText;

	public void SetHp(int hp)
    {
        hpText.text = hp.ToString();
    }


}
