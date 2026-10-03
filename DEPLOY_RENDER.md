# نشر امتحان XtremeCodeCamp على Render

## 1) ارفع المشروع إلى GitHub
- أنشئ Repository جديدًا باسم `xtreme-code-camp-exam`.
- ارفع جميع ملفات هذا المجلد إلى الـ repository.

## 2) أنشئ Web Service في Render
- اختر New -> Web Service.
- اربط GitHub repository.
- Runtime: Docker.
- Dockerfile Path: `./Dockerfile`.
- Port: `10000`.

## 3) Environment Variables
أضف:
- `ADMIN_PASSWORD` = كلمة مرور المدرس
- `STUDENT_ACCESS_CODE` = كود دخول الطلاب
- `ConnectionStrings__DefaultConnection` = `Data Source=/data/exam.db`

## 4) قاعدة البيانات
التطبيق يستخدم SQLite. يجب إضافة Persistent Disk وربطه على:
`/data`

بدون Persistent Disk يمكن أن تضيع نتائج الامتحان عند إعادة تشغيل الخدمة أو إعادة نشرها.

## 5) بعد النشر
سيعطيك Render رابطًا عامًا مثل:
`https://اسم-الخدمة.onrender.com/`

رابط الطلاب:
`https://اسم-الخدمة.onrender.com/`

رابط المدرس:
`https://اسم-الخدمة.onrender.com/Admin/Login`

لا تستخدم `exam-xtreme.com` إلا بعد شراء نطاق وربطه بالخدمة.
