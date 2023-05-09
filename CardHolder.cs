using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BepInEx;
using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UnboundLib.Cards;

public class CardHolder : MonoBehaviour
{
    public List<GameObject> Cards;
    public List<GameObject> HiddenCards;

    internal void RegisterCards()
    {
        foreach (var Card in Cards)
        {
            CustomCard.RegisterUnityCard(Card, mod1.modInitials, Card.GetComponent<CardInfo>().cardName, true, null);
        }
        foreach (var Card in HiddenCards)
        {
            CustomCard.RegisterUnityCard(Card, mod1.modInitials, Card.GetComponent<CardInfo>().cardName, false, null);
            ModdingUtils.Utils.Cards.instance.AddHiddenCard(Card.GetComponent<CardInfo>());
        }
    }
}
