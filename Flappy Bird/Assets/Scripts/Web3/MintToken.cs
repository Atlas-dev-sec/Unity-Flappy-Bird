using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MintToken : MonoBehaviour
{
    public TextMeshProUGUI buttonTextClaim;
    
    public void MintingToken()
    {
        GameManager.newRecord = false;
        Application.ExternalCall("claimTokens");
        Debug.Log("Token Was claim");
    }
}
