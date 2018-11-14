alter table [dbo].[Category] drop constraint [PK_Category]
alter table [dbo].[Category] drop column ID
alter table [dbo].[Category] add [ID] int identity not null
alter table [dbo].[Category] add primary key (ID)