using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public string[] animType;
    Animator animator;
    public GameObject P1HP;
    public GameObject attackEffect;
    public GameObject getEffect;
    public bool pause = false;
    int hp;

    /// <summary>
    /// 操作モード
    /// </summary>
    public enum ControlMode
    {
        Human, // 人間
        AI     // AI
    }

    public ControlMode Mode = ControlMode.AI;

    /// <summary>
    /// 攻撃状態ならtrue
    /// </summary>
    public bool IsAttacking;

    /// <summary>
    /// ダメージ状態ならtrue
    /// </summary>
    public bool IsDamaged;

    /// <summary>
    /// 死んだらtrue
    /// </summary>
    public bool IsDead;

    /// <summary>
    /// 敵
    /// </summary>
    [SerializeField]
    Player1 Enemy;

    //自分のHPバー
    public GameObject hpbar;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

	private void OnEnable()
	{
        StartCoroutine("Attack");
	}

	// Update is called once per frame
	void Update()
    {
        animator.SetBool("damage", IsDamaged);

        //ダメージを受けていたら何もしない
        if (IsDamaged)
            return;

        //死んでたら何もしない
        if (IsDead)
            return;
        if(pause){
            return;
        }

        switch( Mode )
        {
            case ControlMode.Human:
                
                break;

            case ControlMode.AI:
                Vector3 diff = transform.position - Enemy.transform.position;

                if (diff.x > +1)
                    transform.position += Vector3.left * 0.05f;
                else
                if (diff.x < -1)
                    transform.position += Vector3.right * 0.05f;
                break;
        }
    }

    // コルーチン  
    private IEnumerator Attack()
    {
        // コルーチンの処理  
        while (!IsDead)
        {
            float waitTime = Random.Range(1.0f, 2.0f);
            yield return new WaitForSeconds(waitTime);

            int animIndex = Random.Range(0, animType.Length);
            // Debug.Log(animType[animIndex]);

            animator.SetBool(animType[animIndex], true);
        }
    }

    //ダメージを受ける
    public void Damage()
    {
        //  既にダメージを受けていたら何もしない
        if (IsDamaged)
            return;

        //死んでたら何もしない
        if (IsDead)
            return;
        
        // Debug.Log("Player 2 Damaged!");

        IsDamaged = true;
        Debug.Log("StartCoroutine damaged");
        StartCoroutine(damaged());

        P1HP.GetComponent<SetSpriteToHP>().addHP();

        //コピーして表示
        Instantiate(attackEffect, gameObject.transform.position, Quaternion.identity);
    }

    // ダメージを受けたフラグを管理するコルーチン  
    private IEnumerator damaged()
    {
        Debug.Log("damaged started");
        // n秒待機してから、ダメージ状態を解除する
        yield return new WaitForSeconds(1.0f);
        Debug.Log("damaged 1");
        IsDamaged = false;
        Debug.Log("damaged 2");
    }

    //ダメージを受けました
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject != Enemy.gameObject)
            return;

        //ダメージ中は追加ダメージを受けない
        if (IsDamaged)
            return;

        //死んでいたらダメージはない
        if (IsDead)
            return;
        
        //敵が攻撃中ではないなら、ダメージにはならない
        if (!Enemy.IsAttacking)
            return;



        damaged(3);

        if (hp > 0)
        {
            Damage();
        }
        else
        {
            //HPが０以下なので、「そこまで！」
            GameManager.Instance.GameSet(1);
            animator.SetBool("die", true);
        }

    }

    public void damaged(int v)
    {
        var slider = hpbar.GetComponent<Slider>();
        hp = (int)slider.value;
        hp -= v;
        slider.value = hp;
    }
}


// http://developer.wonderpla.net/entry/blog/engineer/Unity_Co-routine/