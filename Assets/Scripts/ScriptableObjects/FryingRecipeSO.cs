using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class FryingRecipeSO : ScriptableObject
{
    public float fryingTimerMax;
    public KitchenObjectSO input;
    public KitchenObjectSO output;
}
