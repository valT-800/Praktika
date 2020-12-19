INSERT INTO dbo.images

(

       name

      ,format

      ,ImageFile

)

SELECT

      'Bread'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\Bread.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'White bread'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\white_bread.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'Milk'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\Milk.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'Yougurt'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\Yougurt.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'Bananas'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\Bananas.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'Apples'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\apples.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'Potatos'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\potatos.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);
SELECT

      'Tomatos'

      ,'jpg'

      ,ImageFile

FROM OPENROWSET(BULK N'D:\VIKO\OP\Uzduotis\Uzduotis\Images\tomatos.jpg', SINGLE_BLOB) AS ImageSource(ImageFile);