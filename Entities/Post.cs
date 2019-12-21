using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostAway.API.Entities
{
  public class Post
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [Required]
    [BsonElement("Title")]
    public string Title { get; set; }
    [BsonElement("Body")]
    public string Body { get; set; }
    public string User { get; set; }

    //[ForeignKey("UserId")]
    // public User User { get; set; }

    //  public Guid UserId { get; set; }
  }
}
