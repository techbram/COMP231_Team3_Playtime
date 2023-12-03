exec getproducts



INSERT INTO Product ([Name], CategoryId, [Desc], Price, Imagelg, ImageSm, AgeGroup, IsActive)
VALUES ('Toy 1', 1, 'Toy 1 desc', 99, 'large', 'small', 'agegroup', 1);

INSERT INTO Product ([Name], CategoryId, [Desc], Price, Imagelg, ImageSm, AgeGroup, IsActive) 
VALUES ('aaaaaa', 1, 'aaaaaa', 22, 'aaaaaa' , 'aaaa', 'aaaaaa', 1);

Update Product set [Name] = 'bbb', CategoryId =1, [Desc] = 'bbb', Price = 12, Imagelg= 'large', ImageSm = 'small', AgeGroup = 'agegrp', IsActive = 0 where Id = 1003






INSERT INTO Product ([Name], CategoryId, [Desc], Price, Imagelg, ImageSm, AgeGroup, IsActive)
VALUES ('Toy 2', 1, 'Toy 2 desc', 99, 'large', 'small', 'agegroup', 1);

INSERT INTO Product ([Name], CategoryId, [Desc], Price, Imagelg, ImageSm, AgeGroup, IsActive)
VALUES ('Toy 3', 1, 'Toy 3 desc', 99, 'large', 'small', 'agegroup', 1);

INSERT INTO Product ([Name], CategoryId, [Desc], Price, Imagelg, ImageSm, AgeGroup, IsActive)
VALUES ('Toy 4', 1, 'Toy 4 desc', 99, 'large', 'small', 'agegroup', 1);


delete from Product where Id = 4




insert into Category ([Name], IsActive )
values ('Small', 1)

insert into Category ([Name], IsActive )
values ('Education', 1)


insert into Category ([Name], IsActive )
values ('Puzzle', 1)

insert into Category ([Name], IsActive )
values ('Wooden', 1)

exec getCategories

delete from Category where Id = 4

Select * from Category where id = 1


Update Category set [Name] = 'bbb', IsActive = 0 where Id = 1