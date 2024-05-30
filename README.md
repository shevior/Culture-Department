# **Culture department**
## **תיאור הפרויקט:**

> מערכת ניהול למחלקת תרבות בעיריות, במתנ"סים וכו'. באמצעות המערכת ניתן
> לנהל אירועים וכנסים  לפי מספר מוזמנים, גילאים, מגורים ועוד.


**ישויות:**
 - [ ] מנהל
 - [ ] עובד
 - [ ] תושב
 - [ ] אירוע


|                |**מיפוי** **Routes** **למנהל**
|----------------|-------------------------------
|שליפת מנהל		 |Get https://culture.co.il/manager
|עדכון מנהל         |Post https://culture.co.il/manager              
> בחרתי לא למפות מחיקה והוספה למנהל כדי לשמור על היררכיה, שקיים מנהל אחד בלבד



-----------

|                	 |**מיפוי** **Routes** **לעובד**
|--------------------|------------------------------------
|שליפת רשימת העובדים		 |Get https://culture.co.il/workers
|שליפת עובד לפי תעודת זהות  |Get https://culture.co.il/workers/2 
|הוספת עובד		     |Put https://culture.co.il/workers
|עדכון עובד  			 |Post https://culture.co.il/workers/4
|מחיקת עובד 			 |Delete https://culture.co.il/workers/5

-----------
|                	 |**מיפוי** **Routes** **לתושב**
|--------------------|------------------------------------
|שליפת רשימת התושבים		 |Get https://culture.co.il/residents
|שליפת תושב לפי תעודת זהות  |Get https://culture.co.il/residents/2 
|הוספת תושב		     |Put https://culture.co.il/residents
|עדכון תושב  			 |Post https://culture.co.il/residents/4
|מחיקת תושב 			 |Delete https://culture.co.il/residents/5
-----------
|                	 |**מיפוי** **Routes** **לאירוע**
|--------------------|------------------------------------
|שליפת רשימת האירועים		 |Get https://culture.co.il/events
|שליפת אירוע לפי מזהה  |Get https://culture.co.il/events/2 
|הוספת אירוע		     |Put https://culture.co.il/events
|עדכון אירוע  			 |Post https://culture.co.il/events/4
| עדכון סטטוס אירוע |Post https://culture.co.il/events/4/status
> בחרתי לא למפות מחיקת אירוע במקום זה הוספתי Route לעדכון סטטוס אירוע


# מחלקות
  
**מנהל (יורש מעובד)**
- סיסמא

**עובדים**
- מספר עובד
- ת ז
- שם פרטי
- שם משפחה
- האם תושב

**תושבים**
- מספר תושב
- ת ז
- שם פרטי
- שם משפחה
- רחוב
- מספר בית
- טלפון

**אירועים**
- מזהה
- תאריך ושעה
- שם
- תיאור
- סטטוס: 
  - התקיים 
  - התבטל 
  - עתידי
 - מקום
- קהל היעד
- גיל
- מגדר
- מחיר
