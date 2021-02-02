using UnityEngine;
using UniRx;

public class MVPmodel
{
	public ReactiveProperty<int> hp = new ReactiveProperty<int>(100);

    //public void HpInit()
    //{
    //    hp.Value = 100;
    //}
	public void HpDmg(int dmg)
    {
        hp.Value -= dmg;
        Debug.Log("HP=" +hp.Value);
    }

}
