using System;
using UnityEngine;


    public class CollisionShell : MonoBehaviour
    {
        public CollisionHandler CollisionHandler;
        private void Awake()
        {
            CollisionHandler = FindObjectOfType<CollisionHandler>();
        }

        private void OnCollisionEnter(Collision other)
        {
            CollisionHandler.RegisterCollision(this.gameObject, other.gameObject, other.gameObject.tag);
        }
    }
    