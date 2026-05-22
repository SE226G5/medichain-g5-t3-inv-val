# مخطط الكيان والعلاقة لنظام المواد والاختبارات المخبرية
### Entity Relationship Diagram for Materials and Laboratory Test System

هذا المخطط يوضح بنية قاعدة البيانات والعلاقات بين الجداول. تم إنشاؤه باستخدام **Mermaid.js** ليظهر بشكل رسومي ومباشر على GitHub، ولكي يكون قابلاً للتعديل بسهولة من قبل أي مطور.

```mermaid
erDiagram
    Material ||--o{ Batch : "has"
    User ||--o{ Batch : "manages"
    Role ||--o{ User : "assigned to"
    Test_Location ||--o{ Lab_test : "hosts"
    Batch ||--o{ Lab_Test_Details : "included in"
    Lab_test ||--o{ Lab_Test_Details : "contains"

    Material {
        int material_id PK
        string material_name
    }

    User {
        int user_id PK
        string username
        int role FK
    }

    Role {
        int role_id PK
        string role_name
    }

    Batch {
        int batch_id PK
        int material_id FK
        int managed_by_user FK
        date expiry_date
        float total_quantity
        string status
    }

    Test_Location {
        int location_id PK
        string location_name
        string location_type
    }

    Lab_test {
        int test_id PK
        int analyst_id FK
        int batch_id FK
        float consumed_quantity
        int test_location FK
        string test_parameter
        string result_value
        string status
        date test_date
    }

    Lab_Test_Details {
        int test_id PK
        int batch_id PK
        float consumed_quantity
        string test_parameter
        string result_value
    }
