using Microsoft.AspNetCore.Mvc;

namespace Template.Models
{
  public class Parcel
  {
    public string Length { get; set; }
    public string Width { get; set; }
    public string Width { get; set; }

    public Parcel(string test1, string test2)
    {
        Test1 = test1;
        Test2 = test2;
    }
    //Here we have the constructors that will be passed into our route then to our main page
  }
}