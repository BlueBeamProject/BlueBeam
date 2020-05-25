using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public GameObject jumptime,
        doslide,
        usedash,
        deathtime,
        killennemies,
        coinspick,
        shielddestroy,
        levelfinish,
        sologame,
        multigame,
        bosskill;
    // Start is called before the first frame update
    void Start()
    {
        LoadStat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadStat()
    {
        jumptime.GetComponent<Text>().text = jumptime.GetComponent<Text>().text + SaveData.ReadValueInt("JumpTime");
        doslide.GetComponent<Text>().text = doslide.GetComponent<Text>().text + SaveData.ReadValueInt("DoSlide");
        usedash.GetComponent<Text>().text = usedash.GetComponent<Text>().text + SaveData.ReadValueInt("UseDash");
        deathtime.GetComponent<Text>().text = deathtime.GetComponent<Text>().text + SaveData.ReadValueInt("DeathTime");
        killennemies.GetComponent<Text>().text = killennemies.GetComponent<Text>().text + SaveData.ReadValueInt("KillEnnemie");
        
        coinspick.GetComponent<Text>().text = coinspick.GetComponent<Text>().text + SaveData.ReadValueInt("CoinsPick");
        shielddestroy.GetComponent<Text>().text = shielddestroy.GetComponent<Text>().text + SaveData.ReadValueInt("ShieldDestroy");
        levelfinish.GetComponent<Text>().text = levelfinish.GetComponent<Text>().text + SaveData.ReadValueInt("LevelFinish");
        sologame.GetComponent<Text>().text = sologame.GetComponent<Text>().text + SaveData.ReadValueInt("SoloGame");
        multigame.GetComponent<Text>().text = multigame.GetComponent<Text>().text + SaveData.ReadValueInt("MultiGame");
        
        bosskill.GetComponent<Text>().text = bosskill.GetComponent<Text>().text + SaveData.ReadValueInt("BossKill");
    }
}
