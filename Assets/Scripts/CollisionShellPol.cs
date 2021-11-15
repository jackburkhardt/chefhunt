using System;
using UnityEngine;


    public class CollisionShellPol : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("dead");
                GameObject.FindObjectOfType<KitchenManager>().GameOverLose();
            }
        }
    }
