using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;
            decimal percent = 2.26598546988956M;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            string marker ="flag";

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL
            //bool charToBoolImplict = hasFingerPrints;                   //IMPLICIT: NOT COMPILING
           //bool charToBoolExplict = (bool)hasFingerPrints;             //EXPLICIT: NOT COMPILING
            //bool charToBoolUsingConverter = Convert.ToBoolean(hasFingerPrints); //System.InvalidCastException: 'Недопустимое приведение "Char" к "Boolean".'



            //1.3 CHAR to DECIMAL
            decimal charToDecimalImplict = place;       //IMPLICIT: CONVERT IN 51
            decimal charToDecimalExplict = (decimal)place; //EXPLICIT: COMPILING BUT CONVERT INTO 0
           // decimal charToDecimalUsingConverter = Convert.ToDecimal(place); //System.InvalidCastException: 'Недопустимое приведение "Char" к "Decimal".'



            //1.4 CHAR to INT
            int charToIntImplict = place; //IMPLICIT: COMPILING SET UNICODE VALUE 51 INSTEAD OF '3'
            int charToIntExplict = (int)place; //EXPLICIT: COMPILING SET UNICODE VALUE 51 INSTEAD OF '3'
            int charToIntUsingConverter = Convert.ToInt32(place); //CONVERT COMPILING SET UNICODE VALUE 51 INSTEAD OF '3'


            //2. STRING CONVERSION

            //2.1 STRING to CHAR
            //char stringToCharImplict = name; //IMPLICIT: NOT COMPILING
            //char stringToCharExplict = (char)name; //EXPLICIT: NOT COMPILING
            //char stringToCharUsingConverter = Convert.ToChar(name); //System.FormatException: 'Длина строки должна составлять один знак.'


            //2.2 STRING to BOOL
            //bool stringToBoolImplict = hasPhoto; //IMPLICIT: NOT COMPILING
            //bool stringToBoolExplict = (bool)hasPhoto; //EXPLICIT: NOT COMPILING
            bool stringToBoolUsingCoverter = Convert.ToBoolean(hasPhoto); //CONVERT INTO BOOLEAN VALUE TRUE

            //2.3 STRING to DECIMAL
            //decimal stringToDecimalImplict = flatNumber; //IMPLICIT: NOT COMPILING
            //decimal stringToDecimalExplict = (decimal)flatNumber; //EXPLICIT: NOT COMPILING
            decimal stringToDecimalUsingConverter = Convert.ToDecimal(flatNumber); //CONVERT INTO DECIMAL 34


            //2.4 STRING to INT
            //int stringToIntImplict = flatNumber; //IMPLICIT: NOT COMPILING
            //int stringToIntExplict = (int)flatNumber; //EXPLICIT: NOT COMPILING
            int stringToIntUsingConverter = Convert.ToInt32(flatNumber); //CONVERT INTO INT 34


            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR
            //char boolToCharImplict = hasFree2Pages; //IMPLICIT: NOT COMPILING
            //char boolToCharExplict = (char)hasFree2Pages; //EXPLICIT: NOT COMPILING
            //char boolToCharUsingConverter = Convert.ToChar(hasFree2Pages); //System.InvalidCastException: 'Недопустимое приведение "Boolean" к "Char".'

            //3.2 BOOL to STRING
            //string boolToStringImplict = hasFree2Pages; //IMPLICIT: NOT COMPILING
            //string boolToStringExplict = (string)hasFree2Pages; //EXPLICIT: NOT COMPILING
            string boolToStringUsingConverter = Convert.ToString(hasFree2Pages); //CONVERT INTO NULL

            //3.3 BOOL to DECIMAL
            //decimal boolToDecimalImplict = hasFree2Pages; //IMPLICIT: NOT COMPILING
            //decimal boolToDecimaExmplict = (decimal)hasFree2Pages; //EXPLICIT: NOT COMPILING
            decimal boolToDecimalUsingConverter = Convert.ToDecimal(hasFree2Pages); //CONVERT INTO 0

            //3.4 BOOL to INT
            //int boolToIntImplict = hasFree2Pages; //IMPLICIT: NOT COMPILING
            //int boolToIntExplict = (int)hasFree2Pages; //EXPLICIT: NOT COMPILING
            int boolToIntUsingConverter = Convert.ToInt32(hasFree2Pages); //CONVERT INTO 0

            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR
            //char decimalToCharImplict = percent; //IMPLICIT: NOT COMPILING
            char decimalToCharExplict = (char)percent; //CONVERT FROM DECIMAL 2.26598546988956M INTO CHAR 2'/u0002' 
            //char decimalToCharUsingConverter = Convert.ToChar(percent);//System.InvalidCastException: 'Недопустимое приведение "Decimal" к "Char".'


            //4.2 DECIMAL to BOOL
            //ool decimalToBoolImplict = percent; //IMPLICIT: NOT COMPILING
            //bool decimalToBoolExplict = (bool)percent; //EXPLICIT: NOT COMPILING
            bool decimalToBoolUsingConverter = Convert.ToBoolean(percent); //CONVERT INTO BOOL TRUE

            //4.3 DECIMAL to STRING
            //string decimalToStringImplict = percent; //IMPLICIT: NOT COMPILING
            //string decimalToStringExplict = (string)percent; //EXPLICIT: NOT COMPILING
            string decimalToStringUsingConverter = Convert.ToString(percent); //CONVERT FROM DECIMAL 2.26598546988956M INTO STRING "2.26598546988956"


            //4.4 DECIMAL to INT
            //int decimalToIntImplict = percent; //IMPLICIT: NOT COMPILING
            int decimalToIntExplict = (int)percent; //CONVERT FROM DECIMAL 2.26598546988956M INTO INT 2
            int decimalToIntUsingConverter = Convert.ToInt32(percent); //CONVERT FROM DECIMAL 2.26598546988956M INTO INT 2

            //5. INT CONVERSION         

            //5.1 INT to CHAR

            //5.2 INT to BOOL

            //5.3 INT to DECIMAL

            //5.4 INT to STRING
        }
    }
}
