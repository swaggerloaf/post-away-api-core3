using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PostAway.API.Entities
{
  public class User
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(50)]
    public string Username { get; set; }
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }
    public Address Address { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }
    public Company Company { get; set; }

    public ICollection<Post> Courses { get; set; }
        = new List<Post>();
  }

  public class Address
  {
    public string Street { get; set; }

    public string Suite { get; set; }

    public string City { get; set; }

    public string Zipcode { get; set; }

    public Geo Geo { get; set; }
  }

  public class Geo
  {
    public string Lat { get; set; }

    public string Lng { get; set; }
  }

  public class Company
  {
    public string Name { get; set; }

    public string CatchPhrase { get; set; }

    public string Bs { get; set; }
  }
}
