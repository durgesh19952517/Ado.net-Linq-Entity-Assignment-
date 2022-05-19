Create database League;

--creating table Footballleague

create table FootBallLeague
(
MatchId int Identity(1001,1) primary key,
TeamName1 nvarchar(50) ,
TeamName2 nvarchar(50) ,
MatchStatus nvarchar(50) Not NULL,
WinningTeam nvarchar(50),
Points int NOT NULL
);

--inserting data into footballleague table

INSERT INTO FootBallLeague(TeamName1,TeamName2,MatchStatus,WinningTeam,Points)
VALUES
('Italy','France','Win','France',4),
('Brazil','Portugal','Draw',null,2),
('England','Japan','Win','England',4),
('Usa','Russia','Win','Russia',4),
('Portugal','Italy','Draw',null,2),
('Brazil','France','Win','Brazil',4),
('England','Russia','Win','Russia',4),
('Japan','USA','Draw',null,2);

