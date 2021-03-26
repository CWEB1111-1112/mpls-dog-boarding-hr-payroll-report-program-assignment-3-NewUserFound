using System;
using System.Collections.Generic;
namespace assignment_three
{
    class Number_Validate
    {        
        //Department Number Validation
        public int Department_Number_Validate(int index) 
        {
            int[] departmentNumberArray = {1,2,3,4,5,6,7};
            if (index < 0 || index > departmentNumberArray.Length){
                throw new IndexOutOfRangeException();
            }
            return departmentNumberArray[index];
        }
    }
}