/*
Johnny Flores red.sys@live.com.mx
*/

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


/// <summary>
/// get the json and create the player
/// </summary>
public class ServiceApi : MonoBehaviour{

    public Transform playerPrefap,content;
    Player[] player;

    // Use this for initialization
    void Start() {

        LoadAPI();
    }

    public void LoadAPI(){

        StartCoroutine(CoroutineAPI());

    }

    /// <summary>
    /// Helper method to verify if we have internet connection
    /// </summary>

    private IEnumerator CoroutineAPI(){

        WWW www = new WWW(API.localURL+"/Json/team.json");

        yield return www;
        // Checking for a valid response
        if (www.error == null){
            //Debug.Log(www.text);
            player = JsonHelper.FromJson<Player>(www.text);
            InstantiateBtns();
        }
        else{
            Debug.Log("ERROR: " + www.error);
        }
    }

    private void InstantiateBtns(){


        /// <summary>
        /// Add buttons and add to the content Panel
        /// </summary>
        //		msjText.text = "Result:";
        for (int i = 0; i <player.Length; i++){            
           // Debug.Log(player[i].name);
            Transform newPlayer = Instantiate(playerPrefap, new Vector3(0, 0, 0), Quaternion.identity) as Transform;
            newPlayer.transform.SetParent(content.transform);
            newPlayer.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            var detailsPlayer = newPlayer.GetComponent<DetailsPlayer>();

            detailsPlayer.textName.text = player[i].name;
            detailsPlayer.stars.text = player[i].star_rating;
            StartCoroutine(detailsPlayer.DownloadImage( player[i].avatar_url));
            detailsPlayer.is_injured = player[i].is_injured;
            detailsPlayer.country.text = player[i].country;

            for (int j = 0; j < player[i].positions.Length; j++) {
                detailsPlayer.position.text += player[i].positions[j]+" ";
            }

        }

    }
}
