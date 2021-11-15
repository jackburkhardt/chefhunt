using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;
    public KitchenManager KitchenManager;
    public Animator Animator;
    public AudioSource heartbeat;
    public AudioHandler AudioHandler;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        //Animator.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!KitchenManager.gameActive) return;
        
        transform.LookAt(player);
        var newPos = transform.position;
        newPos += transform.forward * speed * Time.fixedDeltaTime;
        newPos = new Vector3(newPos.x, 0.25f, newPos.z);
        transform.position = newPos;
    }

    public void ToggleSound(bool val)
    {
        if (val) { heartbeat.Play(); } else { heartbeat.Stop(); }
    }

    public IEnumerator BeginFrenzy(int time)
    {
        //Debug.Log("frenzy started for " + time + " seconds");
        AudioHandler.Play("frenzy_warning");
        speed += 1f;
        Animator.speed += 0.3f;
        StartCoroutine(KitchenManager.UIManager.FlashFrenzyMessage(time));
        yield return new WaitForSeconds(time);
        speed -= 1f;
        Animator.speed -= 0.3f;
    }
    
}
