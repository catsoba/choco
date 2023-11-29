using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EnemyData")]
public class EnemyData : ScriptableObject
{
    public string id;          //登録ID

    public string charName;    //キャラクターの名前

    public float hp;           //体力
    public float atack;     //攻撃力
    public float Cost;      //掛かるコスト
    public float speed;        //素早さ
}