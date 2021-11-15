using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenManager : MonoBehaviour
{
    public GameState currentState;
    public UIManager UIManager;
    public AudioHandler AudioHandler;
    public ChasePlayer Pol;

    public int ovenTimer = 30;
    public bool gameActive;
    public GameObject cake;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        currentState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProgressGame()
    {
        if (currentState + 1 != GameState.PickUpCake && currentState + 1 != GameState.WaitForOven)
        {
            AudioHandler.Play("advance_objective");
            currentState += 1;
            Pol.speed += 0.3f;
            //Debug.Log("pol speed: " + Pol.speed);
            StartCoroutine(UIManager.UpdateObjectiveUI(currentState));
        }
        else if (currentState + 1 == GameState.WaitForOven)
        {
            currentState += 1;
            //Debug.Log("pol speed: " + Pol.speed);
            AudioHandler.Play("advance_objective");
            StartCoroutine(UIManager.UpdateObjectiveUI(currentState));
            StartCoroutine(WaitForOven());
        }
        else
        {
            GameOverWin();
        }
        
    }

    public void GameOverWin()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Pol.ToggleSound(false);
        AudioHandler.Play("win");
        UIManager.DisplayWin();
    }

    public void GameOverLose()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Pol.ToggleSound(false);
        UIManager.DisplayLose();
        AudioHandler.Play("lose");
    }

    public void StartGame()
    {
        gameActive = true;
        Pol.ToggleSound(true);
        Time.timeScale = 1;
        Cursor.visible = false;
        
        // PATCHWORK FIX FOR ODD MOVEMENT PROBLEMS
        GameObject player = GameObject.Find("Player");
        player.GetComponent<Rigidbody>().mass = 5;
        player.GetComponent<Rigidbody>().drag = 7;
        player.GetComponent<PlayerControls>().MovementScale = 2;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        var thisScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(thisScene);
    }

    IEnumerator WaitForOven()
    {
        //Debug.Log("oven started");
        yield return new WaitForSeconds(ovenTimer);
        //Debug.Log("oven done");
        currentState += 1;
        cake.SetActive(true);
        AudioHandler.Play("advance_objective");
        StartCoroutine(UIManager.UpdateObjectiveUI(currentState));
    }
}
