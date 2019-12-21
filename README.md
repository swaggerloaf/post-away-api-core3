# post-away-api-core3

A .net Core 3 api demo

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package MongoDB.Driver

use PostAwayDb
db.createCollection('Posts')
db.Posts.insertMany([{'Title':'Design Patterns','Body':'Computers','User':'Glenn'}, {'Title':'Clean. Martin'}])

db.Posts.find({}).pretty()

http://localhost:5000/api/posts
