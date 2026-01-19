# LookClosely

Look Closely е уеб базирана игра от типа Hidden Objects, разработена с ASP.NET Core MVC и Entity Framework Core.  
Играчите се регистрират, играят нива, намират скрити обекти и получават резултат (score), който се записва в база данни.

База данни
Проектът използва MS SQL Server.

 Основни таблици:
- Users
  - Id
  - Username
  - Password

- Levels
  - Id
  - Name
  - ImagePath
  - Difficulty

- Scores
  - Id
  - Points
  - UserId
  - LevelId
  - CreatedOn
