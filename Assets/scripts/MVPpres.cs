using UnityEngine;
using UniRx;

public class MVPpres
{
    public MVPpres(MVPmodel m1, MVPview v1)
    {
        m1.hp
            .Subscribe(hp => v1.SetHp(hp));
        Debug.Log("HP="+m1.hp);
    }
}
