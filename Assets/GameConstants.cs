using UnityEngine;
public class GameConstants {

    /******* Scoring Variables *****/
    public const int maxScore = 10;
    public static int playerAScore;
    public static int playerBScore;
    public static int hitCount;

    public enum AI_Difficulty {Easy,Medium, Hard};

    public static string choosen_Difficulty;
    public static string steering = "Button";

    public static int characterChoosen;

    public static bool winnerFound = false;
    public static bool isCharacter3Unlocked;
    public static bool isCharacter4Unlocked;

    public static string mode = "Single";
    public static int highScore;

    /***** Player Pref variables ****/
    
    public static int winCount;
    public static int lossCount;

    /**** Game related constants ****/
    public static Vector3 playSideBallPosition = new Vector3(-4.2f,3f,0);
    public static Vector3 playerPosition = new Vector3(-4.2f, 0.5f, 0);


    public static bool changesMade = true;

    public static int rangeOfChangesMade = 500;

}
