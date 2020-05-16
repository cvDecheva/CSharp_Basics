using System;
using System.Numerics;

class AllTypes
{
    static void Main()
    {
        //Integers
        sbyte signedByteNumber = -128;
        byte unsugnedBytenumber = 255;
        short signedShortInt = -32768;
        ushort unsignedShortInt = 65535;
        int signedIntegerNumber = -2147483648;
        uint unsignedIntegerNumber = 4294967295;
        long signedLongNumber = -9223372036854775808;
        ulong signedlongNumber = 18446744073709551615;
        BigInteger reallyBigInteger = new BigInteger();
        reallyBigInteger = (BigInteger)Math.Pow(10, 30);

        //Floating point
        float floatNumber = 1.1234567f;
        double doubleNumber = 4.2222222222222;
        decimal decimalNumber = 5.1m;

        //Boolean
        bool isTrue = false;

        //Character
        char symbol = 'j';

        //String
        string name = "Cvetelina";

        //Object
        object objectInt = 4, objectString = "Cvetelina";

        //Dynamic
        dynamic dynamicInt = 12, dynamicString = "string";
    }
}

