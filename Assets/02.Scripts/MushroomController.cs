using JetBrains.Annotations;
using UnityEngine;

public class MushroomController : MonsterManager
{
    public override void Init()
    {
        hp = 5f;
        moveSpeed = 3f;
    }

    /*
    public int atk; // ���ݷ�
    public float attackDelay; // �ٷ� ����x ������ �� ����

    public float inter_MoveWaitTime; // �̵��ϱ� �� ���ð�
    private float current_interMWT;

    private Vector3 PlayerPos; // �÷��̾��� ��ǥ��

    private int randomInt; // ���� ���� ������
    private string direction;    

    private void RandomDirection()
   {
       Vector3.Set(0, 0, );
       randomInt = Random.Range(0, 2);
       switch (randomInt)
       {
           case 0:
               Vector3.x = -1f;

           case 1:
               Vector3.x = 0f;

           case 2:
               Vector3.x = 1f;

       } 
   }
    */
}
