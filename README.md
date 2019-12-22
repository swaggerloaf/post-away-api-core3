# post-away-api-core3

A .net Core 3 api demo

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package MongoDB.Driver

use PostAwayDb
db.createCollection('Posts')
db.createCollection('Users')
db.Posts.insertMany([
{'Title':'Design Patterns are Us','Body':'So many patterns dude, 'User':'Fred'},{'Title':'Design Patterns are Us as welll','Body':'So many patterns sweetheart, 'User':'Brian'},{'Title':'Design Patterns are Us','Body':'So many patterns dudess, 'User':'Tom'}]);

db.Posts.find({}).pretty()

http://localhost:5000/api/posts
