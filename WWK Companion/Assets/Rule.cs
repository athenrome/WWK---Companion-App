using UnityEngine;
using System.Collections;

public class Rule : MonoBehaviour {

    public string name;
    public string text;
    public RuleType type;

	public Rule(string _name, string _text, RuleType _rule)
    {
        name = _name;
        text = _text;
        type = _rule;
    }
}

public enum RuleType
{
    Setup,
    Card,
    Coins,
    Map,
    Tile,
}
