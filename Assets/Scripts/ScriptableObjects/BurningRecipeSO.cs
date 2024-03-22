using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class BurningRecipeSO : ScriptableObject {
    public float burningTimerMax;
    public KitchenObjectSO input;
    public KitchenObjectSO output;
}
