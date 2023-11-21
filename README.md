# Culture-Department
## תיאור הפרויקט
**מערכת ניהול למחלקת תרבות בעיריות, במתנ"סים וכו'. באמצעות המערכת ניתן לנהל אירועים וכנסים לפי מספר מוזמנים, גילאים, מגורים ועוד.**

## ישויות
**מנהל**

**עובד**

**תושב**

**אירוע**

## מיפוי Routes למנהל
**שליפת מנהל Get https://culture.co.il/manager**

**עדכון מנהל Post https://culture.co.il/manager**

**בחרתי לא למפות מחיקה והוספה למנהל כדי לשמור על היררכיה, שקיים מנהל אחד בלבד**

## מיפוי Routes לעובד
**שליפת רשימת העובדים Get https://culture.co.il/workers**

**שליפת עובד לפי מזהה Get https://culture.co.il/workers/1**

**הוספת עובד Put https://culture.co.il/workers**

**עדכון עובד Post https://culture.co.il/workers/1**

**מחיקת עובד Delete https://culture.co.il/workers/1**

## מיפוי Routes לתושב
**שליפת רשימת התושבים Get https://culture.co.il/residents**

**שליפת תושב לפי תעודת זהות Get https://culture.co.il/residents/1**

**הוספת תושב Put https://culture.co.il/residents**

**עדכון תושב Post https://culture.co.il/residents/1**

**מחיקת תושב Delete https://culture.co.il/residents/1**

## מיפוי Routes לאירוע
**שליפת רשימת האירועים Get https://culture.co.il/eventsr**

**שליפת אירוע לפי מזהה Get https://culture.co.il/events/1**

**הוספת אירוע Put https://culture.co.il/events**

**עדכון אירוע Post https://culture.co.il/events/1**

**בחרתי לא למפות מחיקת אירוע כדי לשמור נתונים. במקום זה הוספתי Route לעדכון סטטוס (עבר, עתידי, בוטל)**

**עדכון סטטוס אירוע Post https://culture.co.il/events/1/status**
