using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Dictionary<GameState, string> ObjectMappings = new Dictionary<GameState, string>();
    public KitchenManager KitchenManager;
    public Dictionary<string, GameObject> InactiveObjects = new Dictionary<string, GameObject>();

    void Awake()
    {
        ObjectMappings = new Dictionary<GameState, string>
        {
            {GameState.GetFlour, "flour"},
            {GameState.DepositFlour, "bowl"},
            {GameState.GetButter, "butter"},
            {GameState.DepositButter, "bowl"},
            {GameState.GetSugar, "sugar"},
            {GameState.DepositSugar, "bowl"},
            {GameState.GetMilk, "milk"},
            {GameState.DepositMilk, "bowl"},
            {GameState.GetSalt, "salt"},
            {GameState.DepositSalt, "bowl"},
            {GameState.GetEggs1, "egg"},
            {GameState.GetEggs2, "egg"},
            {GameState.GetEggs3, "egg"},
            {GameState.DepositEggs, "bowl"},
            {GameState.InsertMixer, "mixer"},
            {GameState.GetPan, "pan"},
            {GameState.DepositPan, "mixer"},
            {GameState.InsertOven, "oven"},
            {GameState.WaitForOven, "null"},
            {GameState.PickUpCake, "cake"}
        };
    }

    public void RegisterCollision(GameObject object1, GameObject object2, string tag)
    {
        if (ObjectMappings[KitchenManager.currentState] == tag)
        {
            if (CheckIfPickedUp(object2, tag))
            {
                //InactiveObjects.Add(object2.tag, object2);
                object2.SetActive(false);
            }

            if (tag == "cake")
            {
                KitchenManager.GameOverWin();
            }

            KitchenManager.ProgressGame();
        }
    }

    public bool CheckIfPickedUp(GameObject gameObject, string tag)
    {
        GameState state = KitchenManager.currentState;

        if (tag == "egg"|| tag == "flour" || tag == "sugar" ||
            tag == "milk" || tag == "butter" || tag == "salt" || tag == "bowl" && state == GameState.InsertMixer)
        {
            return true;
        }

        return false;
    }
    
}
