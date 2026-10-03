# Xtreme Code Camp - ASP.NET Core Online Exam

## التقنية
- C#
- ASP.NET Core MVC (.NET 8)
- HTML + CSS + JavaScript
- Entity Framework Core + SQLite

## التشغيل على Windows
1. ثبّت .NET 8 SDK.
2. افتح المشروع في Visual Studio 2022 أو VS Code.
3. افتح Terminal داخل مجلد المشروع.
4. نفّذ:
   dotnet restore
   dotnet run
5. افتح الرابط الذي يظهر لك، غالباً:
   http://localhost:5000
   أو https://localhost:xxxx

## بيانات الدخول
- Student code: XTC2026
- Teacher password: 1234

غيّر الرموز وكلمة المرور في:
Controllers/ExamController.cs
Controllers/AdminController.cs

## ملاحظات
- الامتحان 45 دقيقة.
- 16 MCQ = 64 علامة.
- 4 أسئلة Coding = 36 علامة، تصحيحها يدوي من لوحة المعلم.
- الأسئلة وترتيب الخيارات عشوائية لكل محاولة.
- النتائج تحفظ في exam.db.
- فحص التشابه >= 85% هو تنبيه للمراجعة فقط، وليس دليلاً قاطعاً على الغش.
- المشروع لا ينفذ كود Python الخاص بالطلاب على الخادم، وهذا مقصود لأمان الخادم.

## النشر على الإنترنت
لجعله متاحاً للطلاب من أي مكان، ارفع ASP.NET Core إلى استضافة تدعم .NET 8، واستبدل SQLite بقاعدة بيانات مستضافة عند الحاجة. لا تستخدم جهاز المدرس كخادم للإمتحان.
