using UnityEngine;
using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UnboundLib.Cards;


[BepInDependency("com.willis.rounds.unbound")]
[BepInDependency("pykess.rounds.plugins.moddingutils")]
[BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")]
[BepInPlugin("TC1", "mod1", "0.0.0")] 
[BepInProcess("Rounds.exe")]
public class mod1 : BaseUnityPlugin
{
    internal static string modInitials = "TC1";
    internal static AssetBundle assets;

    void Awake()
    {
        assets = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("assets", typeof(mod1).Assembly);

        assets.LoadAsset<GameObject>("ModCards").GetComponent<CardHolder>().RegisterCards();
    } 
    void Start()
    {

    }
}
    

