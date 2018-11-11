/*alter table [OnlineShop1].[dbo].[Account] alter column UserName varchar(20) NOT NULL*/
alter table Account add primary key (UserName)
/*alter table Account drop constraint [PK__Account__C9F28457F9C2932A]
alter table Account alter column UserName varchar(20)
alter table Account alter column Password varchar(50)*/
