using System.Collections;
using System.Collections.Generic;
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
    public Button startGame;
    public Button restartGame;
    public Image blackground;
    
    // Start is called before the first frame update
    void Awake()
    {
        DirectionMappings = new Dictionary<GameState, string>
        {
            {GameState.GetFlour, "Find the box of flour."},
            {GameState.DepositFlour, "Put the flour in the bowl."},
            {GameState.GetButter, "Find the stick of butter."},
            {GameState.DepositButter, "Put the butter in the bowl."},
            {GameState.GetSugar, "Find the box of sugar."},
            {GameState.DepositSugar, "Put the sugar in the bowl."},
            {GameState.GetMilk, "Find the carton of milk."},
            {GameState.DepositMilk, "Put the milk in the bowl."},
            {GameState.GetSalt, "Find the salt."},
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
}
