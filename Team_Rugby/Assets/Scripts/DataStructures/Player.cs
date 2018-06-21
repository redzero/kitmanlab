

/// <summary>
    /// Represents a collections of items (name, avatar...)
    /// Used in the service Api Json. This is root level of the Json
    /// </summary>
[System.Serializable]
public class Player  {

	// Use this for initialization

    public string name;
    public string avatar_url;
    public string is_injured;
    public string star_rating;
    public string[] positions;
    public string country;
    public string last_played;
}
