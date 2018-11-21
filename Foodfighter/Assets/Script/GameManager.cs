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

    //「そこまで！」の表示オブジェクト
    public GameObject KO_Object;
    //「両者互角！」の表示オブジェクト
    public GameObject DrawGame_Object;


    // Use this for initialization
    void Start()
    {
        if (Instance != null)
            throw new System.Exception(gameObject.name);

        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // ゲームセットになったら呼ばれる！
    public void GameSet( Player winner )
    {
        if (CurrentState == State.GameSet)
            return;

        CurrentState = State.GameSet;

        //ゲームセットの処理を書く⬇️

        switch( winner)
        {
            case Player.Player1:
            case Player.Player2:
                //KO表示を起動する！
                KO_Object.SetActive(true);
                break;

                //引き分け表示を起動する！
            case Player.Void:
            default:
                DrawGame_Object.SetActive(true);
                break;
        }

        Winner = winner;

        //指定秒のあとでKOシーン切り替え処理を呼び出す
        Invoke("ChangeSceneWhenKO", 7.0f );
    }

    //KO時のシーン切り替え
    void ChangeSceneWhenKO()
    {
        //勝者別の処理
        switch (Winner)
        {
            case Player.Player1:
                SceneManager.LoadScene("Food_fighter's_winnori");
                break;
            case Player.Player2:
                SceneManager.LoadScene("Food_fighter's_wingohan");
                break;
            case Player.Void:
                SceneManager.LoadScene("Food_fighter's_wingohan");
                break;
        }
    }
}
