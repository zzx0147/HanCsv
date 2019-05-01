using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item {

    //Csc파일 상에서의 인덱스
    public enum ArmorAttribute {
        Image_File = 1,
        ID = 2,
        Name = 3,
        Require_Level = 4,
        S_HP = 5,
        S_Def = 6,
        S_Str = 7,
        S_Dex = 8,
        S_Will = 9
    }

    //생성자
    public Armor(int m_ID, string m_Name, int m_Require_Level, string imagePath,int m_S_HP, int m_S_Def, int m_S_Will, int m_S_Str, int m_S_Dex)
        :base(m_ID,m_Name,m_Require_Level,imagePath)
    {
        M_S_HP = m_S_HP;
        M_S_Def = m_S_Def;
        M_S_Will = m_S_Will;
        M_S_Str = m_S_Str;
        M_S_Dex = m_S_Dex;
    }

    public int M_S_HP { get; set; }     //갑옷 HP
    public int M_S_Def { get; set; }    //갑옷 방어력
    public int M_S_Will { get; set; }   //갑옷 강인함
    public int M_S_Str { get; set; }    //갑옷 힘
    public int M_S_Dex { get; set; }    //갑옷 민첩
}
