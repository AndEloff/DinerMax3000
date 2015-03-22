SELECT * FROM Menu
SELECT * FROM MenuItem
SELECT * FROM Menu_MenuItem

SELECT * FROM Menu WHERE MenuTypes = 'food'

/*Joining the Menu and Menu Item tables on the Menu_MenuItem connection table */
SELECT * FROM Menu_MenuItem JOIN Menu ON Menu.Id = Menu_MenuItem.MenuId
JOIN MenuItem ON Menu_MenuItem.MenuItemId = MenuItem.Id

/*Using the AS statement to show the Menu Name and MenuItem Name as MenuName and MenuItemName to prevent confusion*/
SELECT Menu.Name AS MenuName, MenuItem.Name AS MenuItemName, MenuItem.Price Menu FROM Menu_MenuItem JOIN Menu ON Menu.Id = Menu_MenuItem.MenuId
JOIN MenuItem ON Menu_MenuItem.MenuItemId = MenuItem.Id
 
/*UPDATE SECTION*/
UPDATE MenuItem SET Name = 'Nachos' WHERE Id = 2
UPDATE MenuItem SET Name = 'Hamburgers' WHERE Id = 1
UPDATE MenuItem SET Description = 'An American Classic' WHERE Id = 1
UPDATE MenuItem SET Description = 'A Mexican Classic' WHERE Id = 2

/*INSERT SECTION*/
INSERT INTO Menu(Name, MenuTypes,Disclaimer)VALUES('Drinks Menu','drink','Do not drink and code')
INSERT INTO MenuItem(Name,Description,Price)VALUES('Whiskey Coke','A Classic!',5)
INSERT INTO Menu_MenuItem(MenuId,MenuItemId)VALUES(2,3)
INSERT INTO Menu_MenuItem(MenuId,MenuItemId)VALUES(1,1)
INSERT INTO Menu_MenuItem(MenuId,MenuItemId)VALUES(1,2)


