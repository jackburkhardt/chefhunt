using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Dictionary<GameState, string> DirectionMappings = new Dictionary<GameState, string>();
    public Canvas UICanvas;
    public KitchenManager KitchenManager;

    public Text winText;
    public Text loseText;
    public Text startText;
    public Text objLabelText;
    public Text objectiveText;
    public Text frenzyText;
    public Button startGame;
    public Button restartGame;
    public Image blackground;
    
    // Start is called before the first frame update
    void Awake()
    {
        DirectionMappings = new Dictionary<GameState, string>
        {
            {GameState.GetFlour, "Find the box of flour."},
            {GameState.DepositFlour, "Bring the flour to the bowl."},
            {GameState.GetButter, "Find the stick of butter."},
            {GameState.DepositButter, "Bring the butter to the bowl."},
            {GameState.GetSugar, "Find the box of sugar."},
            {GameState.DepositSugar, "Bring the sugar to the bowl."},
            {GameState.GetMilk, "Find the carton of milk."},
            {GameState.DepositMilk, "Bring the milk to the bowl."},
            {GameState.GetSalt, "Find the salt shaker."},
            {GameState.DepositSalt, "You've probably figured out what to do by now."},
            {GameState.GetEggs1, "Find eggs. (0/3)"},
            {GameState.GetEggs2, "Find eggs. (1/3)"},
            {GameState.GetEggs3, "Find eggs. (2/3)"},
            {GameState.DepositEggs, "Deposit the eggs in the bowl. (3/3)"},
            {GameState.InsertMixer, "Bring the bowl to the mixer machine."},
            {GameState.GetPan, "Find a round baking pan."},
            {GameState.DepositPan, "Bring the pan to the mixer."},
            {GameState.InsertOven, "Put the pan in the oven."},
            {GameState.WaitForOven, "Now wait. And survive. (30s)"},
            {GameState.PickUpCake, "GRAB THE CAKE!"}
        };
    }
    

    public void StartGame()
    {
        startText.enabled = false;
        blackground.enabled = false;
        ToggleButton(startGame, false);
        KitchenManager.StartGame();
        objLabelText.enabled = true;
        objectiveText.enabled = true;
        objectiveText.text = DirectionMappings[0];
        
    }

    // Update is called once per frame
    public void DisplayWin()
    {
        objectiveText.enabled = false;
        objLabelText.enabled = false;
        winText.enabled = true;
        blackground.enabled = true;
        ToggleButton(restartGame, true);
    }

    public void DisplayLose()
    {
        objectiveText.enabled = false;
        objLabelText.enabled = false;
        loseText.enabled = true;
        blackground.enabled = true;
        ToggleButton(restartGame, true);
    }

    public IEnumerator UpdateObjectiveUI(GameState state)
    {
        //objectiveText.color = new Color32(73, 128, 25);
        objectiveText.color = Color.green;
        yield return new WaitForSeconds(3);
        objectiveText.text = DirectionMappings[state];
        objectiveText.color = Color.white;
    }

    void ToggleButton(Button button, bool active)
    {
        button.enabled = active;
        button.image.enabled = active;
        button.GetComponentInChildren<Text>().enabled = active;
    }

    public IEnumerator FlashFrenzyMessage(int time)
    {
        float elapsed = 0;

        while (elapsed <= time)
        {
            frenzyText.enabled = !frenzyText.enabled;
            yield return new WaitForSeconds(0.7f);
            elapsed += 0.7f;
        }

        frenzyText.enabled = false;
    }
}
