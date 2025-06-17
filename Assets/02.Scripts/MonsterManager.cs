using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public abstract class MonsterManager : MonoBehaviour
{
    [SerializeField] protected float hp = 10f;
    [SerializeField] protected float moveSpeed = 1f;

    // Rigidbody2D rigid;
    SpriteRenderer sRenderer;
    private enum StateType { Left, Stop, Right }
    private StateType stateType;

    public abstract void Init();

    private void Awake()
    {
        // rigid = GetComponent<Rigidbody2D>();

        sRenderer = GetComponent<SpriteRenderer>();
        Init();

    }

    private void Start()
    {
        Invoke("NextMove", 1f);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

        switch (stateType)
        {
            case StateType.Left:
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
                sRenderer.flipX = true;
                break;

            case StateType.Right:
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
                sRenderer.flipX = false;
                break;

            case StateType.Stop:
                // ����
                break;
        }

        // ��迡 ������ ���� �ڵ� ����
        if (transform.position.x > 8f)
            SetStateType(StateType.Left);
        else if (transform.position.x < -8f)
            SetStateType(StateType.Right);
    }

    void SetStateType(StateType state)
    {
        stateType = state;
    }

    void NextMove()
    {
        int rand = Random.Range(-1, 2); // -1, 0, 1
        StateType newState = rand == -1 ? StateType.Left :
                             rand == 0 ? StateType.Stop : StateType.Right;

        SetStateType(newState);

        Invoke("NextMove", 5f);
    }


    private void OnTriggerEnter(Collider other)
    {

    }

    void OnMouseDown()
    {
        Hit(1);
    }

    void Hit(float damage) // ĳ���Ͱ� �����ҽ÷� ���� ����
    {
        hp -= damage;

        if (hp <= 0)
        {
            Destroy(gameObject);
            // ������ ������ ��� �߰�
        }
    }

    void Attack()
    {
        // hp -= player.attack; // �÷��̾ ���� �������� ���
        if (hp <= 0)
        {

        }

    }



}
