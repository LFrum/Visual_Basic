Module EmployeeDirectoryModule

    ' Global variable to hold the index of the selected employee
    Public g_intSelectedItem As Integer

    ' Global array to hold the employee names
    Public g_strNames() As String = {"Jill Anders", "Henry Cosworth",
                                     "Hans Denton", "Susan Fowler",
                                     "Geri Garrison", "Jean Horton",
                                     "Kevin Lang"}

    ' Global array to hold the department names
    Public g_strDepartmentNames() As String = {"MIS", "Sales", "Marketing",
                                               "Accounting", "Research",
                                               "Administration", "Clerical"}

    ' Global array to hold the employee ID numbers
    Public g_strIdNumbers() As String = {"14759", "45878", "55562", "700789",
                                         "721459", "56411", "39947"}

    ' Global array to hold the telephone numbers
    Public g_strTelephoneNumbers() As String = {"555-1279", "555-5478", "555-1115",
                                                "555-8897", "555-8845", "555-6565",
                                                "555-1478"}
End Module
