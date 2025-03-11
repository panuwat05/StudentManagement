## StudentManagement 
by Panuwat Prasertdee 673450474-0 IS KKU61

## Ui
![image](https://github.com/user-attachments/assets/68ce5e71-b8a8-4945-a78e-b07f202fe1b1)


## 📌 Class Diagram
```mermaid

    classDiagram
    class Person {
        +string Name
        +string Major
        +Person(name: string, major: string)
    }

    class Student {
        +string ID
        +double Grade
        +Advisor Advisor
        +Student(id: string, name: string, major: string, grade: double, advisor: Advisor)
    }

    class Advisor {
        +List~Student~ Students
        +Advisor(name: string, major: string)
        +AddStudent(student: Student)
    }

    class Form1 {
        +List~Student~ students
        +List~Advisor~ advisors
        +InitializeDataGridView()
        +UpdateStudentList()
        +LoadAdvisors()
        +btAddAdvisor_Click()
        +btAddSt_Click()
        +btSearch_Click_1()
        +lstStuden_SelectedIndexChanged()
        +dgvStudents_SelectionChanged()
        +btTopSt_Click()
    }

    Person <|-- Student
    Person <|-- Advisor
    Advisor "1" -- "0..*" Student : manages
    Form1 "1" -- "0..*" Student : contains
    Form1 "1" -- "0..*" Advisor : manages

```
## ฟีเจอร์หลักและฟังก์ชันการทำงาน:

1.การจัดการนักศึกษาและที่ปรึกษา:
เพิ่มที่ปรึกษา: เพิ่มที่ปรึกษาใหม่ลงในรายการ และอัปเดต ComboBox ของที่ปรึกษา รวมถึงเคลียร์ฟิลด์ข้อมูลหลังจากเพิ่มสำเร็จ
เพิ่มนักศึกษา: เพิ่มนักศึกษาใหม่ลงในรายการพร้อมกับการตรวจสอบข้อมูล (เช่น การตรวจสอบความซ้ำของรหัสนักศึกษา, การป้อนเกรดที่ถูกต้อง, การเลือกที่ปรึกษา) นักศึกษาจะถูกมอบหมายให้กับที่ปรึกษา และ UI จะได้รับการอัปเดต
แสดงรายชื่อนักศึกษา: แสดงรายชื่อนักศึกษาผ่าน DataGridView และ ListBox เมื่อคลิกที่นักศึกษาใน ListBox หรือ DataGridView จะมีข้อมูลของนักศึกษาปรากฏใน Label
ฟังก์ชันการค้นหา:

2.ปุ่มค้นหาช่วยให้ผู้ใช้สามารถกรองนักศึกษาตามรหัสนักศึกษาหรือชื่อ โดยจะมีการอัปเดต DataGridView และแสดงผลใน MessageBox (พบข้อมูลหรือไม่พบข้อมูล)
การแสดงนักศึกษาที่เก่งที่สุด:

3.ปุ่มจะแสดงนักศึกษาที่มีเกรดสูงสุด โดยแสดงชื่อและเกรดของนักศึกษาคนนั้น

## มีไฟล์ Document ให้อ่านด้วยนะครับ
https://github.com/panuwat05/StudentManagement/blob/main/Document.txt
