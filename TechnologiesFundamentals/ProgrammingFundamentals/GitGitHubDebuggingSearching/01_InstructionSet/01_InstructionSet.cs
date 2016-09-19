// 4 грешки в кода
using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine();

        //while (opCode != "end")
        while (opCode != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        //result = operandOne++;
                        result = operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        //result = operandOne--;
                        result = operandOne - 1;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        // result = (long)(operandOne * operandTwo);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            //add
            opCode = Console.ReadLine();
        }
    }
}

//Грешки в кода:
//Input "END" в кода е "end" -->"END"
//Input "END" не се чете --> Console.ReadLine();
//operandOne++ стойността се запазва(после нарастване) -->++опрандОне
//(long) кастването променя резултата, променяме на long променливите
