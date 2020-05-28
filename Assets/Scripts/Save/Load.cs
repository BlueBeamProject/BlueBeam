using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
        //SaveData.WriteValueInt("Shield",0);
        //SaveData.WriteValueInt("Money",400);
        
        
        //Pour initialiser un nouvelle donné sauvergardé recopier les lignes en dessous
        //et mettez une valeur par défaut si la "key" n'existe

        //Monney Load
        if (!PlayerPrefs.HasKey("Money"))
        {
            PlayerPrefs.SetInt("Money", 0);
        }

        //Inventaire Item
        if (!PlayerPrefs.HasKey("Shield"))
        {
            PlayerPrefs.SetInt("Shield", 0);
        }
        
        //GameInfo
        if (!PlayerPrefs.HasKey("PlayerInGame"))
        {
            PlayerPrefs.SetInt("PlayerInGame", 1);
        }
        
        if (!PlayerPrefs.HasKey("PlayerInGameMemorie"))
        {
            PlayerPrefs.SetInt("PlayerInGameMemorie", 1);
        }
        
        if (!PlayerPrefs.HasKey("GameGO"))
        {
            PlayerPrefs.SetInt("GameGO", 0);
        }

        PlayerPrefs.SetInt("PlayerShield", 0);
        

        //Controlle default
        if (!PlayerPrefs.HasKey("JumpP1"))
        {
            PlayerPrefs.SetInt("JumpP1", 32);//space
        }

        if (!PlayerPrefs.HasKey("SlideP1"))
        {
            PlayerPrefs.SetInt("SlideP1", 115);//s
        }

        if (!PlayerPrefs.HasKey("AttackP1"))
        {
            PlayerPrefs.SetInt("AttackP1", 100);//d
        }

        if (!PlayerPrefs.HasKey("DashP1"))
        {
            PlayerPrefs.SetInt("DashP1", 102);//f
        }
        
        if (!PlayerPrefs.HasKey("JumpP2"))
        {
            PlayerPrefs.SetInt("JumpP2", 273);//up arrow
        }

        if (!PlayerPrefs.HasKey("SlideP2"))
        {
            PlayerPrefs.SetInt("SlideP2", 274);//down arrow
        }

        if (!PlayerPrefs.HasKey("AttackP2"))
        {
            PlayerPrefs.SetInt("AttackP2", 275);//left arrow
        }

        if (!PlayerPrefs.HasKey("DashP2"))
        {
            PlayerPrefs.SetInt("DashP2", 276);//right arrow
        }

        if (!PlayerPrefs.HasKey("JumpP3"))
        {
            PlayerPrefs.SetInt("JumpP3", 13);//return
        }

        if (!PlayerPrefs.HasKey("SlideP3"))
        {
            PlayerPrefs.SetInt("SlideP3", 106);//j
        }

        if (!PlayerPrefs.HasKey("AttackP3"))
        {
            PlayerPrefs.SetInt("AttackP3", 108);//l
        }

        if (!PlayerPrefs.HasKey("DashP3"))
        {
            PlayerPrefs.SetInt("DashP3", 109);//m
        }
        
        if (!PlayerPrefs.HasKey("JumpP4"))
        {
            PlayerPrefs.SetInt("JumpP4", 116);//t
        }

        if (!PlayerPrefs.HasKey("SlideP4"))
        {
            PlayerPrefs.SetInt("SlideP4", 97);//a
        }

        if (!PlayerPrefs.HasKey("AttackP4"))
        {
            PlayerPrefs.SetInt("AttackP4", 122);//z
        }

        if (!PlayerPrefs.HasKey("DashP4"))
        {
            PlayerPrefs.SetInt("DashP4", 101);//e
        }
        
        //Checkpoint zone
        if (!PlayerPrefs.HasKey("Checkpoint1"))
        {
            PlayerPrefs.SetInt("Checkpoint1", 0);//checkpoint lvl 1
        }
        
        
        //Avancement
        if (!PlayerPrefs.HasKey("Level1"))
        {
            PlayerPrefs.SetInt("Level1", 0);
        }
        if (!PlayerPrefs.HasKey("Level2"))
        {
            PlayerPrefs.SetInt("Level2", 0);
        }
        if (!PlayerPrefs.HasKey("Level3"))
        {
            PlayerPrefs.SetInt("Level3", 0);
        }
        if (!PlayerPrefs.HasKey("Level4"))
        {
            PlayerPrefs.SetInt("Level4", 0);
        }
        if (!PlayerPrefs.HasKey("Level5"))
        {
            PlayerPrefs.SetInt("Level5", 0);
        }
        
        
        //Statisque
        if (!PlayerPrefs.HasKey("JumpTime"))
        {
            PlayerPrefs.SetInt("JumpTime", 0);
        }
        
        if (!PlayerPrefs.HasKey("DoSlide"))
        {
            PlayerPrefs.SetInt("DoSlide", 0);
        }
        
        if (!PlayerPrefs.HasKey("KillEnnemie"))
        {
            PlayerPrefs.SetInt("KillEnnemie", 0);
        }
        
        if (!PlayerPrefs.HasKey("CoinsPick"))
        {
            PlayerPrefs.SetInt("CoinsPick", 0);
        }
        
        if (!PlayerPrefs.HasKey("UseDash"))
        {
            PlayerPrefs.SetInt("UseDash", 0);
        }
        
        if (!PlayerPrefs.HasKey("ShieldDestroy"))
        {
            PlayerPrefs.SetInt("ShieldDestroy", 0);
        }
        
        if (!PlayerPrefs.HasKey("LevelFinish"))
        {
            PlayerPrefs.SetInt("LevelFinish", 0);
        }
        
        if (!PlayerPrefs.HasKey("DeathTime"))
        {
            PlayerPrefs.SetInt("DeathTime", 0);
        }
        
        if (!PlayerPrefs.HasKey("SoloGame"))
        {
            PlayerPrefs.SetInt("SoloGame", 0);
        }
        
        if (!PlayerPrefs.HasKey("MultiGame"))
        {
            PlayerPrefs.SetInt("MultiGame", 0);
        }
        
        if (!PlayerPrefs.HasKey("BossKill"))
        {
            PlayerPrefs.SetInt("BossKill", 0);
        }
        
        


        PlayerController.ReloadControl();
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
