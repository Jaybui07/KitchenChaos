using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO platKitchenObjectSO;

    private float spawnPlateTimer;
    private float maxPlateSpawnTime =4f;
    private int platesSpawnedAmount;
    private int platesSpawnedAmountMax = 4;



    private void Update() {
        spawnPlateTimer += Time.deltaTime;
        if (spawnPlateTimer > maxPlateSpawnTime) {
            spawnPlateTimer = 0f;

            if (platesSpawnedAmount < platesSpawnedAmountMax) {
                platesSpawnedAmount++;
            }
        }
    }

}
