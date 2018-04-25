DECLARE @num INT
SET @num=0
WHILE (@num<100)
BEGIN
SET @num=@num+1
IF @num%7 = 0 AND NOT @num%9 =0
   PRINT 'POP'
 ELSE IF  @num%9 =0 AND NOT @num%7 = 0
 PRINT 'QUIZ'
 ELSE IF  @num%7=0 AND  @num%9=0
  PRINT 'POPQUIZ'
 ELSE
 PRINT @num
END


