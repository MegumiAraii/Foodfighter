using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Game manager.とてもえらい。全体の進行管理を行う
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string[] animType;
    Animator animator;

    public enum Player
    {
        Player1,
        Player2,
        Void
    }

    //勝者
    public Player Winner;
    int winnerNumber;

    /// <summary>
    /// ゲームの現在の状態
    /// </summary>
    public enum State
    {
        GameStart,
        Fighting,
        GameSet,
    }

    public State CurrentState = State.Fighting;

    /// <summary>
    /// The Game object.
    /// </summary>
    public GameObject Game_Object;

    //「そこまで！」の表示オブジェクト
    public GameObject KO_Object;
    //「両者互角！」の表示オブジェクト
    public GameObject DrawGame_Object;

    //「ごはんの必殺技」の表示オブジェクト
    public GameObject Cutingohan_Object;
    //「のりの必殺技」の表示オブジェクト
    public GameObject Cutinnori_Object;

    Player1 Player1_Object;
    Player2 Player2_Object;

    public SetSpriteToHP WazaGauge1P;
    public SetSpriteToHP WazaGauge2P;
    public string[] winScene;


    // Use this for initialization
    void Start()
    {
        if (Instance != null)
            throw new System.Exception(gameObject.name);

        Player1_Object = GetComponentInChildren<Player1>();
        Player2_Object = GetComponentInChildren<Player2>();

        Instance = this;

        StartCoroutine( ManageGame());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cutin"))
        {
            Debug.Log("Cutin");
        }
        if (Input.GetButtonDown("Cutin2"))
        {
            Debug.Log("Cutin2");
        }


    }

    /// <summary>
    /// ゲームを管理します
    /// </summary>
    /// <returns>The game.</returns>
    IEnumerator ManageGame()
    {
        // メインプログラム
        while( CurrentState != State.GameSet )
        {
            // 必殺技の判定
            if( Input.GetKeyDown( KeyCode.Return) || Input.GetButtonDown("Cutin") )
            {
                /*if (Input.GetButtonDown("Cutin"))
                {
                }
                    Debug.Log("Cutin");*/
                // ゲージが満タンか
                if( WazaGauge1P.IsSpecialAttackReady )
                {
                    // ゲーム本編の動きを止める
                    // Game_Object.SetActive(false);

                    Player2_Object.pause = true;

                    //　必殺技演出！
                    Cutingohan_Object.SetActive(true);

                    // 必殺技の終了待ち
                    while (Cutingohan_Object.activeSelf)
                        yield return null;

                    //  スペシャルアタックのゲージをリセット
                    WazaGauge1P.resetHP();

                    // ゲーム再開
                    Game_Object.SetActive(true);
                }
            }

            if (Input.GetKeyDown(KeyCode.P) || Input.GetButtonDown("Cutin2"))
            {
                /*if (Input.GetButtonDown("Cutin"))
                {
                }
                    Debug.Log("Cutin");*/
                // ゲージが満タンか
                if (WazaGauge2P.IsSpecialAttackReady)
                {
                    // ゲーム本編の動きを止める
                    // Game_Object.SetActive(false);

                    Player1_Object.pause = true;

                    //　必殺技演出！
                    Cutinnori_Object.SetActive(true);

                    // 必殺技の終了待ち
                    while (Cutingohan_Object.activeSelf)
                        yield return null;

                    //  スペシャルアタックのゲージをリセット
                    WazaGauge2P.resetHP();

                    // ゲーム再開
                    Game_Object.SetActive(true);
                }
            }

            yield return null;
        }

        // 決着したので終了
    }

    // ゲームセットになったら呼ばれる！
    // public void GameSet( Player winner )
    public void GameSet(int playerNumber)
    {
        if (CurrentState == State.GameSet)
            return;

        CurrentState = State.GameSet;

        //ゲームセットの処理を書く⬇️
        switch (playerNumber)
        {
            case 1:
            case 2:
                //KO表示を起動する！
                KO_Object.SetActive(true);
                break;

            //引き分け表示を起動する！
            case 0:
            default:
                DrawGame_Object.SetActive(true);
                break;
        }

        winnerNumber = playerNumber;

        //指定秒のあとでKOシーン切り替え処理を呼び出す
        Invoke("ChangeSceneWhenKO", 7.0f );
    }

    //KO時のシーン切り替え
    void ChangeSceneWhenKO()
    {
        //勝者別の処理
        SceneManager.LoadScene(winScene[winnerNumber]);

        /*
        //勝者別の処理
        switch (winnerNumber)
        {
            case 1:
                SceneManager.LoadScene("Food_fighter's_wingohan");
                break;
            case 2:
                SceneManager.LoadScene("Food_fighter's_winnori");
                break;
            case 0:
                SceneManager.LoadScene("Food_drawgame");
                break;
        }*/
    }
}
