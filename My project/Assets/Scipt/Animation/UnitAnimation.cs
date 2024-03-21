using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    private Animator anim;

    private Unit unit;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>();
    }

    private void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);
        anim.SetBool("IsMoveToBuild", false);
        anim.SetBool("IsBuilding", false);
        anim.SetBool("IsMoveToResource", false);
        anim.SetBool("IsGather", false);
        anim.SetBool("IsDeliverToHQ", false);
        anim.SetBool("IsStoreAtHQ", false);
        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case UnitState.Move:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.MoveToEnemy:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.AttackUnit:
                anim.SetBool("IsAttack", true);
                break;
            case UnitState.MoveToBuild:
                anim.SetBool("IsMoveToBuild", true);
                break;
            case UnitState.BuildProgress:
                anim.SetBool("IsBuilding", true);
                break;
            case UnitState.MoveToResource:
                anim.SetBool("IsMoveToResource", true);
                break;
            case UnitState.DeliverToHQ:
                anim.SetBool("IsDeliverToHQ", true);
                break;
            case UnitState.Gather:
                anim.SetBool("IsGather", true);
                break;
            case UnitState.StoreAtHQ:
                anim.SetBool("IsStoreAtHQ", true);
                break;
            case UnitState.Die:
                anim.SetBool("IsDeath", true);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnimation(unit);
    }
}
