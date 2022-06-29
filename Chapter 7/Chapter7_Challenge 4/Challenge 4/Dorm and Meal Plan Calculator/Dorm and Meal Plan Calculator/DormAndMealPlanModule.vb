Module DormAndMealPlanModule
    ' Global constants
    Public Const g_decDORM_ALLEN_HALL As Decimal = 1500D        ' Allen Hall is $1,500 per semester
    Public Const g_decDORM_PIKE_HALL As Decimal = 1600D         ' Pike Hall is $1,600 per semester
    Public Const g_decDORM_FARTHING_HALL As Decimal = 1200D     ' Farthing Hall is $1,200 per semester
    Public Const g_decDORM_UNIVERSITY_SUITE As Decimal = 1800D  ' University Suite is $1,800 per semester
    Public Const g_decMEAL_PLAN_7 As Decimal = 560D             ' 7 meal plan is $560 per semester
    Public Const g_decMEAL_PLAN_14 As Decimal = 1095D           ' 14 meal plan is $1,095 per semester
    Public Const g_decMEAL_PLAN_UNLIMITED As Decimal = 1500D    ' Unlimited meal plan is $1,500 per semester

    ' Global variables
    Public g_decDormitory As Decimal = 0D   ' To hold the charge for the selected dormitory
    Public g_decMealPlan As Decimal = 0D    ' To hold the charge for the selected meal plan

    ' The CalcTotalCharges function calculates and returns the total charges for the semester.
    Public Function CalcTotalCharges() As Decimal
        ' Return the total charges for the semester.
        Return g_decDormitory + g_decMealPlan
    End Function

    ' The ResetCharges procedure resets the dormitory and meal plan charges.
    Public Sub ResetCharges()
        ' Reset the dormitory and meal plan charges.
        g_decDormitory = 0D
        g_decMealPlan = 0D
    End Sub
End Module
