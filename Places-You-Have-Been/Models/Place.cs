using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _city;
    private string _img;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city, string image)
    {
      _city = city;
      _img = image;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity (string newCity)
    {
      _city = newCity;
    }
    public string GetImage()
    {
      return _img;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
        return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
