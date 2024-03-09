using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;
    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            //There is no KitchenObject
            if (player.HasKitchenObject()) {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {
                //Player not carrying anything
            }
        } else {
            //There is KitchenObject
            if (player.HasKitchenObject()) {
                //Player already carrying
            } else {
                GetKitchenObject().SetKitchenObjectParent(player);
            }

        }
    }
    public override void InteractAlternate(Player player) {
        if (HasKitchenObject()) { 
            //Cut the KitchenObject here
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }   
    }
}
