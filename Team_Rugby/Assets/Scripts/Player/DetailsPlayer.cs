using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsPlayer : MonoBehaviour {


    public Text textName,country,stars,position;
    public Image avatarImage; 
    public string is_injured;
    public Image loadBar;


    void Start(){

        /// <summary>
        /// validate if is hurt and put it in the power bar 
        /// </summary>
       
        if (is_injured != "true") { loadBar.fillAmount = 1.0f;}
        else{loadBar.fillAmount = 0.5f; this.GetComponent<DraggBtn>().enabled = false;}
       
    }

    /// <summary>
        /// Add avatar picture from url 
        /// </summary>
    public IEnumerator DownloadImage(string url){
        WWW www = new WWW(url);
        yield return www;
        // Checking for a valid response
        if (www.error == null){
            avatarImage.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        }      
    }
	
	// Update is called once per frame
	void Update () {
        


		
	}
}
