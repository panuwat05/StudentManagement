'''mermaid

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
'''
